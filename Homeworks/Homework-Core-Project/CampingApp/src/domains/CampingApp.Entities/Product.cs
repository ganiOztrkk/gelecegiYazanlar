using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp.Entities
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }

        public string? ProductImageUrl { get; set; }
        public string? ProductWarranty { get; set; }
        public int? ProductCategoryID { get; set; }
        public Category? Category { get; set; }
        
    }
}
