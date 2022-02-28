using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleOne.Controllers
{
    public class ProfileController : Controller
    {
        
        public string PersonalInfo()
        {
            return "I am Jeffrey Miller O. Razon, 20 Years Of Age.";
        }

        public string Date(int month, int day, int year)
        {
            return "The date today is" + month + " " + day + " " + year;
        }

        public string Info(string name, int age)
        {
            return "I am " + age + " , " + "I am" + age + " years old.";
        }

    }
}