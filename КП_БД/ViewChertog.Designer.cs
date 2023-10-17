
namespace КП_БД
{
    partial class ViewChertog
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
            System.Windows.Forms.Label chertognoLabel;
            System.Windows.Forms.Label chnameLabel;
            System.Windows.Forms.Label chsphereLabel;
            System.Windows.Forms.Label chcharLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewChertog));
            this.dataDBDataSet = new КП_БД.DataDBDataSet();
            this.cHERTOGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHERTOGTableAdapter = new КП_БД.DataDBDataSetTableAdapters.CHERTOGTableAdapter();
            this.tableAdapterManager = new КП_БД.DataDBDataSetTableAdapters.TableAdapterManager();
            this.pERSONTableAdapter = new КП_БД.DataDBDataSetTableAdapters.PERSONTableAdapter();
            this.cHERTOGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cHERTOGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.chertognoTextBox = new System.Windows.Forms.TextBox();
            this.chnameTextBox = new System.Windows.Forms.TextBox();
            this.chsphereTextBox = new System.Windows.Forms.TextBox();
            this.chcharTextBox = new System.Windows.Forms.TextBox();
            this.pERSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            chertognoLabel = new System.Windows.Forms.Label();
            chnameLabel = new System.Windows.Forms.Label();
            chsphereLabel = new System.Windows.Forms.Label();
            chcharLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHERTOGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHERTOGBindingNavigator)).BeginInit();
            this.cHERTOGBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chertognoLabel
            // 
            chertognoLabel.AutoSize = true;
            chertognoLabel.Location = new System.Drawing.Point(12, 42);
            chertognoLabel.Name = "chertognoLabel";
            chertognoLabel.Size = new System.Drawing.Size(58, 13);
            chertognoLabel.TabIndex = 1;
            chertognoLabel.Text = "chertogno:";
            // 
            // chnameLabel
            // 
            chnameLabel.AutoSize = true;
            chnameLabel.Location = new System.Drawing.Point(12, 68);
            chnameLabel.Name = "chnameLabel";
            chnameLabel.Size = new System.Drawing.Size(48, 13);
            chnameLabel.TabIndex = 3;
            chnameLabel.Text = "chname:";
            // 
            // chsphereLabel
            // 
            chsphereLabel.AutoSize = true;
            chsphereLabel.Location = new System.Drawing.Point(12, 94);
            chsphereLabel.Name = "chsphereLabel";
            chsphereLabel.Size = new System.Drawing.Size(54, 13);
            chsphereLabel.TabIndex = 5;
            chsphereLabel.Text = "chsphere:";
            // 
            // chcharLabel
            // 
            chcharLabel.AutoSize = true;
            chcharLabel.Location = new System.Drawing.Point(12, 120);
            chcharLabel.Name = "chcharLabel";
            chcharLabel.Size = new System.Drawing.Size(43, 13);
            chcharLabel.TabIndex = 7;
            chcharLabel.Text = "chchar:";
            // 
            // dataDBDataSet
            // 
            this.dataDBDataSet.DataSetName = "DataDBDataSet";
            this.dataDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHERTOGBindingSource
            // 
            this.cHERTOGBindingSource.DataMember = "CHERTOG";
            this.cHERTOGBindingSource.DataSource = this.dataDBDataSet;
            // 
            // cHERTOGTableAdapter
            // 
            this.cHERTOGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHERTOGTableAdapter = this.cHERTOGTableAdapter;
            this.tableAdapterManager.GUARDNUMBERTableAdapter = null;
            this.tableAdapterManager.HALLTableAdapter = null;
            this.tableAdapterManager.LIFENUMBERTableAdapter = null;
            this.tableAdapterManager.PERSONTableAdapter = this.pERSONTableAdapter;
            this.tableAdapterManager.UpdateOrder = КП_БД.DataDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ZODIAKTableAdapter = null;
            // 
            // pERSONTableAdapter
            // 
            this.pERSONTableAdapter.ClearBeforeFill = true;
            // 
            // cHERTOGBindingNavigator
            // 
            this.cHERTOGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cHERTOGBindingNavigator.BindingSource = this.cHERTOGBindingSource;
            this.cHERTOGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cHERTOGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cHERTOGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cHERTOGBindingNavigatorSaveItem});
            this.cHERTOGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cHERTOGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cHERTOGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cHERTOGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cHERTOGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cHERTOGBindingNavigator.Name = "cHERTOGBindingNavigator";
            this.cHERTOGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cHERTOGBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.cHERTOGBindingNavigator.TabIndex = 0;
            this.cHERTOGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cHERTOGBindingNavigatorSaveItem
            // 
            this.cHERTOGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cHERTOGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cHERTOGBindingNavigatorSaveItem.Image")));
            this.cHERTOGBindingNavigatorSaveItem.Name = "cHERTOGBindingNavigatorSaveItem";
            this.cHERTOGBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cHERTOGBindingNavigatorSaveItem.Text = "Save Data";
            this.cHERTOGBindingNavigatorSaveItem.Click += new System.EventHandler(this.cHERTOGBindingNavigatorSaveItem_Click);
            // 
            // chertognoTextBox
            // 
            this.chertognoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHERTOGBindingSource, "chertogno", true));
            this.chertognoTextBox.Location = new System.Drawing.Point(76, 39);
            this.chertognoTextBox.Name = "chertognoTextBox";
            this.chertognoTextBox.Size = new System.Drawing.Size(100, 20);
            this.chertognoTextBox.TabIndex = 2;
            // 
            // chnameTextBox
            // 
            this.chnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHERTOGBindingSource, "chname", true));
            this.chnameTextBox.Location = new System.Drawing.Point(76, 65);
            this.chnameTextBox.Name = "chnameTextBox";
            this.chnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.chnameTextBox.TabIndex = 4;
            // 
            // chsphereTextBox
            // 
            this.chsphereTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHERTOGBindingSource, "chsphere", true));
            this.chsphereTextBox.Location = new System.Drawing.Point(76, 91);
            this.chsphereTextBox.Name = "chsphereTextBox";
            this.chsphereTextBox.Size = new System.Drawing.Size(100, 20);
            this.chsphereTextBox.TabIndex = 6;
            // 
            // chcharTextBox
            // 
            this.chcharTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cHERTOGBindingSource, "chchar", true));
            this.chcharTextBox.Location = new System.Drawing.Point(76, 117);
            this.chcharTextBox.Name = "chcharTextBox";
            this.chcharTextBox.Size = new System.Drawing.Size(100, 20);
            this.chcharTextBox.TabIndex = 8;
            // 
            // pERSONBindingSource
            // 
            this.pERSONBindingSource.DataMember = "FK__PERSON__chertogn__4E88ABD4";
            this.pERSONBindingSource.DataSource = this.cHERTOGBindingSource;
            // 
            // pERSONDataGridView
            // 
            this.pERSONDataGridView.AutoGenerateColumns = false;
            this.pERSONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pERSONDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.pERSONDataGridView.DataSource = this.pERSONBindingSource;
            this.pERSONDataGridView.Location = new System.Drawing.Point(15, 143);
            this.pERSONDataGridView.Name = "pERSONDataGridView";
            this.pERSONDataGridView.Size = new System.Drawing.Size(420, 126);
            this.pERSONDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pid";
            this.dataGridViewTextBoxColumn1.HeaderText = "pid";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pname";
            this.dataGridViewTextBoxColumn2.HeaderText = "pname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "psurname";
            this.dataGridViewTextBoxColumn3.HeaderText = "psurname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "chertogno";
            this.dataGridViewTextBoxColumn4.HeaderText = "chertogno";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "hallno";
            this.dataGridViewTextBoxColumn5.HeaderText = "hallno";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "zodiakno";
            this.dataGridViewTextBoxColumn6.HeaderText = "zodiakno";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "lifenumberno";
            this.dataGridViewTextBoxColumn7.HeaderText = "lifenumberno";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "guardnumberno";
            this.dataGridViewTextBoxColumn8.HeaderText = "guardnumberno";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "pyear";
            this.dataGridViewTextBoxColumn9.HeaderText = "pyear";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "pmonth";
            this.dataGridViewTextBoxColumn10.HeaderText = "pmonth";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "pday";
            this.dataGridViewTextBoxColumn11.HeaderText = "pday";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "phour";
            this.dataGridViewTextBoxColumn12.HeaderText = "phour";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "pmin";
            this.dataGridViewTextBoxColumn13.HeaderText = "pmin";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Confirm changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewChertog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pERSONDataGridView);
            this.Controls.Add(chertognoLabel);
            this.Controls.Add(this.chertognoTextBox);
            this.Controls.Add(chnameLabel);
            this.Controls.Add(this.chnameTextBox);
            this.Controls.Add(chsphereLabel);
            this.Controls.Add(this.chsphereTextBox);
            this.Controls.Add(chcharLabel);
            this.Controls.Add(this.chcharTextBox);
            this.Controls.Add(this.cHERTOGBindingNavigator);
            this.Name = "ViewChertog";
            this.Text = "Chertog Info";
            this.Load += new System.EventHandler(this.RSForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHERTOGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHERTOGBindingNavigator)).EndInit();
            this.cHERTOGBindingNavigator.ResumeLayout(false);
            this.cHERTOGBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataDBDataSet dataDBDataSet;
        private System.Windows.Forms.BindingSource cHERTOGBindingSource;
        private DataDBDataSetTableAdapters.CHERTOGTableAdapter cHERTOGTableAdapter;
        private DataDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cHERTOGBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cHERTOGBindingNavigatorSaveItem;
        private DataDBDataSetTableAdapters.PERSONTableAdapter pERSONTableAdapter;
        private System.Windows.Forms.TextBox chertognoTextBox;
        private System.Windows.Forms.TextBox chnameTextBox;
        private System.Windows.Forms.TextBox chsphereTextBox;
        private System.Windows.Forms.TextBox chcharTextBox;
        private System.Windows.Forms.BindingSource pERSONBindingSource;
        private System.Windows.Forms.DataGridView pERSONDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button button1;
    }
}