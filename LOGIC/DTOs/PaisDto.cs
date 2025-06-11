using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class PaisDto
    {
        public int PaisID { get; set; }
        public string Nombre { get; set; } = null!;
        public string CodigoISO { get; set; } = null!;
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public int? TotalDepartamentos { get; set; }
    }

    public class PaisCreateDto
    {
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        [Required]
        [StringLength(2)]
        [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "El código ISO debe tener 2 letras mayúsculas")]
        public string CodigoISO { get; set; } = null!;

        public bool? Activo { get; set; } = true;
    }
}
