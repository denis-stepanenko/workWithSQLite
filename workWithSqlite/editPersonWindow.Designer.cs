namespace workWithSqlite
{
    partial class editPersonWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialogButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.personPictureBox = new System.Windows.Forms.PictureBox();
            this.editPersonButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Путь к фотографии:";
            // 
            // openFileDialogButton
            // 
            this.openFileDialogButton.Location = new System.Drawing.Point(633, 303);
            this.openFileDialogButton.Name = "openFileDialogButton";
            this.openFileDialogButton.Size = new System.Drawing.Size(124, 23);
            this.openFileDialogButton.TabIndex = 13;
            this.openFileDialogButton.Text = "Выбрать и заменить";
            this.openFileDialogButton.UseVisualStyleBackColor = true;
            this.openFileDialogButton.Click += new System.EventHandler(this.openFileDialogButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(414, 306);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(213, 20);
            this.filePathTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Фамилия:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Имя:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(19, 81);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(282, 20);
            this.lastnameTextBox.TabIndex = 9;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(21, 26);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(280, 20);
            this.firstnameTextBox.TabIndex = 8;
            // 
            // personPictureBox
            // 
            this.personPictureBox.Location = new System.Drawing.Point(419, 10);
            this.personPictureBox.Name = "personPictureBox";
            this.personPictureBox.Size = new System.Drawing.Size(338, 275);
            this.personPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.personPictureBox.TabIndex = 15;
            this.personPictureBox.TabStop = false;
            // 
            // editPersonButton
            // 
            this.editPersonButton.Location = new System.Drawing.Point(226, 122);
            this.editPersonButton.Name = "editPersonButton";
            this.editPersonButton.Size = new System.Drawing.Size(75, 23);
            this.editPersonButton.TabIndex = 16;
            this.editPersonButton.Text = "Изменить";
            this.editPersonButton.UseVisualStyleBackColor = true;
            this.editPersonButton.Click += new System.EventHandler(this.editPersonButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // editPersonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 348);
            this.Controls.Add(this.editPersonButton);
            this.Controls.Add(this.personPictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openFileDialogButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Name = "editPersonWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "editPersonWindow";
            ((System.ComponentModel.ISupportInitialize)(this.personPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button openFileDialogButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.PictureBox personPictureBox;
        private System.Windows.Forms.Button editPersonButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}