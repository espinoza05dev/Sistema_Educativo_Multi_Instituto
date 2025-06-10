using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Calificacione
{
    [Key]
    public int CalificacionID { get; set; }

    public int EvaluacionID { get; set; }

    public int EstudianteID { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal PuntajeObtenido { get; set; }

    [StringLength(5)]
    public string? NotaLiteral { get; set; }

    [StringLength(500)]
    public string? Observaciones { get; set; }

    public DateTime? FechaCalificacion { get; set; }

    public bool? Activo { get; set; }

    [ForeignKey("EstudianteID")]
    [InverseProperty("Calificaciones")]
    public virtual Estudiante Estudiante { get; set; } = null!;

    [ForeignKey("EvaluacionID")]
    [InverseProperty("Calificaciones")]
    public virtual Evaluacione Evaluacion { get; set; } = null!;
}
