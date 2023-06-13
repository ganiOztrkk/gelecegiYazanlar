using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp.Entities
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string? CategoryDescription { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
