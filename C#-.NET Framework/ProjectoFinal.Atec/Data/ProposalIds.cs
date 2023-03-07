using ProjetoFinal.Models.Service;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class ProposalIds
    {
        public int ProposalId { get; set; }
        public int CountyId { get; set; }
        public int DistrictId { get; set; }
        public int PublicationId { get; set; }
        public int CategoryId { get; set; }
        public string ClientId { get; set; }
        public string ProviderId { get; set; }
        public Publication Publication { get; set; }
        public Proposal Proposal { get; set; }
        public DateTime? ServiceDateStart { get; set; }
        public string? ClientName { get; set; }
        public string? PublicationTitle { get; set; }

        public ProposalIds(Proposal proposal)
        {
            ProposalId = proposal.Id;
            CountyId = proposal.Publication.CountyId;
            DistrictId = proposal.Publication.County.DistrictId;
            PublicationId = proposal.PublicationId;
            CategoryId = proposal.Publication.CategoryId;
            ClientId = proposal.Publication.ClientUserId;
            ProviderId = proposal.ProviderUserId;
            ServiceDateStart = proposal.Publication.ServiceDateStart;
            Publication = proposal.Publication;
            Proposal = proposal;
        }
    }
}
