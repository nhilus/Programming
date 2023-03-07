using ProjetoFinal.Models.Postal;
using ProjetoFinal.Models.Service;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class Publications
    {
        public List<Publication> PublicationsList { get; set; }

        public Publications()
        {
            PublicationsList = new List<Publication>();
        }

        public async Task<bool> FetchPublications(HttpClient mainHttpClient)
        {
            PublicationsList = await mainHttpClient.GetFromJsonAsync<List<Publication>>("/publications");
            return true;
        }

        public async Task<Publication> FetchPublication(HttpClient mainHttpClient, int publicationId)
        {
            return await mainHttpClient.GetFromJsonAsync<Publication>($"/publications/{publicationId}");
        }

        public List<Publication> GetPublications()
        {
            return PublicationsList;
        }
    }
}
