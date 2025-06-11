using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class ProfesorDto
    {
        public int ProfesorID { get; set; }
        public int PersonaID { get; set; }
        public string CodigoProfesor { get; set; } = null!;
        public DateOnly FechaIngreso { get; set; }
        public string? TituloAcademico { get; set; }
        public string? Especialidad { get; set; }
        public int? AniosExperiencia { get; set; }
        public string? EstadoProfesor { get; set; }
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        // Propiedades de navegación
        public string? NombreCompleto { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? EmailPrincipal { get; set; }
        public string? TelefonoPrincipal { get; set; }
        public int? TotalAsignaciones { get; set; }
    }

    public class ProfesorCreateDto
    {
        [Required]
        public int PersonaID { get; set; }

        [Required]
        [StringLength(20)]
        public string CodigoProfesor { get; set; } = null!;

        [Required]
        public DateOnly FechaIngreso { get; set; }

        [StringLength(100)]
        public string? TituloAcademico { get; set; }

        [StringLength(100)]
        public string? Especialidad { get; set; }

        [Range(0, 50)]
        public int? AniosExperiencia { get; set; }

        [StringLength(20)]
        public string? EstadoProfesor { get; set; } = "Activo";

        [StringLength(500)]
        public string? Observaciones { get; set; }

        public bool? Activo { get; set; } = true;
    }

}
