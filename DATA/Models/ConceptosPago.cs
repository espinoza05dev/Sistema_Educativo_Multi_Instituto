using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("ConceptosPago")]
public partial class ConceptosPago
{
    [Key]
    public int ConceptoID { get; set; }

    public int InstitutoID { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(300)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Monto { get; set; }

    [StringLength(20)]
    public string TipoConcepto { get; set; } = null!;

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Concepto")]
    public virtual ICollection<CuentasPorCobrar> CuentasPorCobrars { get; set; } = new List<CuentasPorCobrar>();

    [ForeignKey("InstitutoID")]
    [InverseProperty("ConceptosPagos")]
    public virtual Instituto Instituto { get; set; } = null!;
}
