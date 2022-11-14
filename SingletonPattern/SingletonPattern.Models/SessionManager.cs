using System;

namespace SingletonPattern.Models
{
    public class SessionManager
    {
        private static SessionManager _session;
        public Usuario Usuario { get; set; }
        public DateTime FechaInicio { get; set; }
        private SessionManager()
        {

        }
        //public static SessionManager GetInstance
        //{
        //    get
        //    {
        //        if (_session is null)
        //        {
        //            _session = new SessionManager();
        //        }
        //        return _session;
        //    }
        //}
        public static SessionManager GetInstance
        {
            get
            {
                if (_session is null)
                {
                    throw new Exception("Sesión no iniciada");
                }
                return _session;
            }
        }
        public static void Login(Usuario usuario)
        {
            if (usuario != null && _session == null)
            {
                _session = new SessionManager();
                _session.Usuario = usuario;
                _session.FechaInicio = DateTime.Now;
            }
            else
            {
                throw new Exception("Sesion ya iniciada");
            }
        }
        public static void Logout()
        {
            if (_session != null)
            {
                _session = null;
            }
            else
            {
                throw new Exception("Sesion no iniciada");
            }
        }
        public string GetUserData()
        {
            return $"{Usuario}, Horario de ingreso: {FechaInicio}";
        }
    }
}
