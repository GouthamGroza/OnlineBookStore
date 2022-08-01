using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace BFF.HttpHelpers
{
    public class HttpClientHelper
    {
        public static async Task<T> Get<T>(string url)
        {
            T result = default(T);
           using(var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(new System.Uri(url)).Result;

                response.EnsureSuccessStatusCode();

                await response.Content.ReadAsStringAsync().ContinueWith((Task<string> res) =>
                {
                    if (res.IsFaulted)
                    {
                        throw res.Exception;

                    } else
                       result = JsonConvert.DeserializeObject<T>(res.Result);

                });
            } 
            return result;
        }
    }
}