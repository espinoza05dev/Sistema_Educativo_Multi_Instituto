using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class DireccionesPersona
{
    [Key]
    public int DireccionPersonaID { get; set; }

    public int PersonaID { get; set; }

    public int MunicipioID { get; set; }

    [StringLength(300)]
    public string DireccionCompleta { get; set; } = null!;

    [StringLength(10)]
    public string? CodigoPostal { get; set; }

    [StringLength(20)]
    public string? TipoDireccion { get; set; }

    public bool? EsDireccionPrincipal { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [ForeignKey("MunicipioID")]
    [InverseProperty("DireccionesPersonas")]
    public virtual Municipio Municipio { get; set; } = null!;

    [ForeignKey("PersonaID")]
    [InverseProperty("DireccionesPersonas")]
    public virtual Persona Persona { get; set; } = null!;
}
