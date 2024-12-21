using System.Threading.Tasks;
using IonitaIsabelaLab11.Models;

namespace IonitaIsabelaLab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
