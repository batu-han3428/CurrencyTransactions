using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace dövizAlimSatim.Methods
{
    public class Json_Convert<T> where T : class
    {
        public static T deserializeProcess(string response)
        {
            return JsonSerializer.Deserialize<T>(response);
        }

    }
}
