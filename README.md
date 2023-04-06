<div align="center">
 <img src="https://avatars.githubusercontent.com/u/82725791?s=200&v=4" align="center"
     alt="Liquiid logo" width="280" height="300">
</div>

---

<div align="center">

[![Builds](https://github.com/liquiidio/AtomicMarketApiClient/actions/workflows/build.yml/badge.svg)](https://github.com/liquiidio/AtomicMarketApiClient/actions/workflows/build.yml)
[![Tests](https://github.com/liquiidio/AtomicMarketApiClient/actions/workflows/test.yml/badge.svg)](https://github.com/liquiidio/AtomicMarketApiClient/actions/workflows/test.yml)
[![Documentation](https://github.com/liquiidio/AtomicMarketApiClient/actions/workflows/docs.yml/badge.svg)](https://github.com/liquiidio/AtomicMarketApiClient/actions/workflows/docs.yml)
[![Deployment](https://github.com/liquiidio/AtomicMarketApiClient/actions/workflows/deploy.yml/badge.svg)](https://github.com/liquiidio/AtomicMarketApiClient/actions/workflows/deploy.yml)
 
</div>

# AtomicMarketApiClient

.NET and Unity3D-compatible (Desktop, Mobile, WebGL) ApiClient for AtomicMarket

# Installation

**_Requires Unity 2019.1+ with .NET 4.x+ Runtime_**

This package can be included into your project by either:

 1. Installing the package via Unity's Package Manager (UPM) in the editor (recommended).
 2. Importing the .unitypackage which you can download [here](https://github.com/liquiidio/AtomicMarketApiClient/releases/latest/download/atomicmarket.unitypackage). 
 3. Manually add the files in this repo.
 4. Installing it via NuGet.
---

### 1. Installing via Unity Package Manager (UPM).

In your Unity project:

 1. Open the Package Manager Window/Tab

    ![image](https://user-images.githubusercontent.com/74650011/208429048-37e2277c-3e10-4794-97e7-3ec87f55f8c9.png)

 2. Click on + icon and then click on "Add Package From Git URL"

    ![image](https://user-images.githubusercontent.com/74650011/208429298-76fe1101-95f3-4ab0-bbd5-f0a32a1cc652.png)

 3. Enter URL:  `https://github.com/liquiidio/AtomicMarketApiClient.git#upm`
   
---

### 2. Importing the Unity Package.

Download the [UnityPackage here](https://github.com/liquiidio/AtomicMarketApiClient/releases/latest/download/atomicmarket.unitypackage).

Then in your Unity project:

 1. Open up the import a custom package window
    
    ![image](https://user-images.githubusercontent.com/74650011/208430044-caf91dd9-111e-4224-8441-95d116dbec3b.png)

 2. Navigate to where you downloaded the file and open it.
    
    ![image](https://user-images.githubusercontent.com/86061433/217053958-815fcd3e-902f-4ed0-86f5-073a55d39b5e.jpg)

    
 3. Check all the relevant files needed (if this is a first time import, just select ALL) and click on import.
   
    ![image](https://user-images.githubusercontent.com/86061433/217054414-d0a1b56b-1404-4341-8630-5a92cb697b24.jpg)
    
---

### 3. Install manually.

Download [the latest Release](https://github.com/liquiidio/AtomicMarketApiClient/releases/latest).

Then in your Unity project, copy the sources from `AtomicMarketApiClient` into your Unity `Assets` directory.

 
 ---
 
### 4. Install via NuGet (for Standard .NET users only - No Unity3D)

#### .NET CLI

`> dotnet add package Liquiid.io.AtomicMarket`

#### Package Manager

`PM> Install-Package Liquiid.io.AtomicMarket`

---

# Usage
.NET and Unity3D-compatible (Desktop, Mobile, WebGL) ApiClient for the different  APIs. 
Endpoints have its own set of parameters that you may build up and pass in to the relevant function.

---

# Examples

## Example calling the /v1/assets endpoint
 ### Initialise the Assets API
```csharp
     var assetsApi = AtomicAssetsApiFactory.Version1.AssetsApi;
```
 
 ### Call the assets endpoint
```csharp
     var assets = await assetsApi.Assets();
```
 
 ### Print all asset ids
```csharp
     assets.Data.ToList().ForEach(a => Console.WriteLine(a.AssetId));
```
 
 ##### Example output
 
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
```csharp
     var assetsApi = AtomicAssetsApiFactory.Version1.AssetsApi;
```
 
### Build up the AssetsParameters with the AssetsUriParameterBuilder
```csharp
     var builder = new AssetsUriParameterBuilder().WithLimit(1);
```
 
### Call the assets endpoint, passing in the builder
```csharp
     var assets = await assetsApi.Assets(builder);
```


### Print all asset ids

```csharp
assets.Data.ToList().ForEach(a => Console.WriteLine(a.AssetId));
 ```
##### Example output

1099567200114

1099567200113  

1099567200112  

1099567200111 

1099567200110  

1099567200109  

1099567200108 

1099567200107 

1099567200106 

....

