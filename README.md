<div align="center">

[![builds](https://github.com/liquiidio/AtomicMarketApiClient-Private/actions/workflows/dotnet-build.yml/badge.svg)](https://github.com/liquiidio/AtomicMarketApiClient-Private/actions/workflows/dotnet-build.yml)
[![tests](https://github.com/liquiidio/AtomicMarketApiClient-Private/actions/workflows/dotnet-test.yml/badge.svg)](https://github.com/liquiidio/AtomicMarketApiClient-Private/actions/workflows/dotnet-test.yml)
       
</div>

# AtomicMarketApiClient

.NET and Unity3D-compatible (Desktop, Mobile, WebGL) ApiClient for AtomicMarket

 ## Usage

 The entry point to the APIs is in the AtomicMarketApiFactory. You can initialise any supported API from there.
 You can then call any endpoint from the initialised API.
 Each endpoint has its own set of parameters that you may build up and pass in to the relevant function.

 ## Example calling the /v1/assets endpoint
 ### Initialise the Assets API
 ```csharp
 
 var salesApi = AtomicMarketApiFactory.Version1.SalesApi;
 var auctionsApi = AtomicMarketApiFactory.Version1.AuctionsApi;
 var assetsApi = AtomicMarketApiFactory.Version1.AssetsApi;

 ```
 
 ### Call the /assets endpoint
 ```csharp
 var sales = salesApi.Sales();
 var aution = auctionApi.Auction();
 var assets = assetsApi.Assets();
 ```
 
 ### Example to Filter and search Assets by either Sales Id, Auction Id and Asset Id, 
```csharp
    private async void SearchAsset()
    {
        if (_selectorDropdownField.value != null)
        {
            try
            {
                switch (_selectorDropdownField.value)
                {
                    case "Asset ID":
                        var assetDto = await assetsApi.Asset(_collectionNameOrAssetId.value);
                        if (assetDto != null)
                        {
                            Rebind(assetDto);
                        }
                        else Debug.Log("asset id not found");
                        break;

                    case "Sale ID":
                        var saleDto = await salesApi.Sale(Convert.ToInt32(_collectionNameOrAssetId.value));
                        if (saleDto != null)
                        {
                            Rebind(saleDto);
                        }
                        else Debug.Log("sales id not found");
                        break;

                    case "Auction ID":
                        var auctionDto = await auctionsApi.Auction((Convert.ToInt32(_collectionNameOrAssetId.value)));
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
                AtomicMarketErrorPanel.ErrorText("Content Error", ex.Content);
                Show(AtomicMarketErrorPanel.Root);
            }
        }
    }
    
````
 
 ##### Example output
 
 ## Results Search for Sales Id "#105106129"
<img width="836" alt="image" src="https://user-images.githubusercontent.com/31707324/213105963-0916568e-eea2-456f-ac39-3758ad0f4514.png">

 ## Results Search for Auction Id "#1016310"
<img width="838" alt="image" src="https://user-images.githubusercontent.com/31707324/213106315-cd67121b-adb9-4ff3-a42f-610868206921.png">

 ...
 
 ## Example calling the /v1/assets endpoint with parameters
 ### Initialise the Assets API
 var assetsApi = AtomicMarketApiFactory.Version1.AssetsApi();
 
 ### Build up the AssetsParameters with the AssetsUriParameterBuilder
 var builder = new MarketUriParameterBuilder().WithLimit(1);
 
 ### Call the /assets endpoint, passing in the builder
 var assets = assetsApi.Assets(builder);
 
 ### Print all asset ids
 assets.Data.ToList().ForEach(a => Console.WriteLine(a.AssetId));
 
 ### Example output
 1099567200114
