using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Index("CodigoInstituto", Name = "UQ__Institut__5F553F53A74CB49E", IsUnique = true)]
public partial class Instituto
{
    [Key]
    public int InstitutoID { get; set; }

    public int TipoInstitutoID { get; set; }

    [StringLength(200)]
    public string Nombre { get; set; } = null!;

    [StringLength(20)]
    public string CodigoInstituto { get; set; } = null!;

    [StringLength(500)]
    public string? Descripcion { get; set; }

    [StringLength(20)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    public string? Email { get; set; }

    [StringLength(200)]
    public string? SitioWeb { get; set; }

    public byte[]? Logo { get; set; }

    public DateOnly? FechaFundacion { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaModificacion { get; set; }

    [InverseProperty("Instituto")]
    public virtual ICollection<Aula> Aulas { get; set; } = new List<Aula>();

    [InverseProperty("Instituto")]
    public virtual ICollection<Comunicacione> Comunicaciones { get; set; } = new List<Comunicacione>();

    [InverseProperty("Instituto")]
    public virtual ICollection<ConceptosPago> ConceptosPagos { get; set; } = new List<ConceptosPago>();

    [InverseProperty("Instituto")]
    public virtual ICollection<DireccionesInstituto> DireccionesInstitutos { get; set; } = new List<DireccionesInstituto>();

    [InverseProperty("Instituto")]
    public virtual ICollection<Grado> Grados { get; set; } = new List<Grado>();

    [InverseProperty("Instituto")]
    public virtual ICollection<PeriodosClase> PeriodosClases { get; set; } = new List<PeriodosClase>();

    [ForeignKey("TipoInstitutoID")]
    [InverseProperty("Institutos")]
    public virtual TiposInstituto TipoInstituto { get; set; } = null!;

    [InverseProperty("Instituto")]
    public virtual ICollection<UsuariosRole> UsuariosRoles { get; set; } = new List<UsuariosRole>();
}
