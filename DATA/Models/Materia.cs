using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

public partial class Materia
{
    [Key]
    public int MateriaID { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; } = null!;

    [StringLength(20)]
    public string? Codigo { get; set; }

    [StringLength(300)]
    public string? Descripcion { get; set; }

    public int? CreditosAcademicos { get; set; }

    public int? HorasSemanales { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaCreacion { get; set; }

    [InverseProperty("Materia")]
    public virtual ICollection<MateriasGrado> MateriasGrados { get; set; } = new List<MateriasGrado>();
}
