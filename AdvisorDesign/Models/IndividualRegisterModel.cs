using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdvisorDesign.Models
{
    public class IndividualRegisterModel
    {
        
            [Required(ErrorMessage = "Pole jméno a přijmení je povinné.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Pole email je povinné.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Pole heslo je povinné.")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Pole licenční klíč je povinné.")]
            public string LicenseKey { get; set; }
            
            public string Gender { get; set; }
    }
}