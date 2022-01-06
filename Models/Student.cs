using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_WebApp.Models
{
    public class Student
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z][a-z]", ErrorMessage = "Numele trebuie sa fie de forma 'Nume'"), Required, StringLength(50, MinimumLength = 2)]
        [Display(Name = "Student First Name")]
        public string Nume { get; set; }

        [RegularExpression(@"^[A-Z][a-z]", ErrorMessage = "Prenumele trebuie sa fie de forma 'Prenume'"), Required, StringLength(50, MinimumLength = 2)]
        [Display(Name = "Student Last Name")]
        public string Prenume { get; set; }

        [RegularExpression(@"^[0-9]{10-13}$", ErrorMessage = "Numarul de telefon trebuie sa fie de forma '0123456789'"), Required, StringLength(13, MinimumLength = 10)]
        [Display(Name = "Student Phone")]
        public string Telefon { get; set; }

        [Required, StringLength(13, MinimumLength = 10)]
        [Display(Name = "Catalog ID")]
        public int CatalogID { get; set; }
        public Catalog Catalog { get; set; }

        public ICollection<Grade> Grades { get; set; }
    }
}
