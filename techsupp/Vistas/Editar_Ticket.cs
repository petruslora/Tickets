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
    public partial class Editar_Ticket : Form
    {
        // Atributos...
        private string Ticket, Fecha, Tecnico, Estado, Departamento, ProblemasCon, NoAF, Comentario;
        Tickets tickets = new Tickets();

        public Editar_Ticket(string ticket, string fecha, string tecnico, string estado, string departameto, string problemascon, string noaf, string comentario)
        {
            this.Ticket = ticket;
            this.Fecha = fecha;
            this.Tecnico = tecnico;
            this.Estado = estado;
            this.Departamento = departameto;
            this.ProblemasCon = problemascon;
            this.NoAF = noaf;
            this.Comentario = comentario;
            InitializeComponent();
        }
        private void Editar_ticket_Load(object sender, EventArgs e)
        {
            this.lbl_Ticket.Text = this.Ticket.ToString();
            this.lbl_date.Text = this.Fecha.ToString();
            this.tb_Tecnico.Text = this.Tecnico;
            this.cb_Estado.Text = this.Estado;
            this.tb_Departamento.Text = this.Departamento;
            this.cb_Problemascon.Text = this.ProblemasCon;
            this.tb_noaf.Text = this.NoAF;
            this.tb_comentario.Text = this.Comentario;          
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();    
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            EditarTicket();
        }
        private void cb_Estado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void tb_Departamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void tb_Tecnico_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void EditarTicket()
        {
            if (this.cb_Problemascon.Text.Length <= 2)
            {
                MessageBox.Show("Por favor llene correctamente el formulario ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tickets.EditarTicket(this.Ticket, this.Tecnico, this.cb_Estado.Text, this.tb_Departamento.Text, this.cb_Problemascon.Text, this.tb_noaf.Text, this.tb_comentario.Text);
            }
        }
    }
}
