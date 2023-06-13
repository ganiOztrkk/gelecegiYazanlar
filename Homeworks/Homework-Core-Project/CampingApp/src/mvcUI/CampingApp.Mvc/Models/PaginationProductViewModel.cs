using CampingApp.DataTransferObjects.responses;

namespace CampingApp.Mvc.Models
{
    public class PaginationProductViewModel
    {
        public IEnumerable<ProductDisplayResponseDto> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
