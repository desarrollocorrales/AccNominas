using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using AccAsistencia;
using AccAsistencia.Utilerias;
using System.IO;
using System.Runtime.Serialization;

namespace AccNominas.Formularios.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            switch (this.tabControl1.SelectedTab.Text.ToLower())
            {
                case "alta":
                    if (ValidarControles() == true)
                    {
                        Guardar();
                    }
                    break;
                case "baja":
                    Eliminar();
                    break;
                case "cambio":
                    if (ValidarControlesCambios() == true)
                    {
                        Modificar();
                    }
                    break;
            }
            
        }
        private void Guardar()
        {
            List<Usuario> lstUsuarios = new List<Usuario>();

            try
            {
                string sFileName;
                FileStream stream;
                BinaryFormatter bFormatter;

                Usuario user = new Usuario();
                user.nombre = txbNombre.Text;
                user.username = txbUserName.Text.ToLower();
                user.password = md5(txbPass.Text.ToLower());
                user.permisos = ObtenerPermisos(lstbPermisos);

                sFileName = Environment.CurrentDirectory + "\\config.conf";
                stream = new FileStream(sFileName, FileMode.Open);
                bFormatter = new BinaryFormatter();
                lstUsuarios = bFormatter.Deserialize(stream) as List<Usuario>;
                stream.Close();

                Usuario validar =
                    lstUsuarios.Find(o => o.username == user.username);
                if (validar != null)
                {
                    MessageBox.Show("El usuario ya existe...", 
                                    "", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }
                else
                {

                    lstUsuarios.Add(user);
                    stream = new FileStream(sFileName, FileMode.Create);
                    bFormatter = new BinaryFormatter();
                    bFormatter.Serialize(stream, lstUsuarios);
                    stream.Close();

                    MessageBox.Show("El usuario fue dado de alta con exito.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.Message);
            }
        }
        private void Eliminar()
        {
            Usuario oUsuario = new Usuario();
            oUsuario = (Usuario)cbNombreBaja.SelectedItem;
            DialogResult dr = MessageBox.Show("Desea eliminar al usuario: " + oUsuario.nombre,
                                              "",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                List<Usuario> lstUsuarios = new List<Usuario>();

                try
                {
                    string sFileName;
                    FileStream stream;
                    BinaryFormatter bFormatter;

                    sFileName = Environment.CurrentDirectory + "\\config.conf";
                    stream = new FileStream(sFileName, FileMode.Open);
                    bFormatter = new BinaryFormatter();
                    lstUsuarios = bFormatter.Deserialize(stream) as List<Usuario>;
                    stream.Close();

                    lstUsuarios.RemoveAll(o => o.nombre == oUsuario.nombre);
                    stream = new FileStream(sFileName, FileMode.Create);
                    bFormatter = new BinaryFormatter();
                    bFormatter.Serialize(stream, lstUsuarios);
                    stream.Close();

                    MessageBox.Show("El usuario fue eliminado con exito.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    this.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocurrio un error: " + e.Message);
                }
            }
        }
        private void Modificar()
        {
            List<Usuario> lstUsuarios = new List<Usuario>();

            try
            {
                string sFileName;
                FileStream stream;
                BinaryFormatter bFormatter;

                sFileName = Environment.CurrentDirectory + "\\config.conf";
                stream = new FileStream(sFileName, FileMode.Open);
                bFormatter = new BinaryFormatter();
                lstUsuarios = bFormatter.Deserialize(stream) as List<Usuario>;
                stream.Close();

                Usuario UsuarioSeleccionado = (Usuario)cbNombreCambios.SelectedItem;
                Usuario validar = lstUsuarios.Find(o => o.username == UsuarioSeleccionado.username);

                if (validar == null)
                {
                    MessageBox.Show("No ha seleccionado un usuario...",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    validar.nombre = txbNombreCambios.Text;
                    validar.password = md5(txbPassCambios.Text);
                    validar.permisos = ObtenerPermisos(chLstBoxPermisosCambios);
                    stream = new FileStream(sFileName, FileMode.Create);
                    bFormatter = new BinaryFormatter();
                    bFormatter.Serialize(stream, lstUsuarios);
                    stream.Close();

                    MessageBox.Show("La modificacion se ha realizado con exito.",
                                    "",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    if (Configuracion.oUsuario.username == validar.username)
                    {
                        MessageBox.Show("Debe reiniciar la aplicacion para realizar los cambios",
                                                            "",
                                                            MessageBoxButtons.OK,
                                                            MessageBoxIcon.Information);
                        Application.Exit();
                    }

                    this.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.Message);
            }
        }

        private bool ValidarControles()
        {
            bool bExito = true;

            StringBuilder sb = new StringBuilder();

            if (txbNombre.Text.Trim() == string.Empty)
            {
                sb.Append("Debe asignar el nombre completo del usuario...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (txbUserName.Text.Trim() == string.Empty)
            {
                sb.Append("Debe asignar el nombre de usuario...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (txbPass.Text.Trim() == string.Empty)
            {
                sb.Append("Debe asignar una contraseña...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (txbPass.Text.Trim() != txbPass2.Text.Trim())
            {
                sb.Append("Las contraseñas no coinciden...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (lstbPermisos.CheckedItems.Count == 0)
            {
                sb.Append("Debe asignar al menos un permiso...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }

            if (bExito == false)
            {
                MessageBox.Show(sb.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bExito;
        }
        private bool ValidarControlesCambios()
        {
            bool bExito = true;

            StringBuilder sb = new StringBuilder();

            if (txbNombreCambios.Text.Trim() == string.Empty)
            {
                sb.Append("Debe asignar el nombre completo del usuario...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (txbPassCambios.Text.Trim() == string.Empty)
            {
                sb.Append("Debe asignar una contraseña...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (txbPassCambios.Text.Trim() != txbPass2Cambios.Text.Trim())
            {
                sb.Append("Las contraseñas no coinciden...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }
            if (chLstBoxPermisosCambios.CheckedItems.Count == 0)
            {
                sb.Append("Debe asignar al menos un permiso...");
                sb.Append(Environment.NewLine + Environment.NewLine);
                bExito = false;
            }

            if (bExito == false)
            {
                MessageBox.Show(sb.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return bExito;
        }

        private string md5(string password)
        {
            //Declaraciones
            System.Security.Cryptography.MD5 md5;
            md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            //Conversion
            //genero el hash a partir de la password original
            Byte[] encodedBytes = md5.ComputeHash(ASCIIEncoding.Default.GetBytes(password));

            //Resultado
            //devuelve el hash continuo y en minuscula. (igual que en php)
            return System.Text.RegularExpressions.Regex.Replace(BitConverter.ToString(encodedBytes).ToLower(), @"-", "");
        }

        private string ObtenerPermisos(CheckedListBox chlb)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Permiso item in chlb.CheckedItems)
            {
                sb.Append(item.Valor + ";");
            }
            return sb.ToString();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            this.Text += " - " + Configuracion.oUsuario.nombre;
            llenarListaPermisos();
            llenarCombos();
        }

        private void llenarListaPermisos()
        {
            CatalogoPermisos catPermisos = new CatalogoPermisos();
            lstbPermisos.DataSource = null;
            lstbPermisos.DataSource = catPermisos.ListaPermisos;
            lstbPermisos.DisplayMember = "Nombre";
            lstbPermisos.ValueMember = "Valor";

            chLstBoxPermisosCambios.DataSource = null;
            chLstBoxPermisosCambios.DataSource = catPermisos.ListaPermisos;
            chLstBoxPermisosCambios.DisplayMember = "Nombre";
            chLstBoxPermisosCambios.ValueMember = "Valor";
        }

        private void llenarCombos()
        {
            List<Usuario> lstUsuariosNombre = ObtenerUsuarios();
            cbNombreBaja.DataSource = null;
            lstUsuariosNombre.RemoveAll(o => o.username == Configuracion.oUsuario.username);
            cbNombreBaja.DataSource = lstUsuariosNombre;
            cbNombreBaja.DisplayMember = "nombre";

            cbNombreCambios.DataSource = null;
            cbNombreCambios.DataSource = ObtenerUsuarios();
            cbNombreCambios.DisplayMember = "username";
        }

        private List<Usuario> ObtenerUsuarios()
        {
            FileStream stream = null;
            List<Usuario> lstUsuarios = new List<Usuario>();

            try
            {
                string sFileName;
                sFileName = Environment.CurrentDirectory + "\\config.conf";
                stream = new FileStream(sFileName, FileMode.Open);
                BinaryFormatter bFormatter = new BinaryFormatter();
                lstUsuarios = bFormatter.Deserialize(stream) as List<Usuario>;
                lstUsuarios.RemoveAll(o => o.username == "administrador");
                stream.Close();
            }
            catch (SerializationException se)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("El archivo de usuarios se ha corrompido." + Environment.NewLine);
                sb.Append("Pongase en contacto con el Administrador.");
                MessageBox.Show(sb.ToString());
                if (stream != null)
                {
                    stream.Close();
                }
                LogManager.AgregarLog(se.Message);
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error: " + e.Message);
                if (stream != null)
                {
                    stream.Close();
                }
            }

            return lstUsuarios;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (e.TabPage.Text.ToLower())
            {
                case "alta":
                    btnGuardar.Text = "Guardar";
                    break;
                case "baja":
                    btnGuardar.Text = "Eliminar";
                    validarBajas();
                    break;
                case "cambio":
                    btnGuardar.Text = "Modificar";
                    validarCambios();
                    break;
            }
        }

        private void validarBajas()
        {
            if (cbNombreBaja.Items.Count == 0)
            {
                MessageBox.Show("No hay mas usuarios...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            }
        }

        private void validarCambios()
        {
            if (cbNombreCambios.Items.Count == 0)
            {
                MessageBox.Show("No hay mas usuarios...", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage1"];
            }
        }

        private void cbNombreBaja_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            CatalogoPermisos catPermisos = new CatalogoPermisos();

            user = (Usuario)cbNombreBaja.SelectedItem;
            List<string> lstsPermisos = new List<string>();
            foreach (string s in user.permisos.Split(';'))
            {
                if (s != string.Empty)
                {
                    lstsPermisos.Add(catPermisos.ListaPermisos.Find(o => o.Valor == s).Nombre);
                }
            }
            ListBoxBaja.DataSource = null;
            ListBoxBaja.DataSource = lstsPermisos;
        }

        private void cbNombreCambios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user = (Usuario)cbNombreCambios.SelectedItem;
            txbNombreCambios.Text = user.nombre;
        }

        private void chbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTodos.Checked)
            {
                SeleccionarTodos(lstbPermisos, true);
            }
            else
            {
                SeleccionarTodos(lstbPermisos, false);
            }
        }

        private void SeleccionarTodos(CheckedListBox chlb, bool b)
        {
            for (int i = 0; i < chlb.Items.Count; i++)
            {
                chlb.SetItemChecked(i, b);
            } 
        }

        private void chbTodosCambio_CheckedChanged(object sender, EventArgs e)
        {
            if (chbTodosCambio.Checked)
            {
                SeleccionarTodos(chLstBoxPermisosCambios, true);
            }
            else
            {
                SeleccionarTodos(chLstBoxPermisosCambios, false);
            }
        }
    }
}
