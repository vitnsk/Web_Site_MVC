namespace Web_Site_MVC.Models;

public record HomeModelBindingViewModel
(
  Thing Thing, 
  bool HasErrors,
  IEnumerable<string> ValidationErrors
);