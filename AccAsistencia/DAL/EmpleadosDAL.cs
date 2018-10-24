using System;
using System.Collections.Generic;
using System.Data;

using MySql.Data.MySqlClient;

namespace AccAsistencia.DAL
{
    public class EmpleadosDAL : GenericDAL
    {
        #region *** Atributos ***

        private List<Horario> ListaDeTodosLosHorarios;
        private List<EmpleadoHorario> ListaEmpleadosHorarios;

        #endregion

        #region *** Constructores ***

        public EmpleadosDAL():base()
        {

        }

        #endregion

        #region *** Metodos Privados ***

        private List<Horario> ObtenerTodosLosHorarios()
        {
            Horario oHorario;
            List<Horario> lstHorarios = new List<Horario>();

            try
            {
                if (oConnection.State == ConnectionState.Open)
                {
                    /* Obtener todos los horarios sin detalles */
                    oCommand.Connection = oConnection;
                    oCommand.CommandText = string.Format(@"SELECT 
                                                                id_horario, 
                                                                descripcion,
                                                                dias_que_aplica,
                                                                dias_que_no_aplica,
                                                                fecha_actualizacion,
                                                                dia_siguiente
                                                           FROM
                                                                horarios");

                    DataTable DT_Horarios = new DataTable();
                    oAdapter.SelectCommand = oCommand;
                    oAdapter.Fill(DT_Horarios);

                    /* Obtener todos los detalles de horarios */
                    oCommand.CommandText = string.Format(@"SELECT 
                                                               hd.id_detalle,
                                                               hd.id_horario,
                                                               c.clave,
                                                               c.descripcion,
                                                               hd.hora_minima,
                                                               hd.hora_checada,
                                                               hd.hora_maxima
                                                           FROM
                                                               horarios_detalles hd
                                                                   INNER JOIN
                                                               conceptos c ON hd.clave_concepto = c.clave");
                    DataTable DT_Detalles = new DataTable();
                    oAdapter.SelectCommand = oCommand;
                    oAdapter.Fill(DT_Detalles);

                    /* Crear lista de detalles de horairos */
                    List<HorariosDetalles> lstHorariosDetalles = ConvertirALista(DT_Detalles);
                    foreach (DataRow row in DT_Horarios.Rows)
                    {
                        oHorario = new Horario();
                        oHorario.id_horario = Convert.ToInt32(row["id_horario"]);
                        oHorario.descripcion = Convert.ToString(row["descripcion"]);
                        oHorario.dias_que_aplica = Convert.ToString(row["dias_que_aplica"]);
                        oHorario.dias_que_no_aplica = Convert.ToString(row["dias_que_no_aplica"]);
                        oHorario.fecha_actualizacion = Convert.ToDateTime(row["fecha_actualizacion"]);
                        oHorario.checa_dia_siguiente = Convert.ToBoolean(row["dia_siguiente"]);
                        oHorario.lstDetalles = lstHorariosDetalles.FindAll(o => o.id_horario == oHorario.id_horario);
                        lstHorarios.Add(oHorario);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return lstHorarios;
        }

        private List<HorariosDetalles> ConvertirALista(DataTable DT)
        {
            HorariosDetalles Detalle;
            List<HorariosDetalles> lista = new List<HorariosDetalles>();

            foreach (DataRow row in DT.Rows)
            {
                Detalle = new HorariosDetalles();
                Detalle.id_detalle = Convert.ToInt32(row["id_detalle"]);
                Detalle.id_horario = Convert.ToInt32(row["id_horario"]);
                Detalle.oConcepto = new Concepto();
                Detalle.oConcepto.clave = Convert.ToString(row["clave"]);
                Detalle.oConcepto.descripcion = Convert.ToString(row["descripcion"]);
                Detalle.hora_minima = (TimeSpan)row["hora_minima"];
                Detalle.hora_checada = row["hora_checada"] == DBNull.Value ? null : (TimeSpan?)row["hora_checada"];
                Detalle.hora_maxima = (TimeSpan)row["hora_maxima"];
                lista.Add(Detalle);
            }

            return lista;
        }

        private List<EmpleadoHorario> ObtenerRelacionEmpleadoHorario()
        {
            EmpleadoHorario oEmpleadoHorario;
            List<EmpleadoHorario> lista = new List<EmpleadoHorario>();

            try
            {
                if (oConnection.State == ConnectionState.Open)
                {
                    oCommand.Connection = oConnection;
                    oCommand.CommandText =
                        string.Format(@"SELECT 
                                            id_empleado,
                                            id_horario,
                                            vigencia_inicio,
                                            vigencia_fin,
                                            prioridad
                                        FROM
                                            empleados_horarios;");
                    DataTable DT_Relacion = new DataTable();
                    oAdapter.SelectCommand = oCommand;
                    oAdapter.Fill(DT_Relacion);

                    foreach (DataRow row in DT_Relacion.Rows)
                    {
                        oEmpleadoHorario = new EmpleadoHorario();
                        oEmpleadoHorario.id_horario = Convert.ToInt32(row["id_horario"]);
                        oEmpleadoHorario.id_empleado = Convert.ToInt32(row["id_empleado"]);
                        oEmpleadoHorario.vigencia_inicio = Convert.ToDateTime(row["vigencia_inicio"]);
                        oEmpleadoHorario.vigencia_fin = Convert.ToDateTime(row["vigencia_fin"]);
                        oEmpleadoHorario.prioridad = Convert.ToInt32(row["prioridad"]);
                        lista.Add(oEmpleadoHorario);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return lista;
        }

        private List<EmpleadoHorario> ObtenerRelacionEmpleadoHorario(int id_interno)
        {
            EmpleadoHorario oEmpleadoHorario;
            List<EmpleadoHorario> lista = new List<EmpleadoHorario>();

            try
            {
                if (oConnection.State == ConnectionState.Open)
                {
                    oCommand.Connection = oConnection;
                    oCommand.CommandText =
                        string.Format(@"SELECT 
                                            id_empleado,
                                            id_horario,
                                            vigencia_inicio,
                                            vigencia_fin,
                                            prioridad
                                        FROM
                                            empleados_horarios
                                        WHERE id_empleado = {0}", id_interno);
                    DataTable DT_Relacion = new DataTable();
                    oAdapter.SelectCommand = oCommand;
                    oAdapter.Fill(DT_Relacion);

                    foreach (DataRow row in DT_Relacion.Rows)
                    {
                        oEmpleadoHorario = new EmpleadoHorario();
                        oEmpleadoHorario.id_horario = Convert.ToInt32(row["id_horario"]);
                        oEmpleadoHorario.id_empleado = Convert.ToInt32(row["id_empleado"]);
                        oEmpleadoHorario.vigencia_inicio = Convert.ToDateTime(row["vigencia_inicio"]);
                        oEmpleadoHorario.vigencia_fin = Convert.ToDateTime(row["vigencia_fin"]);
                        oEmpleadoHorario.prioridad = Convert.ToInt32(row["prioridad"]);
                        lista.Add(oEmpleadoHorario);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return lista;
        }

        #endregion

        #region *** Metodos Publicos ***

        /// <summary>
        /// Obtiene Todos los empleados activos
        /// </summary>
        /// <returns>Lista de empleados activos</returns>
        public List<Empleado> ObtenerEmpleadosSencillo()
        {
            List<Empleado> lstSencilla = new List<Empleado>();
            try
            {
                Empleado oEmpleado;
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                  @"SELECT 
                        id_interno, id_depto, nombre AS e_nombre, activado
                    FROM
                        empleados e
                    WHERE
                        activado = 1
                    ORDER BY e_nombre";

                DataTable DT_Empleados = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Empleados);

                foreach (DataRow row in DT_Empleados.Rows)
                {
                    oEmpleado = new Empleado();

                    oEmpleado.id_interno = Convert.ToInt32(row["id_interno"]);
                    oEmpleado.nombre = Convert.ToString(row["e_nombre"]);
                    oEmpleado.id_depto = Convert.ToInt32(row["id_depto"]);
                    oEmpleado.activado = Convert.ToBoolean(row["activado"]);
                    oEmpleado.lstHorarios = null;

                    lstSencilla.Add(oEmpleado);
                }
            }
            catch(Exception e)
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
            return lstSencilla;
        }

        public List<Empleado> ObtenerEmpleadosALL(string where = "")
        {
            List<Empleado> lstSencilla = new List<Empleado>();
            try
            {
                Empleado oEmpleado;
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                  @"SELECT 
                        id_interno, id_depto, nombre AS e_nombre, activado
                    FROM
                        empleados e " + where +
                    " ORDER BY activado desc, e_nombre ";

                DataTable DT_Empleados = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Empleados);

                foreach (DataRow row in DT_Empleados.Rows)
                {
                    oEmpleado = new Empleado();

                    oEmpleado.id_interno = Convert.ToInt32(row["id_interno"]);
                    oEmpleado.nombre = Convert.ToString(row["e_nombre"]);
                    oEmpleado.id_depto = Convert.ToInt32(row["id_depto"]);
                    oEmpleado.activado = Convert.ToBoolean(row["activado"]);
                    oEmpleado.activo = Convert.ToBoolean(row["activado"]) == true ? "SI" : "NO";
                    oEmpleado.lstHorarios = null;

                    lstSencilla.Add(oEmpleado);
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
            return lstSencilla;
        }

        public List<EmpleadoChecador> ObtenerRelacionEmpleadoChecador(int id_empleado)
        {
            List<EmpleadoChecador> lstSencilla = new List<EmpleadoChecador>();
            try
            {
                EmpleadoChecador oEmpleado;
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                  @"SELECT 
                      b.id_checador, a.descripcion, b.id_interno
                    FROM
					  checadores a , empleados_checadores b
				    WHERE
					  b.id_checador=a.id_checador AND b.id_empleado=" + id_empleado+" ORDER BY b.id_checador";

                DataTable DT_Empleados = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Empleados);

                foreach (DataRow row in DT_Empleados.Rows)
                {
                    oEmpleado = new EmpleadoChecador();

                    oEmpleado.id_interno = Convert.ToInt32(row["id_interno"]);
                    oEmpleado.id_checador = Convert.ToInt32(row["id_checador"]);
                    oEmpleado.sChecador = Convert.ToString(row["descripcion"]);

                    lstSencilla.Add(oEmpleado);
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
            return lstSencilla;
        }

        public List<EmpleadoChecador> ObtenerChecadores()
        {
            List<EmpleadoChecador> lstSencilla = new List<EmpleadoChecador>();
            try
            {
                EmpleadoChecador oEmpleado;
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                  @"SELECT 
                      id_checador, descripcion
                    FROM
					  checadores";

                DataTable DT_Checadores = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Checadores);

                foreach (DataRow row in DT_Checadores.Rows)
                {
                    oEmpleado = new EmpleadoChecador();
                    oEmpleado.id_checador = Convert.ToInt32(row["id_checador"]);
                    oEmpleado.sChecador = Convert.ToString(row["descripcion"]);
                    lstSencilla.Add(oEmpleado);
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
            return lstSencilla;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> lstEmpleados = new List<Empleado>();
            
            try
            { 
                Empleado oEmpleado;
                
                oConnection.ConnectionString = getConnectionString();

                oConnection.Open();

                ListaDeTodosLosHorarios = ObtenerTodosLosHorarios();
                ListaEmpleadosHorarios = ObtenerRelacionEmpleadoHorario();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                  @"SELECT 
                        id_interno, d.id AS id, d.nombre AS d_nombre,
                        d.status, e.nombre AS e_nombre, activado, variado
                    FROM
                        empleados e
                            INNER JOIN
                        departamentos d ON e.id_depto = d.id
                    WHERE
                        activado = 1
                    ORDER BY e.nombre";

                DataTable DT_Empleados = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Empleados);

                Horario AuxHorario;
                List<EmpleadoHorario> listAuxEmpleadoHorario;                
                foreach (DataRow row in DT_Empleados.Rows)
                {
                    oEmpleado = new Empleado();
                    oEmpleado.departamento = new Departamento();
                    oEmpleado.lstHorarios = new List<Horario>();

                    oEmpleado.id_interno = Convert.ToInt32(row["id_interno"]);
                    oEmpleado.departamento.Id = Convert.ToInt32(row["id"]);
                    oEmpleado.departamento.Nombre = Convert.ToString(row["d_nombre"]);
                    oEmpleado.departamento.Estatus = Convert.ToBoolean(row["status"]);
                    oEmpleado.nombre = Convert.ToString(row["e_nombre"]);
                    oEmpleado.activado = Convert.ToBoolean(row["activado"]);
                    oEmpleado.variado = Convert.ToBoolean(row["variado"]);
                    
                    oEmpleado.lstHorarios = new List<Horario>();
                    listAuxEmpleadoHorario = new List<EmpleadoHorario>();
                    listAuxEmpleadoHorario.AddRange(ListaEmpleadosHorarios.FindAll(o => o.id_empleado == oEmpleado.id_interno));
                    foreach (EmpleadoHorario EmpHor in listAuxEmpleadoHorario)
                    {
                        AuxHorario = ListaDeTodosLosHorarios.Find(o => o.id_horario == EmpHor.id_horario);
                        if (AuxHorario != null)
                        {
                            Horario oHorarioAux = new Horario();
                            oHorarioAux.checa_dia_siguiente = AuxHorario.checa_dia_siguiente;
                            oHorarioAux.descripcion = AuxHorario.descripcion;
                            oHorarioAux.dias_que_aplica = AuxHorario.dias_que_aplica;
                            oHorarioAux.dias_que_no_aplica = AuxHorario.dias_que_no_aplica;
                            oHorarioAux.fecha_actualizacion = AuxHorario.fecha_actualizacion;
                            oHorarioAux.id_horario = AuxHorario.id_horario;
                            oHorarioAux.lstDetalles = new List<HorariosDetalles>();
                            oHorarioAux.lstDetalles.AddRange(AuxHorario.lstDetalles);

                            oHorarioAux.vigencia_inicio = EmpHor.vigencia_inicio;
                            oHorarioAux.vigencia_fin = EmpHor.vigencia_fin;
                            oHorarioAux.prioridad = EmpHor.prioridad;

                            oEmpleado.lstHorarios.Add(oHorarioAux);
                        }
                    }

                    lstEmpleados.Add(oEmpleado);
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

            return lstEmpleados;
        }

        /// <summary>
        /// Obtiene todos los departamentos activos
        /// </summary>
        /// <returns>Lista de departamentos activos</returns>
        public List<Departamento> ObtenerDepartamentos()
        {
            Departamento oDepartamento;
            List<Departamento> lstDepartamentos = new List<Departamento>();

            oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
            oConnection.Open();

            oCommand.Connection = oConnection;
            oCommand.CommandText =
                @"SELECT 
                    d.id AS id,
                    d.nombre AS nombre
                FROM
                    departamentos d
                WHERE
                    status = 1";

            DataTable DT_Departamentos = new DataTable();
            oAdapter.SelectCommand = oCommand;
            oAdapter.Fill(DT_Departamentos);

            foreach (DataRow row in DT_Departamentos.Rows)
            {
                oDepartamento = new Departamento();
                oDepartamento.Id = Convert.ToInt32(row["id"]);
                oDepartamento.Nombre = Convert.ToString(row["nombre"]);
                
                lstDepartamentos.Add(oDepartamento);
            }

            if (oConnection.State != ConnectionState.Closed)
            {
                oConnection.Close();
            }

            return lstDepartamentos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_horario"></param>
        /// <returns></returns>
        public List<EmpleadoHorario> ObtenerRelacionHorarios(int id_horario)
        {
            EmpleadoHorario oRelacion;
            List<EmpleadoHorario> lstRelacion = new List<EmpleadoHorario>();

            oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
            oConnection.Open();

            oCommand.Connection = oConnection;
            oCommand.CommandText =
                @"SELECT 
                    d.id_empleado AS IdEmpleado,
                    d.id_horario AS IdHorario
                FROM
                    empleados_horarios d
                WHERE
                    d.id_empleado=" + id_horario + "";

            DataTable DT_Relacion = new DataTable();
            oAdapter.SelectCommand = oCommand;
            oAdapter.Fill(DT_Relacion);

            foreach (DataRow row in DT_Relacion.Rows)
            {
                oRelacion = new EmpleadoHorario();
                oRelacion.id_empleado = Convert.ToInt32(row["IdEmpleado"]);
                oRelacion.id_horario = Convert.ToInt32(row["IdHorario"]);
                lstRelacion.Add(oRelacion);
            }

            if (oConnection.State != ConnectionState.Closed)
            {
                oConnection.Close();
            }

            return lstRelacion;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_horario"></param>
        /// <returns></returns>
        public List<EmpleadoHorarioDetalle> ObtenerDetalleHorario(int id_horario)
        {
            EmpleadoHorarioDetalle oDetalle;
            List<EmpleadoHorarioDetalle> lstDetalle = new List<EmpleadoHorarioDetalle>();

            oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
            oConnection.Open();

            oCommand.Connection = oConnection;
            oCommand.CommandText =
                string.Format(@"SELECT 
                                    a.id_empleado AS IdEmpleado,
                                    a.id_horario AS IdHorario,
                                    b.descripcion AS Descrip,
                                    b.dias_que_aplica AS Dias,
                                    b.dias_que_no_aplica AS Dias_que_no,
                                    c.hora_minima AS HoraMin,
                                    c.hora_checada AS HoraChec,
                                    c.hora_maxima AS HoraMax,
                                    d.descripcion AS Concepto
                                FROM
                                    empleados_horarios a
                                        JOIN
                                    horarios b ON b.id_horario = a.id_horario
                                        JOIN
                                    horarios_detalles c ON c.id_horario = a.id_horario
                                        JOIN
                                    conceptos d ON d.clave = c.clave_concepto
                                WHERE
                                    a.id_empleado = {0}
                                ORDER BY a.id_horario, c.hora_minima", id_horario);

            DataTable DT_Detalle = new DataTable();
            oAdapter.SelectCommand = oCommand;
            oAdapter.Fill(DT_Detalle);

            foreach (DataRow row in DT_Detalle.Rows)
            {
                oDetalle = new EmpleadoHorarioDetalle();
                oDetalle.id_empleado = Convert.ToInt32(row["IdEmpleado"]);
                oDetalle.id_horario = Convert.ToInt32(row["IdHorario"]);
                oDetalle.descripcion = Convert.ToString(row["Descrip"]);
                oDetalle.dias_que_aplica = Convert.ToString(row["Dias"]);
                oDetalle.dias_que_no_aplica = Convert.ToString(row["Dias_que_no"]);
                oDetalle.hora_minima = (TimeSpan)row["HoraMin"];
                oDetalle.hora_checada = (row["HoraChec"].Equals(DBNull.Value) == false) ? (TimeSpan?)row["HoraChec"] : null;
                oDetalle.hora_maxima = (TimeSpan)row["HoraMax"];
                oDetalle.concepto = Convert.ToString(row["Concepto"]);
                lstDetalle.Add(oDetalle);
            }

            if (oConnection.State != ConnectionState.Closed)
            {
                oConnection.Close();
            }

            return lstDetalle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_interno"></param>
        /// <param name="id_depto"></param>
        /// <param name="nombre"></param>
        public void InsertarEmpleado(int id_interno, int id_depto, string nombre)
        {
            try
            {
                oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"INSERT INTO empleados 
                                        (id_interno, id_depto, nombre, activado, variado) 
                                    VALUES
                                        ({0}, {1}, '{2}', 1, 1)", id_interno, id_depto, nombre);
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

        public void InsertarEmpleadoTodosLosChecadores(int id_empleado, int id_depto, string nombre)
        {
            try
            {
                oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"INSERT INTO empleados 
                                        (id_empleado, id_depto, nombre, activado) 
                                    VALUES
                                        ({0}, {1}, '{2}', 1)",
                                        id_empleado, 
                                        id_depto, 
                                        nombre);
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

        public void InsertarEmpleadoChecador(int id_empleado, int id_checador, int id_interno)
        {
            try
            {
                oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"INSERT INTO empleados_checadores 
                                        (id_empleado, id_checador, id_interno) 
                                    VALUES
                                        ({0}, {1}, {2})", id_empleado, id_checador, id_interno);
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

        // actualiza informacion del empleado
        public bool actEmpleados(int idInterno, int depto, string empleado, int activado)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"UPDATE empleados SET id_interno = {0},  id_depto = {1}, nombre = '{2}', activado = {3} WHERE id_interno = {0}",
                                    idInterno, depto, empleado, activado);
                oCommand.ExecuteNonQuery();

                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();

                return true;
            }
            catch (Exception ex)
            {
                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void BorrarEmpleado(int id)
        {
            try
            {
                oConnection.ConnectionString = DataBaseUtils.ObtenerConectionString(this.oChecador, this.oServidor);
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText = string.Format("UPDATE empleados SET activado=0 WHERE id_interno = {0}", id);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEmpleado"></param>
        public void ModificarEmpleado(Empleado pEmpleado)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText = 
                    string.Format(@"UPDATE 
                                        empleados 
                                    SET 
                                        nombre='{0}', id_depto={1} 
                                    WHERE 
                                        id_interno={2}",
                                        pEmpleado.nombre, pEmpleado.departamento.Id,
                                        pEmpleado.id_interno);
                oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEmpleado"></param>
        public void ModificarEmpleadoTodosLosChecadores(Empleado pEmpleado)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"UPDATE 
                                        empleados 
                                    SET 
                                        nombre = '{0}', id_depto = {1} 
                                    WHERE 
                                        id_empleado = {2}",
                                        pEmpleado.nombre, 
                                        pEmpleado.departamento.Id,
                                        pEmpleado.id_interno);
                oCommand.ExecuteNonQuery();

                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();
            }
            catch (Exception ex)
            {
                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pagina"></param>
        /// <param name="numRegistros"></param>
        /// <param name="iTotalRegistros"></param>
        /// <param name="iTotalPaginas"></param>
        /// <returns></returns>
        public List<Empleado> ObtenerEmpleadoPaginado
            (int pagina, float numRegistros, 
             out int iTotalRegistros, out int iTotalPaginas)
        {
            List<Empleado> lstEmpleados = new List<Empleado>();
            iTotalRegistros = 0;
            iTotalPaginas = 0;
            Empleado oEmpleado;
            try
            {
                DataTable DT_Empleados = new DataTable();
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                ListaDeTodosLosHorarios = ObtenerTodosLosHorarios();
                ListaEmpleadosHorarios = ObtenerRelacionEmpleadoHorario();

                oCommand.Connection = oConnection;
                oCommand.CommandText = string.Format("SELECT COUNT(*) FROM empleados WHERE activado = 1");
                float iRegistrosTotales = Convert.ToInt32(oCommand.ExecuteScalar());
                float fPaginasTotales = iRegistrosTotales / numRegistros;
                int iPaginasTotales = Convert.ToInt32(iRegistrosTotales / numRegistros);

                if (fPaginasTotales > iPaginasTotales)
                {
                    iPaginasTotales++;
                }

                oCommand.CommandText =
                    string.Format(@"SELECT 
                                        id_interno, 
                                        d.id AS id, 
                                        d.nombre AS d_nombre,
                                        d.status, 
                                        e.nombre AS e_nombre, 
                                        activado, 
                                        variado
                                    FROM
                                        empleados e
                                            LEFT JOIN
                                        departamentos d ON e.id_depto = d.id
                                    WHERE
                                        activado = 1 
                                    ORDER BY id_interno, e_nombre
                                    LIMIT {0} 
                                    OFFSET {1}", 
                                    numRegistros, 
                                    (pagina)*numRegistros);
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Empleados);

                List<EmpleadoHorario> listAuxEmpleadoHorario;
                Horario AuxHorario= new Horario();
                foreach (DataRow row in DT_Empleados.Rows)
                {
                    oEmpleado = new Empleado();
                    oEmpleado.departamento = new Departamento();
                    oEmpleado.lstHorarios = new List<Horario>();

                    oEmpleado.id_interno = Convert.ToInt32(row["id_interno"]);
                    if (row["id"] != DBNull.Value)
                    {
                        oEmpleado.departamento.Id = Convert.ToInt32(row["id"]);
                        oEmpleado.departamento.Nombre = Convert.ToString(row["d_nombre"]);
                        oEmpleado.departamento.Estatus = Convert.ToBoolean(row["status"]);
                    }
                    oEmpleado.nombre = Convert.ToString(row["e_nombre"]);
                    oEmpleado.activado = Convert.ToBoolean(row["activado"]);
                    oEmpleado.variado = Convert.ToBoolean(row["variado"]);

                    oEmpleado.lstHorarios = new List<Horario>();
                    listAuxEmpleadoHorario = new List<EmpleadoHorario>();
                    listAuxEmpleadoHorario.AddRange(ListaEmpleadosHorarios.FindAll(o => o.id_empleado == oEmpleado.id_interno));
                    foreach (EmpleadoHorario EmpHor in listAuxEmpleadoHorario)
                    {
                        AuxHorario = ListaDeTodosLosHorarios.Find(o => o.id_horario == EmpHor.id_horario);
                        if (AuxHorario != null)
                        {
                            oEmpleado.lstHorarios.Add(AuxHorario);
                        }
                    }

                    lstEmpleados.Add(oEmpleado);
                }

                iTotalPaginas = iPaginasTotales;
                iTotalRegistros = Convert.ToInt32(iRegistrosTotales);
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

            return lstEmpleados;
        }

        public List<Empleado> ObtenerEmpleado
            (int pagina, float numRegistros, int idinterno,
             out int iTotalRegistros, out int iTotalPaginas)
        {
            List<Empleado> lstEmpleados = new List<Empleado>();
            iTotalRegistros = 0;
            iTotalPaginas = 0;
            Empleado oEmpleado;
            try
            {
                DataTable DT_Empleados = new DataTable();
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                ListaDeTodosLosHorarios = ObtenerTodosLosHorarios();
                ListaEmpleadosHorarios = ObtenerRelacionEmpleadoHorario();

                oCommand.Connection = oConnection;
                oCommand.CommandText = string.Format("SELECT COUNT(*) FROM empleados WHERE activado = 1");
                float iRegistrosTotales = Convert.ToInt32(oCommand.ExecuteScalar());
                float fPaginasTotales = iRegistrosTotales / numRegistros;
                int iPaginasTotales = Convert.ToInt32(iRegistrosTotales / numRegistros);

                if (fPaginasTotales > iPaginasTotales)
                {
                    iPaginasTotales++;
                }

                oCommand.CommandText =
                    string.Format(@"SELECT 
                                        id_interno, 
                                        d.id AS id, 
                                        d.nombre AS d_nombre,
                                        d.status, 
                                        e.nombre AS e_nombre, 
                                        activado, 
                                        variado
                                    FROM
                                        empleados e
                                            LEFT JOIN
                                        departamentos d ON e.id_depto = d.id
                                    WHERE
                                        activado = 1 and id_interno = {2}
                                    ORDER BY id_interno, e_nombre
                                    LIMIT {0} 
                                    OFFSET {1}",
                                    numRegistros,
                                    (pagina) * numRegistros, idinterno);
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Empleados);

                List<EmpleadoHorario> listAuxEmpleadoHorario;
                Horario AuxHorario = new Horario();
                foreach (DataRow row in DT_Empleados.Rows)
                {
                    oEmpleado = new Empleado();
                    oEmpleado.departamento = new Departamento();
                    oEmpleado.lstHorarios = new List<Horario>();

                    oEmpleado.id_interno = Convert.ToInt32(row["id_interno"]);
                    if (row["id"] != DBNull.Value)
                    {
                        oEmpleado.departamento.Id = Convert.ToInt32(row["id"]);
                        oEmpleado.departamento.Nombre = Convert.ToString(row["d_nombre"]);
                        oEmpleado.departamento.Estatus = Convert.ToBoolean(row["status"]);
                    }
                    oEmpleado.nombre = Convert.ToString(row["e_nombre"]);
                    oEmpleado.activado = Convert.ToBoolean(row["activado"]);
                    oEmpleado.variado = Convert.ToBoolean(row["variado"]);

                    oEmpleado.lstHorarios = new List<Horario>();
                    listAuxEmpleadoHorario = new List<EmpleadoHorario>();
                    listAuxEmpleadoHorario.AddRange(ListaEmpleadosHorarios.FindAll(o => o.id_empleado == oEmpleado.id_interno));
                    foreach (EmpleadoHorario EmpHor in listAuxEmpleadoHorario)
                    {
                        AuxHorario = ListaDeTodosLosHorarios.Find(o => o.id_horario == EmpHor.id_horario);
                        if (AuxHorario != null)
                        {
                            oEmpleado.lstHorarios.Add(AuxHorario);
                        }
                    }

                    lstEmpleados.Add(oEmpleado);
                }

                iTotalPaginas = iPaginasTotales;
                iTotalRegistros = Convert.ToInt32(iRegistrosTotales);
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

            return lstEmpleados;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id_interno"></param>
        /// <returns></returns>
        public List<Horario> ObtenerHorarios(int id_interno)
        {
            List<Horario> lstHorarios = new List<Horario>();

            oConnection.ConnectionString = getConnectionString();
            oConnection.Open();

            ListaDeTodosLosHorarios = ObtenerTodosLosHorarios();
            ListaEmpleadosHorarios = ObtenerRelacionEmpleadoHorario(id_interno);

            Horario objHorario, oHorarioAux;
            DateTime vig_inicio, vig_fin;
            foreach (EmpleadoHorario emphor in ListaEmpleadosHorarios)
            {
                objHorario = new Horario();

                vig_inicio = new DateTime(emphor.vigencia_inicio.Year, emphor.vigencia_inicio.Month, emphor.vigencia_inicio.Day);
                vig_fin = new DateTime(emphor.vigencia_fin.Year, emphor.vigencia_fin.Month, emphor.vigencia_fin.Day);

                oHorarioAux = ListaDeTodosLosHorarios.Find(o => o.id_horario == emphor.id_horario);

                objHorario.id_horario = oHorarioAux.id_horario;
                objHorario.descripcion = oHorarioAux.descripcion;
                objHorario.checa_dia_siguiente = oHorarioAux.checa_dia_siguiente;
                objHorario.dias_que_aplica = oHorarioAux.dias_que_aplica;
                objHorario.dias_que_no_aplica = oHorarioAux.dias_que_no_aplica;
                objHorario.fecha_actualizacion = oHorarioAux.fecha_actualizacion;
                objHorario.lstDetalles = new List<HorariosDetalles>();
                objHorario.lstDetalles.AddRange(oHorarioAux.lstDetalles);

                objHorario.vigencia_inicio = vig_inicio;
                objHorario.vigencia_fin = vig_fin;
                objHorario.prioridad = emphor.prioridad;

                lstHorarios.Add(objHorario);
            }

            if (oConnection.State != ConnectionState.Closed)
            {
                oConnection.Close();
            }

            return lstHorarios;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pagina"></param>
        /// <param name="numRegistros"></param>
        /// <param name="iTotalRegistros"></param>
        /// <param name="iTotalPaginas"></param>
        /// <returns></returns>
        public List<Empleado> ObtenerEmpleadosSencillosTodosLosChecadores
            (int pagina, float numRegistros, 
             out int iTotalRegistros, out int iTotalPaginas)
        {
            List<Empleado> lstSencilla = new List<Empleado>();
            try
            {
                Empleado oEmpleado;
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText = string.Format("SELECT COUNT(*) FROM empleados");
                float iRegistrosTotales = Convert.ToInt32(oCommand.ExecuteScalar());
                float fPaginasTotales = iRegistrosTotales / numRegistros;
                int iPaginasTotales = Convert.ToInt32(iRegistrosTotales / numRegistros);

                if (fPaginasTotales > iPaginasTotales)
                {
                    iPaginasTotales++;
                }

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                  string.Format(@"SELECT 
                                        e.id_empleado, e.nombre, d.id, d.nombre AS depto
                                    FROM
                                        empleados e
                                            INNER JOIN
                                        departamentos d ON e.id_depto = d.id
                                    WHERE
                                        activado = 1
                                    ORDER BY e.nombre
                                    LIMIT {0} 
                                    OFFSET {1}",
                                    numRegistros, 
                                    (pagina)*numRegistros);

                DataTable DT_Empleados = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Empleados);

                foreach (DataRow row in DT_Empleados.Rows)
                {
                    oEmpleado = new Empleado();
                    oEmpleado.id_interno = Convert.ToInt32(row["id_empleado"]);
                    oEmpleado.nombre = Convert.ToString(row["nombre"]);
                    oEmpleado.departamento = new Departamento();
                    oEmpleado.departamento.Id = Convert.ToInt32(row["id"]);
                    oEmpleado.departamento.Nombre = Convert.ToString(row["depto"]);
                    lstSencilla.Add(oEmpleado);
                }

                iTotalPaginas = iPaginasTotales;
                iTotalRegistros = Convert.ToInt32(iRegistrosTotales);
            }
            catch (Exception e)
            {
                throw e;
            }

            return lstSencilla;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Empleado> ObtenerEmpleadosSencillosTodosLosChecadores()
        {
            List<Empleado> lstSencilla = new List<Empleado>();
            try
            {
                Empleado oEmpleado;
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                  string.Format(@"SELECT 
                                        e.id_empleado, e.nombre, d.id, d.nombre AS depto
                                    FROM
                                        empleados e
                                            INNER JOIN
                                        departamentos d ON e.id_depto = d.id
                                    WHERE
                                        activado = 1
                                    ORDER BY e.nombre");

                DataTable DT_Empleados = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(DT_Empleados);

                foreach (DataRow row in DT_Empleados.Rows)
                {
                    oEmpleado = new Empleado();
                    oEmpleado.id_interno = Convert.ToInt32(row["id_empleado"]);
                    oEmpleado.nombre = Convert.ToString(row["nombre"]);
                    oEmpleado.departamento = new Departamento();
                    oEmpleado.departamento.Id = Convert.ToInt32(row["id"]);
                    oEmpleado.departamento.Nombre = Convert.ToString(row["depto"]);
                    lstSencilla.Add(oEmpleado);
                }
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

            return lstSencilla;
        }

        public List<HorarioVigencia> ObtenerHorariosVigencias(int id_interno)
        {
            List<HorarioVigencia> lstHorariosVigencias = new List<HorarioVigencia>();

            try
            {
                HorarioVigencia oHorarioVigencia;
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText =
                  string.Format(@"SELECT 
                                        a.id_horario,
                                        b.prioridad,
                                        a.descripcion,
	                                    b.vigencia_inicio,
	                                    b.vigencia_fin
                                    FROM
                                        horarios a
                                            INNER JOIN
                                        empleados_horarios b ON a.id_horario = b.id_horario
                                    WHERE 
	                                    id_empleado = {0}
                                    ORDER BY prioridad DESC"
                                    , id_interno);

                DataTable dataHorariosVigencias = new DataTable();
                oAdapter.SelectCommand = oCommand;
                oAdapter.Fill(dataHorariosVigencias);

                foreach (DataRow row in dataHorariosVigencias.Rows)
                {
                    oHorarioVigencia = new HorarioVigencia();
                    oHorarioVigencia.id_horario = Convert.ToInt32(row["id_horario"]);
                    oHorarioVigencia.prioridad = Convert.ToInt32(row["prioridad"]);
                    oHorarioVigencia.descripcion = Convert.ToString(row["descripcion"]);
                    oHorarioVigencia.vigencia_inicio = Convert.ToDateTime(row["vigencia_inicio"]);
                    oHorarioVigencia.vigencia_fin = Convert.ToDateTime(row["vigencia_fin"]);
                    lstHorariosVigencias.Add(oHorarioVigencia);
                }

                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }
            }
            catch (Exception e)
            {
                if (oConnection.State != ConnectionState.Closed)
                {
                    oConnection.Close();
                }

                throw e;
            }

            return lstHorariosVigencias;
        }

        public void BorrarRelacionEmpleadoChecador(int id_empleado, int id_checador)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    string.Format(@"DELETE FROM 
                                        empleados_checadores 
                                    WHERE
                                        id_empleado={0} AND id_checador={1}",
                                        id_empleado,id_checador);
                oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
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

        #endregion
    }
}