using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class PagoDto
    {
        public int PagoID { get; set; }
        public int CuentaID { get; set; }
        public decimal MontoPagado { get; set; }
        public DateTime? FechaPago { get; set; }
        public string MetodoPago { get; set; } = null!;
        public string? NumeroRecibo { get; set; }
        public string? Observaciones { get; set; }
        public int UsuarioRegistro { get; set; }
        public DateTime? FechaCreacion { get; set; }

        // Propiedades de navegación
        public string? NombreEstudiante { get; set; }
        public string? ConceptoPago { get; set; }
        public string? UsuarioRegistroNombre { get; set; }
    }

    public class PagoCreateDto
    {
        [Required]
        public int CuentaID { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El monto debe ser mayor a 0")]
        public decimal MontoPagado { get; set; }

        public DateTime? FechaPago { get; set; } = DateTime.Now;

        [Required]
        [StringLength(20)]
        public string MetodoPago { get; set; } = null!;

        [StringLength(50)]
        public string? NumeroRecibo { get; set; }

        [StringLength(500)]
        public string? Observaciones { get; set; }

        [Required]
        public int UsuarioRegistro { get; set; }
    }

}
