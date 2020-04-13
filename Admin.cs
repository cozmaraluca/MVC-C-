using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdminGSS.Models
{
    public class Admin
    {
        public class Clienti
        {
            public int Id { get; set; }
            [Required(ErrorMessage = "Introduceti numele")]
            [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Folositi doar litere")]
            public string Nume { get; set; }
            [Required(ErrorMessage = "Introduceti parola")]
            [RegularExpression(@"^(?=.*\d)(?=.*[A-Z]).{4,8}$",ErrorMessage ="Format parola gresit")]
            public string Parola { get; set; }
            
        }
    }
}