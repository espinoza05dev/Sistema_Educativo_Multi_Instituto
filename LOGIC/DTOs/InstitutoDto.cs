using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class InstitutoDto
    {
        public int InstitutoID { get; set; }
        public int TipoInstitutoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string CodigoInstituto { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? SitioWeb { get; set; }
        public byte[]? Logo { get; set; }
        public DateOnly? FechaFundacion { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        // Propiedades de navegación
        public string? TipoInstitutoNombre { get; set; }
        public int? TotalAulas { get; set; }
        public int? TotalGrados { get; set; }
    }

    public class InstitutoCreateDto
    {
        [Required]
        public int TipoInstitutoID { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; } = null!;

        [Required]
        [StringLength(20)]
        public string CodigoInstituto { get; set; } = null!;

        [StringLength(500)]
        public string? Descripcion { get; set; }

        [StringLength(20)]
        public string? Telefono { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        [StringLength(200)]
        [Url]
        public string? SitioWeb { get; set; }

        public byte[]? Logo { get; set; }
        public DateOnly? FechaFundacion { get; set; }
        public bool? Activo { get; set; } = true;
    }

}
