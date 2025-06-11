using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class PersonaDto
    {
        public int PersonaID { get; set; }
        public int TipoDocumentoID { get; set; }
        public string NumeroDocumento { get; set; } = null!;
        public string PrimerNombre { get; set; } = null!;
        public string? SegundoNombre { get; set; }
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public string? Genero { get; set; }
        public string? EstadoCivil { get; set; }
        public string? TelefonoPrincipal { get; set; }
        public string? TelefonoSecundario { get; set; }
        public string? EmailPrincipal { get; set; }
        public string? EmailSecundario { get; set; }
        public byte[]? Foto { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        // Propiedades calculadas
        public string NombreCompleto => $"{PrimerNombre} {SegundoNombre} {PrimerApellido} {SegundoApellido}".Replace("  ", " ").Trim();
        public int Edad => DateTime.Now.Year - FechaNacimiento.Year - (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear ? 1 : 0);
        public string? TipoDocumentoNombre { get; set; }
    }

    public class PersonaCreateDto
    {
        [Required]
        public int TipoDocumentoID { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroDocumento { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string PrimerNombre { get; set; } = null!;

        [StringLength(50)]
        public string? SegundoNombre { get; set; }

        [Required]
        [StringLength(50)]
        public string PrimerApellido { get; set; } = null!;

        [StringLength(50)]
        public string? SegundoApellido { get; set; }

        [Required]
        public DateOnly FechaNacimiento { get; set; }

        [StringLength(1)]
        [RegularExpression(@"^[MF]$", ErrorMessage = "El género debe ser M o F")]
        public string? Genero { get; set; }

        [StringLength(20)]
        public string? EstadoCivil { get; set; }

        [StringLength(20)]
        [Phone]
        public string? TelefonoPrincipal { get; set; }

        [StringLength(20)]
        [Phone]
        public string? TelefonoSecundario { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string? EmailPrincipal { get; set; }

        [StringLength(100)]
        [EmailAddress]
        public string? EmailSecundario { get; set; }

        public byte[]? Foto { get; set; }
        public bool? Activo { get; set; } = true;
    }

}
