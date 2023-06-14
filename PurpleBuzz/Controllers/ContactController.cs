using Microsoft.AspNetCore.Mvc;
using PurpleBuzz.DAL;
using PurpleBuzz.Models;
using PurpleBuzz.ViewModels.Contact;

namespace PurpleBuzz.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            var contactCreateSuccessComponent = _context.ContactCreateSuccessComponents.FirstOrDefault();
            var contactCategoryComponents = _context.ContactCategoryComponents.ToList();


            var model = new ContactIndexVM
            {
                ContactCreateSuccessComponent = contactCreateSuccessComponent,
                ContactCategoryComponents = contactCategoryComponents
            };

            return View(model);
        }
    }
}
