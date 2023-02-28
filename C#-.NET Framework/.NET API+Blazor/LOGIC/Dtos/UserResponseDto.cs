using BAL.Models;
namespace BAL.Dtos
{
    public class UserResponseDto
    {
        public List<UtilizadorModel> UtilizadoresDto { get; set; } = new List<UtilizadorModel>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}
