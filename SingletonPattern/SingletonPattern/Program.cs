using SingletonPattern.Models;
using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Usuario usuario = new Usuario("UsuarioTest", "1234");
                SessionManager.Login(usuario);
                SessionManager sManager = SessionManager.GetInstance;
                Console.WriteLine(sManager.GetUserData());

                SessionManager.Logout();
                SessionManager sManager2 = SessionManager.GetInstance;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
