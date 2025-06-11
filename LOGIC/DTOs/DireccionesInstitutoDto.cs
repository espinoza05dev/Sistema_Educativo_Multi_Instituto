using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class DireccionesInstitutoDto
    {
        public int DireccionID { get; set; }
        public int InstitutoID { get; set; }
        public int MunicipioID { get; set; }
        public string DireccionCompleta { get; set; } = null!;
        public string? CodigoPostal { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public bool? EsDireccionPrincipal { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual Instituto Instituto { get; set; } = null!;
        public virtual Municipio Municipio { get; set; } = null!;
    }

    public class CreateDireccionesInstitutoDto
    {
        [Required]
        public int InstitutoID { get; set; }
        [Required]
        public int MunicipioID { get; set; }
        [Required, StringLength(300)]
        public string DireccionCompleta { get; set; } = null!;
        [StringLength(10)]
        public string? CodigoPostal { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public bool? EsDireccionPrincipal { get; set; } = false;
        public bool? Activo { get; set; } = true;
    }

    public class UpdateDireccionesInstitutoDto
    {
        [Required]
        public int DireccionID { get; set; }
        [Required]
        public int InstitutoID { get; set; }
        [Required]
        public int MunicipioID { get; set; }
        [Required, StringLength(300)]
        public string DireccionCompleta { get; set; } = null!;
        [StringLength(10)]
        public string? CodigoPostal { get; set; }
        public decimal? Latitud { get; set; }
        public decimal? Longitud { get; set; }
        public bool? EsDireccionPrincipal { get; set; }
        public bool? Activo { get; set; }
    }

}
