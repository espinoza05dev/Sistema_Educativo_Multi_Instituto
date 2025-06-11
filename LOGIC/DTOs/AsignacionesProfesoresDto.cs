using DATA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.DTOs
{
    public class AsignacionesProfesoresDto
    {
        public int AsignacionID { get; set; }

        public int ProfesorID { get; set; }

        public int MateriaGradoID { get; set; }

        public int AnioLectivo { get; set; }

        public DateTime? FechaAsignacion { get; set; }

        public string? EstadoAsignacion { get; set; }

        public string? Observaciones { get; set; }

        public bool? Activo { get; set; }

        public virtual ICollection<Evaluacione> Evaluaciones { get; set; } = new List<Evaluacione>();

        public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

        public virtual MateriasGrado MateriaGrado { get; set; } = null!;

        public virtual Profesore Profesor { get; set; } = null!;
    }

    public class CreateAsignacionProfesoresDto
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "ProfesorID debe ser mayor que 0")]
        public int ProfesorID { get; set; }
        [Required]
        public int MateriaGradoID { get; set; }

        [Required]
        [Range(1900, 2100, ErrorMessage = "El año lectivo debe estar entre 1900 y 2100.")]
        public int AnioLectivo { get; set; }
        [DataType(DataType.Date)]
        public DateTime? FechaAsignacion { get; set; } = DateTime.Now;
        [StringLength(20)]
        public string? EstadoAsignacion { get; set; } = "Activa";
        [StringLength(500)]
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; } = true;
    }

    public class UpdateAsignacionProfesoresDto
    {
        [Required]
        public int AsignacionID { get; set; }
        [Required]
        public int ProfesorID { get; set; }
        [Required]
        public int MateriaGradoID { get; set; }
        [Required]
        public int AnioLectivo { get; set; }
        public DateTime? FechaAsignacion { get; set; }
        [StringLength(20)]
        public string? EstadoAsignacion { get; set; }
        [StringLength(500)]
        public string? Observaciones { get; set; }
        public bool? Activo { get; set; }
    }

}
