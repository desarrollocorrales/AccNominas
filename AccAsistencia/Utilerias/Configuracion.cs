using AccSettings;
using System.Configuration;

namespace AccAsistencia.Utilerias
{
    public static class Configuracion
    {
        public static Checador oChecador;
        public static DBMS oServidor;
        public static Usuario oUsuario;
        public static string dbTodos = ConfigurationManager.AppSettings.Get("db_todos");
    }
}
