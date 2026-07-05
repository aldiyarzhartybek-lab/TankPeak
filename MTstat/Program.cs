using MTstat.ApiClients;

var client = new WargamingApiClient();

try
{
    var accountId = await client.GetAccountIdAsync("___T4122351345631ank_31321__");
    var stats = await client.GetPlayerStatsAsync(accountId);
    Console.WriteLine($"Battles {stats.Battles}");
    Console.WriteLine($"Wins {stats.Wins}");
    Console.WriteLine($"Losses {stats.Losses}");
    Console.WriteLine($"DamageDealt {stats.DamageDealt}");
    Console.WriteLine($"HitsPercents {stats.HitsPercents}");
    Console.WriteLine($"Survived {stats.SurvivedBattles}");
}
catch (Exception ex)
{
    Console.WriteLine("Player not found");
}

