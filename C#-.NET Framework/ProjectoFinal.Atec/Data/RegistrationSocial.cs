using ProjetoFinal.Models.Config;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class RegistrationSocial
    {
        public SocialNetwork Social { get; set; }
        public string? Link { get; set; }

        public RegistrationSocial(SocialNetwork social)
        {
            Social = social;
        }
    }
}
