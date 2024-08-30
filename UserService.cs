// DataAccess/UserService.cs

// Unnecessary "using" directives.
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CodeSmells.Domain;

namespace CodeSmells.DataAccess
{
    // Add dependency injection.
    public class UserService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public UserService(HttpClient httpClient, string apiUrl)
        {
            _httpClient = httpClient;
            _apiUrl = apiUrl;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<User>>(_apiUrl);
        }
    }
}
