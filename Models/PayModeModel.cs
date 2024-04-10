using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay Mode Id")]
        public int Id {get;set;}
        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage ="El Nombre del Metodo de <pago es Requerido")]
        [StringLength(50,MinimumLength = 3, ErrorMessage ="El nombre debe de tener entre 3 y 50 caratcteres")]
        public string Name { get;set;}
        [DisplayName("Observation")]
        [Required(ErrorMessage = "Las Observaciones son requeridas")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "La observacion debe de tener entre 3 y 200 caratcteres")]
        public string Observation { get;set;}

    }
}
