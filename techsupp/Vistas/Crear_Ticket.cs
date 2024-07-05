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
    public partial class Crear_Ticket : Form
    {
        Datos datos = new Datos();

        public Crear_Ticket(string usuario) // Sobrecarga del constructor...
        {
            InitializeComponent();
            this.tb_Tecnico.Text = usuario.ToString();
        }
        private void Reporte_Load(object sender, EventArgs e)
        {
            this.lbl_date.Text = this.dt_Picker1.Text;
            this.dt_Picker1.Hide();
            this.lbl_Ticket.Text = datos.GetCodigoTicket().ToString();
        }
        private void btn_guardar_Click_1(object sender, EventArgs e)
        {
            if (tb_Tecnico.Text == "" || cb_Estado.Text == "" || tb_Departamento.TextLength <= 2 || cb_Problemascon.Text == "")
                MessageBox.Show("Por favor llene el formulario correctamente, los campos marcados con * son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                new Tickets().CrearTicket(this.tb_Tecnico.Text, this.cb_Estado.Text, this.tb_Departamento.Text, this.cb_Problemascon.Text, this.tb_af.Text, this.tb_descripcion.Text);
                LimpiarCampos();
                this.Close();
            }
            
        }
        public void LimpiarCampos()
        {
            //2.Limpiamos los Campos de textos.
            this.cb_Estado.Text = "";
            this.tb_Departamento.Text = "";
            this.cb_Problemascon.Text = "";
            this.tb_descripcion.Text = "";
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cb_Estado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Esta linea evita que se escriba el en combo box...
            e.Handled = true;
        }
        private void tb_Tecnico_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Esta linea evita que se escriba el en combo box...
            e.Handled = true;
        }
        private void tb_Departamento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
