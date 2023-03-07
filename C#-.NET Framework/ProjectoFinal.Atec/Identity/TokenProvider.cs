namespace ProjetoFinal.Web.Blazor.Identity
{
    public class TokenProvider : ITokenProvider
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
