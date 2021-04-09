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
    public partial class fCadResponsavel : Form
    {
        public fCadResponsavel()
        {
            InitializeComponent();
        }

        private void tb_responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_gtarefasDataSet);

        }

        private void fCadResponsavel_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bd_gtarefasDataSet.tb_responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_responsavelTableAdapter.Fill(this.bd_gtarefasDataSet.tb_responsavel);

        }
    }
}
