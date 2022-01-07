using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Proiect_WebApp.Utils;
using Proiect_WebApp.Utils.Validation;

namespace Proiect_WebApp.Models
{
    public class Grade
    {
        public int ID { get; set; }

        [RegularExpression(@"^([1-9]|10)$", ErrorMessage = "Nota trebuie sa fie intre 1 si 10."), Required]
        [Display(Name = "Grade")]
        public int Nota { get; set; }


        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        [DateBeforeToday]
        public DateTime Data { get; set; }

       
        public int MaterieID { get; set; }
        public Discipline Materie { get; set; }

        public int ElevID { get; set; }
        public Student Elev { get; set; }
    }
}
