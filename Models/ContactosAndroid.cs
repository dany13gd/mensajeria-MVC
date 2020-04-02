using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MensajeriaMVC.Models
{
    public class ContactosAndroid
    {
        [Required(ErrorMessage = "Nombre")]
        public string name { get; set; }

        [Required(ErrorMessage = "Organizacion")]
        public string organization { get; set; }

        [Required(ErrorMessage = "Posicion")]
        public string position { get; set; }

        [Required(ErrorMessage = "Archivar como")]
        public string storeType { get; set; }

        [Required(ErrorMessage = "Correo Electronico")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Ingresa un email valido")]
        public string email { get; set; }

        [Required(ErrorMessage = "Mostrar como")]
        public string showAs { get; set; }

        [Required(ErrorMessage = "Pagina Web")]
        public string webSite { get; set; }

        [Required(ErrorMessage = "Direccion de IM")]
        public string imAddress { get; set; }


        [Required(ErrorMessage = "Telefono trabajo")]
        public string phoneWork { get; set; }

        [Required(ErrorMessage = "Telefono casa")]
        public string phoneHome { get; set; }

        [Required(ErrorMessage = "Fax")]
        public string faxWork { get; set; }

        [Required(ErrorMessage = "Celular")]
        public string phoneMovile { get; set; }

        [Required(ErrorMessage = "Direccion trabajo")]
        public string workAddress { get; set; }

        [Required(ErrorMessage = "Direccion para la correspondencia")]
        public bool correspondence { get; set; }

        [Required(ErrorMessage = "Notas")]
        public string notes { get; set; }

        [Required(ErrorMessage = "Foto")]
        public string imagen { get; set; }
    }
}