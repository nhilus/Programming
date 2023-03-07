using ProjetoFinal.Models.Postal;
using ProjetoFinal.Models.Service;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class Counties
    {
        public List<County> CountiesList { get; set; }

        public Counties()
        {
            CountiesList = new List<County>();
        }

        public async Task<bool> FetchCounties(HttpClient mainHttpClient)
        {
            CountiesList = await mainHttpClient.GetFromJsonAsync<List<County>>("/counties");
            return true;
        }

        public async Task<County> FetchCounty(HttpClient mainHttpClient, int countyId)
        {
            return await mainHttpClient.GetFromJsonAsync<County>($"/counties/{countyId}");
        }

        public List<County> GetCounties()
        {
            return CountiesList;
        }
    }
}
