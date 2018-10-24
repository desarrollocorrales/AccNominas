using System;
using System.Data;
using AccSettings;
using MySql.Data.MySqlClient;
using AccAsistencia.Utilerias;

namespace AccAsistencia.DAL
{
    public class GenericDAL
    {
        protected DBMS oServidor;
        protected Checador oChecador;
        protected MySqlCommand oCommand;
        protected MySqlDataAdapter oAdapter;
        protected MySqlConnection oConnection;

        public GenericDAL()
        {
            this.oChecador = Configuracion.oChecador;
            this.oServidor = Configuracion.oServidor;
            oCommand = new MySqlCommand();
            oAdapter = new MySqlDataAdapter();
            oConnection = new MySqlConnection();
        }

        public bool ProbarConexion()
        {
            try
            {
                oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
                oConnection.Open();

                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }

                return true;
            }
            catch (Exception e)
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }

                LogManager.AgregarLog(e.Message);
                return false;
            }
        }

        /// <summary>
        /// Obtiene el string de conexion correspondiente
        /// </summary>
        /// <returns>String de conexion a la base de datos</returns>
        protected string getConnectionString()
        {
            return DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
        }
    }
}
