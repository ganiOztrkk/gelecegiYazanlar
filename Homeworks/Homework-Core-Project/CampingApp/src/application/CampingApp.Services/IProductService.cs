using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp.DataTransferObjects.requests;
using CampingApp.DataTransferObjects.responses;
using CampingApp.Entities;

namespace CampingApp.Services
{
    public interface IProductService
    {
        IEnumerable<ProductDisplayResponseDto> GetProductDisplayResponses();
        IEnumerable<ProductDisplayResponseDto> GetProductByCategory(int categoryId);
        ProductDisplayResponseDto GetProduct(int id);
        Task CreateProductAsync(CreateNewProductRequestDto createNewProductRequestDto);

        Task DeleteProductAsync(Product product);
        Task<Product> GetProductByIdAsync(int id);
        Task<UpdateProductRequestDto> GetProductForUpdateAsync(int id);
        Task UpdateProductAsync(UpdateProductRequestDto updateProductRequest);
    }
}
