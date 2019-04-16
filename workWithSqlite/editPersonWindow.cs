using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace workWithSqlite
{
    public partial class editPersonWindow : Form
    {
        DataGridViewRow currentPerson;
        public editPersonWindow(DataGridViewRow currentPerson)
        {
            InitializeComponent();
            this.currentPerson = currentPerson;

            firstnameTextBox.Text = (string)currentPerson.Cells["personFirstname"].Value;
            lastnameTextBox.Text = (string)currentPerson.Cells["personLastname"].Value;

            byte[] currentPersonPhotoBytes = (byte[])currentPerson.Cells["photoBytes"].Value;
            SetPhoto(currentPersonPhotoBytes);
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            using (var connection = new SQLiteConnection(@"Data Source = ..\..\..\test.db; Version = 3;"))
            {
                connection.Open();

                int currentPersonId = (int)currentPerson.Cells["personId"].Value;
                var updatePersonsCommand = new SQLiteCommand("UPDATE Persons SET firstname = @firstname, lastname = @lastname WHERE id = @id", connection);
                updatePersonsCommand.Parameters.AddWithValue("@firstname", firstnameTextBox.Text);
                updatePersonsCommand.Parameters.AddWithValue("@lastname", lastnameTextBox.Text);
                updatePersonsCommand.Parameters.AddWithValue("@id", currentPersonId);
                updatePersonsCommand.ExecuteNonQuery();
                
                if (!String.IsNullOrWhiteSpace(filePathTextBox.Text))
                {
                    int currentPersonPhotoId = (int)currentPerson.Cells["photoId"].Value;
                        byte[] fileBytes = File.ReadAllBytes(filePathTextBox.Text);
                        var updatePhotoCommand = new SQLiteCommand("UPDATE Photos SET bytes = @bytes WHERE id = @id", connection);
                        updatePhotoCommand.Parameters.AddWithValue("@bytes", fileBytes);
                        updatePhotoCommand.Parameters.AddWithValue("@id", currentPersonPhotoId);
                        updatePhotoCommand.ExecuteNonQuery();
                    }
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

            byte[] newPersonPhotoBytes = File.ReadAllBytes(openFileDialog.FileName);
            SetPhoto(newPersonPhotoBytes);
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
