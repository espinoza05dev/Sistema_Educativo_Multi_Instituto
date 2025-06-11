using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class DireccionesPersonaDto
    {
        public int DireccionPersonaID { get; set; }
        public int PersonaID { get; set; }
        public int MunicipioID { get; set; }
        public string DireccionCompleta { get; set; } = null!;
        public string? CodigoPostal { get; set; }
        public string? TipoDireccion { get; set; }
        public bool? EsDireccionPrincipal { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual Municipio Municipio { get; set; } = null!;
        public virtual Persona Persona { get; set; } = null!;
    }

    public class CreateDireccionesPersonaDto
    {
        [Required]
        public int PersonaID { get; set; }
        [Required]
        public int MunicipioID { get; set; }
        [Required, StringLength(300)]
        public string DireccionCompleta { get; set; } = null!;
        [StringLength(10)]
        public string? CodigoPostal { get; set; }
        [StringLength(20)]
        public string? TipoDireccion { get; set; }
        public bool? EsDireccionPrincipal { get; set; } = false;
        public bool? Activo { get; set; } = true;
    }

    public class UpdateDireccionesPersonaDto
    {
        [Required]
        public int DireccionPersonaID { get; set; }
        [Required]
        public int PersonaID { get; set; }
        [Required]
        public int MunicipioID { get; set; }
        [Required, StringLength(300)]
        public string DireccionCompleta { get; set; } = null!;
        [StringLength(10)]
        public string? CodigoPostal { get; set; }
        [StringLength(20)]
        public string? TipoDireccion { get; set; }
        public bool? EsDireccionPrincipal { get; set; }
        public bool? Activo { get; set; }
    }
}
