using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class PeriodoClaseDto
    {
        public int PeriodoID { get; set; }
        public int InstitutoID { get; set; }
        public string Nombre { get; set; } = null!;
        public TimeOnly HoraInicio { get; set; }
        public TimeOnly HoraFin { get; set; }
        public int? OrdenPeriodo { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        // Propiedades de navegación
        public string? NombreInstituto { get; set; }
        public int DuracionMinutos => (int)(HoraFin.ToTimeSpan() - HoraInicio.ToTimeSpan()).TotalMinutes;
    }

    public class PeriodoClaseCreateDto
    {
        [Required]
        public int InstitutoID { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        [Required]
        public TimeOnly HoraInicio { get; set; }

        [Required]
        public TimeOnly HoraFin { get; set; }

        [Range(1, 20)]
        public int? OrdenPeriodo { get; set; }

        public bool? Activo { get; set; } = true;
    }

}
