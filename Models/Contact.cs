using System;
using System.ComponentModel.DataAnnotations;
namespace ContactsHolder.Models{
    public class Contact{
        public int id{get;set;}
        public string Name{get;set;}
        public string Surname{get;set;}
        public string contactNumber{get;set;}
        public string email{get;set;} 
        public string type{get;set;}
    }
}