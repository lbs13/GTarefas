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
    public partial class fCadTarefa : Form
    {
        public fCadTarefa()
        {
            InitializeComponent();
        }

        private void tb_tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_gtarefasDataSet);

        }

        private void fCadTarefa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_gtarefasDataSet.tb_responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_responsavelTableAdapter.Fill(this.bd_gtarefasDataSet.tb_responsavel);
            // TODO: esta linha de código carrega dados na tabela 'bd_gtarefasDataSet.tb_status'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_statusTableAdapter.Fill(this.bd_gtarefasDataSet.tb_status);
            // TODO: esta linha de código carrega dados na tabela 'bd_gtarefasDataSet.tb_tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_tarefaTableAdapter.Fill(this.bd_gtarefasDataSet.tb_tarefa);

        }
    }
}
