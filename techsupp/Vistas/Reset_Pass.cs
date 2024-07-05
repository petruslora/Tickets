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
    public partial class Reset_Pass : Form
    {
        private string Usuario;

        public Reset_Pass(string usuario)
        {
            InitializeComponent();
            this.Usuario = usuario;
        }

        private void Resetpass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSA.Tab_Usuarios' table. You can move, or remove it, as needed.
            this.tab_UsuariosTableAdapter.Fill(this.dSA.Tab_Usuarios);
            this.cb_Usuario.Text = this.Usuario;
        }
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (this.tb_pass.TextLength >= 6) //Evalua si la contraseña nueva es valida...
            {
                if (this.tb_pass.Text == this.tb_confirm.Text)
                {
                    Conexion conexion = new Conexion();
                    string pass = tb_pass.Text;
                    string user = this.cb_Usuario.Text;
                    string query = "EXEC editar_UnaContraseña @Usuario, @Pass";

                    SqlCommand comando = new SqlCommand(query, conexion.AbrirBD());
                    // Parametros para la query
                    comando.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = user.ToString();
                    comando.Parameters.Add("@Pass", SqlDbType.VarChar).Value = pass.ToString();

                    int cant = comando.ExecuteNonQuery();
                    conexion.CerrarBD();
                    if (cant == 1) // Evalua si hubieron filas afectadas...
                        {
                            MessageBox.Show("La contraseña se cambio correctamente","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Hide();
                        }else 
                            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.tb_pass.Clear(); this.tb_pass.Focus(); this.tb_confirm.Clear(); }
            }
            else { MessageBox.Show("Introduzca una contraseña de 6 o más caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.tb_pass.Clear(); this.tb_pass.Focus(); this.tb_confirm.Clear();}
        }
            
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
