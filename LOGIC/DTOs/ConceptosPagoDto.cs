using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class ConceptosPagoDto
    {
        public int ConceptoID { get; set; }
        public int InstitutoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal Monto { get; set; }
        public string TipoConcepto { get; set; } = null!;
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual Instituto Instituto { get; set; } = null!;
    }

    public class CreateConceptosPagoDto
    {
        [Required]
        public int InstitutoID { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;
        [StringLength(300)]
        public string? Descripcion { get; set; }
        [Required, Range(0.01, 999999999.99)]
        public decimal Monto { get; set; }
        [Required, StringLength(20)]
        public string TipoConcepto { get; set; } = null!;
        public bool? Activo { get; set; } = true;
    }

    public class UpdateConceptosPagoDto
    {
        [Required]
        public int ConceptoID { get; set; }
        [Required]
        public int InstitutoID { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;
        [StringLength(300)]
        public string? Descripcion { get; set; }
        [Required, Range(0.01, 999999999.99)]
        public decimal Monto { get; set; }
        [Required, StringLength(20)]
        public string TipoConcepto { get; set; } = null!;
        public bool? Activo { get; set; }
    }
}
