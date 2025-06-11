using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class DestinatariosComunicacionDto
    {
        public int DestinatarioID { get; set; }
        public int ComunicacionID { get; set; }
        public int PersonaID { get; set; }
        public DateTime? FechaLectura { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public bool? Activo { get; set; }
        public virtual Comunicacione Comunicacion { get; set; } = null!;
        public virtual Persona Persona { get; set; } = null!;
    }

    public class CreateDestinatariosComunicacionDto
    {
        [Required]
        public int ComunicacionID { get; set; }
        [Required]
        public int PersonaID { get; set; }
        public DateTime? FechaLectura { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public bool? Activo { get; set; } = true;
    }

    public class UpdateDestinatariosComunicacionDto
    {
        [Required]
        public int DestinatarioID { get; set; }
        [Required]
        public int ComunicacionID { get; set; }
        [Required]
        public int PersonaID { get; set; }
        public DateTime? FechaLectura { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public bool? Activo { get; set; }
    }

}
