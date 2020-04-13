using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GrandSmartphoneStore.Models
{
    public class Clienti
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Introduceti numele")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Folositi doar litere")]
        public string Nume { get; set; }
        [Required(ErrorMessage = "Introduceti marca")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Introduceti modelul")]
        [RegularExpression("[^0-11]", ErrorMessage = "Modelul nu exista")]
        public int Model { get; set; }
    }
}