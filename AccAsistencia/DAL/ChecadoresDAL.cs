using System;
using System.Collections.Generic;
using System.Data;
using AccAsistencia.Utilerias;
using MySql.Data.MySqlClient;
using AccSettings;
using System.Text;

namespace AccAsistencia.DAL
{
    public class ChecadoresDAL : GenericDAL
    {
        public ChecadoresDAL()
            : base()
        {

        }

        // obtiene los numeros de checador disponibles
        public List<int> getNumChec()
        {
            List<int> result = new List<int>();

            oConnection.ConnectionString = getConnectionString();
            oConnection.Open();

            oCommand.Connection = oConnection;
            oCommand.CommandText = "select no_checador from checadas group by no_checador";

            oAdapter.SelectCommand = oCommand;
                DataTable dt_Checadores = new DataTable();
                oAdapter.Fill(dt_Checadores);

                int obj_Nche;
                foreach (DataRow row in dt_Checadores.Rows)
                {
                    obj_Nche = new int();
                    obj_Nche = Convert.ToInt32(row["no_checador"]);
                    result.Add(obj_Nche);
                }
            
            oConnection.Close();          

            return result;
        }

        /// <summary>
        /// Obtiene una lista de checadores de la base de datos.
        /// </summary>
        /// <returns></returns>
        public List<Checadores> ObtenerChecadores()
        {
            List<Checadores> lstChecadores = new List<Checadores>();

            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText = "SELECT id_checador, descripcion, base_de_datos FROM checadores";

                oAdapter.SelectCommand = oCommand;
                DataTable dt_Checadores = new DataTable();
                oAdapter.Fill(dt_Checadores);

                Checadores oChecadores;
                foreach (DataRow row in dt_Checadores.Rows)
                {
                    oChecadores = new Checadores();
                    oChecadores.id_checador = Convert.ToInt32(row["id_checador"]);
                    oChecadores.descripcion = Convert.ToString(row["descripcion"]);
                    oChecadores.base_de_datos = Convert.ToString(row["base_de_datos"]);
                    lstChecadores.Add(oChecadores);
                }

                oConnection.Close();             
            }
            catch (Exception ex)
            {
                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();
                oAdapter = null;
                oCommand = null;
                oConnection = null;

                GC.Collect();

                throw ex;
            }

            oAdapter = null;
            oCommand = null;
            oConnection = null;

            GC.Collect();

            return lstChecadores;
        }

        /// <summary>
        /// Obtiene una lista de strings con los nombres de las bases de datos que contienen en su nombre
        /// la cadena "corrales"
        /// </summary>
        /// <returns></returns>
        public List<string> ObtenerBasesDeDatos()
        {
            List<string> lstDatabases = new List<string>();

            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText = "SHOW DATABASES";

                oAdapter.SelectCommand = oCommand;
                DataTable dt_Checadores = new DataTable();
                oAdapter.Fill(dt_Checadores);

                string sDatabase;
                foreach (DataRow row in dt_Checadores.Rows)
                {
                    sDatabase = Convert.ToString(row[0]);
                    lstDatabases.Add(sDatabase);
                }

                oConnection.Close();
            }
            catch (Exception ex)
            {
                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();
                oAdapter = null;
                oCommand = null;
                oConnection = null;

                GC.Collect();

                throw ex;
            }

            oAdapter = null;
            oCommand = null;
            oConnection = null;

            GC.Collect();

            lstDatabases = lstDatabases.FindAll(o => o.Contains("corrales"));

            return lstDatabases;
        }

        /// <summary>
        /// Guarda un objeto "Checadores" en la base de datos
        /// </summary>
        /// <param name="oChecadores"></param>
        public void Guardar(Checadores oChecadores)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.Transaction = oConnection.BeginTransaction();
                oCommand.CommandText =
                    string.Format(@"SELECT COUNT(id_checador) AS count 
                                      FROM checadores 
                                     WHERE base_de_datos = '{0}'", oChecadores.base_de_datos);
                
                int count = Convert.ToInt32(oCommand.ExecuteScalar());
                if (count == 0)
                {
                    oCommand.CommandText =
                        string.Format(@"INSERT INTO checadores (descripcion, base_de_datos) 
                                             VALUES ('{0}', '{1}')", 
                                             oChecadores.descripcion, oChecadores.base_de_datos);
                    oCommand.ExecuteNonQuery();
                }
                else
                {
                    string sMensaje =
                        string.Format("La base de datos '{0}' ya esta asignada a un checador.", oChecadores.base_de_datos);

                    throw new DuplicateNameException(sMensaje);
                }

                oCommand.Transaction.Commit();
                oConnection.Close();
            }
            catch (Exception ex)
            {
                if (oCommand.Transaction != null)
                    oCommand.Transaction.Rollback();

                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();

                oAdapter = null; oCommand = null; oConnection = null;
                GC.Collect();

                throw ex;
            }

            oAdapter = null; oCommand = null; oConnection = null;
            GC.Collect();
        }

        /// <summary>
        /// Elimina un registro en la base de datos
        /// </summary>
        /// <param name="id_checador">Id del checador a eliminar.</param>
        public void Eliminar(int id_checador)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;

                oCommand.CommandText =
                    string.Format(@"DELETE FROM checadores WHERE id_checador = {0}", id_checador);
                oCommand.ExecuteNonQuery();

                oConnection.Close();
            }
            catch (Exception ex)
            {
                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();

                oAdapter = null; oCommand = null; oConnection = null;
                GC.Collect();

                throw ex;
            }

            oAdapter = null; oCommand = null; oConnection = null;
            GC.Collect();
        }

        /// <summary>
        /// Modifica un objeto Checadores en la base de datos
        /// </summary>
        /// <param name="oChecadores"></param>
        public void Modificar(Checadores oChecadores)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;

                oCommand.CommandText =
                    string.Format(@"UPDATE checadores 
                                       SET descripcion = '{0}', base_de_datos = '{1}'
                                     WHERE id_checador = {2}",
                                         oChecadores.descripcion, oChecadores.base_de_datos,
                                         oChecadores.id_checador);
                oCommand.ExecuteNonQuery();

                oConnection.Close();
            }
            catch (Exception ex)
            {
                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();

                oAdapter = null; oCommand = null; oConnection = null;
                GC.Collect();

                throw ex;
            }

            oAdapter = null; oCommand = null; oConnection = null;
            GC.Collect();
        }
    }
}
