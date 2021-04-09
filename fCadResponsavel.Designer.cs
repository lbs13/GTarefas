
namespace GTarefas
{
    partial class fCadResponsavel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCadResponsavel));
            System.Windows.Forms.Label id_responsavelLabel;
            System.Windows.Forms.Label nome_responsavelLabel;
            this.bd_gtarefasDataSet = new GTarefas.bd_gtarefasDataSet();
            this.tb_responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_responsavelTableAdapter = new GTarefas.bd_gtarefasDataSetTableAdapters.tb_responsavelTableAdapter();
            this.tableAdapterManager = new GTarefas.bd_gtarefasDataSetTableAdapters.TableAdapterManager();
            this.tb_responsavelBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.tb_responsavelBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_responsavelLabel1 = new System.Windows.Forms.Label();
            this.nome_responsavelTextBox = new System.Windows.Forms.TextBox();
            id_responsavelLabel = new System.Windows.Forms.Label();
            nome_responsavelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_gtarefasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_responsavelBindingNavigator)).BeginInit();
            this.tb_responsavelBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bd_gtarefasDataSet
            // 
            this.bd_gtarefasDataSet.DataSetName = "bd_gtarefasDataSet";
            this.bd_gtarefasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_responsavelBindingSource
            // 
            this.tb_responsavelBindingSource.DataMember = "tb_responsavel";
            this.tb_responsavelBindingSource.DataSource = this.bd_gtarefasDataSet;
            // 
            // tb_responsavelTableAdapter
            // 
            this.tb_responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_responsavelTableAdapter = this.tb_responsavelTableAdapter;
            this.tableAdapterManager.tb_statusTableAdapter = null;
            this.tableAdapterManager.tb_tarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = GTarefas.bd_gtarefasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_responsavelBindingNavigator
            // 
            this.tb_responsavelBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_responsavelBindingNavigator.BindingSource = this.tb_responsavelBindingSource;
            this.tb_responsavelBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_responsavelBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_responsavelBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tb_responsavelBindingNavigatorSaveItem});
            this.tb_responsavelBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_responsavelBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_responsavelBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_responsavelBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_responsavelBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_responsavelBindingNavigator.Name = "tb_responsavelBindingNavigator";
            this.tb_responsavelBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_responsavelBindingNavigator.Size = new System.Drawing.Size(331, 25);
            this.tb_responsavelBindingNavigator.TabIndex = 0;
            this.tb_responsavelBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 15);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // tb_responsavelBindingNavigatorSaveItem
            // 
            this.tb_responsavelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_responsavelBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_responsavelBindingNavigatorSaveItem.Image")));
            this.tb_responsavelBindingNavigatorSaveItem.Name = "tb_responsavelBindingNavigatorSaveItem";
            this.tb_responsavelBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.tb_responsavelBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tb_responsavelBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_responsavelBindingNavigatorSaveItem_Click);
            // 
            // id_responsavelLabel
            // 
            id_responsavelLabel.AutoSize = true;
            id_responsavelLabel.Location = new System.Drawing.Point(12, 42);
            id_responsavelLabel.Name = "id_responsavelLabel";
            id_responsavelLabel.Size = new System.Drawing.Size(43, 13);
            id_responsavelLabel.TabIndex = 1;
            id_responsavelLabel.Text = "Código:";
            // 
            // id_responsavelLabel1
            // 
            this.id_responsavelLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_responsavelBindingSource, "id_responsavel", true));
            this.id_responsavelLabel1.Location = new System.Drawing.Point(114, 42);
            this.id_responsavelLabel1.Name = "id_responsavelLabel1";
            this.id_responsavelLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_responsavelLabel1.TabIndex = 2;
            this.id_responsavelLabel1.Text = "label1";
            // 
            // nome_responsavelLabel
            // 
            nome_responsavelLabel.AutoSize = true;
            nome_responsavelLabel.Location = new System.Drawing.Point(12, 71);
            nome_responsavelLabel.Name = "nome_responsavelLabel";
            nome_responsavelLabel.Size = new System.Drawing.Size(72, 13);
            nome_responsavelLabel.TabIndex = 3;
            nome_responsavelLabel.Text = "Responsável:";
            // 
            // nome_responsavelTextBox
            // 
            this.nome_responsavelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_responsavelBindingSource, "nome_responsavel", true));
            this.nome_responsavelTextBox.Location = new System.Drawing.Point(114, 68);
            this.nome_responsavelTextBox.Name = "nome_responsavelTextBox";
            this.nome_responsavelTextBox.Size = new System.Drawing.Size(196, 20);
            this.nome_responsavelTextBox.TabIndex = 4;
            // 
            // fCadResponsavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 140);
            this.Controls.Add(id_responsavelLabel);
            this.Controls.Add(this.id_responsavelLabel1);
            this.Controls.Add(nome_responsavelLabel);
            this.Controls.Add(this.nome_responsavelTextBox);
            this.Controls.Add(this.tb_responsavelBindingNavigator);
            this.Name = "fCadResponsavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GT Responsável";
            this.Load += new System.EventHandler(this.fCadResponsavel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_gtarefasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_responsavelBindingNavigator)).EndInit();
            this.tb_responsavelBindingNavigator.ResumeLayout(false);
            this.tb_responsavelBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd_gtarefasDataSet bd_gtarefasDataSet;
        private System.Windows.Forms.BindingSource tb_responsavelBindingSource;
        private bd_gtarefasDataSetTableAdapters.tb_responsavelTableAdapter tb_responsavelTableAdapter;
        private bd_gtarefasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_responsavelBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tb_responsavelBindingNavigatorSaveItem;
        private System.Windows.Forms.Label id_responsavelLabel1;
        private System.Windows.Forms.TextBox nome_responsavelTextBox;
    }
}