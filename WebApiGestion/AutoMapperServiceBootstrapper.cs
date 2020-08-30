namespace WebApiGestion
{
    using AutoMapper;
    using Dtos;
    using Domain;

    public class AutoMapperServiceBootstrapper
    {
        public void Bootstrap()
        {
            Mapper.CreateMap<Articulos, ArticulosDto>();
            Mapper.CreateMap<UnidadesMedida, UnidadesMedidaDto>();
            Mapper.CreateMap<SA_Usuarios, SA_UsuariosDto>();
            Mapper.CreateMap<CategoriasIvaArticulo, CategoriasIvaArticuloDto>();
            Mapper.CreateMap<TiposMonedas, TiposMonedasDto>();
            Mapper.CreateMap<TiposComprobantes, TiposComprobantesDto>();
            Mapper.CreateMap<ComprobantesEmitidos, ComprobantesEmitidosDto>();
            Mapper.CreateMap<Clientes, ClientesDto>();
            Mapper.CreateMap<TablasNumeracion, TablasNumeracionDto>();
            Mapper.CreateMap<Productos, ProductosDto>();
            Mapper.CreateMap<Cosechas, CosechasDto>();
            Mapper.CreateMap<OrdenesVenta, OrdenesVentaDto>();
        }
    }
}