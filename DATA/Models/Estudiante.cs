using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Index("CodigoEstudiante", Name = "UQ__Estudian__C0968301CCC4D2DD", IsUnique = true)]
public partial class Estudiante
{
    [Key]
    public int EstudianteID { get; set; }

    public int PersonaID { get; set; }

    [StringLength(20)]
    public string CodigoEstudiante { get; set; } = null!;

    public DateOnly FechaIngreso { get; set; }

    [StringLength(20)]
    public string? EstadoEstudiante { get; set; }

    [StringLength(500)]
    public string? Observaciones { get; set; }

    public bool Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Estudiante")]
    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    [InverseProperty("Estudiante")]
    public virtual ICollection<CuentasPorCobrar> CuentasPorCobrars { get; set; } = new List<CuentasPorCobrar>();

    [InverseProperty("Estudiante")]
    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    [ForeignKey("PersonaID")]
    [InverseProperty("Estudiantes")]
    public virtual Persona Persona { get; set; } = null!;
}
