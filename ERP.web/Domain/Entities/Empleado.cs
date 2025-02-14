﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.web.Domain.Entities;

[Table("Empleados")]
public class Empleado
{
    [Key]
    public int Id { get; set; }
    public int PersonaId { get; set;  }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Sueldo { get; set; }
    [ForeignKey(nameof(PersonaId))]
    public virtual Persona DatosPersonales { get; set; } = null!;
}
