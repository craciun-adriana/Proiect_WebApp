using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_WebApp.Models
{
    public class Catalog
    {
        public int ID { get; set; }

        [Required, Range(8, 12)]
        [Display(Name = "Class")]
        public int Clasa { get; set; }

        [Required, Range(2019, 2025)]
        [Display(Name = "Promition")]
        public int Promotie { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
