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
        public string Nume { get; set; }

        [Display(Name = "Student Last Name")]
        public string Prenume { get; set; }

        [Display(Name = "Student Phone")]
        public string Telefon { get; set; }

        [Display(Name = "Catalog ID")]
        public int CatalogID { get; set; }
        public Catalog Catalog { get; set; }

        public ICollection<Grade> Grades { get; set; }
    }
}
