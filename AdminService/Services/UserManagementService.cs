using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AdminService.Models;
using Microsoft.Extensions.Configuration;

namespace AdminService.Services
{
    public class UserManagementService
    {
        private readonly HttpClient _httpClient;
        private readonly string _userServiceBaseUrl;

        public UserManagementService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _userServiceBaseUrl = configuration["UserServiceBaseUrl"];
        }

        public async Task<HttpResponseMessage> AddUser(User user)
        {
            var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            return await _httpClient.PostAsync($"{_userServiceBaseUrl}/api/users", content);
        }

        public async Task<HttpResponseMessage> UpdateUser(int id, User user)
        {
            var content = new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");
            return await _httpClient.PutAsync($"{_userServiceBaseUrl}/api/users/{id}", content);
        }

        public async Task<HttpResponseMessage> DeleteUser(int id)
        {
            return await _httpClient.DeleteAsync($"{_userServiceBaseUrl}/api/users/{id}");
        }
    }
}
