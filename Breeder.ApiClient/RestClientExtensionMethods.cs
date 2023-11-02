using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breeder.ApiClient;
public static class RestClientExtensionMethods
{
    public static RestResponse<T> Request<T>(this RestClient client, Method method, string resource = null, object body = null)
    {
        var request = new RestRequest(resource, method);
        if (body != null)
        {
            request.AddJsonBody(body);
        }
        return client.Execute<T>(request);
    }
}
