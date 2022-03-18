using Microsoft.AspNetCore.Mvc;
using NerdySoft_task2.Domain;
using System.Linq;
namespace NerdySoft_task2.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
       
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public DataManager DataManager => dataManager;

        public IActionResult Index()
        {
          //  return View(dataManager.ServiceItems.GetServiceItems());

            return View("Index");
        }
    }
}