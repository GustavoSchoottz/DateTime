using DateTime;
using System.Runtime.InteropServices;

/*
HttpClient client = new HttpClient();
var response = await client.GetAsync("https://timeapi.io/api/Time/current/zone?timeZone=America/Sao_Paulo");
var content = await response.Content.ReadAsStringAsync();
Console.WriteLine(content);
*/

await Api.LerApiAsync();

