using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CampingApp.DataTransferObjects.requests;
using CampingApp.DataTransferObjects.responses;
using CampingApp.Entities;
using CampingApp.Infrastructure.Repositories;
using CampingApp.Services.extensions;

namespace CampingApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<ProductDisplayResponseDto> GetProductDisplayResponses()
        {
            var products = _repository.GetAll();
            return products.ConvertToDisplayResponseDto<ProductDisplayResponseDto>(_mapper);
        }

        public IEnumerable<ProductDisplayResponseDto> GetProductByCategory(int categoryId)
        {
            var product = _repository.GetProductsByCategory(categoryId);
            return product.ConvertToDisplayResponseDto<ProductDisplayResponseDto>(_mapper);
        }

        public ProductDisplayResponseDto GetProduct(int id)
        {
            var product = _repository.Get(id);
            return _mapper.Map<ProductDisplayResponseDto>(product);
        }

        public async Task<UpdateProductRequestDto> GetProductForUpdateAsync(int id)
        {
            var product = await _repository.GetAsync(id);
            return _mapper.Map<UpdateProductRequestDto>(product);
        }

        public async Task UpdateProductAsync(UpdateProductRequestDto updateProductRequest)
        {
            var prodcut = _mapper.Map<Product>(updateProductRequest);
            await _repository.UpdateAsync(prodcut);
        }


        public async Task CreateProductAsync(CreateNewProductRequestDto createNewProductRequestDto)
        {
            var product = _mapper.Map<Product>(createNewProductRequestDto);
            await _repository.InsertAsync(product);
        }

        public async Task<Product> GetProductByIdAsync(int id) => (await _repository.GetAsync(id))!;
        public async Task DeleteProductAsync(Product product)
        {
            var deletingProduct = await _repository.GetAsync(product.ProductID);
            await _repository.DeleteAsync(deletingProduct);
        }
    }
}
