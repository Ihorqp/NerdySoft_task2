using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NerdySoft_task2.Domain;

namespace NerdySoft_task2.Models.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        private readonly DataManager dataManager;

        public SidebarViewComponent(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }



        public Task<IViewComponentResult> InvokeAsync()
        {
            return Task.FromResult((IViewComponentResult) View("Default", dataManager.ServiceItems.GetServiceItems()));
        }
    }
}
