namespace VideoChat
{
    partial class FrmMain
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
            videoView1 = new LibVLCSharp.WinForms.VideoView();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnSound = new Button();
            lbConverstaion = new ListBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)videoView1).BeginInit();
            SuspendLayout();
            // 
            // videoView1
            // 
            videoView1.BackColor = Color.Black;
            videoView1.Location = new Point(12, 12);
            videoView1.MediaPlayer = null;
            videoView1.Name = "videoView1";
            videoView1.Size = new Size(225, 400);
            videoView1.TabIndex = 1;
            videoView1.Text = "videoView1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "zh-CN-XiaoxiaoNeural|Female", "zh-CN-XiaoyiNeural|Female", "zh-CN-liaoning-XiaobeiNeural|Female", "zh-CN-shaanxi-XiaoniNeural|Female", "zh-TW-HsiaoChenNeural|Female", "zh-TW-HsiaoYuNeural|Female", "en-US-AnaNeural|Female", "en-US-AriaNeural|Female" });
            comboBox1.Location = new Point(264, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(275, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 13);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 3;
            label1.Text = "发声";
            // 
            // btnSound
            // 
            btnSound.Location = new Point(264, 368);
            btnSound.Name = "btnSound";
            btnSound.Size = new Size(275, 44);
            btnSound.TabIndex = 4;
            btnSound.Text = "说话";
            btnSound.UseVisualStyleBackColor = true;
            btnSound.Click += btnSound_Click;
            // 
            // lbConverstaion
            // 
            lbConverstaion.FormattingEnabled = true;
            lbConverstaion.ItemHeight = 20;
            lbConverstaion.Location = new Point(264, 118);
            lbConverstaion.Name = "lbConverstaion";
            lbConverstaion.Size = new Size(275, 244);
            lbConverstaion.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(264, 94);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 6;
            label2.Text = "消息";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 425);
            Controls.Add(label2);
            Controls.Add(lbConverstaion);
            Controls.Add(btnSound);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(videoView1);
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            FormClosed += FrmMain_FormClosed;
            Load += FrmMain_Load;
            ((System.ComponentModel.ISupportInitialize)videoView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnSound;
        private ListBox lbConverstaion;
        private Label label2;
    }
}