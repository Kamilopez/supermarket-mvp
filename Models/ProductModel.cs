using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Stock")]
        [Required(ErrorMessage = "Stock is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be a positive number")]
        public int Stock { get; set; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be a positive number greater than zero")]
        public decimal Price { get; set; }

        [DisplayName("Category Id")]
        [Required(ErrorMessage = "Category Id is required")]
        public int Category_Id { get; set; }
    }
}
