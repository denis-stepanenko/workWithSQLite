namespace workWithSqlite
{
    partial class mainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.personsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataSet = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.personsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addPersonButton = new System.Windows.Forms.Button();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            this.dataColumn4 = new System.Data.DataColumn();
            this.personPhotoContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.dataColumn5 = new System.Data.DataColumn();
            this.personFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoBytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
            this.personPhotoContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // personsDataGridView
            // 
            this.personsDataGridView.AllowUserToAddRows = false;
            this.personsDataGridView.AllowUserToDeleteRows = false;
            this.personsDataGridView.AllowUserToResizeRows = false;
            this.personsDataGridView.AutoGenerateColumns = false;
            this.personsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.personsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personFirstname,
            this.personLastname,
            this.photoBytes,
            this.photoId,
            this.personId});
            this.personsDataGridView.DataSource = this.personsBindingSource;
            this.personsDataGridView.Location = new System.Drawing.Point(13, 43);
            this.personsDataGridView.Name = "personsDataGridView";
            this.personsDataGridView.ReadOnly = true;
            this.personsDataGridView.RowHeadersVisible = false;
            this.personsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personsDataGridView.Size = new System.Drawing.Size(435, 328);
            this.personsDataGridView.TabIndex = 0;
            this.personsDataGridView.CurrentCellChanged += new System.EventHandler(this.personsDataGridView_CurrentCellChanged);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "NewDataSet";
            this.dataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dataTable1.TableName = "Persons";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "firstname";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "lastname";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "personId";
            this.dataColumn3.DataType = typeof(int);
            // 
            // personsBindingSource
            // 
            this.personsBindingSource.DataMember = "Persons";
            this.personsBindingSource.DataSource = this.dataSet;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(13, 12);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(75, 23);
            this.addPersonButton.TabIndex = 1;
            this.addPersonButton.Text = "Добавить";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(175, 12);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(75, 23);
            this.deletePersonButton.TabIndex = 2;
            this.deletePersonButton.Text = "Удалить";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // personPictureBox
            // 
            this.personPictureBox.ContextMenuStrip = this.personPhotoContextMenuStrip;
            this.personPictureBox.Location = new System.Drawing.Point(465, 13);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(377, 358);
            this.personPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.personPictureBox.TabIndex = 3;
            this.personPictureBox.TabStop = false;
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "bytes";
            this.dataColumn4.DataType = typeof(byte[]);
            // 
            // personPhotoContextMenuStrip
            // 
            this.personPhotoContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.personPhotoContextMenuStrip.Name = "personPhotoContextMenuStrip";
            this.personPhotoContextMenuStrip.Size = new System.Drawing.Size(215, 26);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить на компьютер";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(94, 12);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(75, 23);
            this.editPersonButton.TabIndex = 5;
            this.editPersonButton.Text = "Изменить";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "photoId";
            this.dataColumn5.DataType = typeof(int);
            // 
            // personFirstname
            // 
            this.personFirstname.DataPropertyName = "firstname";
            this.personFirstname.HeaderText = "firstname";
            this.personFirstname.Name = "personFirstname";
            this.personFirstname.ReadOnly = true;
            // 
            // personLastname
            // 
            this.personLastname.DataPropertyName = "lastname";
            this.personLastname.HeaderText = "lastname";
            this.personLastname.Name = "personLastname";
            this.personLastname.ReadOnly = true;
            // 
            // photoBytes
            // 
            this.photoBytes.DataPropertyName = "bytes";
            this.photoBytes.HeaderText = "photoBytes";
            this.photoBytes.Name = "photoBytes";
            this.photoBytes.ReadOnly = true;
            this.photoBytes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.photoBytes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.photoBytes.Visible = false;
            // 
            // photoId
            // 
            this.photoId.DataPropertyName = "photoId";
            this.photoId.HeaderText = "photoId";
            this.photoId.Name = "photoId";
            this.photoId.ReadOnly = true;
            this.photoId.Visible = false;
            // 
            // personId
            // 
            this.personId.DataPropertyName = "personId";
            this.personId.HeaderText = "personId";
            this.personId.Name = "personId";
            this.personId.ReadOnly = true;
            this.personId.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 386);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.personPictureBox);
            this.Controls.Add(this.deletePersonButton);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.personsDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.personsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.personPhotoContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView personsDataGridView;
        private System.Windows.Forms.BindingSource personsBindingSource;
        private System.Data.DataSet dataSet;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.PictureBox personPictureBox;
        private System.Data.DataColumn dataColumn4;
        private System.Windows.Forms.ContextMenuStrip personPhotoContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button editPersonButton;
        private System.Data.DataColumn dataColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn personFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn personLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoBytes;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn personId;
    }
}

