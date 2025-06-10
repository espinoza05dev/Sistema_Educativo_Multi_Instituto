using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("DestinatariosComunicacion")]
public partial class DestinatariosComunicacion
{
    [Key]
    public int DestinatarioID { get; set; }

    public int ComunicacionID { get; set; }

    public int PersonaID { get; set; }

    public DateTime? FechaLectura { get; set; }

    public DateTime? FechaConfirmacion { get; set; }

    public bool? Activo { get; set; }

    [ForeignKey("ComunicacionID")]
    [InverseProperty("DestinatariosComunicacions")]
    public virtual Comunicacione Comunicacion { get; set; } = null!;

    [ForeignKey("PersonaID")]
    [InverseProperty("DestinatariosComunicacions")]
    public virtual Persona Persona { get; set; } = null!;
}
