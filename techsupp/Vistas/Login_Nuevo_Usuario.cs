using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techsupp
{
    public partial class Login_Nuevo_Usuario : Form
    {
        public Login_Nuevo_Usuario(string usuario)
        {
            InitializeComponent();
            this.tb_user.Text = usuario;
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Usuario Usuario = new Usuario();
             
            if (Usuario.ValidarUsuario(this.tb_user.Text, this.tb_pass.Text) == true)
            {
                Nuevo_Usuario Mostrar = new Nuevo_Usuario();
                Mostrar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecto", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_pass.Clear();
                tb_pass.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void tb_user_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LoginNuevoUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
