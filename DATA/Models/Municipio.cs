using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Municipio
{
    [Key]
    public int MunicipioID { get; set; }

    public int DepartamentoID { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(10)]
    public string? Codigo { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [ForeignKey("DepartamentoID")]
    [InverseProperty("Municipios")]
    public virtual Departamento Departamento { get; set; } = null!;

    [InverseProperty("Municipio")]
    public virtual ICollection<DireccionesInstituto> DireccionesInstitutos { get; set; } = new List<DireccionesInstituto>();

    [InverseProperty("Municipio")]
    public virtual ICollection<DireccionesPersona> DireccionesPersonas { get; set; } = new List<DireccionesPersona>();
}
