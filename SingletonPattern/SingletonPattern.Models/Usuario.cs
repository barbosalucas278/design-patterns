namespace SingletonPattern.Models
{
    public class Usuario
    {
        public Usuario(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public string UserName { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $"Usuario: {UserName}, Password: {Password}";
        }
    }
}