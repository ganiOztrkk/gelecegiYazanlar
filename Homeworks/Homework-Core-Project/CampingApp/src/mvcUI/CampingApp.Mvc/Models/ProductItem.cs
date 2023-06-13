using CampingApp.DataTransferObjects.responses;

namespace CampingApp.Mvc.Models;

public class ProductItem // sepete eklenecek ürünü tuttuğumuz model
{
    public ProductDisplayResponseDto Product { get; set; } // eklenecek ürünün kendisi
    public int Quantity { get; set; } // adedi
}