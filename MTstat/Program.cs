using MTstat.ApiClients;
using MTstat.Models;
using MTstat.Services;

var client = new WargamingApiClient();

try
{
    var accountId = await client.GetAccountIdAsync("___Tank___");
    var stats = await client.GetPlayerStatsAsync(accountId);

    var analyzer = new PlayerAnalyzer();
    var result = analyzer.Analyze(stats);

    string WeaknessesToText(WeaknessType type) => type switch
    {
        WeaknessType.LowAvgDamage => "Низкий средний урон",
        WeaknessType.LowWinRate => "Низкий винрейт",
        WeaknessType.LowSurvival => "Низкая выживаемость",
        _ => "хЗ Чтот"
    };

    if (!result.HasBattles)
    {
        Console.WriteLine("Player dont have battles");
    }
    else
    {


        Console.WriteLine($"WinRate {result.WinRate}");
        Console.WriteLine($"Battles {stats.Battles}");
        Console.WriteLine($"Wins {stats.Wins}");
        Console.WriteLine($"Losses {stats.Losses}");
        Console.WriteLine($"DamageDealt {stats.DamageDealt}");
        Console.WriteLine($"HitsPercents {stats.HitsPercents}");
        Console.WriteLine($"Survived {stats.SurvivedBattles}");
        foreach (var resultWeakness in result.Weaknesses)
        {
            Console.WriteLine(WeaknessesToText(resultWeakness));
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine("Player not found");
}

