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
        Tickets tickets = new Tickets();
        Datos datos = new Datos();
        int codigoTicket;

        public Editar_Ticket(int ticket, string fecha, string tecnico, string estado, string departameto, string problemascon, string noaf, string comentario)
        {
            
            tickets.Codigo = ticket;
            tickets.Fecha = fecha;
            tickets.Tecnico = tecnico;
            tickets.Estado = estado;
            tickets.Departamento = departameto;
            tickets.ProblemasCon = problemascon;
            tickets.NumeroActivoFijo = noaf;
            tickets.Comentario = comentario;
            InitializeComponent();
        }
        private void Editar_ticket_Load(object sender, EventArgs e)
        {
            this.lbl_Ticket.Text = tickets.Codigo.ToString();
            this.lbl_date.Text = tickets.Fecha.ToString();
            this.tb_Tecnico.Text = tickets.Tecnico;
            this.cb_Estado.Text = tickets.Estado;
            this.tb_Departamento.Text = tickets.Departamento;
            this.cb_Problemascon.Text = tickets.ProblemasCon;
            this.tb_noaf.Text = tickets.NumeroActivoFijo;
            this.tb_comentario.Text = tickets.Comentario;          
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
               new Tickets(tickets.Codigo, tickets.Tecnico, this.cb_Estado.Text, this.tb_Departamento.Text, this.cb_Problemascon.Text, this.tb_noaf.Text, this.tb_comentario.Text).EditarTicket();
                this.Close();
            }
        }
    }
}
