namespace TorrentBlockCheck
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblIPLabel = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblLocatieLabel = new System.Windows.Forms.Label();
            this.lblISP = new System.Windows.Forms.Label();
            this.lblISPLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbDemoniiUDP = new System.Windows.Forms.PictureBox();
            this.lblDemonii = new System.Windows.Forms.Label();
            this.pbCCCUDP = new System.Windows.Forms.PictureBox();
            this.lblCCC = new System.Windows.Forms.Label();
            this.pbPublicBTUDP = new System.Windows.Forms.PictureBox();
            this.lblPublicBT = new System.Windows.Forms.Label();
            this.lblOpenBT = new System.Windows.Forms.Label();
            this.pbOpenBTUDP = new System.Windows.Forms.PictureBox();
            this.lbliStoleIT = new System.Windows.Forms.Label();
            this.pbiStoleITUDP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDemoniiUDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCCCUDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublicBTUDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenBTUDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbiStoleITUDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIPLabel
            // 
            this.lblIPLabel.AutoSize = true;
            this.lblIPLabel.Location = new System.Drawing.Point(6, 18);
            this.lblIPLabel.Name = "lblIPLabel";
            this.lblIPLabel.Size = new System.Drawing.Size(53, 13);
            this.lblIPLabel.TabIndex = 0;
            this.lblIPLabel.Text = "IP Adres: ";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(65, 18);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(10, 13);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLocatie);
            this.groupBox1.Controls.Add(this.lblLocatieLabel);
            this.groupBox1.Controls.Add(this.lblISP);
            this.groupBox1.Controls.Add(this.lblISPLabel);
            this.groupBox1.Controls.Add(this.lblIPLabel);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.groupBox1.Size = new System.Drawing.Size(259, 74);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP Informatie";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(65, 50);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(10, 13);
            this.lblLocatie.TabIndex = 6;
            this.lblLocatie.Text = "-";
            // 
            // lblLocatieLabel
            // 
            this.lblLocatieLabel.AutoSize = true;
            this.lblLocatieLabel.Location = new System.Drawing.Point(6, 50);
            this.lblLocatieLabel.Name = "lblLocatieLabel";
            this.lblLocatieLabel.Size = new System.Drawing.Size(45, 13);
            this.lblLocatieLabel.TabIndex = 5;
            this.lblLocatieLabel.Text = "Locatie:";
            // 
            // lblISP
            // 
            this.lblISP.AutoSize = true;
            this.lblISP.Location = new System.Drawing.Point(65, 34);
            this.lblISP.Name = "lblISP";
            this.lblISP.Size = new System.Drawing.Size(10, 13);
            this.lblISP.TabIndex = 4;
            this.lblISP.Text = "-";
            // 
            // lblISPLabel
            // 
            this.lblISPLabel.AutoSize = true;
            this.lblISPLabel.Location = new System.Drawing.Point(6, 34);
            this.lblISPLabel.Name = "lblISPLabel";
            this.lblISPLabel.Size = new System.Drawing.Size(27, 13);
            this.lblISPLabel.TabIndex = 3;
            this.lblISPLabel.Text = "ISP:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Location = new System.Drawing.Point(12, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 119);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Torrent Trackers";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Controls.Add(this.pbDemoniiUDP, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDemonii, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.pbCCCUDP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblCCC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pbPublicBTUDP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPublicBT, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOpenBT, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbOpenBTUDP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbliStoleIT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbiStoleITUDP, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pbDemoniiUDP
            // 
            this.pbDemoniiUDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDemoniiUDP.Image = ((System.Drawing.Image)(resources.GetObject("pbDemoniiUDP.Image")));
            this.pbDemoniiUDP.Location = new System.Drawing.Point(217, 83);
            this.pbDemoniiUDP.Name = "pbDemoniiUDP";
            this.pbDemoniiUDP.Size = new System.Drawing.Size(33, 14);
            this.pbDemoniiUDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbDemoniiUDP.TabIndex = 17;
            this.pbDemoniiUDP.TabStop = false;
            // 
            // lblDemonii
            // 
            this.lblDemonii.AutoSize = true;
            this.lblDemonii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDemonii.Location = new System.Drawing.Point(3, 80);
            this.lblDemonii.Name = "lblDemonii";
            this.lblDemonii.Size = new System.Drawing.Size(208, 20);
            this.lblDemonii.TabIndex = 16;
            this.lblDemonii.Text = "open.demonii.com";
            this.lblDemonii.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbCCCUDP
            // 
            this.pbCCCUDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCCCUDP.Image = ((System.Drawing.Image)(resources.GetObject("pbCCCUDP.Image")));
            this.pbCCCUDP.Location = new System.Drawing.Point(217, 63);
            this.pbCCCUDP.Name = "pbCCCUDP";
            this.pbCCCUDP.Size = new System.Drawing.Size(33, 14);
            this.pbCCCUDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCCCUDP.TabIndex = 14;
            this.pbCCCUDP.TabStop = false;
            // 
            // lblCCC
            // 
            this.lblCCC.AutoSize = true;
            this.lblCCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCCC.Location = new System.Drawing.Point(3, 60);
            this.lblCCC.Name = "lblCCC";
            this.lblCCC.Size = new System.Drawing.Size(208, 20);
            this.lblCCC.TabIndex = 13;
            this.lblCCC.Text = "tracker.ccc.de";
            this.lblCCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbPublicBTUDP
            // 
            this.pbPublicBTUDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPublicBTUDP.Image = ((System.Drawing.Image)(resources.GetObject("pbPublicBTUDP.Image")));
            this.pbPublicBTUDP.Location = new System.Drawing.Point(217, 23);
            this.pbPublicBTUDP.Name = "pbPublicBTUDP";
            this.pbPublicBTUDP.Size = new System.Drawing.Size(33, 14);
            this.pbPublicBTUDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbPublicBTUDP.TabIndex = 8;
            this.pbPublicBTUDP.TabStop = false;
            // 
            // lblPublicBT
            // 
            this.lblPublicBT.AutoSize = true;
            this.lblPublicBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublicBT.Location = new System.Drawing.Point(3, 20);
            this.lblPublicBT.Name = "lblPublicBT";
            this.lblPublicBT.Size = new System.Drawing.Size(208, 20);
            this.lblPublicBT.TabIndex = 7;
            this.lblPublicBT.Text = "tracker.publicbt.com";
            this.lblPublicBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOpenBT
            // 
            this.lblOpenBT.AutoSize = true;
            this.lblOpenBT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOpenBT.Location = new System.Drawing.Point(3, 0);
            this.lblOpenBT.Name = "lblOpenBT";
            this.lblOpenBT.Size = new System.Drawing.Size(208, 20);
            this.lblOpenBT.TabIndex = 2;
            this.lblOpenBT.Text = "tracker.openbittorrent.com";
            this.lblOpenBT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbOpenBTUDP
            // 
            this.pbOpenBTUDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOpenBTUDP.Image = ((System.Drawing.Image)(resources.GetObject("pbOpenBTUDP.Image")));
            this.pbOpenBTUDP.Location = new System.Drawing.Point(217, 3);
            this.pbOpenBTUDP.Name = "pbOpenBTUDP";
            this.pbOpenBTUDP.Size = new System.Drawing.Size(33, 14);
            this.pbOpenBTUDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbOpenBTUDP.TabIndex = 1;
            this.pbOpenBTUDP.TabStop = false;
            // 
            // lbliStoleIT
            // 
            this.lbliStoleIT.AutoSize = true;
            this.lbliStoleIT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbliStoleIT.Location = new System.Drawing.Point(3, 40);
            this.lbliStoleIT.Name = "lbliStoleIT";
            this.lbliStoleIT.Size = new System.Drawing.Size(208, 20);
            this.lbliStoleIT.TabIndex = 10;
            this.lbliStoleIT.Text = "tracker.istole.it";
            this.lbliStoleIT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbiStoleITUDP
            // 
            this.pbiStoleITUDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbiStoleITUDP.Image = ((System.Drawing.Image)(resources.GetObject("pbiStoleITUDP.Image")));
            this.pbiStoleITUDP.Location = new System.Drawing.Point(217, 43);
            this.pbiStoleITUDP.Name = "pbiStoleITUDP";
            this.pbiStoleITUDP.Size = new System.Drawing.Size(33, 14);
            this.pbiStoleITUDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbiStoleITUDP.TabIndex = 11;
            this.pbiStoleITUDP.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(277, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 132);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Test!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 347);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Mijn data niet verzenden";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TorrentBlockCheck.Properties.Resources._1517686_1476049775946312_7755740078550404169_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 399);
            this.progressBar1.Maximum = 5;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(477, 10);
            this.progressBar1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 421);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Torrent Blokkade Check";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDemoniiUDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCCCUDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPublicBTUDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpenBTUDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbiStoleITUDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIPLabel;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblISPLabel;
        private System.Windows.Forms.Label lblISP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblLocatieLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbDemoniiUDP;
        private System.Windows.Forms.Label lblDemonii;
        private System.Windows.Forms.PictureBox pbCCCUDP;
        private System.Windows.Forms.Label lblCCC;
        private System.Windows.Forms.PictureBox pbPublicBTUDP;
        private System.Windows.Forms.Label lblPublicBT;
        private System.Windows.Forms.Label lblOpenBT;
        private System.Windows.Forms.PictureBox pbOpenBTUDP;
        private System.Windows.Forms.Label lbliStoleIT;
        private System.Windows.Forms.PictureBox pbiStoleITUDP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

