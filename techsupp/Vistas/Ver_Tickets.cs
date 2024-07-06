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
    public partial class Ver_Tickets : Form
    {
        //Atributos...
        int codigoTicket;
        private string Fecha, Tecnico, Estado, Departameto, ProblemasCon, No_af, Comentario;
        public Ver_Tickets(int ticket, string fecha, string tecnico, string estado, string departameto,  string problemascon, string no_af, string comentario)
        {
            InitializeComponent();
            this.codigoTicket = ticket;
            this.Fecha = fecha;
            this.Tecnico = tecnico;
            this.Estado = estado;
            this.Departameto = departameto;
            this.ProblemasCon = problemascon;
            this.No_af = no_af;
            this.Comentario = comentario;
        }
        private void Ver_Load(object sender, EventArgs e)
        {
            this.lbl_Ticket.Text = this.codigoTicket.ToString();
            this.lbl_rFecha.Text = this.Fecha;
            this.lbl_rTecnico.Text = this.Tecnico;
            this.lbl_rEstado.Text = this.Estado;
            this.lbl_rDepartamento.Text = this.Departameto;
            this.lbl_rProblemascon.Text = this.ProblemasCon;
            this.lbl_rNoaf.Text = this.No_af;
            this.tb_Descripcion.Text = this.Comentario;
        }
        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void tb_Descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
