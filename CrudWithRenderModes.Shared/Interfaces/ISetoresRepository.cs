using CrudWithRenderModes.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWithRenderModes.Shared.Interfaces
{
    public interface ISetoresRepository
    {
        Task<Setores> AddSetoresAsync(Setores model);

        Task<Setores> UpdateSetoresAsync(Setores model);

        Task<Setores> DeleteSetoresAsync(int setoresId);

        Task<List<Setores>> GetAllSetoresAsync();

        Task<Setores> GetSetoresByIdAsync(int setoresId);
    }
}
