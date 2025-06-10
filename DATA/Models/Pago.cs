using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Pago
{
    [Key]
    public int PagoID { get; set; }

    public int CuentaID { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal MontoPagado { get; set; }

    public DateTime? FechaPago { get; set; }

    [StringLength(20)]
    public string MetodoPago { get; set; } = null!;

    [StringLength(50)]
    public string? NumeroRecibo { get; set; }

    [StringLength(500)]
    public string? Observaciones { get; set; }

    public int UsuarioRegistro { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [ForeignKey("CuentaID")]
    [InverseProperty("Pagos")]
    public virtual CuentasPorCobrar Cuenta { get; set; } = null!;

    [ForeignKey("UsuarioRegistro")]
    [InverseProperty("Pagos")]
    public virtual Usuario UsuarioRegistroNavigation { get; set; } = null!;
}
