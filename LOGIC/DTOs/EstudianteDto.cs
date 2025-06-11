using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class EstudianteDto
    {
        public int EstudianteID { get; set; }
        public int PersonaID { get; set; }
        public string CodigoEstudiante { get; set; } = null!;
        public DateOnly FechaIngreso { get; set; }
        public string? EstadoEstudiante { get; set; }
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual Persona Persona { get; set; } = null!;
    }

    public class CreateEstudianteDto
    {
        [Required]
        public int PersonaID { get; set; }
        [Required, StringLength(20)]
        public string CodigoEstudiante { get; set; } = null!;
        [Required]
        public DateOnly FechaIngreso { get; set; }
        [StringLength(20)]
        public string? EstadoEstudiante { get; set; } = "Activo";
        [StringLength(500)]
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; } = true;
    }

    public class UpdateEstudianteDto
    {
        [Required]
        public int EstudianteID { get; set; }
        [Required]
        public int PersonaID { get; set; }
        [Required, StringLength(20)]
        public string CodigoEstudiante { get; set; } = null!;
        [Required]
        public DateOnly FechaIngreso { get; set; }
        [StringLength(20)]
        public string? EstadoEstudiante { get; set; }
        [StringLength(500)]
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; }
    }
}
