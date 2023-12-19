using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Mvc;
using telefon_rehber.Models;

namespace telefon_rehber.Controllers
{
    public class AppController : Controller
    {
        public ActionResult Index()
        {
            List<Contact> kişiler = new List<Contact>();
            
            //sql baplandı kilişler çekildi
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-QFBG11G;Initial Catalog=phoneBook;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM PhoneBook";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Contact kişi = new Contact();
                        kişi.Id = Int32.Parse(reader["Id"].ToString());
                        kişi.Name = reader["Name"].ToString();
                        kişi.Surname = reader["Surname"].ToString();
                        kişi.Phone = reader["Phone"].ToString();
                        kişi.PhoneNumber = reader["PhoneNumber"].ToString();
                        kişi.Email = reader["Email"].ToString();

                        kişiler.Add(kişi);
                    }

                    return Json(kişiler); //kişin verilerini json olarak gönderiyor
                }
                catch (Exception ex)
                {
                    return View("Hata", new { ErrorMessage = ex.Message });
                }
            }
        }
    }
}