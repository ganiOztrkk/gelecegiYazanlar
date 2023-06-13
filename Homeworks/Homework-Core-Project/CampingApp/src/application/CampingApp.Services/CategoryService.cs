using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CampingApp.DataTransferObjects.responses;
using CampingApp.Infrastructure.Repositories;
using CampingApp.Services.extensions;

namespace CampingApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<CategoryDisplayResponseDto> GetCategoryDisplayResponses()
        {
            var categories = _repository.GetAll();
            return categories.ConvertToDisplayResponseDto<CategoryDisplayResponseDto>(_mapper);
        }
    }
}
