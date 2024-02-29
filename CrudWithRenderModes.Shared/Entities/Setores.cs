using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudWithRenderModes.Shared.Entities
{
    public class Setores
    {
        [Key]
        public int Id {  get; set; }

        [Required]
        public string Empresa { get; set; } = string.Empty;

        [Required]
        public string Equipes { get; set; } = string.Empty ;

        [Required]

        public string NomeMaquina { get; set; } = string.Empty;

        [Required]

        public int PontoDeAtendimento { get; set; }
    }
}
