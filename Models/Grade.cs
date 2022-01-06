﻿using System;
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

        [RegularExpression(@"^[1-10]{1}$"), Required]
        [Display(Name = "Grade")]
        public int Nota { get; set; }


        [Display(Name = "Data")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public int MaterieID { get; set; }
        public Discipline Materie { get; set; }

        public int ElevID { get; set; }
        public Student Elev { get; set; }
    }
}
