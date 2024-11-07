using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EnterpriseAppFrontend.Models;

namespace EnterpriseAppFrontend.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Fetch all products from the API
        public async Task<List<Product>> GetProductsAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("https://localhost:5237/api/product");
        }

        // Fetch a single product by ID
        public async Task<Product> GetProductAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"https://localhost:5001/api/product/{id}");
        }

        // Create a new product
        public async Task CreateProductAsync(Product product)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:5001/api/product", product);
        }

        // Update an existing product
        public async Task UpdateProductAsync(int id, Product product)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:5001/api/product/{id}", product);
        }

        // Delete a product by ID
        public async Task DeleteProductAsync(int id)
        {
            await _httpClient.DeleteAsync($"https://localhost:5001/api/product/{id}");
        }
    }
}
