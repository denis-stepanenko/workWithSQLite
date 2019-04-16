using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace workWithSqlite
{
    public partial class addPersonWindow : Form
    {
        public addPersonWindow()
        {
            InitializeComponent();
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(@"Data Source = ..\..\..\test.db; Version = 3;"))
            {
                connection.Open();

                string filePath = filePathTextBox.Text;
                byte[] fileBytes = File.ReadAllBytes(filePath);
                var insertPhotoCommand = new SQLiteCommand(@"INSERT INTO Photos (bytes) VALUES (@bytes)", connection);
                insertPhotoCommand.Parameters.AddWithValue("@bytes", fileBytes);
                insertPhotoCommand.ExecuteNonQuery();

                long insertedPhotoId = connection.LastInsertRowId;
                var command = new SQLiteCommand(@"INSERT INTO Persons (firstname, lastname, photoId) VALUES (@firstname, @lastname, @photoId)", connection);
                command.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
                command.Parameters.AddWithValue("@lastname", lastnameTextBox.Text);
                command.Parameters.AddWithValue("@photoId", insertedPhotoId);
                command.ExecuteNonQuery();
            }
            this.Close();
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "jpg(*.jpg)|*.jpg|bmp(*.bmp)|*.bmp|png(*.png)|*.png|gif(*.gif)|*.gif";
            if(openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            filePathTextBox.Text = openFileDialog.FileName;

            byte[] choosedPhotoBytes = File.ReadAllBytes(openFileDialog.FileName);
            SetPhoto(choosedPhotoBytes);
        }

        void SetPhoto(byte[] bytes)
        {
            using (var ms = new MemoryStream(bytes))
            {
                var image = Image.FromStream(ms);
                personPictureBox.Image = image;
            }
        }
    }
}
