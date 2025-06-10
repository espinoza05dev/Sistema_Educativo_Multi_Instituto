using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Inscripcione
{
    [Key]
    public int InscripcionID { get; set; }

    public int EstudianteID { get; set; }

    public int GradoID { get; set; }

    public int AnioLectivo { get; set; }

    public DateTime? FechaInscripcion { get; set; }

    [StringLength(20)]
    public string? EstadoInscripcion { get; set; }

    [StringLength(500)]
    public string? Observaciones { get; set; }

    public bool? Activo { get; set; }

    [ForeignKey("EstudianteID")]
    [InverseProperty("Inscripciones")]
    public virtual Estudiante Estudiante { get; set; } = null!;

    [ForeignKey("GradoID")]
    [InverseProperty("Inscripciones")]
    public virtual Grado Grado { get; set; } = null!;
}
