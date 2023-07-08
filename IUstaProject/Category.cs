using System.ComponentModel.DataAnnotations;

namespace IUstaProject;

public class Category
{
    [Key]
    [StringLength(15)]
    public string Name { get; set; }
}
