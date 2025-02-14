using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.web.Domain.Entities;
[Table("Personas")]
public class Persona
{
    [Key]
    public int Id { get; set; }
    public string Nombre { get; set; } = null!;
    public DateTime? FechaDeNacimiento { get; set; }
}
