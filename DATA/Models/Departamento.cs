using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Departamento
{
    [Key]
    public int DepartamentoID { get; set; }

    public int PaisID { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(10)]
    public string? Codigo { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Departamento")]
    public virtual ICollection<Municipio> Municipios { get; set; } = new List<Municipio>();

    [ForeignKey("PaisID")]
    [InverseProperty("Departamentos")]
    public virtual Paise Pais { get; set; } = null!;
}
