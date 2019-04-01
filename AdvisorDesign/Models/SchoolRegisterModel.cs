using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvisorDesign.Models
{
    public class SchoolRegisterModel
    {
        
            [Required(ErrorMessage = "Pole jméno školy je povinné.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Pole ICO je povinné.")]
            public string ICO { get; set; }

            [Required(ErrorMessage = "Pole jméno kontaktu heslo je povinné.")]
            public string NickContact { get; set; }

            [Required(ErrorMessage = "Pole email je povinné.")]
            public string Email { get; set; }

            public string Message { get; set; }

            [Required(ErrorMessage = "Pole heslo je povinné.")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Pole licenční klíč je povinné.")]

            public string LicenseKey { get; set; }
        
    }
}