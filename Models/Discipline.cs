using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_WebApp.Models
{
    public class Discipline
    {
        public int ID{ get; set; }

        [RegularExpression(@"^[A-Z][a-z]$"), Required, StringLength(30, MinimumLength = 2)]
        [Display(Name = "Discipline Name")]
        public string Denumire { get; set; }

        [Display(Name = "Details")]
        public string Detalii { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Grade> Grades { get; set; }
    }
}
