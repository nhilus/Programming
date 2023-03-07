using ProjetoFinal.Models.Postal;
using ProjetoFinal.Models.Provider;
using ProjetoFinal.Models.Service;

namespace ProjetoFinal.Web.Blazor.Data
{
    public class MessagingUserData
    {
        public string UserId { get; set; }
        public string UserName { get; set; }

        public Guid ConversationId { get; set; }

        public MessagingUserData(string userId, string userName, Guid conversationId)
        {
            UserId = userId;
            UserName = userName;
            ConversationId = conversationId;
        }
    }
}
