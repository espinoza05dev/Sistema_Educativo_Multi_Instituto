using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("TiposInstituto")]
public partial class TiposInstituto
{
    [Key]
    public int TipoInstitutoID { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(200)]
    public string? Descripcion { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("TipoInstituto")]
    public virtual ICollection<Instituto> Institutos { get; set; } = new List<Instituto>();
}
