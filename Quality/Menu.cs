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

namespace Quality
{
    public partial class Menu : DevComponents.DotNetBar.Office2007Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonX49_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            pnlSystem.Text = "Ambiente de produção v0.1";
            sptUser.Visible = false;
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sptUser.Visible = true;
            sptPrinc.Visible = false;
        }

    }
}
