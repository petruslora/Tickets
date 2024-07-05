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
    public partial class Login : Form
    {
        Usuario usuario = new Usuario();
                 
        public Login()
        {
            InitializeComponent();
        }     
        private void btn_entrar_Click_1(object sender, EventArgs e)
        {
                if (usuario.ValidarUsuario(this.tb_user.Text.ToLower(), this.tb_pass.Text) == true)
                {
                Appsoporte principal = new Appsoporte(this.tb_user.Text.ToLower());
                principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_pass.Clear();
                    tb_pass.Focus();
                }
        }
        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
