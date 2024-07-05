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
    public partial class Nuevo_Usuario : Form
    {
        Usuario usuario = new Usuario();
        public Nuevo_Usuario()
        {
            InitializeComponent();
        }
        private void Nuevo_usuario_Load(object sender, EventArgs e)
        {
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.tb_nombrecompleto.TextLength > 3 && this.tb_nombreUsuario.TextLength > 1)
            {
                if (this.tb_contraseña.TextLength >= 6)
                {
                    if (this.tb_contraseña.Text == this.tb_confirmar.Text)
                    {
                        usuario.CrearUsuario(this.tb_nombreUsuario.Text, this.tb_nombrecompleto.Text, this.tb_contraseña.Text, this.cb_TipoUsuario.Text);                      
                    }
                    else
                    { MessageBox.Show("Las contraseñas no cinciden", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error); this.tb_contraseña.Clear(); this.tb_contraseña.Focus(); this.tb_confirmar.Clear(); }
                }
                else
                { MessageBox.Show("La contraseña debe tener 6 o más caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.tb_contraseña.Clear(); this.tb_contraseña.Focus(); this.tb_confirmar.Clear(); this.tb_nombrecompleto.Focus(); }
            }
            else
            { MessageBox.Show("Por favor llene el formulario correctamente.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); this.tb_nombrecompleto.Focus(); }
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_TipoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
