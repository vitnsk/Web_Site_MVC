using System.ComponentModel.DataAnnotations; // [Range], [Required], [EmailAddress]

namespace Web_Site_MVC.Models;

public class Thing
{
  [Range(1, 10)]
  public int? Id { get; set; }

  [Required]
  public string? Color { get; set; }

    [EmailAddress]
    public string? Email { get; set; }
}
