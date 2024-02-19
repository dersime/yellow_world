using AsyncAwaitBestPractices;
using Microsoft.Extensions.Configuration;

var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true);

var config = builder.Build();

var channel = config["channel"];
var userName = config["user:username"];
Console.WriteLine($"Channel is: {channel}");
Console.WriteLine($"User name is: {userName}");
