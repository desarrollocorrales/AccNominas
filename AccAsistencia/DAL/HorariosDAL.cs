using System;
using System.Collections.Generic;
using System.Data;
using AccAsistencia.Utilerias;
using MySql.Data.MySqlClient;

namespace AccAsistencia.DAL
{
    public class HorarioDAL : GenericDAL
    {
        public HorarioDAL():base()
        {

        }

        /// <summary>
        /// Obtiene todos los horarios
        /// </summary>
        /// <returns>Lista con todos los horarios</returns>
        public List<Horario> ObtenerHorarios()
        {
            oConnection.ConnectionString = getConnectionString();
            oConnection.Open();

            List<HorariosDetalles> ListaTodosLosDetalles = ObtenerTodosLosDetalles();

            oCommand.Connection = oConnection;
            oCommand.CommandText =
                    string.Format(@"SELECT 
                                        id_horario, 
                                        descripcion, 
                                        dias_que_aplica, 
                                        fecha_actualizacion, 
                                        dia_siguiente
                                    FROM
                                        horarios
                                    WHERE
                                        activo = 1");

            DataTable DT_Checadas = new DataTable();
            oAdapter.SelectCommand = oCommand;
            oAdapter.Fill(DT_Checadas);

            Horario oHorarios;
            List<Horario> lstHorarios = new List<Horario>();

            foreach (DataRow row in DT_Checadas.Rows)
            {
                oHorarios = new Horario();
                oHorarios.id_horario = Convert.ToInt32(row["id_horario"]);
                oHorarios.descripcion = Convert.ToString(row["descripcion"]);
                oHorarios.dias_que_aplica = Convert.ToString(row["dias_que_aplica"]);
                oHorarios.fecha_actualizacion = Convert.ToDateTime(row["fecha_actualizacion"]);
                oHorarios.checa_dia_siguiente = Convert.ToBoolean(row["dia_siguiente"]);
                oHorarios.lstDetalles = new List<HorariosDetalles>();
                oHorarios.lstDetalles.AddRange(ListaTodosLosDetalles.FindAll(o => o.id_horario == oHorarios.id_horario));
                lstHorarios.Add(oHorarios);
            }

            if (oConnection.State != ConnectionState.Closed)
                oConnection.Close();

            LogManager.AgregarLog(" - Termina correctamente rutina ObtenerHorarios() - Horarios DAL -");
            return lstHorarios;
        }

        private List<HorariosDetalles> ObtenerTodosLosDetalles()
        {
            HorariosDetalles oDetalles;
            List<HorariosDetalles> lstDetalles = new List<HorariosDetalles>();
            try
            {
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"SELECT 
                                    id_detalle,
                                    id_horario,
                                    c.clave,
	                                c.descripcion,
                                    hora_minima,
                                    hora_checada,
                                    hora_maxima
                                FROM
                                    horarios_detalles hd
                                        LEFT JOIN
                                    conceptos c ON hd.clave_concepto = c.clave");

                oAdapter.SelectCommand = oCommand;

                DataTable DT_Detalles = new DataTable();
                oAdapter.Fill(DT_Detalles);

                foreach (DataRow row in DT_Detalles.Rows)
                {
                    oDetalles = new HorariosDetalles();
                    oDetalles.id_detalle = Convert.ToInt32(row["id_detalle"]);
                    oDetalles.id_horario = Convert.ToInt32(row["id_horario"]);
                    oDetalles.oConcepto = new Concepto();
                    oDetalles.oConcepto.clave = Convert.ToString(row["clave"]);
                    oDetalles.oConcepto.descripcion = Convert.ToString(row["descripcion"]);
                    oDetalles.hora_minima = (TimeSpan)row["hora_minima"];
                    if (row["hora_checada"].Equals(DBNull.Value) == false)
                    {
                        oDetalles.hora_checada = (TimeSpan)row["hora_checada"];
                    }
                    oDetalles.hora_maxima = (TimeSpan)row["hora_maxima"];
                    lstDetalles.Add(oDetalles);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return lstDetalles;
        }

        public int ObtenerUltimoID()
        {
            int ID = -1;
            oConnection.ConnectionString = getConnectionString();
            oConnection.Open();

            oCommand.Connection = oConnection;
            oCommand.CommandText = "SELECT MAX(id_horario) AS id_horario FROM horarios";
            object obj = oCommand.ExecuteScalar();
            if (obj != null)
            {
                ID = Convert.ToInt32(obj);
            }

            if (oConnection.State != ConnectionState.Closed)
                oConnection.Close();

            return ID;
        }

        public void GuardarHorario(Horario oHorario)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.Transaction = oConnection.BeginTransaction();

                oCommand.CommandText =
                    string.Format(@"INSERT INTO 
                                        horarios (descripcion, dias_que_aplica, dias_que_no_aplica,
                                                  fecha_actualizacion, dia_siguiente) 
                                    VALUES ('{0}', '{1}', '{2}', '{3}', {4})",
                                    oHorario.descripcion,
                                    oHorario.dias_que_aplica,
                                    oHorario.dias_que_no_aplica,
                                    oHorario.fecha_actualizacion.ToString("yyyy-MM-dd HH:mm"),
                                    Convert.ToInt32(oHorario.checa_dia_siguiente));
                oCommand.ExecuteNonQuery();
                
                oCommand.CommandText = "SELECT LAST_INSERT_ID()";
                int id_horario = Convert.ToInt32(oCommand.ExecuteScalar());
                
                int id_detalle = 0;
                foreach (HorariosDetalles oDetalle in oHorario.lstDetalles)
                {
                    id_detalle++;
                    if (oDetalle.hora_checada.HasValue)
                    {
                        //*** Tiene Hora de Checada
                        oCommand.CommandText =
                        string.Format(@"INSERT INTO horarios_detalles
                                            (id_detalle, id_horario, clave_concepto, hora_minima, hora_maxima, hora_checada)
                                        VALUES
                                            ( {0} ,{1}, '{2}', {3}, {4}, {5})",
                                            id_detalle,
                                            id_horario,
                                            oDetalle.oConcepto.clave,
                                            ("'" + oDetalle.hora_minima + "'"),
                                            ("'" + oDetalle.hora_maxima + "'"),
                                            ("'" + oDetalle.hora_checada + "'"));
                    }
                    else
                    {
                        //*** NO tiene hora de checada
                        oCommand.CommandText =
                        string.Format(@"INSERT INTO horarios_detalles
                                            (id_detalle, id_horario, clave_concepto, hora_minima, hora_maxima)
                                        VALUES
                                            ({0}, {1}, '{2}', {3}, {4})",
                                            id_detalle,
                                            id_horario,
                                            oDetalle.oConcepto.clave,
                                            ("'" + oDetalle.hora_minima + "'"),
                                            ("'" + oDetalle.hora_maxima + "'"));
                    }
                    oCommand.ExecuteNonQuery();
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

        public void ModificarHorario(Horario oHorario)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.Transaction = oConnection.BeginTransaction();

                oCommand.CommandText =
                    string.Format(@"UPDATE horarios 
                                    SET 
                                        descripcion = '{0}',
                                        dias_que_aplica = '{1}',
                                        dias_que_no_aplica = '{2}',
                                        fecha_actualizacion = '{3}',
                                        dia_siguiente = {4}
                                    WHERE
                                        id_horario = {5};",
                                    oHorario.descripcion,
                                    oHorario.dias_que_aplica,
                                    oHorario.dias_que_no_aplica,
                                    oHorario.fecha_actualizacion.ToString("yyyy-MM-dd HH:mm"),
                                    Convert.ToInt32(oHorario.checa_dia_siguiente),
                                    oHorario.id_horario);
                oCommand.ExecuteNonQuery();
                
                BorrarDetalles(oHorario);

                int id_detalle = 0;
                foreach (HorariosDetalles oDetalle in oHorario.lstDetalles)
                {
                    id_detalle++;
                    if (oDetalle.hora_checada.HasValue)
                    {
                        //*** Tiene Hora de Checada
                        oCommand.CommandText =
                           string.Format(@"INSERT INTO horarios_detalles
                                                (id_detalle, id_horario, clave_concepto,
                                                hora_minima, hora_maxima, hora_checada)
                                           VALUES
                                                ({0}, {1}, '{2}', {3}, {4}, {5})",
                                                id_detalle,
                                                oHorario.id_horario,
                                                oDetalle.oConcepto.clave,
                                                ("'" + oDetalle.hora_minima + "'"),
                                                ("'" + oDetalle.hora_maxima + "'"),
                                                ("'" + oDetalle.hora_checada + "'"));
                    }
                    else
                    {
                        //*** NO tiene hora de checada
                        oCommand.CommandText =
                            string.Format(@"INSERT INTO horarios_detalles
                                                (id_detalle, id_horario, clave_concepto,
                                                hora_minima, hora_maxima)
                                            VALUES
                                                ({0}, {1}, '{2}', {3}, {4})",
                                                id_detalle,
                                                oHorario.id_horario,
                                                oDetalle.oConcepto.clave,
                                                ("'" + oDetalle.hora_minima + "'"),
                                                ("'" + oDetalle.hora_maxima + "'"));
                    }

                    oCommand.ExecuteNonQuery();
                }

                oCommand.Transaction.Commit();
            }
            catch
            {
                if (oCommand.Transaction != null)
                {
                    oCommand.Transaction.Rollback();
                }

                throw;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }
        }

        private void BorrarDetalles(Horario pHorario)
        {
            oCommand.CommandText = string.Format(@"DELETE FROM horarios_detalles WHERE id_horario = {0}", pHorario.id_horario);
            oCommand.ExecuteNonQuery();
        }
        
        /// <summary>
        /// Asigna un horario a una lista de empleados.
        /// </summary>
        /// <param name="lstEmp">Lista de empleados</param>
        /// <param name="h">Horario a asignar</param>
        public void AsignarHorario(List<Empleado> lstEmp, HorarioVigencia h)
        {
            try
            {
                int prioridad=0;
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;

                if ((lstEmp != null) && (h != null))
                {
                    oCommand.Transaction = oConnection.BeginTransaction();

                    foreach (Empleado e in lstEmp)
                    {
                        try
                        {

                            oCommand.CommandText = @"SELECT IFNULL(MAX(prioridad), 0)
                                                       FROM empleados_horarios 
                                                      WHERE id_empleado=" + e.id_interno;
                            prioridad = Convert.ToInt32(oCommand.ExecuteScalar());
                            prioridad++;

                            oCommand.CommandText =
                                string.Format(@"INSERT INTO 
                                                    empleados_horarios
                                                    (id_empleado, id_horario,
                                                     vigencia_inicio, vigencia_fin,
                                                     prioridad)
                                                VALUES
                                                    ({0}, {1}, '{2}', '{3}', {4})",
                                                    e.id_interno, h.id_horario,
                                                    h.vigencia_inicio.ToString("yyyy-MM-dd"),
                                                    h.vigencia_fin.ToString("yyyy-MM-dd"),
                                                    prioridad);
                            oCommand.ExecuteNonQuery();
                            oCommand.CommandText =
                                string.Format(@"INSERT INTO 
                                                    bitacora_horarios
                                                    (id_interno, id_horario, fecha)
                                                VALUES
                                                    ({0}, {1},'{2}')",
                                                    e.id_interno, h.id_horario, DateTime.Now.ToString("yyy-MM-dd hh:mm:ss"));
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

        /// <summary>
        /// Elimina las entradas de horarios para un empleado dado
        /// </summary>
        /// <param name="e">Objeto empleado</param>
        /// <param name="h">Objeto Horario a desasignar</param>
        public void DesasignarHorario(Empleado e, HorarioVigencia h)
        {
            try
            {
                if ((e != null) && (h != null))
                {
                    oConnection.ConnectionString = getConnectionString();
                    oConnection.Open();
                    oCommand.Connection = oConnection;
                    oCommand.Transaction = oConnection.BeginTransaction();
                    oCommand.CommandText =
                        string.Format(@"DELETE
                                        FROM
                                            empleados_horarios
                                        WHERE
                                            id_empleado = {0} 
                                            AND id_horario = {1}
                                            AND prioridad = {2}",
                                            e.id_interno, h.id_horario,
                                            h.prioridad);
                    oCommand.ExecuteNonQuery();
                    oCommand.Transaction.Commit();
                }                
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

        /// <summary>
        /// Regresa una lista con los horarios detallados
        /// </summary>
        /// <returns></returns>
        public List<HorarioGrid> ObtenerHorariosParaGrid()
        {
            List<HorarioGrid> lstHorariosGrid = new List<HorarioGrid>();
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"SELECT 
	                                    b.id_horario,
	                                    c.id_detalle,
                                        b.descripcion AS descripcion,
	                                    d.descripcion AS concepto,
                                        c.hora_minima,
                                        c.hora_checada,
                                        c.hora_maxima,
                                        b.dia_siguiente
                                    FROM
                                        horarios b 
                                            JOIN
                                        horarios_detalles c ON c.id_horario = b.id_horario
                                            JOIN
                                        conceptos d ON d.clave = c.clave_concepto
                                    WHERE b.activo=1 ORDER BY b.id_horario, c.hora_minima");

                DataTable DT_Grid = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Grid);

                HorarioGrid oHorarioGrid;
                foreach (DataRow row in DT_Grid.Rows)
                {
                    oHorarioGrid = new HorarioGrid();
                    oHorarioGrid.id_horario = Convert.ToInt32(row["id_horario"]);
                    oHorarioGrid.id_detalle = Convert.ToInt32(row["id_detalle"]);
                    oHorarioGrid.descripcion = Convert.ToString(row["descripcion"]);
                    oHorarioGrid.concepto = Convert.ToString(row["concepto"]);
                    oHorarioGrid.hora_minima = (TimeSpan)row["hora_minima"];
                    oHorarioGrid.hora_checada = (row["hora_checada"] == DBNull.Value) ? null : (TimeSpan?)row["hora_checada"];
                    oHorarioGrid.hora_maxima = (TimeSpan)row["hora_maxima"];
                    oHorarioGrid.checa_dia_siguiente = Convert.ToBoolean(row["dia_siguiente"]);
                    lstHorariosGrid.Add(oHorarioGrid);
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

            return lstHorariosGrid;
        }

        /// <summary>
        /// Desactiva el horario con el ID especificado
        /// </summary>
        /// <param name="id_horario"></param>
        public void DesactivarHorario(int id_horario)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.Transaction = oConnection.BeginTransaction();
                oCommand.CommandText =
                    @"UPDATE horarios SET activo = 0 WHERE id_horario = " + id_horario;

                oCommand.ExecuteNonQuery();

                oCommand.CommandText =
                    @"DELETE FROM empleados_horarios WHERE id_horario = " + id_horario;
                oCommand.ExecuteNonQuery();
                oCommand.Transaction.Commit();
            }
            catch (Exception e)
            {
                if (oCommand.Transaction != null)
                    oCommand.Transaction.Rollback();

                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();

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

        /// <summary>
        /// Obtiene el horario de la fecha especificada para el empleado especificado
        /// </summary>
        /// <returns></returns>
        public Horario obtenerHorarioDelDia(DateTime dtFecha, int id_interno)
        {
            Horario oHorario = null;
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"SELECT 
                                        h.id_horario,
                                        h.descripcion,
                                        h.dias_que_aplica,
                                        h.dias_que_no_aplica,
                                        h.fecha_actualizacion,
                                        h.dia_siguiente,
                                        h.activo
                                    FROM
                                        empleados_horarios eh
                                            INNER JOIN
                                        horarios h ON eh.id_horario = h.id_horario
                                    WHERE
                                        eh.id_empleado = {0}
                                            AND eh.vigencia_inicio <= '{1}'
                                            AND eh.vigencia_fin >= '{1}'
		                                    AND h.activo = 1
                                            AND SUBSTRING(h.dias_que_aplica, {2} , 1) = 1
                                    ORDER BY eh.prioridad DESC
                                    LIMIT 1",
                                    id_interno,
                                    dtFecha.ToString("yyyy-MM-dd"),
                                    dtFecha.DayOfWeek.GetHashCode() + 1);
                oAdapter = new MySqlDataAdapter();
                oAdapter.SelectCommand = oCommand;

                DataTable databHorario = new DataTable();
                oAdapter.Fill(databHorario);

                if (databHorario.Rows.Count != 0)
                {
                    DataRow row = databHorario.Rows[0];
                    oHorario = new Horario();
                    oHorario.id_horario = Convert.ToInt32(row["id_horario"]);
                    oHorario.descripcion = Convert.ToString(row["descripcion"]);
                    oHorario.dias_que_aplica = Convert.ToString(row["dias_que_aplica"]);
                    oHorario.dias_que_no_aplica = Convert.ToString(row["dias_que_no_aplica"]);
                    oHorario.fecha_actualizacion = Convert.ToDateTime(row["fecha_actualizacion"]);
                    oHorario.checa_dia_siguiente = Convert.ToBoolean(row["dia_siguiente"]);
                    List<HorariosDetalles> lstDetalles = ObtenerTodosLosDetalles();
                    oHorario.lstDetalles = lstDetalles.FindAll(o => o.id_horario == oHorario.id_horario);
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

            return oHorario;
        }

        /// <summary>
        /// Borra todos los horarios asignados a un empleado
        /// </summary>
        /// <param name="id_interno">id interno del empleado</param>
        public void BorrarAsignaciones(int id_interno)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    @"DELETE FROM empleados_horarios WHERE id_empleado = " + id_interno;
                oCommand.ExecuteNonQuery();

                if (oConnection.State != ConnectionState.Closed) 
                    oConnection.Close();
            }
            catch (Exception e)
            {
                if (oConnection.State != ConnectionState.Closed) 
                    oConnection.Close();
                throw e;
            }
        }
    }
}
