using GitHubRESTApiSDK.Models;
using IdentityModel.Client;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GitHubRESTApiSDK
{
    public class GitHubClient : IGitHubClient
    {
        private static IGitHubClient _gitHubClient;
        private readonly ILogger<GitHubClient> _logger;
        private REST _rest;
        public GitHubClient(HttpClient client, string token)
        {
            _rest = new REST(client);
            token = $"username:{token}".ToBase64();
            _rest._client.SetToken("Basic", token);
            _rest._client.DefaultRequestHeaders.Host = "api.github.com";
            var productValue = new ProductInfoHeaderValue("GitHubRESTApiSDK", "1.0");
            _rest._client.DefaultRequestHeaders.UserAgent.Add(productValue);
            _rest._client.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue() { NoCache = true };
        }
        public static IGitHubClient getInstance(string url, string token)
        {
            if (_gitHubClient.IsNull())
            {
                HttpClient client;
                var uri = new Uri(url);
                if (uri.Scheme == Uri.UriSchemeHttps)
                {
                    HttpClientHandler clientHandler = new HttpClientHandler();
                    clientHandler.ServerCertificateCustomValidationCallback =
            (sender, cert, chain, sslPolicyErrors) => { return true; };
                    client = new HttpClient(clientHandler);
                }
                else { client = new HttpClient(); }
                client.BaseAddress = uri;
                _gitHubClient = new GitHubClient(client, token);
            }

            return _gitHubClient;

        }

        public async Task<List<GitRepository>> Repositories()
        {
            var uri = new Uri($"{_rest._client.BaseAddress}users/ahmadhamzavi/repos");
            return await _rest.Get<List<GitRepository>>(uri);
        }

        public void Dispose()
        {
            _rest._client.Dispose();
            _gitHubClient = null;
        }

    }

}