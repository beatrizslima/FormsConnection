using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPesquisaCli_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = String.Format("SELECT * FROM clientes WHERE codigo = {0}", txtCodigoCli.Text);
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Conexao.abreConexao();
            MySqlDataReader dr;

            try
            {
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtCodigoCli.Text = dr["codigo"].ToString();
                    txtNomeCli.Text = dr["nome"].ToString();
                 
                    string sexo = dr[sexo].ToString();
                    if (sexo == "Feminino")
                        rbtFem.Checked = true;
                    else if (sexo == "Masculino")                   
                        rbtMasc.Checked = true;
                }
                else
                {
                    txtNomeCli.Text = "";
                    rbtMasc.Checked= false;
                    rbtFem.Checked= false;
                }
                dr.Close();
                cmd.Dispose();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.fechaConexao();
            }
        }
    }
}
