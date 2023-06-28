using ApiInsumos.Dtos;

namespace ApiInsumos.Repository
{
    public interface InterfaceInsumoRepository
    {
        Task<IEnumerable<InsumoDto>> GetInsumos();
        Task<IEnumerable<InsumoDto>> GetInsumosBySeccionCode(string seccionCode);
        Task<InsumoDto> GetInsumoById(int insumoId);
        Task<InsumoDto> CreateInsumo(InsumoDto insumoDto);
        Task<InsumoDto> UpdateInsumo(InsumoDto insumoDto);
        Task<bool> DeleteInsumo(int insumoId);
    }
}
