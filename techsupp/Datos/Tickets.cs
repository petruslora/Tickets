using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace techsupp
{
    internal class Tickets : Datos
    {
        public int Codigo { get; set; }
        public string Fecha { get; set; }
        public string Tecnico { get; set; }
        public string Estado { get; set; }
        public string Departamento { get; set; }
        public string ProblemasCon { get; set; }
        public string NumeroActivoFijo { get; set; }
        public string Comentario { get; set; }
        public Tickets()
        {
            
        }
        public Tickets(int codigoTicket)
        {
            this.Codigo = codigoTicket;
        }
        public Tickets(int codigo, string tecnico, string estado, string departamento, string problemasCon, string numeroActivoFijo, string comentario)
        {
            this.Codigo = codigo;
            this.Tecnico = tecnico;
            this.Estado = estado;
            this.Departamento = departamento;
            this.ProblemasCon = problemasCon;
            this.NumeroActivoFijo = numeroActivoFijo;
            this.Comentario = comentario;
        }
        public void CrearTicket()
        {
            // 1. Conectar a la base de datos....
            this.Codigo= GetCodigoTicket();

            // 2. Armar la quiery...
            Query = "EXEC crear_Ticket @tecnico, @estado, @departamento, @problemascon, @noaf, @comentario;";
             
            Comando = new SqlCommand(Query, AbrirBD());
            Comando.Parameters.Add("@tecnico", SqlDbType.VarChar).Value = Tecnico;
            Comando.Parameters.Add("@estado", SqlDbType.VarChar).Value = Estado;
            Comando.Parameters.Add("@departamento", SqlDbType.VarChar).Value = Departamento;
            Comando.Parameters.Add("@problemascon", SqlDbType.VarChar).Value = ProblemasCon;
            Comando.Parameters.Add("@Noaf", SqlDbType.VarChar).Value = NumeroActivoFijo;
            Comando.Parameters.Add("@comentario", SqlDbType.VarChar).Value = Comentario;
            try
            {
                int FilasAfectadas = Comando.ExecuteNonQuery();
                CerrarBD();
                if (FilasAfectadas > 0)
                {
                    // Mensaje que aparece luego de enviar la solicitud    
                    MessageBox.Show("ENVIADO!. El No. de Ticket es -- " + Codigo + ", \n\nRecuerde que puede darle seguimiento a esta solicitud con este nùmero ya que es único. \n\n¿Desea salir? s/n", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error por favor intentelo de nuevo");//"Ha ocurrido un error por favor intentelo de nuevo","Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
            }
        }
        public void EditarTicket()
        {
            {
                Query = "EXEC editarTicket @Tecnico, @Estado, @Departamento, @Problemas, @Noaf, @Comentario,@Ticket";
                Comando = new SqlCommand(Query, AbrirBD());
                Comando.Parameters.Add("@Tecnico", SqlDbType.VarChar).Value = Tecnico;
                Comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = Estado;
                Comando.Parameters.Add("@Departamento", SqlDbType.VarChar).Value = Departamento;
                Comando.Parameters.Add("@Problemas", SqlDbType.VarChar).Value = ProblemasCon;
                Comando.Parameters.Add("@Noaf", SqlDbType.VarChar).Value = NumeroActivoFijo;
                Comando.Parameters.Add("@Comentario", SqlDbType.VarChar).Value = Comentario;
                Comando.Parameters.Add("@Ticket", SqlDbType.Int).Value = Codigo;
                try
                {
                    int FilasAfectadas = Comando.ExecuteNonQuery();
                    CerrarBD();
                    if (FilasAfectadas > 0)
                    {
                        if (MessageBox.Show("El Ticket número " + Codigo + ", ha sido actualizado satisfactoriamente.", "Actualizacion realizada", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK) ;
                        //this.Close();
                        else
                            MessageBox.Show("Ha Ocurrido un error");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error por favor intentelo de nuevo", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Exclamation);
                }
            }
        }
        public void EliminarTicket() 
        {
            try
            {
                if (MessageBox.Show("Hola, esta seguro que desea eliminar el Ticket No. " + Codigo, "Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Query = "EXEC eliminarTicket '" + Codigo + "'";
                    Comando = new SqlCommand(Query, AbrirBD());
                    int FilasAfectadas = Comando.ExecuteNonQuery();
                    CerrarBD();
                    if (FilasAfectadas > 0)
                        MessageBox.Show("El ticket No. " + Codigo+ " ha sido eliminado satisfactoriamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                }
            }
            catch (NullReferenceException x)
            {
                MessageBox.Show(x.Message.ToString());
            }
        }
    }
}
