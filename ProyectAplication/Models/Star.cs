using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectAplication.Models
{
    //THIS IS THE CONSTELLATION CLASS, WITH ITS ATRIBUTES
    public class Star
    {
        [Key]
        [Display(Name = "Estrella ID")]
        public int IdCStar { get; set; }
        [Display(Name = "Nombre")]
        public String Name_S { get; set; }
        [Display(Name = "Tipo de estrella")]
        public String Tipo { get; set; }
        [Display(Name = "Constelación ID")]
        public int IdConstellation { get; set; }

    }
}
