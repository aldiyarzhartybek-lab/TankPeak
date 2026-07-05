using MTstat.ApiClients;

var client = new WargamingApiClient();
var accountId = await client.GetAccountIdAsync("___Tank___");
var stats =  await client.GetPlayerStatsAsync(accountId);

Console.WriteLine($"Battles {stats.Battles}");
Console.WriteLine($"Wins {stats.Wins}");
Console.WriteLine($"Losses {stats.Losses}");
Console.WriteLine($"DamageDealt {stats.DamageDealt}");
Console.WriteLine($"HitsPercents {stats.HitsPercents}");
Console.WriteLine($"Survived {stats.SurvivedBattles}");