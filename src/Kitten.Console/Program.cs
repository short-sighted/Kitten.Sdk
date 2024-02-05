using System.Text.Json;
using Kitten.Sdk.Client;
using Kitten.Sdk.Extensions;

var kittenClient = new KittenClient(new KittenClientOptions());
kittenClient.ResetKittenHttpClientBaseUrl(new KittenClientOptions
{
    KittenClientHttpEndpoints = "http://127.0.0.1:9191/"
});
var status = await kittenClient.ExecuteGetStatus();
var version = await kittenClient.ExecuteGetVersion();

Console.WriteLine(status);
Console.WriteLine(JsonSerializer.Serialize(version));