using ProjetoFinal.Models.Service;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class Categories
    {
        public List<Category> CategoriesList { get; set; }

        public Categories()
        {
            CategoriesList = new List<Category>();
        }

        public async Task<bool> FetchCategories(HttpClient mainHttpClient)
        {
            CategoriesList = await mainHttpClient.GetFromJsonAsync<List<Category>>("/categories");
            return true;
        }

        public async Task<Category> FetchCategory(HttpClient mainHttpClient, int categoryId)
        {
            return await mainHttpClient.GetFromJsonAsync<Category>($"/categories/{categoryId}");
        }

        public List<Category> GetCategories()
        {
            return CategoriesList;
        }
    }
}
