using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvisorDesign.Models
{
    public class StudentRegisterModel
    {
        
            [Required(ErrorMessage = "Pole jméno a příjmení je povinné.")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Pole email je povinné.")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Pole heslo je povinné.")]
            public string Password { get; set; }

            [Required(ErrorMessage = "Pole licenční klíč je povinné.")]
            public string SchoolCode { get; set; }

            public IEnumerable<SelectListItem> SchoolName { get; set; }

            public IEnumerable<SelectListItem> ClassName { get; set; }

            public string Gender { get; set; }
    }
}