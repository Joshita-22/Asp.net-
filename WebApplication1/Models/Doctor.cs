using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Doctor
    {
        public int id { get; set; }
        [Display(Name = "NAME")]
        public string name { get; set; }
        public string speciality { get; set; }

    }

    public class Appointment
    {
        public int id { get; set; }
        
        public DateTime appointdate { get; set; }
        [ForeignKey("pt")]
        public int ptId { get; set; }
        public Patient pt { get; set; }
        [ForeignKey("doc")]
        public int docId  { get; set; }
        public Doctor doc { get; set; }


    }
}
 