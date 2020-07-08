namespace WebApiGestion
{
    using Services;
    using Services.Buscadores;
    using Services.QueryBuilders;
    using Services.Builders;
    using Services.Generadores;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddTransient<IServiceArticulos, ServiceArticulos>();
            services.AddTransient<IServiceUnidadesMedida, ServiceUnidadesMedida>();
            services.AddTransient<IServiceSAUsuarios, ServiceSAUsuarios>();
            services.AddTransient<IServiceCategoriasIvaArticulo, ServiceCategoriasIvaArticulo>();
            services.AddTransient<IServiceTiposMonedas, ServiceTiposMonedas>();
            services.AddTransient<IServiceClientes, ServiceClientes>();
            services.AddTransient<IServiceTiposComprobantes, ServiceTiposComprobantes>();
            services.AddTransient<IServiceComprobantesEmitidos, ServiceComprobantesEmitidos>();
            services.AddTransient<IServiceTablasNumeracion, ServiceTablasNumeracion>();

            services.AddTransient<IContextManager, ContextManager>();
            services.AddTransient<IBuscadorArticulos, BuscadorArticulos>();
            services.AddTransient<IBuscadorSAUsuarios, BuscadorSAUsuarios>();
            services.AddTransient<IBuscadorComprobantesEmitidos, BuscadorComprobantesEmitidos>();
            services.AddTransient<IBuscadorTiposComprobantes, BuscadorTiposComprobantes>();

            services.AddTransient<ISAUsuariosQueryBuilder, SAUsuariosQueryBuilder>();
            services.AddTransient<IComprobantesEmitidosQueryBuider, ComprobantesEmitidosQueryBuider>();
            services.AddTransient<ITiposComprobantesQueryBuilder, TiposComprobantesQueryBuilder>();

            services.AddTransient<IGeneradorToken, GeneradorToken>();

            services.AddTransient<IBuilderComprobantesEmitidos, BuilderComprobantesEmitidos>();
            services.AddTransient<IBuilderDetalleComprobantesEmitidos, BuilderDetalleComprobantesEmitidos>();

            services.AddTransient<IGeneradorBase, GeneradorBase>();
            services.AddTransient<IGeneradorDetalleIvaEmitidos, GeneradorDetalleIvaEmitidos>();

            return services;
        }
    }
}
