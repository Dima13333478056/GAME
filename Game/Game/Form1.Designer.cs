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
            Fon = new PictureBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            Text_Schujet = new Label();
            ((System.ComponentModel.ISupportInitialize)Fon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
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
            // Fon
            // 
            Fon.Image = (Image)resources.GetObject("Fon.Image");
            Fon.Location = new Point(0, 0);
            Fon.Name = "Fon";
            Fon.Size = new Size(1920, 1080);
            Fon.SizeMode = PictureBoxSizeMode.StretchImage;
            Fon.TabIndex = 2;
            Fon.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(8, 8);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(75, 23);
            axWindowsMediaPlayer1.TabIndex = 3;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // Text_Schujet
            // 
            Text_Schujet.AutoSize = true;
            Text_Schujet.Font = new Font("Showcard Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Text_Schujet.Location = new Point(821, 801);
            Text_Schujet.Name = "Text_Schujet";
            Text_Schujet.Size = new Size(246, 79);
            Text_Schujet.TabIndex = 4;
            Text_Schujet.Text = "label1";
            Text_Schujet.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(Text_Schujet);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(Exit);
            Controls.Add(Play);
            Controls.Add(Fon);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Fon).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play;
        private Button Exit;
        private PictureBox Fon;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Label Text_Schujet;
    }
}
