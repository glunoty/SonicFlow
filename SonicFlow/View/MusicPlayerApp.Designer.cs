namespace SonicFlow
{
    partial class MusicPlayerApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxCover = new PictureBox();
            labelCurrentlyPlaying = new TextBox();
            buttonPlay = new PictureBox();
            btnDelete = new Button();
            btnEdit = new Button();
            songList = new Label();
            btnAdd = new Button();
            listViewSongs = new ListView();
            Title = new ColumnHeader();
            panel1 = new Panel();
            buttonNext = new PictureBox();
            buttonPrevious = new PictureBox();
            labelCurrentlyPlayingArtist = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonPlay).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonNext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonPrevious).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.BackColor = Color.Black;
            pictureBoxCover.Image = Properties.Resources.Album_Cover_Art;
            pictureBoxCover.Location = new Point(1064, 116);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(640, 640);
            pictureBoxCover.TabIndex = 6;
            pictureBoxCover.TabStop = false;
            pictureBoxCover.Click += pictureBoxCover_Click;
            // 
            // labelCurrentlyPlaying
            // 
            labelCurrentlyPlaying.BackColor = Color.FromArgb(26, 27, 26);
            labelCurrentlyPlaying.BorderStyle = BorderStyle.None;
            labelCurrentlyPlaying.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCurrentlyPlaying.ForeColor = SystemColors.Info;
            labelCurrentlyPlaying.Location = new Point(1064, 776);
            labelCurrentlyPlaying.Name = "labelCurrentlyPlaying";
            labelCurrentlyPlaying.ReadOnly = true;
            labelCurrentlyPlaying.Size = new Size(444, 31);
            labelCurrentlyPlaying.TabIndex = 12;
            labelCurrentlyPlaying.Text = "No Song Playing";
            labelCurrentlyPlaying.TextChanged += labelCurrentlyPlaying_TextChanged;
            // 
            // buttonPlay
            // 
            buttonPlay.BackColor = Color.Transparent;
            buttonPlay.BackgroundImageLayout = ImageLayout.None;
            buttonPlay.Image = Properties.Resources.buttonPlay;
            buttonPlay.Location = new Point(1585, 788);
            buttonPlay.Name = "buttonPlay";
            buttonPlay.Size = new Size(48, 48);
            buttonPlay.TabIndex = 16;
            buttonPlay.TabStop = false;
            buttonPlay.Click += buttonPlay_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.ForeColor = SystemColors.Control;
            btnDelete.Location = new Point(239, 937);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Song";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(428, 937);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(174, 29);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "Edit Song Metadata";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // songList
            // 
            songList.AutoSize = true;
            songList.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            songList.ForeColor = SystemColors.Info;
            songList.Location = new Point(62, 67);
            songList.Name = "songList";
            songList.RightToLeft = RightToLeft.No;
            songList.Size = new Size(325, 81);
            songList.TabIndex = 14;
            songList.Text = "ALL SONG";
            songList.Click += songList_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(18, 18, 18);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(48, 937);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(176, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Song";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // listViewSongs
            // 
            listViewSongs.BackColor = Color.FromArgb(18, 18, 18);
            listViewSongs.BorderStyle = BorderStyle.None;
            listViewSongs.Columns.AddRange(new ColumnHeader[] { Title });
            listViewSongs.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listViewSongs.ForeColor = SystemColors.Window;
            listViewSongs.FullRowSelect = true;
            listViewSongs.HeaderStyle = ColumnHeaderStyle.None;
            listViewSongs.Location = new Point(100, 200);
            listViewSongs.MultiSelect = false;
            listViewSongs.Name = "listViewSongs";
            listViewSongs.Size = new Size(745, 670);
            listViewSongs.TabIndex = 15;
            listViewSongs.UseCompatibleStateImageBehavior = false;
            listViewSongs.View = System.Windows.Forms.View.Details;
            listViewSongs.SelectedIndexChanged += listViewSongs_SelectedIndexChanged;
            // 
            // Title
            // 
            Title.Text = "#Title";
            Title.Width = 400;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 18, 18);
            panel1.Controls.Add(listViewSongs);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(songList);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(-1, -13);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 1058);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint_1;
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.Transparent;
            buttonNext.BackgroundImageLayout = ImageLayout.None;
            buttonNext.Image = Properties.Resources.buttonNext;
            buttonNext.Location = new Point(1656, 794);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(36, 36);
            buttonNext.TabIndex = 17;
            buttonNext.TabStop = false;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonPrevious
            // 
            buttonPrevious.BackColor = Color.Transparent;
            buttonPrevious.BackgroundImageLayout = ImageLayout.None;
            buttonPrevious.Image = Properties.Resources.buttonBack;
            buttonPrevious.Location = new Point(1514, 794);
            buttonPrevious.Name = "buttonPrevious";
            buttonPrevious.Size = new Size(36, 36);
            buttonPrevious.TabIndex = 18;
            buttonPrevious.TabStop = false;
            buttonPrevious.Click += buttonPrevious_Click;
            // 
            // labelCurrentlyPlayingArtist
            // 
            labelCurrentlyPlayingArtist.BackColor = Color.FromArgb(26, 27, 26);
            labelCurrentlyPlayingArtist.BorderStyle = BorderStyle.None;
            labelCurrentlyPlayingArtist.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCurrentlyPlayingArtist.ForeColor = SystemColors.ScrollBar;
            labelCurrentlyPlayingArtist.Location = new Point(1064, 811);
            labelCurrentlyPlayingArtist.Name = "labelCurrentlyPlayingArtist";
            labelCurrentlyPlayingArtist.ReadOnly = true;
            labelCurrentlyPlayingArtist.Size = new Size(444, 24);
            labelCurrentlyPlayingArtist.TabIndex = 19;
            labelCurrentlyPlayingArtist.Text = "Currently";
            // 
            // MusicPlayerApp
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(26, 27, 26);
            ClientSize = new Size(1902, 1033);
            Controls.Add(labelCurrentlyPlayingArtist);
            Controls.Add(buttonPrevious);
            Controls.Add(buttonNext);
            Controls.Add(buttonPlay);
            Controls.Add(labelCurrentlyPlaying);
            Controls.Add(pictureBoxCover);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MusicPlayerApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SonicFlow";
            WindowState = FormWindowState.Maximized;
            Load += MusicPlayerApp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonPlay).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonNext).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonPrevious).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxCover;
        private TextBox labelCurrentlyPlaying;
        private PictureBox buttonPlay;
        private Button btnDelete;
        private Button btnEdit;
        private Label songList;
        private Button btnAdd;
        private ListView listViewSongs;
        private ColumnHeader Title;
        private Panel panel1;
        private PictureBox buttonNext;
        private PictureBox buttonPrevious;
        private TextBox labelCurrentlyPlayingArtist;
    }
}
