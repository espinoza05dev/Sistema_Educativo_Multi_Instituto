using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class UsuariosRole
{
    [Key]
    public int UsuarioRolID { get; set; }

    public int UsuarioID { get; set; }

    public int RolID { get; set; }

    public int InstitutoID { get; set; }

    public DateTime? FechaAsignacion { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public bool? Activo { get; set; }

    [ForeignKey("InstitutoID")]
    [InverseProperty("UsuariosRoles")]
    public virtual Instituto Instituto { get; set; } = null!;

    [ForeignKey("RolID")]
    [InverseProperty("UsuariosRoles")]
    public virtual RolesUsuario Rol { get; set; } = null!;

    [ForeignKey("UsuarioID")]
    [InverseProperty("UsuariosRoles")]
    public virtual Usuario Usuario { get; set; } = null!;
}
