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
        public string nume { get; set; }

        [Display(Name = "Teacher Last Name")]
        public string prenume { get; set; }

        [Display(Name = "Teacher Phone")]
        public string telefon { get; set; }

        [Display(Name = "Hire Date")]
        public DateTime data_angajarii { get; set; }

        [Display(Name = "Where teach")]
        [ForeignKey("fk_teacher_school")]
        public virtual School scoala { get; set; }

        [Display(Name = "What teach")]
        [ForeignKey("fk_teacher_discipline")]
        public virtual Discipline materie { get; set; }

    }
}
