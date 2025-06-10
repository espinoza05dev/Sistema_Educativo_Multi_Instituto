using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Auditorium
{
    [Key]
    public int AuditoriaID { get; set; }

    [StringLength(100)]
    public string NombreTabla { get; set; } = null!;

    [StringLength(10)]
    public string Operacion { get; set; } = null!;

    public int? UsuarioID { get; set; }

    public DateTime? FechaOperacion { get; set; }

    public string? ValoresAnteriores { get; set; }

    public string? ValoresNuevos { get; set; }

    [StringLength(45)]
    public string? DireccionIP { get; set; }

    [ForeignKey("UsuarioID")]
    [InverseProperty("Auditoria")]
    public virtual Usuario? Usuario { get; set; }
}
