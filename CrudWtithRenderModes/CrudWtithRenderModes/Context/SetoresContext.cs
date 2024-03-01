using CrudWithRenderModes.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudWtithRenderModes.Context
{
    public class SetoresContext : DbContext
    {
        public SetoresContext(DbContextOptions options) : base(options)
        {

        }
       public DbSet<Setores> Setores{ get; set; }
    }
}
