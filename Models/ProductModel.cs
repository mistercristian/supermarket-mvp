using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Product Id")]
        public int Id { get; set; }

        [DisplayName("Product Name")]
        [Required(ErrorMessage = "El Nombre del Producto es Requerido")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "El nombre debe de tener entre 3 y 50 caratcteres")]
        public string Name { get; set; }

        [DisplayName("Product Observation")]
        [Required(ErrorMessage = "L0s Productos son requeridas")]
        [StringLength(200, MinimumLength = 3, ErrorMessage =
            "Los product debe de tener entre 3 y 200 caratcteres")]
        public string Observation { get; set; }

    }
}
