using System.Net.Http.Headers;

// HTTP client &  HTTP request 
var client = new HttpClient();
var request = new HttpRequestMessage
{

    //HTTP Get 
    Method = HttpMethod.Get,
    //Requested URL
    RequestUri = new Uri("https://free-nba.p.rapidapi.com/players?page=0&per_page=25"),
    Headers =
    {
        //API KEY 
        { "X-RapidAPI-Key", "a13f82f79fmshdbe468d30030820p1312e4jsnf5532e7ac0af" },
        //API Host
        { "X-RapidAPI-Host", "free-nba.p.rapidapi.com" },
    },
};
    //Async request
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    //String Async
    var body = await response.Content.ReadAsStringAsync();
    //Console Write
    Console.WriteLine(body);
}