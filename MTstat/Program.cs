using MTstat.ApiClients;
using MTstat.Services;

var client = new WargamingApiClient();

try
{
    var accountId = await client.GetAccountIdAsync("___Tank___");
    var stats = await client.GetPlayerStatsAsync(accountId);

    var analyzer = new PlayerAnalyzer();
    var result = analyzer.Analyze(stats); 
    
    Console.WriteLine($"WinRate {result.WinRate}");
    
    
    
    Console.WriteLine($"Battles {stats.Battles}");
    Console.WriteLine($"Wins {stats.Wins}");
    Console.WriteLine($"Losses {stats.Losses}");
    Console.WriteLine($"DamageDealt {stats.DamageDealt}");
    Console.WriteLine($"HitsPercents {stats.HitsPercents}");
    Console.WriteLine($"Survived {stats.SurvivedBattles}");
    Console.WriteLine($"Weaknesses {string.Join(", ", result.Weaknesses)}");
}
catch (Exception ex)
{
    Console.WriteLine("Player not found");
}

