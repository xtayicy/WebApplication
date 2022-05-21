using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            Person[] persons = new Person[2] { new Person(1, "Mike", 22), new Person(2, "Harry", 21) };

            return View(persons);
        }

        /*public string Details(string name,int age) {

            //return $"name:{name} age:{age}";
            return HtmlEncoder.Default.Encode($"name:{name} age:{age}");
        }*/

        public IActionResult Details() {
            //Person[] persons = new Person[2] { new Person(1, "Mike", 22), new Person(2, "Harry", 21) };

            return View();
        }
    }
}
