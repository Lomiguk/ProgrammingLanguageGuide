namespace ProgrammingLanguageGuide.Api;

using ProgrammingLanguageGuide.Services.Settings;
using Microsoft.Extensions.DependencyInjection;
using ProgrammingLanguageGuide.Api.Settings;

public static class Bootstrapper
{
    public static IServiceCollection RegisterAppServices(this IServiceCollection services)
    {
        services
            .AddMainSettings()
            .AddSwaggerSettings()
            .AddApiSpecialSettings()
            ;

        return services;
    }
}
