using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class DiassemanaDto
    {
        public int DiaSemanaID { get; set; }
        public string Nombre { get; set; } = null!;
        public string Abreviatura { get; set; } = null!;
    }

    public class CreateDiassemanaDto
    {
        [Required, StringLength(20)]
        public string Nombre { get; set; } = null!;
        [Required, StringLength(3)]
        public string Abreviatura { get; set; } = null!;
    }

    public class UpdateDiassemanaDto
    {
        [Required]
        public int DiaSemanaID { get; set; }
        [Required, StringLength(20)]
        public string Nombre { get; set; } = null!;
        [Required, StringLength(3)]
        public string Abreviatura { get; set; } = null!;
    }

}
