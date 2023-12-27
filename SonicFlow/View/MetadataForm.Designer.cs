namespace SonicFlow.View
{
    partial class MetadataForm
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
            textBoxTitle = new TextBox();
            textBoxArtist = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxPath = new TextBox();
            pictureBoxCover = new PictureBox();
            btnBrowse = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).BeginInit();
            SuspendLayout();
            // 
            // textBoxTitle
            // 
            textBoxTitle.BackColor = Color.FromArgb(18, 18, 18);
            textBoxTitle.BorderStyle = BorderStyle.FixedSingle;
            textBoxTitle.Font = new Font("Segoe UI", 10.2F);
            textBoxTitle.ForeColor = SystemColors.Window;
            textBoxTitle.Location = new Point(520, 398);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(401, 30);
            textBoxTitle.TabIndex = 0;
            textBoxTitle.TextChanged += textBoxTitle_TextChanged;
            // 
            // textBoxArtist
            // 
            textBoxArtist.BackColor = Color.FromArgb(18, 18, 18);
            textBoxArtist.BorderStyle = BorderStyle.FixedSingle;
            textBoxArtist.Font = new Font("Segoe UI", 10.2F);
            textBoxArtist.ForeColor = SystemColors.Window;
            textBoxArtist.Location = new Point(520, 319);
            textBoxArtist.Name = "textBoxArtist";
            textBoxArtist.Size = new Size(401, 30);
            textBoxArtist.TabIndex = 1;
            textBoxArtist.TextChanged += textBoxArtist_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.ForeColor = SystemColors.ControlLightLight;
            buttonSave.Location = new Point(717, 487);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = SystemColors.ControlLightLight;
            buttonCancel.Location = new Point(827, 487);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPath
            // 
            textBoxPath.BackColor = Color.FromArgb(18, 18, 18);
            textBoxPath.BorderStyle = BorderStyle.FixedSingle;
            textBoxPath.Font = new Font("Segoe UI", 10.2F);
            textBoxPath.ForeColor = SystemColors.Window;
            textBoxPath.Location = new Point(520, 242);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(244, 30);
            textBoxPath.TabIndex = 4;
            textBoxPath.TextChanged += textBoxPath_TextChanged;
            // 
            // pictureBoxCover
            // 
            pictureBoxCover.BackColor = Color.Black;
            pictureBoxCover.BackgroundImage = Properties.Resources.Album_Cover_Art;
            pictureBoxCover.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxCover.Location = new Point(1, 46);
            pictureBoxCover.Name = "pictureBoxCover";
            pictureBoxCover.Size = new Size(493, 493);
            pictureBoxCover.TabIndex = 5;
            pictureBoxCover.TabStop = false;
            pictureBoxCover.Click += pictureBoxCover_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.FlatStyle = FlatStyle.Flat;
            btnBrowse.ForeColor = SystemColors.ButtonFace;
            btnBrowse.Location = new Point(781, 242);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(140, 30);
            btnBrowse.TabIndex = 6;
            btnBrowse.Text = "Browse Path";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(961, 49);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(524, 207);
            label1.Name = "label1";
            label1.Size = new Size(45, 23);
            label1.TabIndex = 8;
            label1.Text = "Path";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(524, 285);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 9;
            label2.Text = "Title";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(524, 363);
            label3.Name = "label3";
            label3.Size = new Size(50, 23);
            label3.TabIndex = 10;
            label3.Text = "Artist";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(520, 72);
            label4.Name = "label4";
            label4.Size = new Size(102, 46);
            label4.TabIndex = 11;
            label4.Text = "Song";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(520, 118);
            label5.Name = "label5";
            label5.Size = new Size(172, 46);
            label5.TabIndex = 12;
            label5.Text = "Metadata";
            // 
            // MetadataForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 27, 26);
            ClientSize = new Size(960, 540);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnBrowse);
            Controls.Add(textBoxPath);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxArtist);
            Controls.Add(textBoxTitle);
            Controls.Add(pictureBoxCover);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MetadataForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCover).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitle;
        private TextBox textBoxArtist;
        private Button buttonSave;
        private Button buttonCancel;
        private TextBox textBoxPath;
        private PictureBox pictureBoxCover;
        private Button btnBrowse;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}