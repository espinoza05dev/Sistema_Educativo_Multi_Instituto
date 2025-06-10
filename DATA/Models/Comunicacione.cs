using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Comunicacione
{
    [Key]
    public int ComunicacionID { get; set; }

    public int InstitutoID { get; set; }

    public int TipoComunicacionID { get; set; }

    [StringLength(200)]
    public string Titulo { get; set; } = null!;

    public string Contenido { get; set; } = null!;

    public DateTime? FechaEnvio { get; set; }

    public int UsuarioEnvia { get; set; }

    public bool? Urgente { get; set; }

    public bool? RequiereConfirmacion { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Comunicacion")]
    public virtual ICollection<DestinatariosComunicacion> DestinatariosComunicacions { get; set; } = new List<DestinatariosComunicacion>();

    [ForeignKey("InstitutoID")]
    [InverseProperty("Comunicaciones")]
    public virtual Instituto Instituto { get; set; } = null!;

    [ForeignKey("TipoComunicacionID")]
    [InverseProperty("Comunicaciones")]
    public virtual TiposComunicacion TipoComunicacion { get; set; } = null!;

    [ForeignKey("UsuarioEnvia")]
    [InverseProperty("Comunicaciones")]
    public virtual Usuario UsuarioEnviaNavigation { get; set; } = null!;
}
