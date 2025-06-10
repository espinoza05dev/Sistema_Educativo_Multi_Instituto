using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("TiposEvaluacion")]
public partial class TiposEvaluacion
{
    [Key]
    public int TipoEvaluacionID { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal? PorcentajeMaximo { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("TipoEvaluacion")]
    public virtual ICollection<Evaluacione> Evaluaciones { get; set; } = new List<Evaluacione>();
}
