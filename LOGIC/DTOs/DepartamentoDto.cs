using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class DepartamentoDto
    {
        public int DepartamentoID { get; set; }
        public int PaisID { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Codigo { get; set; }
        public bool? Activo { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public virtual Paise Pais { get; set; } = null!;
    }

    public class CreateDepartamentoDto
    {
        [Required]
        public int PaisID { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;
        [StringLength(10)]
        public string? Codigo { get; set; }
        public bool? Activo { get; set; } = true;
    }

    public class UpdateDepartamentoDto
    {
        [Required]
        public int DepartamentoID { get; set; }
        [Required]
        public int PaisID { get; set; }
        [Required, StringLength(100)]
        public string Nombre { get; set; } = null!;
        [StringLength(10)]
        public string? Codigo { get; set; }
        public bool? Activo { get; set; }
    }

}
