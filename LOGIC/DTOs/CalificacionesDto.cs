using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class CalificacioneDto
    {
        public int CalificacionID { get; set; }
        public int EvaluacionID { get; set; }
        public int EstudianteID { get; set; }
        public decimal PuntajeObtenido { get; set; }
        public string? NotaLiteral { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? FechaCalificacion { get; set; }
        public bool? Activo { get; set; }
        public virtual Estudiante Estudiante { get; set; } = null!;
        public virtual Evaluacione Evaluacion { get; set; } = null!;
    }

    public class CreateCalificacioneDto
    {
        [Required]
        public int EvaluacionID { get; set; }
        [Required]
        public int EstudianteID { get; set; }
        [Required, Range(0, 999.99)]
        public decimal PuntajeObtenido { get; set; }
        [StringLength(5)]
        public string? NotaLiteral { get; set; }
        [StringLength(500)]
        public string? Observaciones { get; set; }
        public DateTime? FechaCalificacion { get; set; } = DateTime.Now;
        public bool? Activo { get; set; } = true;
    }

    public class UpdateCalificacioneDto
    {
        [Required]
        public int CalificacionID { get; set; }
        [Required]
        public int EvaluacionID { get; set; }
        [Required]
        public int EstudianteID { get; set; }
        [Required, Range(0, 999.99)]
        public decimal PuntajeObtenido { get; set; }
        [StringLength(5)]
        public string? NotaLiteral { get; set; }
        [StringLength(500)]
        public string? Observaciones { get; set; }
        public DateTime? FechaCalificacion { get; set; }
        public bool? Activo { get; set; }
    }
}
