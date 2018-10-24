using System;

namespace AccAsistencia.Utilerias
{
    [Serializable]
    public class Usuario
    {
        public string nombre { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string permisos { get; set; }
    }
}
