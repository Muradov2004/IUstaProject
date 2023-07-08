using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace IUstaProject;

public class Expert
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(int.MaxValue)]
    public string PhotoPath { get; set; }
    [Required]
    [StringLength(15)]
    public string Name { get; set; }
    [Required]
    [StringLength(15)]
    public string Surname { get; set; }
    [Required]
    [StringLength(100)]
    public string Email { get; set; }
    [Required]
    [StringLength(100)]
    public string Password { get; set; }
    [Required]
    [ForeignKey("CategoryName")]
    public string CategoryName { get; set; }
    public override string ToString() => $@"
Photo: {PhotoPath}
Name: {Name}
Surname: {Surname}
Email: {Email}
Password: {Password}
Category: {CategoryName}";
}

