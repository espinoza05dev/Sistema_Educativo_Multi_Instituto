using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class EvaluacioneDto
    {
        public int EvaluacionID { get; set; }
        public int AsignacionID { get; set; }
        public int TipoEvaluacionID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public DateOnly FechaEvaluacion { get; set; }
        public decimal PuntajeMaximo { get; set; }
        public decimal Porcentaje { get; set; }
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual AsignacionesProfesore Asignacion { get; set; } = null!;
        public virtual TiposEvaluacion TipoEvaluacion { get; set; } = null!;
    }

    public class CreateEvaluacioneDto
    {
        [Required]
        public int AsignacionID { get; set; }
        [Required]
        public int TipoEvaluacionID { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;
        [StringLength(300)]
        public string? Descripcion { get; set; }
        [Required]
        public DateOnly FechaEvaluacion { get; set; }
        [Required, Range(0.01, 999.99)]
        public decimal PuntajeMaximo { get; set; }
        [Required, Range(0.01, 100)]
        public decimal Porcentaje { get; set; }
        [StringLength(500)]
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; } = true;
    }

    public class UpdateEvaluacioneDto
    {
        [Required]
        public int EvaluacionID { get; set; }
        [Required]
        public int AsignacionID { get; set; }
        [Required]
        public int TipoEvaluacionID { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;
        [StringLength(300)]
        public string? Descripcion { get; set; }
        [Required]
        public DateOnly FechaEvaluacion { get; set; }
        [Required, Range(0.01, 999.99)]
        public decimal PuntajeMaximo { get; set; }
        [Required, Range(0.01, 100)]
        public decimal Porcentaje { get; set; }
        [StringLength(500)]
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; }
    }
}
