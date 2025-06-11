using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class ComunicacioneDto
    {
        public int ComunicacionID { get; set; }
        public int InstitutoID { get; set; }
        public int TipoComunicacionID { get; set; }
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public DateTime? FechaEnvio { get; set; }
        public int UsuarioEnvia { get; set; }
        public bool? Urgente { get; set; }
        public bool? RequiereConfirmacion { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual Instituto Instituto { get; set; } = null!;
        public virtual TiposComunicacion TipoComunicacion { get; set; } = null!;
        public virtual Usuario UsuarioEnviaNavigation { get; set; } = null!;
    }

    public class CreateComunicacioneDto
    {
        [Required]
        public int InstitutoID { get; set; }
        [Required]
        public int TipoComunicacionID { get; set; }
        [Required, StringLength(200)]
        public string Titulo { get; set; } = null!;
        [Required]
        public string Contenido { get; set; } = null!;
        public DateTime? FechaEnvio { get; set; }
        [Required]
        public int UsuarioEnvia { get; set; }
        public bool? Urgente { get; set; } = false;
        public bool? RequiereConfirmacion { get; set; } = false;
        public bool? Activo { get; set; } = true;
    }

    public class UpdateComunicacioneDto
    {
        [Required]
        public int ComunicacionID { get; set; }
        [Required]
        public int InstitutoID { get; set; }
        [Required]
        public int TipoComunicacionID { get; set; }
        [Required, StringLength(200)]
        public string Titulo { get; set; } = null!;
        [Required]
        public string Contenido { get; set; } = null!;
        public DateTime? FechaEnvio { get; set; }
        [Required]
        public int UsuarioEnvia { get; set; }
        public bool? Urgente { get; set; }
        public bool? RequiereConfirmacion { get; set; }
        public bool? Activo { get; set; }
    }
}
