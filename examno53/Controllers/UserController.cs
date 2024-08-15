using Microsoft.AspNetCore.Mvc;
using examno53.Models;
using System;

namespace YourNamespace.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(UserForm model) 
        {
            if (ModelState.IsValid)
            {
                var age = DateTime.Now.Year - model.DateOfBirth.Year;
                if (model.DateOfBirth > DateTime.Now.AddYears(-age)) age--;

                if (age < 18)
                {
                    return RedirectToAction("KidsSuccess");
                }
                else
                {
                    return RedirectToAction("AdultsSuccess");
                }
            }
            return View("Index", model);
        }

        public IActionResult KidsSuccess()
        {
            return View();
        }

        public IActionResult AdultsSuccess()
        {
            return View();
        }
    }
}
