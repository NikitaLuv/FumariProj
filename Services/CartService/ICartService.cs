using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FumariProject.Models;

namespace FumariProject.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(MerchModel model);
        Task<List<MerchModel>> GetCartItems();
    }
}
