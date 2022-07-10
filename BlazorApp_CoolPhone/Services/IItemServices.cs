using BlazorApp_CoolPhone.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp_CoolPhone.Services
{
    public interface IItemServices
    {
        Task<IEnumerable<ItemModel>> GetReports();
    }
}