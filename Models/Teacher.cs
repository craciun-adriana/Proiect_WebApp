using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proiect_WebApp.Utils.Validation;

namespace Proiect_WebApp.Models
{
    public class Teacher
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Numele trebuie sa fie de forma 'Nume'"),Required, StringLength(50, MinimumLength = 2)]
        [Display(Name = "Teacher First Name")]
        public string Nume { get; set; }

        [RegularExpression(@"^[A-Z][a-z]*$", ErrorMessage = "Prenumele trebuie sa fie de forma 'Prenume'"), Required, StringLength(50, MinimumLength = 2)]
        [Display(Name = "Teacher Last Name")]
        public string Prenume { get; set; }

        [RegularExpression(@"^[0-9]{10,13}$", ErrorMessage = "Numarul de telefon trebuie sa fie de forma '0123456789'"), Required, StringLength(13, MinimumLength = 10)]
        [Display(Name = "Teacher Phone")]
        public string Telefon { get; set; }


        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [DateBeforeToday]
        public DateTime Data_angajarii { get; set; }

        [Display(Name = "School ID")]
        public int ScoalaID { get; set; }
        public School Scoala { get; set; }

        [Display(Name = "Discipline ID")]
        public int MaterieID { get; set; }
        public Discipline Materie { get; set; }
    }
}
