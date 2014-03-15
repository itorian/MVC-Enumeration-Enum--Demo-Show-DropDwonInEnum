using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcEnumDemo.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public Salutation Salutation { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
    }

    public enum Salutation
    {
        [Display(Name = "Mr.")]
        Mr,
        [Display(Name = "Mrs.")]
        Mrs,
        [Display(Name = "Ms.")]
        Ms,
        [Display(Name = "Dr.")]
        Doctor,
        [Display(Name = "Prof.")]
        Professor,
        Sir,
        Lady,
        Lord
    }
}