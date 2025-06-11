using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class TipoEvaluacionDto
    {
        public int TipoEvaluacionID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal? PorcentajeMaximo { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public int? TotalEvaluaciones { get; set; }
    }

    public class TipoEvaluacionCreateDto
    {
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        [StringLength(200)]
        public string? Descripcion { get; set; }

        [Range(0.01, 100.00)]
        public decimal? PorcentajeMaximo { get; set; }

        public bool? Activo { get; set; } = true;
    }
}
