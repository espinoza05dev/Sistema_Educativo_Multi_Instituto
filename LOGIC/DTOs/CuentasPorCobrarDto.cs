using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class CuentasPorCobrarDto
    {
        public int CuentaID { get; set; }
        public int EstudianteID { get; set; }
        public int ConceptoID { get; set; }
        public int AnioLectivo { get; set; }
        public decimal MontoOriginal { get; set; }
        public decimal? MontoDescuento { get; set; }
        public decimal MontoTotal { get; set; }
        public DateOnly FechaVencimiento { get; set; }
        public string? Estado { get; set; }
        public string? Observaciones { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual ConceptosPago Concepto { get; set; } = null!;
        public virtual Estudiante Estudiante { get; set; } = null!;
    }

    public class CreateCuentasPorCobrarDto
    {
        [Required]
        public int EstudianteID { get; set; }
        [Required]
        public int ConceptoID { get; set; }
        [Required, Range(2000, 2100)]
        public int AnioLectivo { get; set; }
        [Required, Range(0.01, 999999999.99)]
        public decimal MontoOriginal { get; set; }
        [Range(0, 999999999.99)]
        public decimal? MontoDescuento { get; set; }
        [Required, Range(0.01, 999999999.99)]
        public decimal MontoTotal { get; set; }
        [Required]
        public DateOnly FechaVencimiento { get; set; }
        [StringLength(20)]
        public string? Estado { get; set; } = "Pendiente";
        [StringLength(500)]
        public string? Observaciones { get; set; }
    }

    public class UpdateCuentasPorCobrarDto
    {
        [Required]
        public int CuentaID { get; set; }
        [Required]
        public int EstudianteID { get; set; }
        [Required]
        public int ConceptoID { get; set; }
        [Required, Range(2000, 2100)]
        public int AnioLectivo { get; set; }
        [Required, Range(0.01, 999999999.99)]
        public decimal MontoOriginal { get; set; }
        [Range(0, 999999999.99)]
        public decimal? MontoDescuento { get; set; }
        [Required, Range(0.01, 999999999.99)]
        public decimal MontoTotal { get; set; }
        [Required]
        public DateOnly FechaVencimiento { get; set; }
        [StringLength(20)]
        public string? Estado { get; set; }
        [StringLength(500)]
        public string? Observaciones { get; set; }
    }

}
