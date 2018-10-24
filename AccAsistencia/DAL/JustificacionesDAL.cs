using System;
using System.Collections.Generic;
using System.Data;
using AccAsistencia.Utilerias;
using MySql.Data.MySqlClient;

namespace AccAsistencia.DAL
{
    public class JustificacionesDAL : GenericDAL
    {
        public JustificacionesDAL(): base()
        {
 
        }

        public List<Justificacion> ObtenerJustificaciones(int id_interno, DateTime dtInicial, DateTime dtFinal)
        {
            List<Justificacion> lstJustificaciones = new List<Justificacion>();

            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                        string.Format(@"SELECT 
                                            id_justificacion,
                                            id_interno,
                                            fecha_hora,
                                            detalle,
                                            autorizado_por,
	                                        c.clave,
	                                        c.descripcion
                                        FROM
                                            justificaciones j
                                                INNER JOIN
                                            conceptos c ON j.clave_concepto = c.clave
                                        WHERE
	                                        id_interno = {0}
	                                        AND 
	                                        fecha_hora BETWEEN '{1}' AND '{2}'"
                                            , id_interno
                                            , dtInicial.ToString("yyyy-MM-dd")
                                            , dtFinal.ToString("yyyy-MM-dd"));

                DataTable DT_Checadas = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Checadas);

                Justificacion oJustificacion;
                foreach (DataRow row in DT_Checadas.Rows)
                {
                    oJustificacion = new Justificacion();
                    oJustificacion.id_justificacion = Convert.ToInt32(row["id_justificacion"]);
                    oJustificacion.id_interno = Convert.ToInt32(row["id_interno"]);
                    oJustificacion.fecha_hora = Convert.ToDateTime(row["fecha_hora"]);
                    oJustificacion.detalle = Convert.ToString(row["detalle"]);
                    oJustificacion.autorizado_por = Convert.ToString(row["autorizado_por"]);
                    oJustificacion.oConcepto = new Concepto();
                    oJustificacion.oConcepto.clave = Convert.ToString(row["clave"]);
                    oJustificacion.oConcepto.descripcion = Convert.ToString(row["descripcion"]);
                    lstJustificaciones.Add(oJustificacion);
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

            return lstJustificaciones;
        }

        public void GuardarJustificacion(Justificacion pJustificacion)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"INSERT INTO justificaciones
                                        (id_interno, fecha_hora,
                                         detalle, clave_concepto,
                                         autorizado_por)
                                    VALUES
                                        ({0}, '{1}', '{2}', '{3}', '{4}')",
                                        pJustificacion.id_interno,
                                        pJustificacion.fecha_hora.ToString("yyyy/MM/dd HH:mm"),
                                        pJustificacion.detalle,
                                        pJustificacion.oConcepto.clave,
                                        pJustificacion.autorizado_por);

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

        private int GuardarDiaInhabil(VacacionFeriado pVacacionFeriado)
        {
            try
            {      
                int id_dia_inhabil = ObtenerUltimoID() + 1;

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"INSERT INTO dias_inhabiles
                                        (id_dia_inhabil, motivo, descripcion, fecha)
                                    VALUES
                                        ({0}, '{1}', '{2}', '{3}')",
                                        id_dia_inhabil,
                                        pVacacionFeriado.concepto,
                                        pVacacionFeriado.descripcion,
                                        pVacacionFeriado.fecha.ToString("yyyy-MM-dd"));
                oCommand.ExecuteNonQuery();

                return id_dia_inhabil;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        
        public void GuardarVacacionFeriado(List<Empleado> lista, VacacionFeriado feriado)
        {
            try
            {
                if ((lista != null) && (feriado != null))
                {
                    oConnection.ConnectionString = getConnectionString();
                    oConnection.Open();
                    oCommand.Connection = oConnection;
                    oCommand.Transaction = oConnection.BeginTransaction();

                    int id_dia_inhabil = GuardarDiaInhabil(feriado);

                    foreach (Empleado e in lista)
                    {
                        try
                        {
                            oCommand.CommandText =
                                string.Format(@"INSERT INTO empleados_dias_inhabiles
                                                    (id_interno, id_dia_inhabil)
                                                VALUES
                                                    ({0}, {1})",
                                                    e.id_interno, id_dia_inhabil);
                            oCommand.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.Contains("Duplicate entry"))
                            {
                                continue;
                            }
                            else
                            {
                                throw ex;
                            }
                        }
                    }
                }

                oCommand.Transaction.Commit();
            }
            catch (Exception e)
            {
                if (oCommand.Transaction != null)
                {
                    oCommand.Transaction.Rollback();
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

        public List<VacacionFeriado> ObtenerFeriados(int id_interno, DateTime dtInicial, DateTime dtFinal)
        {
            List<VacacionFeriado> lstFeriados = new List<VacacionFeriado>();
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                        string.Format(@"SELECT 
                                            di.id_dia_inhabil, di.fecha,
                                            di.motivo, di.descripcion
                                        FROM
                                            dias_inhabiles di
                                                INNER JOIN
                                            empleados_dias_inhabiles edi 
                                                ON di.id_dia_inhabil = edi.id_dia_inhabil
                                        WHERE
                                            edi.id_interno = {0}
                                            and fecha Between '{1}' And '{2}';"
                                            , id_interno
                                            , dtInicial.ToString("yyyy-MM-dd")
                                            , dtFinal.ToString("yyyy-MM-dd"));

                DataTable DT_Vacacion = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Vacacion);

                VacacionFeriado oVacacion;
                foreach (DataRow row in DT_Vacacion.Rows)
                {
                    oVacacion = new VacacionFeriado();
                    oVacacion.id_interno = id_interno;
                    oVacacion.fecha = Convert.ToDateTime(row["fecha"]);
                    oVacacion.concepto = Convert.ToString(row["motivo"]);
                    oVacacion.descripcion = Convert.ToString(row["descripcion"]);
                    lstFeriados.Add(oVacacion);
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
            return lstFeriados;
        }

        private int ObtenerUltimoID()
        {            
            int ID = -1;

            try
            {
                oCommand.Connection = oConnection;
                oCommand.CommandText = "SELECT IFNULL(MAX(id_dia_inhabil), 0) AS id_dia_inhabil FROM dias_inhabiles";
                object obj = oCommand.ExecuteScalar();
                ID = Convert.ToInt32(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ID;
        }

        public List<VacacionFeriado> ObtenerDiaFeriado()
        {
            List<VacacionFeriado> lstFeriados = new List<VacacionFeriado>();
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                        string.Format(@"SELECT 	id_dia_inhabil, 
		                                        fecha,
		                                        motivo 
                                        FROM dias_inhabiles");

                DataTable DT_Vacacion = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Vacacion);

                VacacionFeriado oVacacion;
                foreach (DataRow row in DT_Vacacion.Rows)
                {
                    oVacacion = new VacacionFeriado();
                    oVacacion.id_feriado = Convert.ToInt32(row["id_dia_inhabil"]);
                    oVacacion.fecha = Convert.ToDateTime(row["fecha"]);
                    oVacacion.concepto = Convert.ToString(row["motivo"]);;
                    lstFeriados.Add(oVacacion);
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
            return lstFeriados;
        }

        public void PermisoLaboral(int id_empleado, DateTime fecha)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.Transaction = oConnection.BeginTransaction();

                oCommand.CommandText = 
                    string.Format(@"SELECT 
                                        di.id_dia_inhabil
                                    FROM
                                        dias_inhabiles di
                                            INNER JOIN
                                        empleados_dias_inhabiles edi ON di.id_dia_inhabil = edi.id_dia_inhabil
                                    WHERE
                                        fecha = '{0}'
                                            AND id_interno = {1}", fecha.ToString("yyyy-MM-dd"), id_empleado);
                int id_dia_inhabil = Convert.ToInt32(oCommand.ExecuteScalar());

                oCommand.CommandText =
                    string.Format(@"DELETE
                                        FROM
                                            empleados_dias_inhabiles
                                        WHERE
                                            id_dia_inhabil = {1}
                                                AND id_interno = {0}",
                                        id_empleado, id_dia_inhabil);
                oCommand.ExecuteNonQuery();
                oCommand.Transaction.Commit();

            }
            catch (Exception ex)
            {
                if (oCommand.Transaction != null)
                {
                    oCommand.Transaction.Rollback();
                }

                throw ex;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }
        }
    }
}
