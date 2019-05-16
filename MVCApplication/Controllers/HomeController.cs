using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApplication.Models;
using MVCApplication.ViewModels;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        internal static Dictionary<string, string> columnChoices = new Dictionary<string, string>();

        // This is a "static constructor" which can be used
        // to initialize static members of a class
       

        public IActionResult Index()
        {

            ViewBag.columns = columnChoices;

            return View();


        }

        public IActionResult Values(string column)
        {

            ValuesViewModel valuesViewModel = new ValuesViewModel();


            List<string> elements = TextData.FindAll();

            valuesViewModel.elements = elements;

            return View(valuesViewModel);
        }


        public IActionResult Results(string searchTerm)

        {

            if (searchTerm == null)

            {

                return Redirect("/");

            }
            
                else

            {

                List<string> elements = TextData.FindByValue(searchTerm);
                ViewBag.elements = elements;
                return View();
            }
                
            }

        }

    }

