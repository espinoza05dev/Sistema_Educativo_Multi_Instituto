using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class TipoAulaDto
    {
        public int TipoAulaID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public int? TotalAulas { get; set; }
    }

    public class TipoAulaCreateDto
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        [StringLength(200)]
        public string? Descripcion { get; set; }

        public bool? Activo { get; set; } = true;
    }
}
