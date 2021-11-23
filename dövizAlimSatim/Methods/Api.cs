using dövizAlimSatim.DTO;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dövizAlimSatim.Methods
{
    public class Api<T> where T : class
    {
        public async static Task<T> pullDataAsync(string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
     
            return Json_Convert<T>.deserializeProcess(response);
        }

        public static string apiFormat(IRestResponse response)
        {
            var result = response.Content.Replace("\\", "");
            return result.Substring(1, result.Length - 2);
        }

    }
}
