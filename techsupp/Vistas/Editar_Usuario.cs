using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace techsupp
{
    public partial class Editar_Usuario : Form
    {
        private string Usuario;
        public Editar_Usuario()
        {
            InitializeComponent();
        }
        public Editar_Usuario(string usuario)
        {
            InitializeComponent();
            this.tb_user.Text = usuario;
        }
        private void Cambiar_pass_Load(object sender, EventArgs e)
        {
            OcultarControles();
        }
        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();    
            if (usuario.ValidarUsuario(tb_user.Text, tb_pass.Text) == true)
            {
                MostrarControles();
                tb_nuevapass.Focus();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_pass.Clear();
                tb_pass.Focus();
            }
        }
        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            if (tb_nuevapass.Text == tb_nuevapassconf.Text) // Evalua si la contraseña nueva es valida...
            { 
                EvaluaPassword();
            }
            else
            {
                MessageBox.Show("Las contraseñas introducidas no coninciden...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_nuevapass.Focus();
                tb_nuevapass.Clear();
                tb_nuevapassconf.Clear();
            }
        }
        public void MostrarControles()
        {
            lbl_nuevapass.Show();
            lbl_nuevapassconf.Show();
            tb_nuevapass.Show();
            tb_nuevapassconf.Show();
            btn_cambiar.Show();
            this.label7.Show();
        }
        public void OcultarControles()
        {
            lbl_nuevapass.Hide();
            lbl_nuevapassconf.Hide();
            tb_nuevapass.Hide();
            tb_nuevapassconf.Hide();
            btn_cambiar.Hide();
            this.label7.Hide();
        }
        public void EvaluaPassword()
        {
            if (tb_nuevapass.TextLength >= 6) //Evalua si la contraseña nueva es valida...
                {
                    Conexion conexion = new Conexion();
                    string query = @"exec editar_Contraseña @NombreUsuario, @Contraseña; ";

                    SqlCommand comando = new SqlCommand(query, conexion.AbrirBD());
                    // Parametros para la query...
                    comando.Parameters.Add("@NombreUsuario", SqlDbType.VarChar).Value = tb_user.Text;
                    comando.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = tb_nuevapass.Text;

                    int cant = comando.ExecuteNonQuery();
                    conexion.CerrarBD();
                    if (cant == 1) // Evalua si hubieron filas afectadas...
                        {
                            MessageBox.Show("La contraseña se cambio correctamente");
                            tb_user.Clear();
                            tb_pass.Clear();
                            tb_nuevapass.Clear();
                            tb_nuevapassconf.Clear();
                            this.Hide();
                        }else
                            MessageBox.Show("Ha ocurrido un error");                        
                } 
            else 
                {
                    MessageBox.Show("Introduzca una contraseña de 6 o más caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_nuevapass.Focus();
                    tb_nuevapass.Clear();
                    tb_nuevapassconf.Clear();
                } //Fin del if... 
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
