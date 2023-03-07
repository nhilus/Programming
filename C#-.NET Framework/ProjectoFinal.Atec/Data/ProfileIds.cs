using ProjetoFinal.Models.Postal;
using ProjetoFinal.Models.Provider;
using ProjetoFinal.Models.Service;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class ProfileIds
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public Profile Profile { get; set; }
        public List<Category> Categories { get; set; }
        public List<County> Locations { get; set; }
        public bool HasRatings { get; set; }
        public int Rating { get; set; }

        public ProfileIds(Profile profile, List<Category> categories, List<County> locations, bool hasRatings)
        {
            Name = profile.Name;
            Profile = profile;
            Categories = categories;
            Locations = locations;
            HasRatings = hasRatings;
        }

        public ProfileIds(Profile profile, List<Category> categories, List<County> locations, bool hasRatings, int rating)
        {
            Name = profile.Name;
            Profile = profile;
            Categories = categories;
            Locations = locations;
            HasRatings = hasRatings;
            Rating = rating;
        }
    }
}
