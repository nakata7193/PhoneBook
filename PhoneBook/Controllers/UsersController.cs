using Microsoft.AspNetCore.Mvc;
using PhoneBook.Repositories;
using PhoneBook.ViewModels.Users;

namespace PhoneBook.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            IndexVM model = new IndexVM();
            model.Items = UsersRepository.Items;
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateVM model)
        {
            return View();
        }

    }
}
