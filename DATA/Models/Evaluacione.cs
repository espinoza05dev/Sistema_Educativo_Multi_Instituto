using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Evaluacione
{
    [Key]
    public int EvaluacionID { get; set; }

    public int AsignacionID { get; set; }

    public int TipoEvaluacionID { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(300)]
    public string? Descripcion { get; set; }

    public DateOnly FechaEvaluacion { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal PuntajeMaximo { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Porcentaje { get; set; }

    [StringLength(500)]
    public string? Observaciones { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [ForeignKey("AsignacionID")]
    [InverseProperty("Evaluaciones")]
    public virtual AsignacionesProfesore Asignacion { get; set; } = null!;

    [InverseProperty("Evaluacion")]
    public virtual ICollection<Calificacione> Calificaciones { get; set; } = new List<Calificacione>();

    [ForeignKey("TipoEvaluacionID")]
    [InverseProperty("Evaluaciones")]
    public virtual TiposEvaluacion TipoEvaluacion { get; set; } = null!;
}
