using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Grado
{
    [Key]
    public int GradoID { get; set; }

    public int InstitutoID { get; set; }

    public int NivelEducativoID { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(20)]
    public string? Codigo { get; set; }

    [StringLength(300)]
    public string? Descripcion { get; set; }

    public int? EdadMinimaRequerida { get; set; }

    public int? EdadMaximaRequerida { get; set; }

    public int? OrdenJerarquico { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Grado")]
    public virtual ICollection<Inscripcione> Inscripciones { get; set; } = new List<Inscripcione>();

    [ForeignKey("InstitutoID")]
    [InverseProperty("Grados")]
    public virtual Instituto Instituto { get; set; } = null!;

    [InverseProperty("Grado")]
    public virtual ICollection<MateriasGrado> MateriasGrados { get; set; } = new List<MateriasGrado>();

    [ForeignKey("NivelEducativoID")]
    [InverseProperty("Grados")]
    public virtual NivelesEducativo NivelEducativo { get; set; } = null!;
}
