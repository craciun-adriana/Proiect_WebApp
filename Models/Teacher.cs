using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_WebApp.Models
{
    public class Teacher
    {
        public int ID { get; set; }

        [Display(Name = "Teacher First Name")]
        public string Nume { get; set; }

        [Display(Name = "Teacher Last Name")]
        public string Prenume { get; set; }

        [Display(Name = "Teacher Phone")]
        public string Telefon { get; set; }

        [Display(Name = "Hire Date")]
        public DateTime Data_angajarii { get; set; }

        public int ScoalaID { get; set; }
        public School Scoala { get; set; }

        public int MaterieID { get; set; }
        public Discipline Materie { get; set; }
    }
}
