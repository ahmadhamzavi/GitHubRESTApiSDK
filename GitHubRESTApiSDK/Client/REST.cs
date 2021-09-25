using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GitHubRESTApiSDK
{
    internal class REST
    {
        public HttpClient _client;
        public REST(HttpClient client)
        {
            _client = client;
        }
        #region Post
        public async Task<string> Post(Uri uri, ContentType contentType) => await Post(uri, null, null, contentType);
        public async Task<string> Post(Uri uri, Dictionary<string, string> headers, ContentType contentType) => await Post(uri, headers, null, contentType);
        public async Task<string> Post(Uri uri, Dictionary<string, string> headers, object body, ContentType contentType)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = uri,
            };
            request.Headers.Add(HttpRequestHeader.ContentType.ToString(), contentType.GetDescription());
            if (headers != null && headers.Count > 0)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            if (body != null)
            {
                request.Content = new StringContent(body.ToCamelCaseJson(), Encoding.UTF8, contentType.GetDescription());
            }
            var response = await _client.SendAsync(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            throw new Exception(await response.Content.ReadAsStringAsync());
        }
        public async Task<T> Post<T>(Uri uri, Dictionary<string, string> headers, object body, ContentType contentType) where T : class
        {
            var response = await Post(uri, headers, body, contentType);
            return JsonConvert.DeserializeObject<T>(response, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
        public async Task<string> Post(Uri uri, object body, ContentType contentType) => await Post(uri, null, body, contentType);
        #endregion
        #region Get
        public async Task<string> Get(Uri uri, Dictionary<string, string> headers)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
            };
            if (headers != null && headers.Count > 0)
            {
                foreach (var header in headers)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }
            var response = await _client.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<T> Get<T>(Uri uri) where T : class
        {
            var response = await Get(uri, null);
            return JsonConvert.DeserializeObject<T>(response, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
        public async Task<T> Get<T>(Uri uri, Dictionary<string, string> headers) where T : class
        {
            var response = await Get(uri, headers);
            return JsonConvert.DeserializeObject<T>(response, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
        #endregion
        public Dictionary<string, string> AddHeader(string key, string value, Dictionary<string, string> heagers = null)
        {
            if (heagers == null) { heagers = new Dictionary<string, string>(); }
            heagers.Add(key, value);
            return heagers;
        }
    }
}