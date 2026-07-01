namespace MTstat.ApiClients;
using MTstat.Models;
public interface ILestaApiClient
{
    Task<int> GetAccountIdAsync(string nickname);
    Task<PlayerStats> GetPlayerStatsAsync(int accountId);
}