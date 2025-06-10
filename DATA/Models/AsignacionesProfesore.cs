using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class AsignacionesProfesore
{
    [Key]
    public int AsignacionID { get; set; }

    public int ProfesorID { get; set; }

    public int MateriaGradoID { get; set; }

    public int AnioLectivo { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    [StringLength(20)]
    public string? EstadoAsignacion { get; set; }

    [StringLength(500)]
    public string? Observaciones { get; set; }

    public bool? Activo { get; set; }

    [InverseProperty("Asignacion")]
    public virtual ICollection<Evaluacione> Evaluaciones { get; set; } = new List<Evaluacione>();

    [InverseProperty("Asignacion")]
    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

    [ForeignKey("MateriaGradoID")]
    [InverseProperty("AsignacionesProfesores")]
    public virtual MateriasGrado MateriaGrado { get; set; } = null!;

    [ForeignKey("ProfesorID")]
    [InverseProperty("AsignacionesProfesores")]
    public virtual Profesore Profesor { get; set; } = null!;
}
