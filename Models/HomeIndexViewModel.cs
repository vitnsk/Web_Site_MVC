
using Pact.Shared; // Category, Product

namespace Web_Site_MVC.Models
{
    public record HomeIndexViewModel
(
  int VisitorCount,
  IList<Category> Categories,
  IList<Product> Products
);
}
