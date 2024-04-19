using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class CategoriaModel
    {
        [DisplayName("Categoria Id")]
        public int Id { get; set; }

        [DisplayName("Categoria Name")]
        [Required(ErrorMessage = "El Nombre de la Categoria es Requerido")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "El nombre debe de tener entre 3 y 50 caratcteres ")]
        public string Name { get; set; }

        [DisplayName("Categoria Observation")]
        [Required(ErrorMessage = "Las Categorias son requeridas")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = 
            "La Categoria debe de tener entre 3 y 200 caratcteres")]
        public string Observation { get; set; }
    


}
}
