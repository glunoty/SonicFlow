using SonicFlow.Controller;
using SonicFlow.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicFlow.View
{
    public partial class MetadataForm : Form
    {
        private MusicController musicController;
        private MusicTrack selectedTrack;

        public MetadataForm(MusicTrack track)
        {
            InitializeComponent();

            musicController = new MusicController();
            selectedTrack = track;

            // Setel nilai awal TextBox sesuai metadata lagu yang dipilih
            textBoxTitle.Text = selectedTrack.Title;
            textBoxArtist.Text = selectedTrack.Artist;
            textBoxPath.Text = selectedTrack.FilePath;

            // Tampilkan cover art
            DisplayCoverArt(selectedTrack.FilePath);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Simpan perubahan metadata
            selectedTrack.Title = textBoxTitle.Text;
            selectedTrack.Artist = textBoxArtist.Text;
            selectedTrack.FilePath = textBoxPath.Text;

            // Update metadata di database
            musicController.UpdateMusicTrack(selectedTrack);

            MessageBox.Show("Metadata lagu berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            // Batalkan pengeditan dan tutup form
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Buat dialog pemilihan file untuk memilih path baru
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.mp3;*.wav|All Files|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var title = GetTitleFromMetadata(ofd.FileName) ?? Path.GetFileNameWithoutExtension(ofd.FileName);
                var artist = GetArtistFromMetadata(ofd.FileName) ?? "Unknown Artist";

                // Isi TextBoxTitle dan TextBoxArtist dengan metadata baru
                textBoxTitle.Text = title;
                textBoxArtist.Text = artist;
                textBoxPath.Text = ofd.FileName;
                DisplayCoverArt(ofd.FileName);
            }
        }

        private string GetTitleFromMetadata(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                return file.Tag.Title;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private string GetArtistFromMetadata(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);
                return file.Tag.FirstPerformer;
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void DisplayCoverArt(string filePath)
        {
            // Tampilkan cover art pada PictureBox
            try
            {
                var file = TagLib.File.Create(filePath);

                if (file.Tag.Pictures.Length > 0)
                {
                    var cover = file.Tag.Pictures[0];
                    using (var stream = new System.IO.MemoryStream(cover.Data.Data))
                    {
                        pictureBoxCover.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                    pictureBoxCover.Image = null;
                }
            }
            catch (Exception)
            {
                pictureBoxCover.Image = null;
            }
        }

        private void btnChangeCoverArt_Click(object sender, EventArgs e)
        {
            // Buka OpenFileDialog untuk memilih file gambar baru
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Ambil path file gambar yang dipilih
                    string imagePath = ofd.FileName;

                    // Tampilkan gambar pada PictureBox
                    pictureBoxCover.Image = Image.FromFile(imagePath);

                    // Simpan path file gambar ke dalam objek MusicTrack
                }
            }
        }

        private void pictureBoxCover_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxArtist_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
