using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Aula
{
    [Key]
    public int AulaID { get; set; }

    public int InstitutoID { get; set; }

    public int TipoAulaID { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(20)]
    public string? Codigo { get; set; }

    public int? Capacidad { get; set; }

    public int? Piso { get; set; }

    [StringLength(50)]
    public string? Edificio { get; set; }

    [StringLength(500)]
    public string? Equipamiento { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Aula")]
    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();

    [ForeignKey("InstitutoID")]
    [InverseProperty("Aulas")]
    public virtual Instituto Instituto { get; set; } = null!;

    [ForeignKey("TipoAulaID")]
    [InverseProperty("Aulas")]
    public virtual TiposAula TipoAula { get; set; } = null!;
}
