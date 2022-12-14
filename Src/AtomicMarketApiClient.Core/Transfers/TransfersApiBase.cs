﻿using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Core.Transfers
{
    public class TransfersApiBase
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        protected TransfersApiBase(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        public async Task<TransfersDto> Transfers()
        {
            return await _httpHandler.GetJsonAsync<TransfersDto>(TransfersUri().OriginalString);
        }

        public async Task<TransfersDto> Transfers(TransfersUriParameterBuilder transfersUriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<TransfersDto>(TransfersUri(transfersUriParameterBuilder).OriginalString);
        }

        private Uri TransfersUri() => new Uri($"{_requestUriBase}/transfers");
        private Uri TransfersUri(TransfersUriParameterBuilder transfersUriParameterBuilder) => new Uri($"{_requestUriBase}/transfers{transfersUriParameterBuilder.Build()}");
    }
}