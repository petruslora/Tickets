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
    public partial class Login_Editar_Usuario : Form
    {
        public Login_Editar_Usuario()
        {
            InitializeComponent();
        }
        public Login_Editar_Usuario(string usuario)
        {
            this.tb_user.Text = usuario;
            InitializeComponent();
        }
        private void LoginEditarUsuario_Load(object sender, EventArgs e)
        {
            this.tb_pass.Focus();
        }
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Usuario Usuario = new Usuario();
            
            if (Usuario.ValidarUsuario(this.tb_user.Text, this.tb_pass.Text) == true)
            {
                Ver_Usuarios Mostrar = new Ver_Usuarios(this.tb_user.Text);
                Mostrar.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_pass.Clear();
                tb_pass.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tb_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
