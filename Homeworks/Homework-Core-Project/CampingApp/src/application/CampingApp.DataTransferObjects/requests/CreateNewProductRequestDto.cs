using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp.DataTransferObjects.requests
{
    public class CreateNewProductRequestDto
    {
        [Required(ErrorMessage = "Ürün Adı Boş Geçilemez")]
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public string? ProductImageUrl { get; set; }
        public string? ProductWarranty { get; set; }
        public int? ProductCategoryID { get; set; }
    }
}
