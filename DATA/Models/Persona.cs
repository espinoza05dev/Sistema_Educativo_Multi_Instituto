using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Index("EmailPrincipal", Name = "IX_Personas_Email")]
[Index("NumeroDocumento", Name = "IX_Personas_NumeroDocumento")]
public partial class Persona
{
    [Key]
    public int PersonaID { get; set; }

    public int TipoDocumentoID { get; set; }

    [StringLength(50)]
    public string NumeroDocumento { get; set; } = null!;

    [StringLength(50)]
    public string PrimerNombre { get; set; } = null!;

    [StringLength(50)]
    public string? SegundoNombre { get; set; }

    [StringLength(50)]
    public string PrimerApellido { get; set; } = null!;

    [StringLength(50)]
    public string? SegundoApellido { get; set; }

    public DateOnly FechaNacimiento { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Genero { get; set; }

    [StringLength(20)]
    public string? EstadoCivil { get; set; }

    [StringLength(20)]
    public string? TelefonoPrincipal { get; set; }

    [StringLength(20)]
    public string? TelefonoSecundario { get; set; }

    [StringLength(100)]
    public string? EmailPrincipal { get; set; }

    [StringLength(100)]
    public string? EmailSecundario { get; set; }

    public byte[]? Foto { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    [InverseProperty("Persona")]
    public virtual ICollection<DestinatariosComunicacion> DestinatariosComunicacions { get; set; } = new List<DestinatariosComunicacion>();

    [InverseProperty("Persona")]
    public virtual ICollection<DireccionesPersona> DireccionesPersonas { get; set; } = new List<DireccionesPersona>();

    [InverseProperty("Persona")]
    public virtual ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    [InverseProperty("Persona")]
    public virtual ICollection<Profesore> Profesores { get; set; } = new List<Profesore>();

    [ForeignKey("TipoDocumentoID")]
    [InverseProperty("Personas")]
    public virtual TiposDocumento TipoDocumento { get; set; } = null!;

    [InverseProperty("Persona")]
    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
