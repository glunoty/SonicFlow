using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using SonicFlow.Controller;
using SonicFlow.Model;
using SonicFlow.View;
using TagLib;


namespace SonicFlow
{
    public partial class MusicPlayerApp : Form
    {
        private string[] paths, files;
        private IWavePlayer wavePlayer;
        private AudioFileReader audioFileReader;
        private MusicController musicController;
        private bool isPlaying = false;
        private int currentSongIndex = -1;


        public MusicPlayerApp()
        {
            InitializeComponent();
            musicController = new MusicController();
            listViewSongs.SelectedIndexChanged += new EventHandler(listViewSongs_SelectedIndexChanged);
        }


        private void MusicPlayerApp_Load(object sender, EventArgs e)
        {
            var musicTracks = musicController.GetMusicTracks();
            foreach (var track in musicTracks)
            {
                var listViewItem = new ListViewItem();
                listViewItem.Text = $"{track.Title} - {track.Artist}"; // Set the main text (Title - Artist) of the ListViewItem
                listViewItem.Tag = track;
                listViewSongs.Items.Add(listViewItem);
            }
            currentSongIndex = -1;

        }

        private void listViewSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopPlayback(); // Stop the previous playback
            PlaySelectedSong();
            UpdatePlayPauseButtonImage();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Code to Select Songs
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.SafeFileNames; // Save the names of the track in files array
                paths = ofd.FileNames; // Save the paths of the tracks in path array

                // Display the music titles in listbox with format "Title - Artist"
                foreach (var filePath in paths)
                {
                    var title = GetTitleFromMetadata(filePath) ?? System.IO.Path.GetFileNameWithoutExtension(filePath);
                    var artist = GetArtistFromMetadata(filePath) ?? "Unknown Artist";

                    var listViewItem = new ListViewItem();
                    listViewItem.Text = $"{title} - {artist}";
                    listViewItem.Tag = new MusicTrack { Title = title, Artist = artist, FilePath = filePath };
                    listViewSongs.Items.Add(listViewItem);

                    // Add the track to the database
                    var track = new MusicTrack { Title = title, Artist = artist, FilePath = filePath };
                    musicController.AddMusicTrack(track);
                }

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

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (wavePlayer != null)
            {
                if (wavePlayer.PlaybackState == PlaybackState.Paused)
                {
                    wavePlayer.Play();
                    UpdatePlayPauseButtonImage(); // Fungsi ini untuk mengupdate gambar tombol
                }
                else if (wavePlayer.PlaybackState == PlaybackState.Stopped)
                {
                    PlaySelectedSong();
                    UpdatePlayPauseButtonImage();
                }
                else if (wavePlayer.PlaybackState == PlaybackState.Playing)
                {
                    wavePlayer.Pause();
                    UpdatePlayPauseButtonImage();
                }
            }
        }

        private void UpdatePlayPauseButtonImage()
        {
            // Ganti gambar pada PictureBox berdasarkan apakah sedang diputar atau tidak
            if (isPlaying)
            {
                buttonPlay.Image = Properties.Resources.buttonPause; // Ganti dengan gambar play
            }
            else
            {
                buttonPlay.Image = Properties.Resources.buttonPlay; // Ganti dengan gambar pause
            }

            isPlaying = !isPlaying; // Toggle nilai isPlaying
        }


        private void PlaySelectedSong()
        {
            StopPlayback();

            if (listViewSongs.SelectedItems.Count > 0)
            {
                currentSongIndex = listViewSongs.SelectedItems[0].Index;
                var selectedTrack = (MusicTrack)listViewSongs.SelectedItems[0].Tag;
                wavePlayer = new WaveOut();
                audioFileReader = new AudioFileReader(selectedTrack.FilePath);
                wavePlayer.Init(audioFileReader);
                wavePlayer.Play();


                // Display cover art
                DisplayCoverArt(selectedTrack.FilePath);

                labelCurrentlyPlaying.Text = $"{selectedTrack.Title}";
                labelCurrentlyPlayingArtist.Text = $"{selectedTrack.Artist}";
            }
        }


        private void StopPlayback()
        {
            if (wavePlayer != null)
            {
                wavePlayer.Stop();
                wavePlayer.Dispose();

                labelCurrentlyPlaying.Text = "No song playing";
            }
        }


        private void DisplayCoverArt(string filePath)
        {
            try
            {
                var file = TagLib.File.Create(filePath);

                // Check if there is cover art
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
                    // If no cover art, you can set a default image or leave it empty
                    pictureBoxCover.Image = null;
                }
            }
            catch (Exception)
            {
                // Handle exceptions (e.g., file format not supported or no metadata)
                // You can set a default image or leave it empty
                pictureBoxCover.Image = null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0)
            {
                // Get the selected track from the ListView
                var selectedTrack = (MusicTrack)listViewSongs.SelectedItems[0].Tag;

                // Remove the selected item from the ListView
                listViewSongs.Items.Remove(listViewSongs.SelectedItems[0]);

                // Delete the track from the database
                musicController.DeleteMusicTrack(selectedTrack.Id);

                // Clear the cover art (optional)
                pictureBoxCover.Image = null;

                // Stop playback if the deleted track is currently playing
                StopPlayback();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            PlayPreviousSong();
        }

        private void PlayNextSong()
        {
            if (currentSongIndex < listViewSongs.Items.Count - 1)
            {
                // Pindah ke lagu berikutnya dalam urutan database
                currentSongIndex++;
                listViewSongs.Items[currentSongIndex].Selected = true;
                PlaySelectedSong();
            }
        }

        private void PlayPreviousSong()
        {
            if (currentSongIndex > 0)
            {
                // Pindah ke lagu sebelumnya dalam urutan database
                currentSongIndex--;
                listViewSongs.Items[currentSongIndex].Selected = true;
                PlaySelectedSong();
            }
        }



        private void labelCurrentlyPlaying_TextChanged(object sender, EventArgs e)
        {

        }

        private void songList_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listViewSongs.SelectedItems.Count > 0)
            {
                // Dapatkan lagu yang dipilih dari ListView
                var selectedTrack = (MusicTrack)listViewSongs.SelectedItems[0].Tag;

                // Buat instance EditMetadataForm dan tampilkan
                using (var editMetadataForm = new MetadataForm(selectedTrack))
                {
                    editMetadataForm.ShowDialog();

                    // Perbarui tampilan ListView setelah pengeditan metadata
                    var updatedTitle = selectedTrack.Title ?? "Unknown Title";
                    var updatedArtist = selectedTrack.Artist ?? "Unknown Artist";
                    listViewSongs.SelectedItems[0].Text = $"{updatedTitle} - {updatedArtist}";
                }
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxCover_Click(object sender, EventArgs e)
        {

        }
    }
}
