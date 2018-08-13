using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoSearchApplication.Constants;
using RestSharp;

namespace PhotoSearchApplication.Proxys
{
    public class BaseApiProxy
    {
        public T Execute<T>(RestRequest request, string uri) where T : new()
        {
            var client = new RestClient
            {
                BaseUrl = new System.Uri(uri)
            };

            var response = client.Execute<T>(request);

            if (response.ErrorException != null)
            {
                throw new Exception("Error receiving response from api", response.ErrorException);
            }
            return response.Data;
        }
    }
}
