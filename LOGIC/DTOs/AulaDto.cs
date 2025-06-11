using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class AulaDto
    {
        public int AulaID { get; set; }
        public int InstitutoID { get; set; }
        public int TipoAulaID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Codigo { get; set; }
        public int? Capacidad { get; set; }
        public int? Piso { get; set; }
        public string? Edificio { get; set; }
        public string? Equipamiento { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual Instituto Instituto { get; set; } = null!;
        public virtual TiposAula TipoAula { get; set; } = null!;
    }

    public class CreateAulaDto
    {
        [Required]
        public int InstitutoID { get; set; }
        [Required]
        public int TipoAulaID { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; } = null!;
        [StringLength(20)]
        public string? Codigo { get; set; }
        [Range(1, 1000)]
        public int? Capacidad { get; set; }
        public int? Piso { get; set; }
        [StringLength(50)]
        public string? Edificio { get; set; }
        [StringLength(500)]
        public string? Equipamiento { get; set; }
        public bool? Activo { get; set; } = true;
    }

    public class UpdateAulaDto
    {
        [Required]
        public int AulaID { get; set; }
        [Required]
        public int InstitutoID { get; set; }
        [Required]
        public int TipoAulaID { get; set; }
        [Required, StringLength(50)]
        public string Nombre { get; set; } = null!;
        [StringLength(20)]
        public string? Codigo { get; set; }
        [Range(1, 1000)]
        public int? Capacidad { get; set; }
        public int? Piso { get; set; }
        [StringLength(50)]
        public string? Edificio { get; set; }
        [StringLength(500)]
        public string? Equipamiento { get; set; }
        public bool? Activo { get; set; }
    }
}
