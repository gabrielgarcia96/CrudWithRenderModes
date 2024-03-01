
using CrudWtithRenderModes.Context;
using CrudWithRenderModes.Shared.Entities;
using CrudWithRenderModes.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CrudWtithRenderModes.Repositories
{
    public class SetoresRepositories : ISetoresRepository
    {
        private readonly SetoresContext _context;

        public SetoresRepositories(SetoresContext context)
        {
            _context = context;
        }

        public  async Task<Setores> AddSetoresAsync(Setores model)
        {
            if (model is null) return null!;

            var check = await _context.Setores.Where(x => x.NomeMaquina.ToLower().Equals(model.NomeMaquina.ToLower())).FirstOrDefaultAsync();
            if (check is not null) return null!;

            var novoSetor = _context.Setores.Add(model).Entity;
            await _context.SaveChangesAsync();
            return novoSetor;

        }

        public async Task<Setores> DeleteSetoresAsync(int setoresId)
        {
            var setor = await _context.Setores.FirstOrDefaultAsync(x => x.Id == setoresId);

            if (setor is null) return null!;

            await _context.SaveChangesAsync();
            return setor;
        }

        public async Task<List<Setores>> GetAllSetoresAsync()
        {
           return await _context.Setores.ToListAsync();
        }

        public async Task<Setores> GetSetoresByIdAsync(int setoresId)
        {
            var setor = await _context.Setores.FirstOrDefaultAsync(x => x.Id == setoresId);

            if (setor is null) return null!;

            return setor;
        }

        public async Task<Setores> UpdateSetoresAsync(Setores model)
        {
            var setor = await _context.Setores.FirstOrDefaultAsync(x => x.Id == model.Id);

            if (setor is null) return null!;

            setor.NomeMaquina = model.NomeMaquina;
            setor.PontoDeAtendimento = model.PontoDeAtendimento;

            await _context.SaveChangesAsync();

            return await _context.Setores.FirstOrDefaultAsync(x => x.Id == model.Id);
        }
    }
}
