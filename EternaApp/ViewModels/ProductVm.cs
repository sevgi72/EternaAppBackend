using EternaApp.Models;

namespace EternaApp.ViewModels
{
    public class ProductVm
    {
        public List<Product> Product { get; set; } = null!;
        public List<Categories> Categories { get; set; } = null!;
    }
}
