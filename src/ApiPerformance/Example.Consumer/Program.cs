using System.Diagnostics;
using System.Net.Http.Json;
using Example.Api;

var httpClient = new HttpClient();

for (var i = 0; i < 5; i++)
{
    var startTime = Stopwatch.GetTimestamp();
    using var usersResponse = await httpClient.GetAsync("https://localhost:7295/user/top");
    var deltaTime = Stopwatch.GetElapsedTime(startTime);
    var users = await usersResponse.Content.ReadFromJsonAsync<List<User>>();
    Console.WriteLine($"Retrieved {users!.Count} users in {deltaTime.TotalMilliseconds}.");
}
