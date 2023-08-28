using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
  public class Animal
  {
    [Required]
    [Range(0, 10000, ErrorMessage = "Cannot be blank.")]
    public int AnimalId { get; set; }
    [Required]
    [StringLength(250, ErrorMessage = "Cannot be blank.")]
    public string AnimalName { get; set; }
    [Required]
    [StringLength(250, ErrorMessage = "Cannot be blank.")]
    public string AnimalDescription { get; set; }
    [Required]
    [StringLength(250, ErrorMessage = "Cannot be blank.")]
    public string AnimalType { get; set; }
    [Required]
    [StringLength(250, ErrorMessage = "Cannot be blank.")]
    public string MaleFemale { get; set; }
    [Required]
    [Range(0, 507, ErrorMessage = "Age must be between 0 and 507.")]
    public int AnimalAge { get; set; }
  }
}