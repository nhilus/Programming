namespace ProjetoFinal.Web.Blazor.Data
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }



        public User() : this(default!, default!, default!)
        {
        }



        public User(string email, string password, string name)
        {
            Email = email;
            Password = password;
            Name = name;
        }
    }
}
