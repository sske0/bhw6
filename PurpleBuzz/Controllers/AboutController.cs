using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.About;
using System;

namespace PurpleBuzz.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var aboutIntroComponent = _context.AboutIntroComponents.FirstOrDefault();

            var model = new AboutIndexVM
            {
                AboutIntroComponent = aboutIntroComponent
            };
            return View(model);
        }
    }
}
