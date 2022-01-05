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
        public string denumire { get; set; }

        [Display(Name = "Details")]
        public string detalii { get; set; }
    }
}
