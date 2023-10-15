using Experiment.ApiClient.Interfaces;
using Experiment.ApiClient.Services;
using Experiments.Constants.Api;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace Experiment.ApiClient.Extensions
{
    public static class ApiClientExtensions
    {
        public static IServiceCollection AddApiClientServices(this IServiceCollection services)
        {
            services
                .AddRefitClient<IUsersClientForRefit>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(ApiConstants.SampleApiURL));

            services.AddScoped<ISampleApiServices, SampleApiServices>();

            return services;
        }
    }
}
