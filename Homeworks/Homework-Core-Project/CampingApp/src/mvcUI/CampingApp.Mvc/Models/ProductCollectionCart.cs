using CampingApp.Entities;

namespace CampingApp.Mvc.Models
{
    public class ProductCollectionCart
    {
        public List<ProductItem> ProductItems { get; set; } = new List<ProductItem>();
        public void ClearCart() => ProductItems.Clear();
        public decimal TotalCartPrice() => ProductItems.Sum(item => item.Product.ProductPrice * item.Quantity);
        public void AddNewProduct(ProductItem productItem)
        {
            var exist = ProductItems.FirstOrDefault(_ => _.Product.ProductID == productItem.Product.ProductID);
            if (exist != null)
            {
                exist.Quantity += productItem.Quantity;
            }
            else
            {
                ProductItems.Add(productItem);
            }
        }
    }
}
