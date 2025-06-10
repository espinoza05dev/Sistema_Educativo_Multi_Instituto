using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Paise
{
    [Key]
    public int PaisID { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string CodigoISO { get; set; } = null!;

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Pais")]
    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();
}
