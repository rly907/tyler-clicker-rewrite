namespace tyler_rewrite
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            timer1 = new System.Windows.Forms.Timer(components);
            labelScore = new Label();
            multBtn = new Button();
            autoBtn = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            multLbl = new Label();
            autoLbl = new Label();
            pictureBox4 = new PictureBox();
            comboBox1 = new ComboBox();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(517, 276);
            webView21.Margin = new Padding(4, 3, 4, 3);
            webView21.Name = "webView21";
            webView21.Size = new Size(402, 230);
            webView21.Source = new Uri("https://www.youtube-nocookie.com/embed/8kGRtHafKJA?playlist=8kGRtHafKJA&autoplay=1&iv_load_policy=3&loop=1&start=", UriKind.Absolute);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Font = new Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelScore.Location = new Point(637, 42);
            labelScore.Margin = new Padding(4, 0, 4, 0);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(36, 39);
            labelScore.TabIndex = 2;
            labelScore.Text = "0";
            // 
            // multBtn
            // 
            multBtn.Location = new Point(517, 208);
            multBtn.Margin = new Padding(4, 3, 4, 3);
            multBtn.Name = "multBtn";
            multBtn.Size = new Size(148, 44);
            multBtn.TabIndex = 4;
            multBtn.Text = "Power - 10";
            multBtn.UseVisualStyleBackColor = true;
            multBtn.Click += multBtn_Click;
            // 
            // autoBtn
            // 
            autoBtn.Location = new Point(672, 208);
            autoBtn.Margin = new Padding(4, 3, 4, 3);
            autoBtn.Name = "autoBtn";
            autoBtn.Size = new Size(148, 44);
            autoBtn.TabIndex = 5;
            autoBtn.Text = "Auto - 20";
            autoBtn.UseVisualStyleBackColor = true;
            autoBtn.Click += autoBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = tyler_rewrite.Properties.Resources.Coins;
            pictureBox2.Location = new Point(513, 32);
            pictureBox2.Margin = new Padding(4, 3, 4, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = tyler_rewrite.Properties.Resources.tyler1;
            pictureBox1.Location = new Point(88, 45);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = tyler_rewrite.Properties.Resources.starpower;
            pictureBox3.Location = new Point(513, 97);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(166, 104);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // multLbl
            // 
            multLbl.AutoSize = true;
            multLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            multLbl.Location = new Point(584, 132);
            multLbl.Margin = new Padding(4, 0, 4, 0);
            multLbl.Name = "multLbl";
            multLbl.Size = new Size(18, 20);
            multLbl.TabIndex = 7;
            multLbl.Text = "1";
            multLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // autoLbl
            // 
            autoLbl.AutoSize = true;
            autoLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            autoLbl.Location = new Point(757, 135);
            autoLbl.Margin = new Padding(4, 0, 4, 0);
            autoLbl.Name = "autoLbl";
            autoLbl.Size = new Size(18, 20);
            autoLbl.TabIndex = 9;
            autoLbl.Text = "0";
            autoLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = tyler_rewrite.Properties.Resources.gadget;
            pictureBox4.Location = new Point(686, 97);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(166, 104);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownWidth = 320;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "I TOLD MARK CUBAN ABOUT POOKIE’S PICKLE", "I SHOWED MY FIRST SONG TO WIZ KHALIFA", "INTRODUCING POOKIE", "I TURNED DOWN ONLYFANS W/ HOLLY MADISON", "JOSH RICHARDS CONVINCES ME TO REVEAL POOKIE", "BRIANNA CHICKENFRY ON DATING IN PUBLIC, ZACH BRYAN & HALIEY'S DAVE PORTNOY BEEF", "I RUINED MY FIRST DATE WITH POOKIE", "IM FIGHTING JOJO SIWA", "I WROTE DASHA’S NEXT HIT SONG", "I MADE IT OFFICIAL WITH POOKIE", "I TOLD GRANNY ABOUT HAWK TUAH", "I SAID HAWK TUAH AND NOW I'M HERE w/ Whitney Cummings", "Introducing Talk Tuah", "Mr.Beast Playlist", "google" });
            comboBox1.Location = new Point(369, 276);
            comboBox1.Margin = new Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 10;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(369, 308);
            btnLoad.Margin = new Padding(4, 3, 4, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(141, 27);
            btnLoad.TabIndex = 11;
            btnLoad.Text = "Load Episode";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(btnLoad);
            Controls.Add(comboBox1);
            Controls.Add(autoLbl);
            Controls.Add(pictureBox4);
            Controls.Add(multLbl);
            Controls.Add(pictureBox3);
            Controls.Add(autoBtn);
            Controls.Add(multBtn);
            Controls.Add(pictureBox2);
            Controls.Add(labelScore);
            Controls.Add(pictureBox1);
            Controls.Add(webView21);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Tyler Clicker: Definitive Edition (2024)";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button multBtn;
        private System.Windows.Forms.Button autoBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label multLbl;
        private System.Windows.Forms.Label autoLbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLoad;
    }
}

