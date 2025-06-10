using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Horario
{
    [Key]
    public int HorarioID { get; set; }

    public int AsignacionID { get; set; }

    public int DiaSemanaID { get; set; }

    public int PeriodoID { get; set; }

    public int? AulaID { get; set; }

    public int AnioLectivo { get; set; }

    public DateOnly FechaInicio { get; set; }

    public DateOnly FechaFin { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [ForeignKey("AsignacionID")]
    [InverseProperty("Horarios")]
    public virtual AsignacionesProfesore Asignacion { get; set; } = null!;

    [ForeignKey("AulaID")]
    [InverseProperty("Horarios")]
    public virtual Aula? Aula { get; set; }

    [ForeignKey("DiaSemanaID")]
    [InverseProperty("Horarios")]
    public virtual Diassemana DiaSemana { get; set; } = null!;

    [ForeignKey("PeriodoID")]
    [InverseProperty("Horarios")]
    public virtual PeriodosClase Periodo { get; set; } = null!;
}
