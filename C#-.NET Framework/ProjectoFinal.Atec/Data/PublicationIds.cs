using ProjetoFinal.Models.Service;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class PublicationIds
    {
        public int CountyId { get; set; }
        public int DistrictId { get; set; }
        public int PublicationId { get; set; }
        public int CategoryId { get; set; }
        public Publication Publication { get; set; }
        public DateTime? ServiceDateStart { get; set; }
        public DateTime? ServiceDateEnd { get; set; }
        public string? ClientName { get; set; }
        public string? PublicationTitle { get; set; }

        public PublicationIds(Publication p)
        {
            CountyId = p.CountyId;
            DistrictId = p.County.DistrictId;
            PublicationId = p.Id;
            CategoryId = p.CategoryId;
            ServiceDateStart = p.ServiceDateStart;
            ServiceDateEnd = p.ServiceDateEnd;
            Publication = p;
            PublicationTitle = p.Title;
        }
    }
}
