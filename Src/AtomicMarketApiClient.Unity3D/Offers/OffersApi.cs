﻿using AtomicMarketApiClient.Core.Offers;

namespace AtomicMarketApiClient.Unity3D.Offers
{
    public class OffersApi : OffersApiBase
    {
        internal OffersApi(string baseUrl) : base(baseUrl, new HttpHandler())
        {

        }
    }
}