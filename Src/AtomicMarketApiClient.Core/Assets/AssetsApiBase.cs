﻿using System;
using System.Threading.Tasks;

namespace AtomicMarketApiClient.Core.Assets
{
    public class AssetsApiBase
    {
        private readonly string _requestUriBase;
        private readonly IHttpHandler _httpHandler;

        protected AssetsApiBase(string baseUrl, IHttpHandler httpHandler)
        {
            _requestUriBase = baseUrl;
            _httpHandler = httpHandler;
        }

        public async Task<AssetsDto> Assets()
        {
            return await _httpHandler.GetJsonAsync<AssetsDto>(AssetsUri().OriginalString);
        }

        public async Task<AssetsDto> Assets(AssetsUriParameterBuilder assetsUriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<AssetsDto>(AssetsUri(assetsUriParameterBuilder).OriginalString);
        }

        public async Task<AssetDto> Asset(string assetId)
        {
            return await _httpHandler.GetJsonAsync<AssetDto>(AssetUri(assetId).OriginalString);
        }

        public async Task<StatsDto> AssetStats(string assetId)
        {
            return await _httpHandler.GetJsonAsync<StatsDto>(AssetStatsUri(assetId).OriginalString);
        }

        public async Task<LogsDto> AssetLogs(string assetId)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(AssetLogsUri(assetId).OriginalString);
        }

        public async Task<LogsDto> AssetLogs(string assetId, AssetsUriParameterBuilder assetsUriParameterBuilder)
        {
            return await _httpHandler.GetJsonAsync<LogsDto>(AssetLogsUri(assetId, assetsUriParameterBuilder).OriginalString);
        }

        private Uri AssetsUri() => new Uri($"{_requestUriBase}/assets");
        private Uri AssetsUri(AssetsUriParameterBuilder assetsUriParameterBuilder) => new Uri($"{_requestUriBase}/assets{assetsUriParameterBuilder.Build()}");
        private Uri AssetUri(string assetId) => new Uri($"{_requestUriBase}/assets/{assetId}");
        private Uri AssetStatsUri(string assetId) => new Uri($"{_requestUriBase}/assets/{assetId}/stats");
        private Uri AssetLogsUri(string assetId) => new Uri($"{_requestUriBase}/assets/{assetId}/logs");
        private Uri AssetLogsUri(string assetId, AssetsUriParameterBuilder assetsUriParameterBuilder) => new Uri($"{_requestUriBase}/assets/{assetId}/logs{assetsUriParameterBuilder.Build()}");
    }
}