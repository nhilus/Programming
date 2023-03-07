using ProjetoFinal.Web.Blazor.Identity;

namespace ProjetoFinal.Web.Blazor.Shared.Utilities
{
    public class HttpUtilities
    {
        private readonly ITokenProvider _tokenProvider;
        private readonly IHttpClientFactory _httpClientFactory;

        public HttpUtilities(ITokenProvider tokenProvider, IHttpClientFactory httpClientFactory)
        {
            _tokenProvider = tokenProvider;
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Creates an HttpClient of the specified client and adds the 'Authorization Bearer' of the user from the TokenProvider.
        /// </summary>
        /// <param name="clientName">HttpClient instance name</param>
        /// <returns>HttpClient with 'Authorization Bearer' of the current user.</returns>
        public HttpClient CreateUserClient(string clientName)
        {
            HttpClient client = _httpClientFactory.CreateClient(clientName);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {_tokenProvider.AccessToken}");
            return client;
        }

        /// <summary>
        /// Creates an HttpClient of the specified client and adds the 'Authorization Bearer' with the specified token.
        /// </summary>
        /// <param name="clientName">HttpClient instance name</param>
        /// <returns>HttpClient with 'Authorization Bearer' of the current user.</returns>
        public HttpClient CreateUserClient(string clientName, string token)
        {
            HttpClient client = _httpClientFactory.CreateClient(clientName);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
            return client;
        }

        //public HttpClient CreateApplicationClient(string clientName)
        //{

        //}


    }
}
