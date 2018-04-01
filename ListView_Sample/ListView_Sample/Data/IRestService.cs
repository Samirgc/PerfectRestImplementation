using ListView_Sample.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ListView_Sample.Data
{
    public interface IRestService
    {
        Task<List<Item>> GetDataAsync();
    }
}
