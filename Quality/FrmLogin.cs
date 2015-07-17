using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Data;
using System.Data.SqlClient;


namespace Quality
{
    public partial class FrmLogin : DevComponents.DotNetBar.Office2007Form
    {
        Conexao cx = new Conexao();
        Menu objForm = new Menu();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboServer.SelectedIndex = 0;
            swtConn.Enabled = false;
        }

        private void cboServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cx.Db = cboServer.SelectedIndex;
            if (cx.Conectar() == 0 || cx.Conectar() == 1)
            {
                swtConn.Value = true;
                pnlStatus.Text = "";
                
            }
            else
            {
                pnlStatus.Text = "Não foi possivel conectar ao servidor";
                swtConn.Value = false;
            }

            cx.Desconectar();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (swtConn.Value == false)
            {
                pnlStatus.Text = "Não pode logar em um servidor offline";
            }
            else
            {
                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

                if (usuario == "" || senha == "")
                {
                    pnlStatus.Text = "Usuario ou senha em brancos";
                }
                else
                {
                    string sql = "select count(id_usuario) from TB_USUARIO where LOGIN = @usuario and senha = @senha";
                    SqlCommand cmd = new SqlCommand(sql, cx.c);
                    cmd.Parameters.AddWithValue("@usuario", SqlDbType.VarChar).Value = usuario;
                    cmd.Parameters.AddWithValue("@senha", SqlDbType.VarChar).Value = senha;
                    cx.Conectar();

                    int v = (int)cmd.ExecuteScalar();

                    if (v > 0)
                    {
                        pnlStatus.Text = "Usuario logado com sucesso";
                        objForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        pnlStatus.Text = "Usuario ou senha incorretos";
                    }
                }
                cx.Desconectar();
            }
        }
    }
}
