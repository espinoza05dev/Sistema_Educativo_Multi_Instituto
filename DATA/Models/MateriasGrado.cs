using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class MateriasGrado
{
    [Key]
    public int MateriaGradoID { get; set; }

    public int GradoID { get; set; }

    public int MateriaID { get; set; }

    public bool? EsObligatoria { get; set; }

    public int? OrdenEnPensum { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("MateriaGrado")]
    public virtual ICollection<AsignacionesProfesore> AsignacionesProfesores { get; set; } = new List<AsignacionesProfesore>();

    [ForeignKey("GradoID")]
    [InverseProperty("MateriasGrados")]
    public virtual Grado Grado { get; set; } = null!;

    [ForeignKey("MateriaID")]
    [InverseProperty("MateriasGrados")]
    public virtual Materia Materia { get; set; } = null!;
}
