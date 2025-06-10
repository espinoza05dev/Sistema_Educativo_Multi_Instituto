using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("TiposDocumento")]
public partial class TiposDocumento
{
    [Key]
    public int TipoDocumentoID { get; set; }

    [StringLength(50)]
    public string Nombre { get; set; } = null!;

    [StringLength(10)]
    public string? Codigo { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("TipoDocumento")]
    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
