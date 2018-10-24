using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using AccAsistencia;
using AccAsistencia.Utilerias;

namespace AccNominas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Frm_Login_Shown(object sender, EventArgs e)
        {
            ValidarArchivos();
            txbUsuario.Focus();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login();
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

        private void login()
        {
            string user = txbUsuario.Text.ToLower();
            string pass = txbContraseña.Text.ToLower();

            List<Usuario> lstUsuarios = ObtenerUsuarios();

            Usuario oUser = 
                lstUsuarios.Find(o => o.username == user && o.password == md5(pass));

            if (oUser != null)
            {
                this.Hide();
                Configuracion.oUsuario = oUser;
                new FrmSplash().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.",
                                "",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
        }

        private void ValidarArchivos()
        {
            string sPath;
            sPath = Environment.CurrentDirectory + "\\config.conf";
            if (!File.Exists(sPath))
            {
                CrearArchivoConf();
            }
        }

        private void CrearArchivoConf()
        {
            try
            {
                string sFileName;
                sFileName = Environment.CurrentDirectory + "\\config.conf";

                Usuario user = new Usuario();
                user.nombre = "Administrador";
                user.username = "administrador";
                user.password = md5("nominaacc");
                user.permisos = ObtenerPermisos();
                List<Usuario> lstUsuarios = new List<Usuario>();
                lstUsuarios.Add(user);

                FileStream stream = new FileStream(sFileName, FileMode.Create);
                BinaryFormatter bFormatter = new BinaryFormatter();
                bFormatter.Serialize(stream, lstUsuarios);
                stream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.ToString());
            }
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
                MessageBox.Show("Ocurrio un error: "+ e.Message);
                if (stream != null)
                {
                    stream.Close();
                }
            }

            return lstUsuarios;
        }

        private void txbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                login();
            }
        }

        private void txbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                login();
            }
        }

        private string ObtenerPermisos()
        {
            StringBuilder sb = new StringBuilder();
            CatalogoPermisos catPermisos = new CatalogoPermisos();
            foreach (Permiso p in catPermisos.ListaPermisos) 
            { 
                sb.Append(p.Valor + ";"); 
            }
            return sb.ToString();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            pictLogo.ImageLocation = ".\\Pict\\LOGO.gif";
        }
    }
}
