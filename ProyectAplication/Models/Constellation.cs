using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectAplication.Models
{
    //THIS IS THE CONSTELLATION CLASS, WITH ITS ATRIBUTES
    public class Constellation
    {
        [Key]
        [Display(Name = "Constelación ID")]
        public int IdConstellation { get; set; }
        [Display(Name = "Nombre")]
        public String Name_C { get; set; }
        [Display(Name = "Hemisferio")]
        public String Hemisphere { get; set; }
        [Display(Name = "Época del año")]
        public String Period { get; set; }
        [Display(Name = "Estrella principal")]
        public String Name_S { get; set; }

    }
}