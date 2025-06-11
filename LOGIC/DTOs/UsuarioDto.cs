using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class UsuarioDto
    {
        public int UsuarioID { get; set; }
        public int PersonaID { get; set; }
        public string NombreUsuario { get; set; } = null!;
        public DateTime? UltimoAcceso { get; set; }
        public int? IntentosLogin { get; set; }
        public bool? Bloqueado { get; set; }
        public DateTime? FechaVencimientoPassword { get; set; }
        public bool? RequiereCambioPassword { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        // Propiedades de navegación
        public string? NombreCompleto { get; set; }
        public string? EmailPrincipal { get; set; }
        public List<string>? Roles { get; set; }
        public List<string>? Institutos { get; set; }
    }

    public class UsuarioCreateDto
    {
        [Required]
        public int PersonaID { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreUsuario { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string Password { get; set; } = null!;

        public bool? RequiereCambioPassword { get; set; } = false;
        public bool? Activo { get; set; } = true;
    }

    public class UsuarioLoginDto
    {
        [Required]
        public string NombreUsuario { get; set; } = null!;

        [Required]
        public string Password { get; set; } = null!;
    }

    public class UsuarioCambioPasswordDto
    {
        [Required]
        public string PasswordActual { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 8)]
        public string PasswordNuevo { get; set; } = null!;

        [Required]
        [Compare("PasswordNuevo")]
        public string ConfirmarPassword { get; set; } = null!;
    }
}
