using GCOM2_Test;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;


namespace GCOM2_Test.Data
{

    public class RandomUserService
    {
        private HttpClient _httpClient;
        private User response;
        private List<User> users;

        public RandomUserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetRandomUsersAsync()
        {
            users = await _httpClient.GetFromJsonAsync<List<User>>("?results=10");
            return users;
        }

    }
}
