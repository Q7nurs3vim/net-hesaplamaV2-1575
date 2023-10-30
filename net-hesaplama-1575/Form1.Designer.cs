namespace net_hesaplama_1575
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
            groupBox1 = new GroupBox();
            btnNethesapla = new Button();
            txtNetT = new TextBox();
            txtNetM = new TextBox();
            txtDogruM = new TextBox();
            txtYanlisT = new TextBox();
            txtYanlisM = new TextBox();
            txtDogruT = new TextBox();
            lblNet = new Label();
            lblYanlis = new Label();
            lblDogru = new Label();
            lblMat = new Label();
            lblTurkce = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(btnNethesapla);
            groupBox1.Controls.Add(txtNetT);
            groupBox1.Controls.Add(txtNetM);
            groupBox1.Controls.Add(txtDogruM);
            groupBox1.Controls.Add(txtYanlisT);
            groupBox1.Controls.Add(txtYanlisM);
            groupBox1.Controls.Add(txtDogruT);
            groupBox1.Controls.Add(lblNet);
            groupBox1.Controls.Add(lblYanlis);
            groupBox1.Controls.Add(lblDogru);
            groupBox1.Controls.Add(lblMat);
            groupBox1.Controls.Add(lblTurkce);
            groupBox1.Location = new Point(27, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sınav 1. Oturum";
            // 
            // btnNethesapla
            // 
            btnNethesapla.BackColor = Color.LawnGreen;
            btnNethesapla.Location = new Point(213, 165);
            btnNethesapla.Name = "btnNethesapla";
            btnNethesapla.Size = new Size(267, 29);
            btnNethesapla.TabIndex = 11;
            btnNethesapla.Text = "Net Hesapla";
            btnNethesapla.UseVisualStyleBackColor = false;
            btnNethesapla.Click += btnNethesapla_Click;
            // 
            // txtNetT
            // 
            txtNetT.Enabled = false;
            txtNetT.Location = new Point(423, 63);
            txtNetT.Multiline = true;
            txtNetT.Name = "txtNetT";
            txtNetT.Size = new Size(57, 29);
            txtNetT.TabIndex = 10;
            // 
            // txtNetM
            // 
            txtNetM.Enabled = false;
            txtNetM.Location = new Point(423, 124);
            txtNetM.Multiline = true;
            txtNetM.Name = "txtNetM";
            txtNetM.Size = new Size(57, 29);
            txtNetM.TabIndex = 9;
            // 
            // txtDogruM
            // 
            txtDogruM.Location = new Point(213, 124);
            txtDogruM.Multiline = true;
            txtDogruM.Name = "txtDogruM";
            txtDogruM.Size = new Size(57, 29);
            txtDogruM.TabIndex = 8;
            // 
            // txtYanlisT
            // 
            txtYanlisT.Location = new Point(327, 66);
            txtYanlisT.Multiline = true;
            txtYanlisT.Name = "txtYanlisT";
            txtYanlisT.Size = new Size(57, 29);
            txtYanlisT.TabIndex = 7;
            // 
            // txtYanlisM
            // 
            txtYanlisM.Location = new Point(327, 124);
            txtYanlisM.Multiline = true;
            txtYanlisM.Name = "txtYanlisM";
            txtYanlisM.Size = new Size(57, 29);
            txtYanlisM.TabIndex = 6;
            // 
            // txtDogruT
            // 
            txtDogruT.Location = new Point(213, 66);
            txtDogruT.Multiline = true;
            txtDogruT.Name = "txtDogruT";
            txtDogruT.Size = new Size(57, 29);
            txtDogruT.TabIndex = 5;
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.Location = new Point(435, 36);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(33, 20);
            lblNet.TabIndex = 4;
            lblNet.Text = "Net";
            // 
            // lblYanlis
            // 
            lblYanlis.AutoSize = true;
            lblYanlis.Location = new Point(333, 36);
            lblYanlis.Name = "lblYanlis";
            lblYanlis.Size = new Size(46, 20);
            lblYanlis.TabIndex = 3;
            lblYanlis.Text = "Yanlış";
            // 
            // lblDogru
            // 
            lblDogru.AutoSize = true;
            lblDogru.Location = new Point(213, 36);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(51, 20);
            lblDogru.TabIndex = 2;
            lblDogru.Text = "Doğru";
            // 
            // lblMat
            // 
            lblMat.AutoSize = true;
            lblMat.Location = new Point(33, 129);
            lblMat.Name = "lblMat";
            lblMat.Size = new Size(138, 20);
            lblMat.TabIndex = 1;
            lblMat.Text = "Matematik(40 soru)";
            // 
            // lblTurkce
            // 
            lblTurkce.AutoSize = true;
            lblTurkce.Location = new Point(33, 66);
            lblTurkce.Name = "lblTurkce";
            lblTurkce.Size = new Size(110, 20);
            lblTurkce.TabIndex = 0;
            lblTurkce.Text = "Türkçe(40 soru)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(626, 226);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNet;
        private Label lblYanlis;
        private Label lblDogru;
        private Label lblMat;
        private Label lblTurkce;
        private TextBox txtNetT;
        private TextBox txtNetM;
        private TextBox txtDogruM;
        private TextBox txtYanlisT;
        private TextBox txtYanlisM;
        private TextBox txtDogruT;
        private Button btnNethesapla;
    }
}