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
        }
    }
}