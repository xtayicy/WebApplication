using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*public string ShowPerson(string name,int age) {

            //return $"name:{name} age:{age}";
            return HtmlEncoder.Default.Encode($"name:{name} age:{age}");
        }*/

        public IActionResult ShowPerson(string name,int age) {
            ViewData["name"] = name;
            ViewData["age"] = age;

            return View();
        }
    }
}
