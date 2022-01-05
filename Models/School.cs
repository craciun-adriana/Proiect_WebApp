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

        [Display(Name = "School Name")]
        public string denumire { get; set; }

        [Display(Name = "School Adress")]
        public string adresa { get; set; }

        [Display(Name = "School Phone")]
        public string telefon { get; set; }
    }
}
