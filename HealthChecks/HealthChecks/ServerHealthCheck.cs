using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthChecks.HealthChecks
{
    public class ServerHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
       CancellationToken cancellationToken = default)
        {
            var isServerHealthy = CheckServerStatus();

            return Task.FromResult(isServerHealthy
                ? HealthCheckResult.Healthy("The server is working")
                : HealthCheckResult.Unhealthy("The server is not working"));
        }

        private bool CheckServerStatus()
        {
            return true;  
        }
    }
}
