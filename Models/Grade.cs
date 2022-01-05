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
        public int nota { get; set; }

        [Display(Name = "Data")]
        public DateTime data { get; set; }

        [Display(Name = "ID Discipline")]
        [ForeignKey("fk_grade_discipline")]
        public virtual Discipline materie { get; set; }

        [Display(Name = "ID Student")]
        [ForeignKey("fk_grade_student")]
        public virtual Student elev { get; set; }

    }
}
