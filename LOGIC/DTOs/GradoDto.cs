using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class GradoDto
    {
        public int GradoID { get; set; }
        public int InstitutoID { get; set; }
        public int NivelEducativoID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Codigo { get; set; }
        public string? Descripcion { get; set; }
        public int? EdadMinimaRequerida { get; set; }
        public int? EdadMaximaRequerida { get; set; }
        public int? OrdenJerarquico { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual Instituto Instituto { get; set; } = null!;
        public virtual NivelesEducativo NivelEducativo { get; set; } = null!;
    }

    public class CreateGradoDto
    {
        [Required]
        public int InstitutoID { get; set; }
        [Required]
        public int NivelEducativoID { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;
        [StringLength(20)]
        public string? Codigo { get; set; }
        [StringLength(300)]
        public string? Descripcion { get; set; }
        [Range(3, 25)]
        public int? EdadMinimaRequerida { get; set; }
        [Range(3, 30)]
        public int? EdadMaximaRequerida { get; set; }
        public int? OrdenJerarquico { get; set; }
        public bool? Activo { get; set; } = true;
    }

    public class UpdateGradoDto
    {
        [Required]
        public int GradoID { get; set; }
        [Required]
        public int InstitutoID { get; set; }
        [Required]
        public int NivelEducativoID { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;
        [StringLength(20)]
        public string? Codigo { get; set; }
        [StringLength(300)]
        public string? Descripcion { get; set; }
        [Range(3, 25)]
        public int? EdadMinimaRequerida { get; set; }
        [Range(3, 30)]
        public int? EdadMaximaRequerida { get; set; }
        public int? OrdenJerarquico { get; set; }
        public bool? Activo { get; set; }
    }
}
