namespace MTstat.ApiClients;
using MTstat.Models;
public interface IWargamingApiClient
{
    Task<int> GetAccountIdAsync(string nickname);
    Task<PlayerStats> GetPlayerStatsAsync(int accountId);
}