using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class MateriaGradoDto
    {
        public int MateriaGradoID { get; set; }
        public int GradoID { get; set; }
        public int MateriaID { get; set; }
        public bool? EsObligatoria { get; set; }
        public int? OrdenEnPensum { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        // Propiedades de navegación
        public string? NombreGrado { get; set; }
        public string? NombreMateria { get; set; }
        public string? CodigoMateria { get; set; }
        public int? CreditosAcademicos { get; set; }
        public int? HorasSemanales { get; set; }
    }

    public class MateriaGradoCreateDto
    {
        [Required]
        public int GradoID { get; set; }

        [Required]
        public int MateriaID { get; set; }

        public bool? EsObligatoria { get; set; } = true;

        [Range(1, 100)]
        public int? OrdenEnPensum { get; set; }

        public bool? Activo { get; set; } = true;
    }
}
