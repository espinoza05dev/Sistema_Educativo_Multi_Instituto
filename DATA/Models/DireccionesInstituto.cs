using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class DireccionesInstituto
{
    [Key]
    public int DireccionID { get; set; }

    public int InstitutoID { get; set; }

    public int MunicipioID { get; set; }

    [StringLength(300)]
    public string DireccionCompleta { get; set; } = null!;

    [StringLength(10)]
    public string? CodigoPostal { get; set; }

    [Column(TypeName = "decimal(10, 8)")]
    public decimal? Latitud { get; set; }

    [Column(TypeName = "decimal(11, 8)")]
    public decimal? Longitud { get; set; }

    public bool? EsDireccionPrincipal { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [ForeignKey("InstitutoID")]
    [InverseProperty("DireccionesInstitutos")]
    public virtual Instituto Instituto { get; set; } = null!;

    [ForeignKey("MunicipioID")]
    [InverseProperty("DireccionesInstitutos")]
    public virtual Municipio Municipio { get; set; } = null!;
}
