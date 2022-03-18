using Microsoft.AspNetCore.Mvc;
using NerdySoft_task2.Domain;

namespace NerdySoft_task2.Controllers
{

    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        public IActionResult Index()
        {
            return View(dataManager.ServiceItems.GetServiceItems());
        }
    }
   

}