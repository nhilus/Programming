using ProjetoFinal.Models.Config;
using ProjetoFinal.Models.Postal;
using ProjetoFinal.Models.Provider;
using System.Net.NetworkInformation;


namespace ProjetoFinal.Web.Blazor.Data
{
    public class Socials
    {

        public Socials()
        {

        }

        public async Task<List<SocialNetwork>> FetchSocials(HttpClient mainHttpClient)
        {
            List<SocialNetwork> SocialsList = await mainHttpClient.GetFromJsonAsync<List<SocialNetwork>>("/socialnetworks");
            return SocialsList;
        }
    }
}
