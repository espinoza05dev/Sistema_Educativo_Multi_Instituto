using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DATA.Models;

[Table("Diassemana")]
public partial class Diassemana
{
    [Key]
    public int DiaSemanaID { get; set; }

    [StringLength(20)]
    public string Nombre { get; set; } = null!;

    [StringLength(3)]
    public string Abreviatura { get; set; } = null!;

    [InverseProperty("DiaSemana")]
    public virtual ICollection<Horario> Horarios { get; set; } = new List<Horario>();
}
