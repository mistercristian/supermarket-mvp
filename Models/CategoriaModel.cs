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

        [DisplayName("Nombre Categoria")]
        [Required(ErrorMessage = "Nombre de Categoria requerido")]
        [StringLength(50, MinimumLength = 3,
            ErrorMessage = "Categoria name must be between 3 and 50 characters ")]
        public string Name { get; set; }

        [DisplayName("Categoria Observation")]
        [Required(ErrorMessage = "Categoria observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage =
            "Categoria observation must be between 3 and 200 characters ")]
        public string Observation { get; set; }



    }
}
