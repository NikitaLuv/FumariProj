using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FumariProject.Models;
using FumariProject.Database;

using Blazored.LocalStorage;
using Blazored.Toast.Services;

namespace FumariProject.Services.CartService
{
    public class CartService : ICartService
    {
        private ILocalStorageService _localStorage;
        private IToastService _toastService;
        private FumariProjectDbContext _db;

        public event Action OnChange;

        public CartService(ILocalStorageService localStorage, IToastService toastService)
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _db = new FumariProjectDbContext();
        }

        public async Task AddToCart(MerchModel model)
        {
            var cart = await _localStorage.GetItemAsync<List<MerchModel>>("cart");
            if (cart == null)
                cart = new List<MerchModel>();
            cart.Add(model);
            await _localStorage.SetItemAsync("cart", cart);
            _toastService.ShowSuccess(model.Flavour, "Добавлено в корзину!");

            OnChange.Invoke();
        }

        public async Task<List<MerchModel>> GetCartItems()
        {
            var result = new List<MerchModel>();
            var cart = await _localStorage.GetItemAsync<List<MerchModel>>("cart");
            if (cart == null)
                return result;

            return cart;
        }
    }
}
