using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class MateriaDto
    {
        public int MateriaID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public int? CreditosAcademicos { get; set; }
        public int? HorasSemanales { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }

    public class MateriaCreateDto
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        [StringLength(20)]
        public string? Codigo { get; set; }

        [StringLength(300)]
        public string? Descripcion { get; set; }

        [Range(1, 10)]
        public int? CreditosAcademicos { get; set; }

        [Range(1, 40)]
        public int? HorasSemanales { get; set; }

        public bool? Activo { get; set; } = true;
    }
}
