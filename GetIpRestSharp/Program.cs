using RestSharp;
using System.Text.Json;
using System.Text.Json.Nodes;

string url = "https://api.ipify.org/?format=json";
var client = new RestClient(url);
var request = new RestRequest();


var response = client.Get(request);
var data = JsonSerializer.Deserialize<JsonNode>(response.Content);
var IsSuccessful = response.IsSuccessful;
var ServerName = response.Server;
var ContentType = response.ContentType;
var StatusCode = response.StatusCode;
if (IsSuccessful)
{
    Console.WriteLine($"The ip is {data["ip"]}");
    Console.WriteLine($"Server Name is {ServerName}");
    Console.WriteLine($"ContentType is {ContentType}");
    Console.WriteLine($"StatusCode is: {StatusCode}");
}

else
    Console.WriteLine("Error");



