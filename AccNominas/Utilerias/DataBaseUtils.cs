using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccSettings;

namespace AccNominas.Utilerias
{
    public static class DataBaseUtils
    {
        public static string ObtenerConectionString(Checador oChecador, DBMSSettings DBSettings)
        {
            string connString = string.Empty;

            //****** Obtener parametros del servidor de bases de datos ******
            DBMS servidor = DBSettings.Dbms.Where(o => o.Nombre == oChecador.Dbms).SingleOrDefault();

            StringBuilder sbStringConn = new StringBuilder();
            sbStringConn.Append(string.Format("Server={0};", servidor.Host));
            sbStringConn.Append(string.Format("Port={0};", servidor.Puerto));
            sbStringConn.Append(string.Format("Database={0};", oChecador.DataBase.ToLower()));
            sbStringConn.Append(string.Format("Uid={0};", servidor.Usuario));
            sbStringConn.Append(string.Format("Pwd={0};", servidor.Pwd));
            connString = sbStringConn.ToString();
            /**********/

            return connString;
        }
    }
}
