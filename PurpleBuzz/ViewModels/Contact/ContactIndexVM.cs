using Microsoft.EntityFrameworkCore.ChangeTracking;
using PurpleBuzz.Models;

namespace PurpleBuzz.ViewModels.Contact
{
    public class ContactIndexVM
    {
        public ContactIndexVM()
        {
            ContactCategoryComponents = new List<ContactCategoryComponent>();
        }
        public ContactCreateSuccessComponent ContactCreateSuccessComponent { get; set; }

        public List<Models.ContactCategoryComponent> ContactCategoryComponents { get; set; }

    }
}
