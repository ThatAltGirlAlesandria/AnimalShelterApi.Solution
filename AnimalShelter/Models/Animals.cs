using System.ComponentModel.DataAnnotations;

namespace AnimalShelterApi.Models
{
  public class Animals
  {
    public int AnimalId { get; set; }
    [Required]
    [StringLength(255, ErrorMessage = "This animal must have a name.")]
    public string AnimalName { get; set; }
    [Required]
    [StringLength(255, ErrorMessage = "This animal must have a description." )]
    public string AnimalDescription { get; set; }
    [Required]
    [StringLength(250, ErrorMessage = "This animal must have a type.")]
    public string AnimalType { get; set; }
    [Required]
    [StringLength(255, ErrorMessage = "You must put if the animal is female or male.")]
    public string MaleFemale { get; set; }
    [Required]
    [Range(0, 255, ErrorMessage = "Age must be between 0 and 80.")]
    public string AnimalAge { get; set; }
    public DateTime Date { get; set; }
  }
}