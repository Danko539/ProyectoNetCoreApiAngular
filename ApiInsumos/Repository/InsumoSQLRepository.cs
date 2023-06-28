using ApiInsumos.DbContexts;
using ApiInsumos.Dtos;
using ApiInsumos.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ApiInsumos.Repository
{
    public class InsumoSQLRepository : InterfaceInsumoRepository
    {
        private AppDbContext dbContext;
        private IMapper mapper;
        public InsumoSQLRepository(AppDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }


        public async Task<InsumoDto> CreateInsumo(InsumoDto insumoDto)
        {
            Insumo insumo = mapper.Map<Insumo>(insumoDto);
            this.dbContext.Insumos.Add(insumo);
            await this.dbContext.SaveChangesAsync();

            return mapper.Map<InsumoDto>(insumo);
        }

        public async Task<bool> DeleteInsumo(int insumoId)
        {
            try
            {
                Insumo insumo = await this.dbContext.Insumos.FirstOrDefaultAsync(insumo => insumo.insumoId == insumoId);

                if(insumo == null)
                {
                    return false;
                }

                dbContext.Insumos.Remove(insumo);
                await dbContext.SaveChangesAsync();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<InsumoDto> GetInsumoById(int insumoId)
        {
            Insumo insumo = await dbContext.Insumos.Where(insumo => insumo.insumoId == insumoId).FirstOrDefaultAsync();

            return mapper.Map<InsumoDto>(insumo);
        }

        public async Task<IEnumerable<InsumoDto>> GetInsumos()
        {
            List<Insumo> insumos = await this.dbContext.Insumos.ToListAsync();

            return mapper.Map<List<InsumoDto>>(insumos);
        }

        public async Task<IEnumerable<InsumoDto>> GetInsumosBySeccionCode(string seccionCode)
        {
            List<Insumo> insumos = await dbContext.Insumos.Where(insumo => insumo.seccionCode == seccionCode)
                                                          .ToListAsync();

            return mapper.Map<List<InsumoDto>>(insumos);
        }

        public async Task<InsumoDto> UpdateInsumo(InsumoDto insumoDto)
        {
            var insumo = mapper.Map<Insumo>(insumoDto);
            this.dbContext.Update(insumo);
            await this.dbContext.SaveChangesAsync();

            return mapper.Map<InsumoDto>(insumo);
        }
    }
}
