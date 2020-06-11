using System;
using System.ComponentModel.DataAnnotations;
namespace ContactsHolder.Models{
    public class Contact{
        public int id{get;set;}
        public string Name{get;set;}
        public string Surname{get;set;}

        [Display(Name="Contact Number")]
        [StringLength(10)]
        [Required]
        public string contactNumber{get;set;}

        [Display(Name="Email")]
        public string email{get;set;} 

        [Display(Name = "Type")]
        public string type{get;set;}

        [Display(Name="Important")]
        public string Importance{get;set;}
    }
}