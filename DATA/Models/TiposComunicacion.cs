using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("TiposComunicacion")]
public partial class TiposComunicacion
{
    [Key]
    public int TipoComunicacionID { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    public string? Descripcion { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("TipoComunicacion")]
    public virtual ICollection<Comunicacione> Comunicaciones { get; set; } = new List<Comunicacione>();
}
