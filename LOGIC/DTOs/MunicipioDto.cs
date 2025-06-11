using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class MunicipioDto
    {
        public int MunicipioID { get; set; }
        public int DepartamentoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Codigo { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        // Propiedades de navegación
        public string? NombreDepartamento { get; set; }
        public string? NombrePais { get; set; }
    }

    public class MunicipioCreateDto
    {
        [Required]
        public int DepartamentoID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        [StringLength(10)]
        public string? Codigo { get; set; }

        public bool? Activo { get; set; } = true;
    }
}
