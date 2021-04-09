
namespace GTarefas
{
    partial class fCadStatus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_statusLabel;
            System.Windows.Forms.Label nome_statusLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadStatus));
            this.bd_gtarefasDataSet = new GTarefas.bd_gtarefasDataSet();
            this.tb_statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_statusTableAdapter = new GTarefas.bd_gtarefasDataSetTableAdapters.tb_statusTableAdapter();
            this.tableAdapterManager = new GTarefas.bd_gtarefasDataSetTableAdapters.TableAdapterManager();
            this.tb_statusBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_statusBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_statusLabel1 = new System.Windows.Forms.Label();
            this.nome_statusTextBox = new System.Windows.Forms.TextBox();
            id_statusLabel = new System.Windows.Forms.Label();
            nome_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_gtarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_statusBindingNavigator)).BeginInit();
            this.tb_statusBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_statusLabel
            // 
            id_statusLabel.AutoSize = true;
            id_statusLabel.Location = new System.Drawing.Point(7, 42);
            id_statusLabel.Name = "id_statusLabel";
            id_statusLabel.Size = new System.Drawing.Size(43, 13);
            id_statusLabel.TabIndex = 1;
            id_statusLabel.Text = "Código:";
            id_statusLabel.Click += new System.EventHandler(this.id_statusLabel_Click);
            // 
            // nome_statusLabel
            // 
            nome_statusLabel.AutoSize = true;
            nome_statusLabel.Location = new System.Drawing.Point(7, 71);
            nome_statusLabel.Name = "nome_statusLabel";
            nome_statusLabel.Size = new System.Drawing.Size(55, 13);
            nome_statusLabel.TabIndex = 3;
            nome_statusLabel.Text = "Descrição";
            // 
            // bd_gtarefasDataSet
            // 
            this.bd_gtarefasDataSet.DataSetName = "bd_gtarefasDataSet";
            this.bd_gtarefasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_statusBindingSource
            // 
            this.tb_statusBindingSource.DataMember = "tb_status";
            this.tb_statusBindingSource.DataSource = this.bd_gtarefasDataSet;
            // 
            // tb_statusTableAdapter
            // 
            this.tb_statusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_responsavelTableAdapter = null;
            this.tableAdapterManager.tb_statusTableAdapter = this.tb_statusTableAdapter;
            this.tableAdapterManager.tb_tarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GTarefas.bd_gtarefasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_statusBindingNavigator
            // 
            this.tb_statusBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_statusBindingNavigator.BindingSource = this.tb_statusBindingSource;
            this.tb_statusBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_statusBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_statusBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_statusBindingNavigatorSaveItem});
            this.tb_statusBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_statusBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_statusBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_statusBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_statusBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_statusBindingNavigator.Name = "tb_statusBindingNavigator";
            this.tb_statusBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_statusBindingNavigator.Size = new System.Drawing.Size(312, 25);
            this.tb_statusBindingNavigator.TabIndex = 0;
            this.tb_statusBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_statusBindingNavigatorSaveItem
            // 
            this.tb_statusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_statusBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_statusBindingNavigatorSaveItem.Image")));
            this.tb_statusBindingNavigatorSaveItem.Name = "tb_statusBindingNavigatorSaveItem";
            this.tb_statusBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_statusBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_statusBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_statusBindingNavigatorSaveItem_Click);
            // 
            // id_statusLabel1
            // 
            this.id_statusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_statusBindingSource, "id_status", true));
            this.id_statusLabel1.Location = new System.Drawing.Point(80, 42);
            this.id_statusLabel1.Name = "id_statusLabel1";
            this.id_statusLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_statusLabel1.TabIndex = 2;
            this.id_statusLabel1.Text = "label1";
            // 
            // nome_statusTextBox
            // 
            this.nome_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_statusBindingSource, "nome_status", true));
            this.nome_statusTextBox.Location = new System.Drawing.Point(80, 68);
            this.nome_statusTextBox.Name = "nome_statusTextBox";
            this.nome_statusTextBox.Size = new System.Drawing.Size(182, 20);
            this.nome_statusTextBox.TabIndex = 4;
            // 
            // fCadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 136);
            this.Controls.Add(id_statusLabel);
            this.Controls.Add(this.id_statusLabel1);
            this.Controls.Add(nome_statusLabel);
            this.Controls.Add(this.nome_statusTextBox);
            this.Controls.Add(this.tb_statusBindingNavigator);
            this.Name = "fCadStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GT Status";
            this.Load += new System.EventHandler(this.fCadGT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_gtarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_statusBindingNavigator)).EndInit();
            this.tb_statusBindingNavigator.ResumeLayout(false);
            this.tb_statusBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_gtarefasDataSet bd_gtarefasDataSet;
        private System.Windows.Forms.BindingSource tb_statusBindingSource;
        private bd_gtarefasDataSetTableAdapters.tb_statusTableAdapter tb_statusTableAdapter;
        private bd_gtarefasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_statusBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_statusBindingNavigatorSaveItem;
        private System.Windows.Forms.Label id_statusLabel1;
        private System.Windows.Forms.TextBox nome_statusTextBox;
    }
}