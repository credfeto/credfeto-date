using Credfeto.Date.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Credfeto.Date;

public static class DateSetup
{
    public static IServiceCollection AddDate(this IServiceCollection services)
    {
        return services.AddSingleton<ICurrentTimeSource, CurrentTimeSource>();
    }
}