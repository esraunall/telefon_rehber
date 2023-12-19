using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


// kişinin bilgileri

namespace telefon_rehber.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }

}