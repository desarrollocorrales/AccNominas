using System;
using System.Collections.Generic;
using System.Data;
using AccAsistencia.Utilerias;
using MySql.Data.MySqlClient;

namespace AccAsistencia.DAL
{
    public class DepartamentosDAL : GenericDAL
    {
        public DepartamentosDAL():base()
        {

        }

        public List<Departamento> ObtenerDepartamentos()
        {
            Departamento oDepartamento;
            List<Departamento> lstDepartamentos = new List<Departamento>();

            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText =
                    @"SELECT 
                            d.id AS id,
                            d.nombre AS d_nombre
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
                    oDepartamento.Nombre = Convert.ToString(row["d_nombre"]);

                    lstDepartamentos.Add(oDepartamento);
                }

                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (oConnection.State != ConnectionState.Closed)
                    oConnection.Close();
            }
            return lstDepartamentos;
        }

        public void InsertarDepartamento(string nombre)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();

                oCommand.Connection = oConnection;
                oCommand.CommandText = string.Format(@"INSERT into departamentos (nombre, status) VALUES ('{0}', 1)", nombre);

                oCommand.ExecuteNonQuery();
            }
            catch
            {
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

        public void BorrarDepartamento(int id)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText = "UPDATE departamentos SET status = 0 WHERE id = " + id + "";
                oCommand.ExecuteNonQuery();
            }
            catch
            {
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

        public void ModificarDepartamento(int id, string nombre_depto)
        {
            try
            {
                oConnection.ConnectionString = getConnectionString();
                oConnection.Open();
                oCommand.Connection = oConnection;
                oCommand.CommandText = "UPDATE departamentos SET nombre = '" + nombre_depto + "' WHERE id = " + id;
                oCommand.ExecuteNonQuery();
            }
            catch
            {
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

    }
}
