using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTarefas
{
    public partial class PrincipalGT : Form
    {
        public PrincipalGT()
        {
            InitializeComponent();
        }


        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fCadStatus cadStatus = new fCadStatus();
            cadStatus.ShowDialog();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fCadResponsavel cadResponsavel = new fCadResponsavel();
            cadResponsavel.ShowDialog();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fCadTarefa cadTarefa = new fCadTarefa();
            cadTarefa.ShowDialog();
        }



        private void PrincipalGT_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_gtarefasDataSet.SelectQueryNOVO'. Você pode movê-la ou removê-la conforme necessário.
            this.selectQueryNOVOTableAdapter.Fill(this.bd_gtarefasDataSet.SelectQueryNOVO);
           
        }


    }
}
