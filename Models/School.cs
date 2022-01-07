using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_WebApp.Models
{
    public class School
    {   public int ID { get; set; }

        [RegularExpression(@"^[a-zA-Z ]*$", ErrorMessage = "Numele trebuie sa fie de forma 'Nume'"), Required, StringLength(50, MinimumLength = 3)]
        [Display(Name = "School Name")]
        public string Denumire { get; set; }

        [Required, StringLength(100, MinimumLength = 3)]
        [Display(Name = "School Adress")]
        public string Adresa { get; set; }

        [RegularExpression(@"^[0-9]{10,13}$", ErrorMessage = "Numarul de telefon trebuie sa fie de forma '0123456789'"), Required, StringLength(13, MinimumLength = 10)]
        [Display(Name = "School Phone")]
        public string Telefon { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
