using System;
using System.Collections.Generic;
using System.Linq;
using AtomicMarketApiClient.Core.Assets;
using AtomicMarketApiClient.Core.Auctions;
using AtomicMarketApiClient.Core.Exceptions;
using AtomicMarketApiClient.Core.Sales;
using AtomicMarketApiClient.Unity3D.Assets;
using AtomicMarketApiClient.Unity3D.Auctions;
using AtomicMarketApiClient.Unity3D.BuyOffers;
using AtomicMarketApiClient.Unity3D.MarketPlaces;
using AtomicMarketApiClient.Unity3D.Pricing;
using AtomicMarketApiClient.Unity3D.Sales;
using UnityEngine;
using UnityEngine.UIElements;
using AtomicMarketApiFactory = AtomicMarketApiClient.Unity3D.AtomicMarketApiFactory;

public class AtomicMarketPanel : MonoBehaviour
{
    /*
     * Child-Controls
     */
    public VisualElement Root;

    private Label _collectionNameLabel;
    private Label _ownerLabel;
    private Label _sellerLabel;
    private Label _tradeOfferIdLabel;
    private Label _nftNameLabel;
    private Label _headerLabel;
    private Label _idLabel;
    private Label _priceLabel;
    private Label _mintNumberLabel;
    private Label _backedTokenLabel;
    private Label _schemaNameLabel;
    private Label _templateIdLabel;
    private Label _propertiesTransferableLabel;
    private Label _propertiesBurnableLabel;

    private Button _searchButton;

    private DropdownField _selectorDropdownField;
    private TextField _collectionNameOrAssetId;

    
    /*
     * Fields/Properties
     */

    private AssetsApi _assetsApi;
    private AuctionsApi _auctionsApi;
    private SalesApi _salesApi;
    private BuyOffersApi _buyOffersApi;
    private PricingApi _pricingApi;
    private MarketPlacesApi _marketPlacesApi;

    private List<string> _searchTypes;


    void Start()
    {
        Root = GetComponent<UIDocument>().rootVisualElement;

        _assetsApi = AtomicMarketApiFactory.Version1.AssetsApi;
        _auctionsApi = AtomicMarketApiFactory.Version1.AuctionsApi;
        _buyOffersApi = AtomicMarketApiFactory.Version1.BuyOffersApi;
        _pricingApi = AtomicMarketApiFactory.Version1.PricingApi;
        _salesApi = AtomicMarketApiFactory.Version1.SalesApi;
        _marketPlacesApi = AtomicMarketApiFactory.Version1.MarketPlacesApi;

        _collectionNameOrAssetId = Root.Q<TextField>("collection-name-or-id-textfield");

        _headerLabel = Root.Q<Label>("header-label");
        _nftNameLabel = Root.Q<Label>("nft-name-label");
        _idLabel = Root.Q<Label>("id-label");
        _tradeOfferIdLabel = Root.Q<Label>("trade-offer-id-label");
        _priceLabel = Root.Q<Label>("price-label");
        _ownerLabel = Root.Q<Label>("owner-label");
        _sellerLabel = Root.Q<Label>("seller-label");
        _mintNumberLabel = Root.Q<Label>("mint-number-label");
        _backedTokenLabel = Root.Q<Label>("backed-token-label");
        _schemaNameLabel = Root.Q<Label>("schema-label");
        _templateIdLabel = Root.Q<Label>("template-id-label");
        _collectionNameLabel = Root.Q<Label>("collection-name-label");
        _propertiesTransferableLabel = Root.Q<Label>("properties-transferable-label");
        _propertiesBurnableLabel = Root.Q<Label>("properties-burnable-label");

        _selectorDropdownField = Root.Q<DropdownField>("selector-dropdown");

        _searchButton = Root.Q<Button>("search-button");

        BindButtons();
    }

    #region Button Binding

    private void BindButtons()
    {
        _searchButton.clicked += SearchAsset;

        _searchTypes = new List<string>()
        {
            { "Sale ID" },
            { "Auction ID" },
            { "Asset ID" }
        };

        _selectorDropdownField.choices = _searchTypes;

        _selectorDropdownField.value = _selectorDropdownField.choices.First();

        _selectorDropdownField.RegisterCallback<ChangeEvent<string>>(evt =>
        {
            _selectorDropdownField.value = _selectorDropdownField.value;
        });
    }

    #endregion

    #region Rebind

    private void Rebind(AssetDto asset)
    {
        _collectionNameLabel.text = asset.Data.Collection.Name;
        _ownerLabel.text = asset.Data.Owner;
        _nftNameLabel.text = asset.Data.Name;
        _idLabel.text = asset.Data.AssetId;
        _mintNumberLabel.text = asset.Data.MintedAtBlock;
        _backedTokenLabel.text = asset.Data.TemplateMint;
        _schemaNameLabel.text = asset.Data.Schema.SchemaName;
        _templateIdLabel.text = asset.Data.Template.TemplateId;
        //_propertiesBurnableLabel.text = auction.Data.Template.Transferable
    }

    private void Rebind(SaleDto sales)
    {
        _collectionNameLabel.text = sales.Data.Collection.CollectionName;
        _ownerLabel.text = sales.Data.Assets[0].Owner;
        _nftNameLabel.text = sales.Data.Assets[0].Name;
        _idLabel.text = $"#{sales.Data.Assets[0].AssetId}";
        _priceLabel.text = $"{Convert.ToDecimal(sales.Data.Price.Amount)/100000000}  {sales.Data.Price.TokenSymbol}";
        _sellerLabel.text = sales.Data.Seller;
        _tradeOfferIdLabel.text = $"#{sales.Data.OfferId}";
        _mintNumberLabel.text = $"{sales.Data.Assets[0].TemplateMint} of {sales.Data.Assets[0].Template.IssuedSupply}" ;
        _backedTokenLabel.text = sales.Data.Assets[0].BackedTokens.Length.ToString();
        _schemaNameLabel.text = sales.Data.Assets[0].Schema.SchemaName;
        _templateIdLabel.text = sales.Data.Assets[0].Template.TemplateId;
    }
    private void Rebind(AuctionDto auction)
    {
        _collectionNameLabel.text = auction.Data.Collection.CollectionName;
        _ownerLabel.text = auction.Data.Assets[0].Owner;
        _nftNameLabel.text = auction.Data.Assets[0].Name;
        _idLabel.text = $"#{auction.Data.Assets[0].AssetId}";
        _priceLabel.text = $"{Convert.ToDecimal(auction.Data.Price.Amount) / 100000000}  {auction.Data.Price.TokenSymbol}";
        _sellerLabel.text = auction.Data.Seller;
        _mintNumberLabel.text = $"{auction.Data.Assets[0].TemplateMint} of {auction.Data.Assets[0].Template.IssuedSupply}";
        _backedTokenLabel.text = auction.Data.Assets[0].BackedTokens.Length.ToString();
        _schemaNameLabel.text = auction.Data.Assets[0].Schema.SchemaName;
        _templateIdLabel.text = auction.Data.Assets[0].Template.TemplateId;
    }
    #endregion

    #region Others

    private async void SearchAsset()
    {
        if (_selectorDropdownField.value != null)
        {
            try
            {
                switch (_selectorDropdownField.value)
                {
                    case "Asset ID":
                        var assetDto = await _assetsApi.Asset(_collectionNameOrAssetId.value);
                        if (assetDto != null)
                        {
                            Rebind(assetDto);
                        }
                        else Debug.Log("asset id not found");
                        break;

                    case "Sale ID":
                        var saleDto = await _salesApi.Sale(Convert.ToInt32(_collectionNameOrAssetId.value));
                        if (saleDto != null)
                        {
                            Rebind(saleDto);
                        }
                        else Debug.Log("sales id not found");
                        break;

                    case "Auction ID":
                        var auctionDto = await _auctionsApi.Auction((Convert.ToInt32(_collectionNameOrAssetId.value)));
                        if (auctionDto != null)
                        {
                            Rebind(auctionDto);
                        }
                        else Debug.Log("auction id not found");
                        break;
                }
            }
            catch (ApiException ex)
            {
                Debug.LogError($"Content: {ex.Content}");
            }
        }
    }
    #endregion
}
