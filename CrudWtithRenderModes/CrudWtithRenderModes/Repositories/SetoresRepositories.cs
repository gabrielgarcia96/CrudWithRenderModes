
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

        public  Task<Setores> AddSetoresAsync(Setores model)
        {
            throw new NotImplementedException();

        }

        public Task<Setores> DeleteSetoresAsync(int setoresId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Setores>> GetAllSetoresAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Setores> GetSetoresByIdAsync(int setoresId)
        {
            throw new NotImplementedException();
        }

        public Task<Setores> UpdateSetoresAsync(Setores model)
        {
            throw new NotImplementedException();
        }
    }
}
