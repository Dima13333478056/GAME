namespace Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Play = new Button();
            Exit = new Button();
            video = new AxWMPLib.AxWindowsMediaPlayer();
            Text_Schujet = new Label();
            Fon = new PictureBox();
            Text_2 = new Label();
            ((System.ComponentModel.ISupportInitialize)video).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fon).BeginInit();
            SuspendLayout();
            // 
            // Play
            // 
            Play.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Play.Font = new Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Play.Location = new Point(844, 714);
            Play.Name = "Play";
            Play.Size = new Size(200, 80);
            Play.TabIndex = 0;
            Play.Text = "Играть";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Exit.Font = new Font("Tahoma", 18F);
            Exit.Location = new Point(844, 800);
            Exit.Name = "Exit";
            Exit.Size = new Size(200, 80);
            Exit.TabIndex = 1;
            Exit.Text = "Выйти";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // video
            // 
            video.Enabled = true;
            video.Location = new Point(8, 8);
            video.Name = "video";
            video.OcxState = (AxHost.State)resources.GetObject("video.OcxState");
            video.Size = new Size(215, 168);
            video.TabIndex = 3;
            video.Visible = false;
            // 
            // Text_Schujet
            // 
            Text_Schujet.AutoSize = true;
            Text_Schujet.BackColor = Color.Transparent;
            Text_Schujet.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_Schujet.Location = new Point(315, 785);
            Text_Schujet.Name = "Text_Schujet";
            Text_Schujet.Size = new Size(144, 46);
            Text_Schujet.TabIndex = 4;
            Text_Schujet.Text = "label1";
            Text_Schujet.Visible = false;
            Text_Schujet.Click += Text_Schujet_Click;
            // 
            // Fon
            // 
            Fon.Location = new Point(193, 157);
            Fon.Name = "Fon";
            Fon.Size = new Size(100, 50);
            Fon.TabIndex = 5;
            Fon.TabStop = false;
            // 
            // Text_2
            // 
            Text_2.AutoSize = true;
            Text_2.BackColor = Color.Transparent;
            Text_2.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_2.Location = new Point(1274, 785);
            Text_2.Name = "Text_2";
            Text_2.Size = new Size(136, 44);
            Text_2.TabIndex = 6;
            Text_2.Text = "label1";
            Text_2.Visible = false;
            Text_2.Click += Text_2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Text_2);
            Controls.Add(Exit);
            Controls.Add(Text_Schujet);
            Controls.Add(Play);
            Controls.Add(video);
            Controls.Add(Fon);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)video).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play;
        private Button Exit;
        private AxWMPLib.AxWindowsMediaPlayer video;
        private Label Text_Schujet;
        private PictureBox Fon;
        private Label Text_2;
    }
}
