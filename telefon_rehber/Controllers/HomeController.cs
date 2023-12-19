using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using telefon_rehber.Models;

namespace telefon_rehber.Controllers
{
    public class HomeController : Controller
    {
        // anasayfaa
        public ActionResult Index()
        {
            var contacts = new List<Contact>
  {
    //new Contact { Name = "esra", Surname = "ünal", Phone = "0212222222", PhoneNumber="05372614602", Email=esraunall2@gmail.com },
    //new Contact { Name = "ayse", Surname = "ayse", Phone = "0222222222" ,PhoneNumber="05555555555" Email="ayse@gmail.com"}
  };

            foreach (var contact in contacts)
            {
                if (contact != null)
                {
                    
                }
            }

            return View(contacts);
        }


    }

}