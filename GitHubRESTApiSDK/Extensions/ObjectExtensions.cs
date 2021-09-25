
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace GitHubRESTApiSDK
{
    public static class ObjectExtension
    {
        public static bool IsNull(this object obj)
        {
            if (obj == null)
            {
                return true;
            }
            return false;
        }
        public static bool IsNotNull(this object obj)
        {
            if (obj != null)
            {
                return true;
            }
            return false;
        }
        public static string ToCamelCaseIndentedJson(this object @object)
        {
            string json = null;
            try
            {
                DefaultContractResolver camelCaseResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() };
                json = JsonConvert.SerializeObject(@object, new JsonSerializerSettings { ContractResolver = camelCaseResolver, Formatting = Formatting.Indented });
            }
            catch { }
            return json;
        }
        public static string ToCamelCaseJson(this object @object)
        {
            string json = null;
            try
            {
                DefaultContractResolver camelCaseResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() };
                json = JsonConvert.SerializeObject(@object, new JsonSerializerSettings { ContractResolver = camelCaseResolver });
            }
            catch { }
            return json;
        }
        public static string ToJson(this object @object)
        {
            string json = null;
            try
            {
                json = JsonConvert.SerializeObject(@object);
            }
            catch { }
            return json;
        }
    }
}
