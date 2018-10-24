using System.Text;
using AccSettings;

namespace AccAsistencia.DAL
{
    public static class DataBaseUtils
    {
        public static string ObtenerConectionString(Checador oChecador, DBMS oServidor)
        {
            string connString = string.Empty;

            StringBuilder sbStringConn = new StringBuilder();
            sbStringConn.Append(string.Format("Server={0};", oServidor.Host));
            sbStringConn.Append(string.Format("Port={0};", oServidor.Puerto));
            sbStringConn.Append(string.Format("Database={0};", oChecador.DataBase.ToLower()));
            sbStringConn.Append(string.Format("Uid={0};", oServidor.Usuario));
            sbStringConn.Append(string.Format("Pwd={0};", oServidor.Pwd));
            connString = sbStringConn.ToString();

            return connString;
        }
    }
}
