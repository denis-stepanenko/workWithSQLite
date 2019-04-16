using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Drawing;
using System;
using System.Drawing.Imaging;

namespace workWithSqlite
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();

            RefreshPersonsList();
        }

        void RefreshPersonsList()
        {
            using (var connection = new SQLiteConnection($@"Data Source = ..\..\..\test.db; Version = 3;"))
            {
                connection.Open();

                var command = new SQLiteCommand(
@"SELECT pr.id personId, pr.firstname, pr.lastname, ph.id photoId, ph.bytes FROM Persons pr
JOIN Photos ph ON ph.id = pr.photoId"
, connection);

                var adapter = new SQLiteDataAdapter();
                adapter.SelectCommand = command;
                dataSet.Tables["Persons"].Clear();
                adapter.Fill(dataSet.Tables["Persons"]);
            }
        }

        private void addPersonButton_Click(object sender, EventArgs e)
        {
            var window = new addPersonWindow();
            window.ShowDialog();
            RefreshPersonsList();
        }

        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            var currentPerson = personsDataGridView.CurrentRow;
            if (currentPerson != null)
            {
                int personId = (int)currentPerson.Cells["personId"].Value;

                using (var connection = new SQLiteConnection(@"Data Source = ..\..\..\test.db; Version = 3;"))
                {
                    connection.Open();
                    var command = new SQLiteCommand("DELETE FROM Persons WHERE id = @id", connection);
                    command.Parameters.AddWithValue("@id", personId);
                    command.ExecuteNonQuery();
                }
                RefreshPersonsList();
            }
        }

        private void editPersonButton_Click(object sender, EventArgs e)
        {
            var currentPerson = personsDataGridView.CurrentRow;
            if (currentPerson != null)
            {
                var window = new editPersonWindow(currentPerson);
                window.ShowDialog();
                RefreshPersonsList();
            }
        }

        private void personsDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            var currentPerson = personsDataGridView.CurrentRow;
            if (currentPerson != null)
            {
                byte[] fileBytes = (byte[])currentPerson.Cells["photoBytes"].Value;
                using (var ms = new MemoryStream(fileBytes))
                {
                    var photo = Image.FromStream(ms);
                    personPictureBox.Image = photo;
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentPerson = personsDataGridView.CurrentRow;
            if (currentPerson != null)
            {
                byte[] fileBytes = (byte[])currentPerson.Cells["photoBytes"].Value;
                using (var ms = new MemoryStream(fileBytes))
                {
                    var photo = Image.FromStream(ms);
                    string fileFormat = GetFileType(photo);
                    string fileName = GetRandomFileName();
                    saveFileDialog.FileName = fileName + "." + fileFormat;


                    if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
                    {
                        string filePath = saveFileDialog.FileName;
                        photo.Save(filePath);
                    }
                }
            }
        }

        // получить случайное имя
        string GetRandomFileName()
        {
            var random = new Random();
            string name = "";

            for (int i = 0; i < 10; i++)
            {
                name += random.Next(10);
            }
            return name;
        }

        // получить mime тип по байт-коду
        string GetMimeType(Image image)
        {
            var imageGuid = image.RawFormat.Guid;
            foreach (var codec in ImageCodecInfo.GetImageDecoders())
            {
                if (codec.FormatID == imageGuid)
                {
                    return codec.MimeType;
                }
            }
            return null;
        }

        // получить расширение файла по байт-коду
        string GetFileType(Image image)
        {
            string mimeType = GetMimeType(image);
            switch (mimeType)
            {
                case "image/jpeg": return "jpg";
                case "image/bmp": return "bmp";
                case "image/png": return "png";
                case "image/gif": return "gif";
            }
            return null;
        }
    }
 }
