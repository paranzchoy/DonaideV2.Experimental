using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DonaideV2.Experimental.Domain;

[Table("Persons")]
public class Person
{
    [Key]
    public int PersonId { get; set; }

    [Required]
    [StringLength(255)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(255)]
    public string LastName { get; set; } = string.Empty;
}
