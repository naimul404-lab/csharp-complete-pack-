using System.Net.Http;

using var client = new HttpClient();
try
{
    string response = await client.GetStringAsync("https://example.com");
    Console.WriteLine($"Received {response.Length} characters.");
}
catch (HttpRequestException error)
{
    Console.WriteLine($"Request failed: {error.Message}");
}
