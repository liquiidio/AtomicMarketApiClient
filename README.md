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
 var assetsApi = AtomicMarketApiFactory.Version1.AssetsApi();
 
 ### Call the /assets endpoint
 var assets = assetsApi.Assets();
 
 ### Print all asset ids
 assets.Data.ToList().ForEach(a => Console.Write(a.AssetId));
 
 ### Example output
 1099567200114
 1099567200113
 1099567200112
 1099567200111
 1099567200110
 1099567200109
 1099567200108
 1099567200107
 1099567200106
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
