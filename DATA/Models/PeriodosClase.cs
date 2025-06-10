using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("PeriodosClase")]
public partial class PeriodosClase
{
    [Key]
    public int PeriodoID { get; set; }

    public int InstitutoID { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    public TimeOnly HoraInicio { get; set; }

    public TimeOnly HoraFin { get; set; }

    public int? OrdenPeriodo { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Periodo")]
    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

    [ForeignKey("InstitutoID")]
    [InverseProperty("PeriodosClases")]
    public virtual Instituto Instituto { get; set; } = null!;
}
