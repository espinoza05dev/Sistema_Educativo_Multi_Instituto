using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Index("CodigoProfesor", Name = "UQ__Profesor__A54169A0F98C52CE", IsUnique = true)]
public partial class Profesore
{
    [Key]
    public int ProfesorID { get; set; }

    public int PersonaID { get; set; }

    [StringLength(20)]
    public string CodigoProfesor { get; set; } = null!;

    public DateOnly FechaIngreso { get; set; }

    [StringLength(100)]
    public string? TituloAcademico { get; set; }

    [StringLength(100)]
    public string? Especialidad { get; set; }

    public int? AniosExperiencia { get; set; }

    [StringLength(20)]
    public string? EstadoProfesor { get; set; }

    [StringLength(500)]
    public string? Observaciones { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Profesor")]
    public virtual ICollection<AsignacionesProfesore> AsignacionesProfesores { get; set; } = new List<AsignacionesProfesore>();

    [ForeignKey("PersonaID")]
    [InverseProperty("Profesores")]
    public virtual Persona Persona { get; set; } = null!;
}
