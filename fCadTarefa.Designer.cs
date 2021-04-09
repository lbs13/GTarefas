
namespace GTarefas
{
    partial class fCadTarefa
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
            System.Windows.Forms.Label id_tarefaLabel;
            System.Windows.Forms.Label descricao_tarefaLabel;
            System.Windows.Forms.Label fk_statusLabel;
            System.Windows.Forms.Label fk_responsavelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadTarefa));
            this.bd_gtarefasDataSet = new GTarefas.bd_gtarefasDataSet();
            this.tb_tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_tarefaTableAdapter = new GTarefas.bd_gtarefasDataSetTableAdapters.tb_tarefaTableAdapter();
            this.tableAdapterManager = new GTarefas.bd_gtarefasDataSetTableAdapters.TableAdapterManager();
            this.tb_responsavelTableAdapter = new GTarefas.bd_gtarefasDataSetTableAdapters.tb_responsavelTableAdapter();
            this.tb_statusTableAdapter = new GTarefas.bd_gtarefasDataSetTableAdapters.tb_statusTableAdapter();
            this.tb_tarefaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tb_tarefaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_tarefaLabel1 = new System.Windows.Forms.Label();
            this.descricao_tarefaTextBox = new System.Windows.Forms.TextBox();
            this.fk_statusComboBox = new System.Windows.Forms.ComboBox();
            this.tbstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fk_responsavelComboBox = new System.Windows.Forms.ComboBox();
            this.tbresponsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            id_tarefaLabel = new System.Windows.Forms.Label();
            descricao_tarefaLabel = new System.Windows.Forms.Label();
            fk_statusLabel = new System.Windows.Forms.Label();
            fk_responsavelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_gtarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefaBindingNavigator)).BeginInit();
            this.tb_tarefaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbresponsavelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_tarefaLabel
            // 
            id_tarefaLabel.AutoSize = true;
            id_tarefaLabel.Location = new System.Drawing.Point(19, 44);
            id_tarefaLabel.Name = "id_tarefaLabel";
            id_tarefaLabel.Size = new System.Drawing.Size(40, 13);
            id_tarefaLabel.TabIndex = 1;
            id_tarefaLabel.Text = "Código";
            // 
            // descricao_tarefaLabel
            // 
            descricao_tarefaLabel.AutoSize = true;
            descricao_tarefaLabel.Location = new System.Drawing.Point(19, 73);
            descricao_tarefaLabel.Name = "descricao_tarefaLabel";
            descricao_tarefaLabel.Size = new System.Drawing.Size(58, 13);
            descricao_tarefaLabel.TabIndex = 3;
            descricao_tarefaLabel.Text = "Descrição:";
            // 
            // fk_statusLabel
            // 
            fk_statusLabel.AutoSize = true;
            fk_statusLabel.Location = new System.Drawing.Point(19, 187);
            fk_statusLabel.Name = "fk_statusLabel";
            fk_statusLabel.Size = new System.Drawing.Size(40, 13);
            fk_statusLabel.TabIndex = 5;
            fk_statusLabel.Text = "Status:";
            // 
            // fk_responsavelLabel
            // 
            fk_responsavelLabel.AutoSize = true;
            fk_responsavelLabel.Location = new System.Drawing.Point(19, 214);
            fk_responsavelLabel.Name = "fk_responsavelLabel";
            fk_responsavelLabel.Size = new System.Drawing.Size(69, 13);
            fk_responsavelLabel.TabIndex = 7;
            fk_responsavelLabel.Text = "Responsável";
            // 
            // bd_gtarefasDataSet
            // 
            this.bd_gtarefasDataSet.DataSetName = "bd_gtarefasDataSet";
            this.bd_gtarefasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_tarefaBindingSource
            // 
            this.tb_tarefaBindingSource.DataMember = "tb_tarefa";
            this.tb_tarefaBindingSource.DataSource = this.bd_gtarefasDataSet;
            // 
            // tb_tarefaTableAdapter
            // 
            this.tb_tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_responsavelTableAdapter = this.tb_responsavelTableAdapter;
            this.tableAdapterManager.tb_statusTableAdapter = this.tb_statusTableAdapter;
            this.tableAdapterManager.tb_tarefaTableAdapter = this.tb_tarefaTableAdapter;
            this.tableAdapterManager.UpdateOrder = GTarefas.bd_gtarefasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_responsavelTableAdapter
            // 
            this.tb_responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // tb_statusTableAdapter
            // 
            this.tb_statusTableAdapter.ClearBeforeFill = true;
            // 
            // tb_tarefaBindingNavigator
            // 
            this.tb_tarefaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_tarefaBindingNavigator.BindingSource = this.tb_tarefaBindingSource;
            this.tb_tarefaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_tarefaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_tarefaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_tarefaBindingNavigatorSaveItem});
            this.tb_tarefaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_tarefaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_tarefaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_tarefaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_tarefaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_tarefaBindingNavigator.Name = "tb_tarefaBindingNavigator";
            this.tb_tarefaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_tarefaBindingNavigator.Size = new System.Drawing.Size(368, 25);
            this.tb_tarefaBindingNavigator.TabIndex = 0;
            this.tb_tarefaBindingNavigator.Text = "bindingNavigator1";
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
            // tb_tarefaBindingNavigatorSaveItem
            // 
            this.tb_tarefaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_tarefaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_tarefaBindingNavigatorSaveItem.Image")));
            this.tb_tarefaBindingNavigatorSaveItem.Name = "tb_tarefaBindingNavigatorSaveItem";
            this.tb_tarefaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_tarefaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_tarefaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_tarefaBindingNavigatorSaveItem_Click);
            // 
            // id_tarefaLabel1
            // 
            this.id_tarefaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_tarefaBindingSource, "id_tarefa", true));
            this.id_tarefaLabel1.Location = new System.Drawing.Point(111, 44);
            this.id_tarefaLabel1.Name = "id_tarefaLabel1";
            this.id_tarefaLabel1.Size = new System.Drawing.Size(121, 23);
            this.id_tarefaLabel1.TabIndex = 2;
            this.id_tarefaLabel1.Text = "label1";
            // 
            // descricao_tarefaTextBox
            // 
            this.descricao_tarefaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_tarefaBindingSource, "descricao_tarefa", true));
            this.descricao_tarefaTextBox.Location = new System.Drawing.Point(111, 70);
            this.descricao_tarefaTextBox.Multiline = true;
            this.descricao_tarefaTextBox.Name = "descricao_tarefaTextBox";
            this.descricao_tarefaTextBox.Size = new System.Drawing.Size(223, 108);
            this.descricao_tarefaTextBox.TabIndex = 4;
            // 
            // fk_statusComboBox
            // 
            this.fk_statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_tarefaBindingSource, "fk_status", true));
            this.fk_statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbstatusBindingSource, "nome_status", true));
            this.fk_statusComboBox.DataSource = this.tbstatusBindingSource;
            this.fk_statusComboBox.DisplayMember = "nome_status";
            this.fk_statusComboBox.FormattingEnabled = true;
            this.fk_statusComboBox.Location = new System.Drawing.Point(111, 184);
            this.fk_statusComboBox.Name = "fk_statusComboBox";
            this.fk_statusComboBox.Size = new System.Drawing.Size(223, 21);
            this.fk_statusComboBox.TabIndex = 6;
            this.fk_statusComboBox.ValueMember = "id_status";
            // 
            // tbstatusBindingSource
            // 
            this.tbstatusBindingSource.DataMember = "tb_status";
            this.tbstatusBindingSource.DataSource = this.bd_gtarefasDataSet;
            // 
            // fk_responsavelComboBox
            // 
            this.fk_responsavelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_tarefaBindingSource, "fk_responsavel", true));
            this.fk_responsavelComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbresponsavelBindingSource, "nome_responsavel", true));
            this.fk_responsavelComboBox.DataSource = this.tbresponsavelBindingSource;
            this.fk_responsavelComboBox.DisplayMember = "nome_responsavel";
            this.fk_responsavelComboBox.FormattingEnabled = true;
            this.fk_responsavelComboBox.Location = new System.Drawing.Point(111, 211);
            this.fk_responsavelComboBox.Name = "fk_responsavelComboBox";
            this.fk_responsavelComboBox.Size = new System.Drawing.Size(223, 21);
            this.fk_responsavelComboBox.TabIndex = 8;
            this.fk_responsavelComboBox.ValueMember = "id_responsavel";
            // 
            // tbresponsavelBindingSource
            // 
            this.tbresponsavelBindingSource.DataMember = "tb_responsavel";
            this.tbresponsavelBindingSource.DataSource = this.bd_gtarefasDataSet;
            // 
            // fCadTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 260);
            this.Controls.Add(id_tarefaLabel);
            this.Controls.Add(this.id_tarefaLabel1);
            this.Controls.Add(descricao_tarefaLabel);
            this.Controls.Add(this.descricao_tarefaTextBox);
            this.Controls.Add(fk_statusLabel);
            this.Controls.Add(this.fk_statusComboBox);
            this.Controls.Add(fk_responsavelLabel);
            this.Controls.Add(this.fk_responsavelComboBox);
            this.Controls.Add(this.tb_tarefaBindingNavigator);
            this.Name = "fCadTarefa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GT Tarefa";
            this.Load += new System.EventHandler(this.fCadTarefa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_gtarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_tarefaBindingNavigator)).EndInit();
            this.tb_tarefaBindingNavigator.ResumeLayout(false);
            this.tb_tarefaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbresponsavelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_gtarefasDataSet bd_gtarefasDataSet;
        private System.Windows.Forms.BindingSource tb_tarefaBindingSource;
        private bd_gtarefasDataSetTableAdapters.tb_tarefaTableAdapter tb_tarefaTableAdapter;
        private bd_gtarefasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_tarefaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_tarefaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label id_tarefaLabel1;
        private System.Windows.Forms.TextBox descricao_tarefaTextBox;
        private System.Windows.Forms.ComboBox fk_statusComboBox;
        private System.Windows.Forms.ComboBox fk_responsavelComboBox;
        private bd_gtarefasDataSetTableAdapters.tb_statusTableAdapter tb_statusTableAdapter;
        private System.Windows.Forms.BindingSource tbstatusBindingSource;
        private bd_gtarefasDataSetTableAdapters.tb_responsavelTableAdapter tb_responsavelTableAdapter;
        private System.Windows.Forms.BindingSource tbresponsavelBindingSource;
    }
}