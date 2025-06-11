using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class HorarioDto
    {
        public int HorarioID { get; set; }
        public int AsignacionID { get; set; }
        public int DiaSemanaID { get; set; }
        public int PeriodoID { get; set; }
        public int? AulaID { get; set; }
        public int AnioLectivo { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        // Propiedades de navegación
        public string? NombreDiaSemana { get; set; }
        public string? NombrePeriodo { get; set; }
        public string? NombreAula { get; set; }
        public string? NombreMateria { get; set; }
        public string? NombreProfesor { get; set; }
    }

    public class HorarioCreateDto
    {
        [Required]
        public int AsignacionID { get; set; }

        [Required]
        public int DiaSemanaID { get; set; }

        [Required]
        public int PeriodoID { get; set; }

        public int? AulaID { get; set; }

        [Required]
        public int AnioLectivo { get; set; }

        [Required]
        public DateOnly FechaInicio { get; set; }

        [Required]
        public DateOnly FechaFin { get; set; }

        public bool? Activo { get; set; } = true;
    }

}
