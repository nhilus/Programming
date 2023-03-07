using ProjetoFinal.Models.Postal;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class Districts
    {
        public List<District> DistrictsList { get; set; }

        public Districts()
        {
            DistrictsList = new List<District>();
        }

        public async Task<bool> FetchDistricts(HttpClient mainHttpClient)
        {
            DistrictsList = await mainHttpClient.GetFromJsonAsync<List<District>>("/Districts");
            return true;
        }

        public async Task<District> FetchDistrict(HttpClient mainHttpClient, int districtId)
        {
            return await mainHttpClient.GetFromJsonAsync<District>($"/districts/{districtId}");
        }

        public List<District> GetDistricts()
        {
            return DistrictsList;
        }
    }
}
