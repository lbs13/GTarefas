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
    public partial class fCadStatus : Form
    {
        public fCadStatus()
        {
            InitializeComponent();
        }

        private void tb_statusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_gtarefasDataSet);

        }

        private void fCadGT_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_gtarefasDataSet.tb_status'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_statusTableAdapter.Fill(this.bd_gtarefasDataSet.tb_status);

        }

        private void id_statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
