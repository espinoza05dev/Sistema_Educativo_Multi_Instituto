using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class InscripcionDto
    {
        public int InscripcionID { get; set; }
        public int EstudianteID { get; set; }
        public int GradoID { get; set; }
        public int AnioLectivo { get; set; }
        public DateTime? FechaInscripcion { get; set; }
        public string? EstadoInscripcion { get; set; }
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; }

        // Propiedades de navegación
        public string? NombreEstudiante { get; set; }
        public string? NombreGrado { get; set; }
        public string? CodigoEstudiante { get; set; }
    }

    public class InscripcionCreateDto
    {
        [Required]
        public int EstudianteID { get; set; }

        [Required]
        public int GradoID { get; set; }

        [Required]
        public int AnioLectivo { get; set; }

        public DateTime? FechaInscripcion { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string? EstadoInscripcion { get; set; } = "Activa";

        [StringLength(500)]
        public string? Observaciones { get; set; }

        public bool? Activo { get; set; } = true;
    }

}
