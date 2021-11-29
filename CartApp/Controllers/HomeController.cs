using CartApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CartApp.Controllers
{
    public class HomeController : Controller
    {
        HttpClientHandler _clientHandler = new HttpClientHandler();

        Product _product = new Product();
        List<Product> _products = new List<Product>();
        Models.Cart _cart = new Models.Cart();
        List<Models.Cart> _carts = new List<Models.Cart>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            _products = new List<Product>();
            _products = await getAllProducts();
            return View(_products);
        }

        public async Task<IActionResult> DisplayProducts()
        {
            _products = new List<Product>();
            _products = await getAllProducts();
            return View(_products);
        }

        //------------------------------------------------------------------------------------

        [HttpGet]
        public async Task<List<Product>> getAllProducts()
        {
            _products = new List<Product>();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:44304/api/Products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }
            }
            return _products;
        }

        [HttpGet]
        public async Task<Product> getProductById(int productId)
        {
            _product = new Product();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:44304/api/Products/" + productId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return _product;
        }

        [HttpPost]
        public async Task<Product> AddUpdateProduct(Product incomingProduct)
        {
            _product = new Product();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(incomingProduct), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44304/api/Products", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _product = JsonConvert.DeserializeObject<Product>(apiResponse);
                }
            }
            return _product;
        }

        [HttpDelete]
        public async Task<string> deleteProduct(int productId)
        {
            string result = "";
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44304/api/Products/" + productId))
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }
            return result;
        }

        //-----------------------------------------------------------------------------------

        [HttpGet]
        public async Task<List<Models.Cart>> getAllCarts()
        {
            _carts = new List<Models.Cart>();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:44304/api/Carts"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _carts = JsonConvert.DeserializeObject<List<Models.Cart>>(apiResponse);
                }
            }
            return _carts;
        }

        [HttpGet]
        public async Task<Models.Cart> getCartById(int cartId)
        {
            _cart = new Models.Cart();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.GetAsync("https://localhost:44304/api/Carts/" + cartId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _cart = JsonConvert.DeserializeObject<Models.Cart>(apiResponse);
                }
            }
            return _cart;
        }

        [HttpPost]
        public async Task<Models.Cart> AddUpdateCart(Models.Cart incomingcart)
        {
            _cart = new Models.Cart();
            using (var httpClient = new HttpClient(_clientHandler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(incomingcart), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44304/api/Carts", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    _cart = JsonConvert.DeserializeObject<Models.Cart>(apiResponse);
                }
            }
            return _cart;
        }

        [HttpDelete]
        public async Task<string> deleteCart(int cartId)
        {
            string result = "";
            using (var httpClient = new HttpClient(_clientHandler))
            {
                using (var response = await httpClient.DeleteAsync("https://localhost:44304/api/Carts/" + cartId))
                {
                    result = await response.Content.ReadAsStringAsync();
                }
            }
            return result;
        }
    }
}