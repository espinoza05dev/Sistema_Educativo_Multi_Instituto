using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Index("NombreUsuario", Name = "UQ__Usuarios__6B0F5AE0F416C53C", IsUnique = true)]
public partial class Usuario
{
    [Key]
    public int UsuarioID { get; set; }

    public int PersonaID { get; set; }

    [StringLength(50)]
    public string NombreUsuario { get; set; } = null!;

    [StringLength(255)]
    public string PasswordHash { get; set; } = null!;

    [StringLength(255)]
    public string Salt { get; set; } = null!;

    public DateTime? UltimoAcceso { get; set; }

    public int? IntentosLogin { get; set; }

    public bool? Bloqueado { get; set; }

    public DateTime? FechaVencimientoPassword { get; set; }

    public bool? RequiereCambioPassword { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    [InverseProperty("Usuario")]
    public virtual ICollection<Auditorium> Auditoria { get; set; } = new List<Auditorium>();

    [InverseProperty("UsuarioEnviaNavigation")]
    public virtual ICollection<Comunicacione> Comunicaciones { get; set; } = new List<Comunicacione>();

    [InverseProperty("UsuarioRegistroNavigation")]
    public virtual ICollection<Pago> Pagos { get; set; } = new List<Pago>();

    [ForeignKey("PersonaID")]
    [InverseProperty("Usuarios")]
    public virtual Persona Persona { get; set; } = null!;

    [InverseProperty("Usuario")]
    public virtual ICollection<UsuariosRole> UsuariosRoles { get; set; } = new List<UsuariosRole>();
}
