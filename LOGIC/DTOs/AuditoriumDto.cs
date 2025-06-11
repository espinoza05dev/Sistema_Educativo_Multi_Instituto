using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class AuditoriumDto
    {
        public int AuditoriaID { get; set; }
        public string NombreTabla { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public int? UsuarioID { get; set; }
        public DateTime? FechaOperacion { get; set; }
        public string? ValoresAnteriores { get; set; }
        public string? ValoresNuevos { get; set; }
        public string? DireccionIP { get; set; }
        public virtual Usuario? Usuario { get; set; }
    }

    public class CreateAuditoriumDto
    {
        [Required, StringLength(100)]
        public string NombreTabla { get; set; } = null!;
        [Required, StringLength(10)]
        public string Operacion { get; set; } = null!;
        public int? UsuarioID { get; set; }
        public DateTime? FechaOperacion { get; set; } = DateTime.Now;
        public string? ValoresAnteriores { get; set; }
        public string? ValoresNuevos { get; set; }
        [StringLength(45)]
        public string? DireccionIP { get; set; }
    }
}
