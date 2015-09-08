namespace DatabaseApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.database1DataSet = new DatabaseApp.Database1DataSet();
            this.contact_ListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contact_ListTableAdapter = new DatabaseApp.Database1DataSetTableAdapters.Contact_ListTableAdapter();
            this.tableAdapterManager = new DatabaseApp.Database1DataSetTableAdapters.TableAdapterManager();
            this.contact_ListBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.contact_ListBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.contact_ListDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_ListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_ListBindingNavigator)).BeginInit();
            this.contact_ListBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contact_ListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contact_ListBindingSource
            // 
            this.contact_ListBindingSource.DataMember = "Contact List";
            this.contact_ListBindingSource.DataSource = this.database1DataSet;
            // 
            // contact_ListTableAdapter
            // 
            this.contact_ListTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Contact_ListTableAdapter = this.contact_ListTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseApp.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contact_ListBindingNavigator
            // 
            this.contact_ListBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contact_ListBindingNavigator.BindingSource = this.contact_ListBindingSource;
            this.contact_ListBindingNavigator.CountItem = null;
            this.contact_ListBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contact_ListBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.contact_ListBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contact_ListBindingNavigatorSaveItem});
            this.contact_ListBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contact_ListBindingNavigator.MoveFirstItem = null;
            this.contact_ListBindingNavigator.MoveLastItem = null;
            this.contact_ListBindingNavigator.MoveNextItem = null;
            this.contact_ListBindingNavigator.MovePreviousItem = null;
            this.contact_ListBindingNavigator.Name = "contact_ListBindingNavigator";
            this.contact_ListBindingNavigator.PositionItem = null;
            this.contact_ListBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contact_ListBindingNavigator.Size = new System.Drawing.Size(670, 25);
            this.contact_ListBindingNavigator.TabIndex = 0;
            this.contact_ListBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Löschen";
            // 
            // contact_ListBindingNavigatorSaveItem
            // 
            this.contact_ListBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contact_ListBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contact_ListBindingNavigatorSaveItem.Image")));
            this.contact_ListBindingNavigatorSaveItem.Name = "contact_ListBindingNavigatorSaveItem";
            this.contact_ListBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contact_ListBindingNavigatorSaveItem.Text = "Daten speichern";
            this.contact_ListBindingNavigatorSaveItem.Click += new System.EventHandler(this.contact_ListBindingNavigatorSaveItem_Click_1);
            // 
            // contact_ListDataGridView
            // 
            this.contact_ListDataGridView.AutoGenerateColumns = false;
            this.contact_ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contact_ListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.contact_ListDataGridView.DataSource = this.contact_ListBindingSource;
            this.contact_ListDataGridView.Location = new System.Drawing.Point(12, 90);
            this.contact_ListDataGridView.Name = "contact_ListDataGridView";
            this.contact_ListDataGridView.Size = new System.Drawing.Size(646, 306);
            this.contact_ListDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vorname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vorname";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Hausnummer";
            this.dataGridViewTextBoxColumn3.HeaderText = "Hausnummer";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Straße";
            this.dataGridViewTextBoxColumn4.HeaderText = "Straße";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PZ";
            this.dataGridViewTextBoxColumn5.HeaderText = "PZ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ort";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ort";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(23, 28);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(145, 20);
            this.tb_name.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 405);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.contact_ListDataGridView);
            this.Controls.Add(this.contact_ListBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_ListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contact_ListBindingNavigator)).EndInit();
            this.contact_ListBindingNavigator.ResumeLayout(false);
            this.contact_ListBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contact_ListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource contact_ListBindingSource;
        private Database1DataSetTableAdapters.Contact_ListTableAdapter contact_ListTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contact_ListBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton contact_ListBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView contact_ListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox tb_name;

    }
}

