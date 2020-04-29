namespace WebApiGestion
{
    using Services;
    using Services.Buscadores;
    using Services.QueryBuilders;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<IServiceArticulos, ServiceArticulos>();
            services.AddTransient<IServiceUnidadesMedida, ServiceUnidadesMedida>();
            services.AddTransient<IServiceSAUsuarios, ServiceSAUsuarios>();

            services.AddTransient<IContextManager, ContextManager>();
            services.AddTransient<IBuscadorArticulos, BuscadorArticulos>();
            services.AddTransient<IBuscadorSAUsuarios, BuscadorSAUsuarios>();

            services.AddTransient<ISAUsuariosQueryBuilder, SAUsuariosQueryBuilder>();

            services.AddTransient<IGeneradorToken, GeneradorToken>();

            return services;
        }
    }
}
