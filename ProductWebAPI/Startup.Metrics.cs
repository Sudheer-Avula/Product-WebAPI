

using Microsoft.Extensions.DependencyInjection;
using App.Metrics;


namespace ProductWebAPI
{
    public partial class Startup
    {
        public void InjecMetrics(IServiceCollection services)
        {
            services.AddMetrics(options =>
            {
                options.MetricsEnabled = true;
                options.ReportingEnabled = true;
                options.AddDefaultGlobalTags = false;
            }).AddJsonSerialization()
            .AddJsonEnvironmentInfoSerialization()
            .AddHealthChecks(factory =>
            {
                var physicalMemoryThresholdBytes = 1024 * 1024 * 1024;//1GB
                factory.RegisterProcessPhysicalMemoryHealthCheck("physcical memory", physicalMemoryThresholdBytes);
            }).AddMetricsMiddleware();            
            
        }
    }
}
