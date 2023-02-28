using BAL.Models;
namespace BAL.Dtos
{
    public class ActiveUserResponseDto
    {
        public List<UtilizadorActivo> UtilizadoresActivosDto { get; set; } = new List<UtilizadorActivo>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
    }
}