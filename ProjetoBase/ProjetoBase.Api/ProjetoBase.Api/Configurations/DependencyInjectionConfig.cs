using Microsoft.Extensions.DependencyInjection;
using ProjetoBase.Shared.Notifications;

namespace ProjetoBase.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services)
        {
            //Notification Pattern
            services.AddScoped<INotification, Notification>();
        }
    }
}
