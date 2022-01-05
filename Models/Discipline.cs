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

        [Display(Name = "Discipline Name")]
        public string Denumire { get; set; }

        [Display(Name = "Details")]
        public string Detalii { get; set; }
    }
}
