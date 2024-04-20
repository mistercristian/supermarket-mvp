using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    [DisplayName("Product Id")]
    internal class ProductModel
    {
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]

        public string Name { get; set; }

        [DisplayName("Observation")]
        [Required(ErrorMessage = "Product observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product observation must be between 3 and 200 characters")]

        public string Observation { get; set; }

    }
}
