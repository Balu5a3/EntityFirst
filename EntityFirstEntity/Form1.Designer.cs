namespace EntityFirstEntity
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.baluEntityFirstContainerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.class1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.databaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeTrackerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.configurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baluEntityFirstContainerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class1DataGridViewTextBoxColumn,
            this.class2DataGridViewTextBoxColumn,
            this.databaseDataGridViewTextBoxColumn,
            this.changeTrackerDataGridViewTextBoxColumn,
            this.configurationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.baluEntityFirstContainerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(57, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // baluEntityFirstContainerBindingSource
            // 
            this.baluEntityFirstContainerBindingSource.DataSource = typeof(EntityFirstEntity.BaluEntityFirstContainer);
            // 
            // class1DataGridViewTextBoxColumn
            // 
            this.class1DataGridViewTextBoxColumn.DataPropertyName = "Class1";
            this.class1DataGridViewTextBoxColumn.HeaderText = "Class1";
            this.class1DataGridViewTextBoxColumn.Name = "class1DataGridViewTextBoxColumn";
            // 
            // class2DataGridViewTextBoxColumn
            // 
            this.class2DataGridViewTextBoxColumn.DataPropertyName = "Class2";
            this.class2DataGridViewTextBoxColumn.HeaderText = "Class2";
            this.class2DataGridViewTextBoxColumn.Name = "class2DataGridViewTextBoxColumn";
            // 
            // databaseDataGridViewTextBoxColumn
            // 
            this.databaseDataGridViewTextBoxColumn.DataPropertyName = "Database";
            this.databaseDataGridViewTextBoxColumn.HeaderText = "Database";
            this.databaseDataGridViewTextBoxColumn.Name = "databaseDataGridViewTextBoxColumn";
            this.databaseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeTrackerDataGridViewTextBoxColumn
            // 
            this.changeTrackerDataGridViewTextBoxColumn.DataPropertyName = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.HeaderText = "ChangeTracker";
            this.changeTrackerDataGridViewTextBoxColumn.Name = "changeTrackerDataGridViewTextBoxColumn";
            this.changeTrackerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // configurationDataGridViewTextBoxColumn
            // 
            this.configurationDataGridViewTextBoxColumn.DataPropertyName = "Configuration";
            this.configurationDataGridViewTextBoxColumn.HeaderText = "Configuration";
            this.configurationDataGridViewTextBoxColumn.Name = "configurationDataGridViewTextBoxColumn";
            this.configurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baluEntityFirstContainerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn class1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn class2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn databaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeTrackerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn configurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource baluEntityFirstContainerBindingSource;
    }
}