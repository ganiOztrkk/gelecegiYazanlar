using CampingApp.DataTransferObjects.responses;

namespace CampingApp.Services;

public interface ICategoryService
{
    IEnumerable<CategoryDisplayResponseDto> GetCategoryDisplayResponses();
}