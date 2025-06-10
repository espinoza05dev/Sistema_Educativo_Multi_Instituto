using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("CuentasPorCobrar")]
public partial class CuentasPorCobrar
{
    [Key]
    public int CuentaID { get; set; }

    public int EstudianteID { get; set; }

    public int ConceptoID { get; set; }

    public int AnioLectivo { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal MontoOriginal { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? MontoDescuento { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal MontoTotal { get; set; }

    public DateOnly FechaVencimiento { get; set; }

    [StringLength(20)]
    public string? Estado { get; set; }

    [StringLength(500)]
    public string? Observaciones { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [ForeignKey("ConceptoID")]
    [InverseProperty("CuentasPorCobrars")]
    public virtual ConceptosPago Concepto { get; set; } = null!;

    [ForeignKey("EstudianteID")]
    [InverseProperty("CuentasPorCobrars")]
    public virtual Estudiante Estudiante { get; set; } = null!;

    [InverseProperty("Cuenta")]
    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();
}
