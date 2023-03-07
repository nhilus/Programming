namespace ProjetoFinal.Web.Blazor.Identity
{
    public interface ITokenProvider
    {
        string? AccessToken { get; set; }
        string? RefreshToken { get; set; }
    }
}