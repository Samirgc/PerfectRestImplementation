using ListView_Sample.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListView_Sample.Data
{
    public class ItemsManager
    {
        IRestService restservice;
        public ItemsManager(IRestService service)
        {
            restservice = service;
        }
        public Task<List<Item>> GetTasksAsync()
        {
            return restservice.GetDataAsync();
        }
    }
}
