using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_WebApp.Models
{
    public class Grade
    {
        public int ID { get; set; }

        [Display(Name = "Grade")]
        public int Nota { get; set; }

        [Display(Name = "Data")]
        public DateTime Data { get; set; }

        public int MaterieID { get; set; }

        public int ElevID { get; set; }

    }
}
