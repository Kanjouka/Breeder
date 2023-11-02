using Breeder.Dal.Models;
using RestSharp;

namespace Breeder.ApiClient;

public class EntityApiClient
{
    private readonly RestClient _restClient;

    public EntityApiClient(string uri)
    {
        _restClient = new RestClient(uri);
    }
    public Entity GetAll()
    {
        var response = _restClient.Request<Entity>(Method.Get, "/entities");
        if (!response.IsSuccessful)
        {
            throw new Exception($"Error retrieving all employees. Message was {response.Content}");
        }
        //Oneliner checking the response for data. If no data, return empty Enumerable.
        //Remaining methods will use classic if statement.
        return response.Data;
    }
}