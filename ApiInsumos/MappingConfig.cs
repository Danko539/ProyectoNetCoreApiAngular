using ApiInsumos.Dtos;
using ApiInsumos.Models;
using AutoMapper;

namespace ApiInsumos
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<InsumoDto, Insumo>();
                config.CreateMap<Insumo, InsumoDto>();
            });

            return mappingConfig;
        }
    }
}
