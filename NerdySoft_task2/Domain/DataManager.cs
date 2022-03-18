using NerdySoft_task2.Domain.Repositories.Abstract;

namespace NerdySoft_task2.Domain
{
    public class DataManager
    {
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(IServiceItemsRepository serviceItemsRepository)
        {
            ServiceItems = serviceItemsRepository;
        }
    }
}
