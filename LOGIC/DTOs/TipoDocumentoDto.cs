using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class TipoDocumentoDto
    {
        public int TipoDocumentoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Codigo { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public int? TotalPersonas { get; set; }
    }

    public class TipoDocumentoCreateDto
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        [StringLength(10)]
        public string? Codigo { get; set; }

        public bool? Activo { get; set; } = true;
    }

}
