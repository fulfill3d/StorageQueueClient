using Client.Interfaces;
using Client.Options;
using Microsoft.Extensions.DependencyInjection;

namespace Client
{
    public static class DepInj
    {
        public static void RegisterStorageQueueClient(this IServiceCollection services, Action<StorageQueueClientOptions> configureQueueOptions)
        {
            services.ConfigureServiceOptions<StorageQueueClientOptions>((_, options) => configureQueueOptions(options));
            services.AddTransient<IStorageQueueClient, StorageQueueClient>();
        }
        
        private static void ConfigureServiceOptions<TOptions>(
            this IServiceCollection services,
            Action<IServiceProvider, TOptions> configure)
            where TOptions : class
        {
            services
                .AddOptions<TOptions>()
                .Configure<IServiceProvider>((options, resolver) => configure(resolver, options));
        }
    }
}