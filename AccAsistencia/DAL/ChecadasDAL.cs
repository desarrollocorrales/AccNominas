using System;
using System.Collections.Generic;
using System.Data;
using AccAsistencia.Utilerias;
using MySql.Data.MySqlClient;
using AccSettings;
using System.Text;

namespace AccAsistencia.DAL
{
    public class ChecadasDAL : GenericDAL
    {
        public ChecadasDAL(): base()
        {

        }

        public List<Checada> ObtenerChecadasSinConcepto()
        {
            oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
            oConnection.Open();

            oCommand.Connection = oConnection;
            oCommand.CommandText =
                    @"SELECT 
                        id_interno, 
                        fecha_hora, 
                        clave_concepto
                    FROM
                        checadas
                    WHERE 
	                    clave_concepto IS NULL 
                        OR clave_concepto = ''";


            DataTable DT_Checadas = new DataTable();
            LogManager.AgregarLog("Inicia descarga de checadas...");
            oAdapter.SelectCommand = oCommand;
            oAdapter.Fill(DT_Checadas);
            LogManager.AgregarLog("Se llenó el DataTable...");

            Checada oChecada;
            List<Checada> lstChecadas = new List<Checada>();

            LogManager.AgregarLog("Inicia transformacion a Lista...");
            foreach (DataRow row in DT_Checadas.Rows)
            {
                oChecada = new Checada();
                oChecada.id_interno = Convert.ToInt32(row["id_interno"]);
                oChecada.fecha_hora = Convert.ToDateTime(row["fecha_hora"]);
                oChecada.oConcepto = new Concepto();
                lstChecadas.Add(oChecada);
            }
            LogManager.AgregarLog("Termina transformación a Lista...");
            LogManager.AgregarLog("Termina descarga de checadas...");

            if (oConnection.State != ConnectionState.Closed)
                oConnection.Close();

            LogManager.AgregarLog("Termina correctamente rutina ObtenerChecadasSinConcepto() - ChecadasDAL");
            return lstChecadas;
        }

        public int ActualizarConceptosChecadas(List<Checada> LstChecadas)
        {
            MensajeGlobal.Texto = "ChecadasDAL - ActualizarConceptosChecadas()";
            LogManager.AgregarLog("Inicia rutina ActualizarConceptosChecadas() - ChecadasDAL");

            MySqlCommand oCommand = new MySqlCommand();
            MySqlConnection oConnection = new MySqlConnection();
            oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
            oConnection.Open();

            int rows = 0;
            oCommand.Connection = oConnection;
            oCommand.Transaction = oConnection.BeginTransaction();
            foreach (Checada oChecada in LstChecadas)
            {
                if (String.IsNullOrEmpty(oChecada.oConcepto.clave))
                {
                    oChecada.oConcepto.clave = "INV";
                }

                oCommand.CommandText =
                        string.Format(@"UPDATE checadas 
                                           SET clave_concepto = '{0}' 
                                         WHERE id_interno = {1} 
                                           AND fecha_hora = '{2}'",
                                               oChecada.oConcepto.clave,
                                               oChecada.id_interno,
                                               oChecada.fecha_hora.ToString("yyyy-MM-dd HH:mm:ss"));
                rows += oCommand.ExecuteNonQuery();
            }

            if (rows == LstChecadas.Count)
            {
                oCommand.Transaction.Commit();
            }
            else
            {
                oCommand.Transaction.Rollback();
            }

            if (oConnection.State != ConnectionState.Closed)
                oConnection.Close();

            LogManager.AgregarLog("Termina correctamente rutina ActualizarChecadas() - ChecadasDAL");
            return rows;
        }

        public void ActualizarChecada(Checada oChecada)
        {
            try
            {
                if (String.IsNullOrEmpty(oChecada.oConcepto.clave))
                {
                    oChecada.oConcepto.clave = "INV";
                }
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                        string.Format(@"UPDATE checadas 
                                           SET clave_concepto = '{0}' 
                                         WHERE id_interno = {1} 
                                               AND fecha_hora = '{2}'",
                                               oChecada.oConcepto.clave,
                                               oChecada.id_interno,
                                               oChecada.fecha_hora.ToString("yyyy-MM-dd HH:mm:ss"));
                oCommand.ExecuteNonQuery();                
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }
        }

        public List<Checada> ObtenerChecadas(int id_interno, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Checada> lstChecadas = new List<Checada>();
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"SELECT 
                                        id_interno, fecha_hora, clave, descripcion
                                    FROM
                                        checadas ch
                                            LEFT JOIN
                                        conceptos c ON ch.clave_concepto = c.clave
                                    WHERE 
	                                    id_interno = {0}
	                                    AND fecha_hora BETWEEN '{1}' AND '{2}'"
                                            , id_interno
                                            , fechaInicial.ToString("yyyy-MM-dd")
                                            , fechaFinal.ToString("yyyy-MM-dd"));

                DataTable DT_Checadas = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Checadas);

                Checada oChecada;

                foreach (DataRow row in DT_Checadas.Rows)
                {
                    oChecada = new Checada();
                    oChecada.id_interno = Convert.ToInt32(row["id_interno"]);
                    oChecada.fecha_hora = Convert.ToDateTime(row["fecha_hora"]);
                    oChecada.oConcepto = new Concepto();
                    oChecada.oConcepto.clave = Convert.ToString(row["clave"]);
                    oChecada.oConcepto.descripcion = Convert.ToString(row["descripcion"]);
                    lstChecadas.Add(oChecada);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }

            return lstChecadas;
        }

        public int MinutosExcedido(int id_interno, DateTime fechaInicial, DateTime fechaFinal)
        {
            int resultado = 0;
            string fi = fechaInicial.ToString("yyyy-MM-dd");
            string ff = fechaFinal.ToString("yyyy-MM-dd");
            try{
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText = string.Format(@"SELECT SUM(minutos) excedido FROM (SELECT TIMESTAMPDIFF(minute,STR_TO_DATE(concat(DATE_FORMAT(fecha_hora,'%Y-%m-%d'), ' 08:15:00'),'%Y-%m-%d %H:%i:%S'), fecha_hora) minutos FROM checadas ch LEFT JOIN conceptos c ON ch.clave_concepto = c.clave WHERE id_interno = {0} AND fecha_hora BETWEEN DATE_FORMAT('{1}','%Y-%m-%d')  AND DATE_FORMAT('{2}','%Y-%m-%d') AND clave = 'ET') x WHERE minutos > 0", id_interno, fi, ff);

                DataTable DT_Checadas = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Checadas);

                foreach (DataRow row in DT_Checadas.Rows)
                {
                    if (row["excedido"].ToString() != string.Empty)
                        resultado = Convert.ToInt32(row["excedido"]);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }

            return resultado;
        }

        public List<Checada> ObtenerChecadasTodosChecadores(int id_interno, DateTime fechaInicial, DateTime fechaFinal)
        {
            List<Checada> lstChecadas = new List<Checada>();
            try
            {
                List<EmpleadoChecador> lstEmpCheca = ObtenerRelacionEmpleadoChecadores(id_interno);
                string ConsultaUnion = obtenerConsultaUnion(lstEmpCheca, fechaInicial, fechaFinal);

                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText = ConsultaUnion;

                DataTable DT_Checadas = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Checadas);

                Checada oChecada;

                foreach (DataRow row in DT_Checadas.Rows)
                {
                    oChecada = new Checada();
                    oChecada.id_interno = Convert.ToInt32(row["id_interno"]);
                    oChecada.fecha_hora = Convert.ToDateTime(row["fecha_hora"]);
                    oChecada.oConcepto = new Concepto();
                    oChecada.oConcepto.clave = Convert.ToString(row["clave"]);
                    oChecada.oConcepto.descripcion = Convert.ToString(row["descripcion"]);
                    oChecada.lugar = Convert.ToString(row["lugar"]);
                    lstChecadas.Add(oChecada);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }

            return lstChecadas;
        }

        public List<Checada> ObtenerChecadasReales(int id_interno, DateTime fechaInicial, DateTime fechaFinal)
        {
            Checada oChecada;
            List<Checada> lstChecadas = new List<Checada>();

            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"SELECT 
                                        id_interno, fecha_hora,
                                        '{0}' AS lugar
                                    FROM
                                        checadas ch
                                    WHERE 
	                                    id_interno = {1} AND fecha_hora BETWEEN '{2}' AND '{3}'"
                                        , Configuracion.oChecador.Nombre
                                        , id_interno
                                        , fechaInicial.ToString("yyyy-MM-dd")
                                        , fechaFinal.ToString("yyyy-MM-dd"));

                DataTable DT_Checadas = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Checadas);

                foreach (DataRow row in DT_Checadas.Rows)
                {
                    oChecada = new Checada();
                    oChecada.id_interno = Convert.ToInt32(row["id_interno"]);
                    oChecada.fecha_hora = Convert.ToDateTime(row["fecha_hora"]);
                    oChecada.lugar = Convert.ToString(row["lugar"]);
                    lstChecadas.Add(oChecada);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }

            return lstChecadas;
        }
        
        public void BorrarConceptosChecadas(int id_interno, DateTime fechaInicial, DateTime fechaFinal)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"UPDATE 
                                        checadas ch
                                    SET 
                                        clave_concepto = null
                                    WHERE 
	                                    id_interno = {0} AND fecha_hora BETWEEN '{1}' AND '{2}'"
                                        , id_interno
                                        , fechaInicial.ToString("yyyy-MM-dd")
                                        , fechaFinal.ToString("yyyy-MM-dd"));
                oCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }

                throw e;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }
        }

        private string obtenerConsultaUnion(List<EmpleadoChecador> lstEmpCheca, DateTime fechaInicial, DateTime fechaFinal)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lstEmpCheca.Count; i++)
            {
                sb.Append("SELECT '" + lstEmpCheca[i].sChecador + "' AS lugar, id_interno, fecha_hora, clave, descripcion" + Environment.NewLine);
                sb.Append("FROM " + lstEmpCheca[i].nombre_bd + ".checadas ch LEFT JOIN conceptos c ON ch.clave_concepto = c.clave" + Environment.NewLine);
                sb.Append("WHERE id_interno = " + lstEmpCheca[i].id_interno);
                sb.Append("      AND fecha_hora ");
                sb.Append("BETWEEN '" + fechaInicial.ToString("yyyy-MM-dd") + "' AND '" + fechaFinal.ToString("yyyy-MM-dd") + "'" + Environment.NewLine);

                if (i != (lstEmpCheca.Count - 1))
                {
                    sb.Append("UNION" + Environment.NewLine);
                }
            }

            return sb.ToString();
        }

        private List<EmpleadoChecador> ObtenerRelacionEmpleadoChecadores(int id_empleado)
        {
            List<EmpleadoChecador> lstEmpleadoChecadores = new List<EmpleadoChecador>();
            MySqlConnection myConn = new MySqlConnection();
            try
            {
                StringBuilder sbStringConn = new StringBuilder();
                sbStringConn.Append(string.Format("Server={0};", oServidor.Host));
                sbStringConn.Append(string.Format("Port={0};", oServidor.Puerto));
                sbStringConn.Append(string.Format("Uid={0};", oServidor.Usuario));
                sbStringConn.Append(string.Format("Pwd={0};", oServidor.Pwd));
                myConn.ConnectionString = sbStringConn.ToString();
                myConn.Open();
                oCommand.Connection = myConn;
                oCommand.CommandText =
                    @"SELECT 
                            ec.id_empleado,
                            ec.id_checador,
                            ec.id_interno,
                            c.base_de_datos,
                            c.descripcion
                        FROM
                            corrales_checadores.empleados_checadores ec
                                Inner Join
                            corrales_checadores.checadores c ON ec.id_checador = c.id_checador
                        WHERE
                            id_empleado = " + id_empleado;
                DataTable DT_EmpleadosChecadores = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_EmpleadosChecadores);

                EmpleadoChecador oEmpChec;
                foreach(DataRow row in DT_EmpleadosChecadores.Rows)
                {
                    oEmpChec = new EmpleadoChecador();
                    oEmpChec.id_empleado = Convert.ToInt32(row["id_empleado"]);
                    oEmpChec.id_checador = Convert.ToInt32(row["id_checador"]);
                    oEmpChec.id_interno = Convert.ToInt32(row["id_interno"]);
                    oEmpChec.nombre_bd = Convert.ToString(row["base_de_datos"]);
                    oEmpChec.sChecador = Convert.ToString(row["descripcion"]);
                    lstEmpleadoChecadores.Add(oEmpChec);
                }
            }
            catch (Exception e)
            {
                LogManager.AgregarLog(e.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            return lstEmpleadoChecadores;
        }

        public DataTable ObtenerChecadasSelectivas(DateTime fecha)
        {
            DataTable Resultado = new DataTable();
            MySqlConnection myConn = new MySqlConnection();
            try
            {
                StringBuilder sbStringConn = new StringBuilder();
                sbStringConn.Append(string.Format("Server={0};", oServidor.Host));
                sbStringConn.Append(string.Format("Port={0};", oServidor.Puerto));
                sbStringConn.Append(string.Format("Uid={0};", oServidor.Usuario));
                sbStringConn.Append(string.Format("Pwd={0};", oServidor.Pwd));
                sbStringConn.Append(string.Format("Database={0};", oChecador.DataBase));
                myConn.ConnectionString = sbStringConn.ToString();
                myConn.Open();
                oCommand.Connection = myConn;
                oCommand.CommandText =
                    string.Format(
                    @"SELECT 
                            empleados.id_interno, 
                            empleados.nombre, 
                            checadas.fecha_hora
                        FROM
                            checadas
                                INNER JOIN
                            empleados ON checadas.id_interno = empleados.id_interno
                       WHERE
                            fecha_hora between '{0}' AND '{1}'
                    ORDER BY empleados.nombre", 
                            fecha.ToString("yyyy-MM-dd"), 
                            fecha.AddDays(1).ToString("yyyy-MM-dd"));
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(Resultado);
            }
            catch (Exception e)
            {
                LogManager.AgregarLog(e.Message);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            return Resultado;
        }

        // obtiene las checadas
        public List<Checadas> getChecadas(string fechaIni, string fechaFin, int id_interno = 0, int Iddepto = 0, int numChec = 0)
        {
            List<Checadas> result = new List<Checadas>();
            Checadas ent;

            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;

                if (Iddepto > 0)
                {
                    if (id_interno == -1)
                    {
                        oCommand.CommandText =
                    string.Format(@"SELECT c.id_interno, c.fecha_hora, c.no_checador, e.nombre as empleado, e.id_depto, d.nombre as departamento FROM checadas c LEFT JOIN empleados e on (c.id_interno = e.id_interno) LEFT JOIN departamentos d on (e.id_depto = d.id) WHERE fecha_hora BETWEEN '{0}' AND '{1}' AND e.id_depto = {2}"
                    , fechaIni, fechaFin, Iddepto);
                    }
                    else
                    {
                        oCommand.CommandText =
                    string.Format(@"SELECT c.id_interno, c.fecha_hora, c.no_checador, e.nombre as empleado, e.id_depto, d.nombre as departamento FROM checadas c LEFT JOIN empleados e on (c.id_interno = e.id_interno) LEFT JOIN departamentos d on (e.id_depto = d.id) WHERE c.id_interno = {0} AND fecha_hora BETWEEN '{1}' AND '{2}' AND e.id_depto = {3}"
                    , id_interno, fechaIni, fechaFin, Iddepto);
                    }

                }
                else
                {
                    if (id_interno == -1)
                    {
                        oCommand.CommandText =
    string.Format(@"SELECT c.id_interno, c.fecha_hora, c.no_checador, e.nombre as empleado, e.id_depto, d.nombre as departamento FROM checadas c LEFT JOIN empleados e on (c.id_interno = e.id_interno) LEFT JOIN departamentos d on (e.id_depto = d.id) WHERE fecha_hora BETWEEN '{0}' AND '{1}'"
                        , fechaIni, fechaFin);
                    }
                    else
                    {
                        oCommand.CommandText =
    string.Format(@"SELECT c.id_interno, c.fecha_hora, c.no_checador, e.nombre as empleado, e.id_depto, d.nombre as departamento FROM checadas c LEFT JOIN empleados e on (c.id_interno = e.id_interno) LEFT JOIN departamentos d on (e.id_depto = d.id) WHERE c.id_interno = {0} AND fecha_hora BETWEEN '{1}' AND '{2}' "
                        ,id_interno, fechaIni, fechaFin);
                    }

                }
                

                DataTable DT_Checadas = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Checadas);

                foreach (DataRow res in DT_Checadas.Rows)
                {
                    ent = new Checadas();
                    ent.idInterno = Convert.ToInt32(res["id_interno"]);
                    ent.fechaHora = Convert.ToDateTime(res["fecha_hora"]).ToString("yyyy/MM/dd HH:mm:ss");
                    ent.empleado = Convert.ToString(res["empleado"]);
                    ent.idDepto = Convert.ToInt16(res["id_depto"]);
                    ent.departamento = Convert.ToString(res["departamento"]);

                    result.Add(ent);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }

            return result;
        }
    }
}
