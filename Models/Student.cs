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

        [Display(Name = "Student First Name")]
        public string nume { get; set; }

        [Display(Name = "Student Last Name")]
        public string prenume { get; set; }

        [Display(Name = "Student Phone")]
        public string telefon { get; set; }

        [Display(Name = "Catalog ID")]
        [ForeignKey("fk_student_catalog")]
        public Catalog catalog { get; set; }
    }
}
