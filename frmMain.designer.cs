namespace uFCoder_DEMO_PC2Phone_NFC
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bReaderOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bReaderClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eMsgPhone = new System.Windows.Forms.TextBox();
            this.eMsgCustom = new System.Windows.Forms.TextBox();
            this.eMsgDef = new System.Windows.Forms.TextBox();
            this.isMsgCustom = new System.Windows.Forms.RadioButton();
            this.isMsgDef = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkAndroidSoftware = new System.Windows.Forms.LinkLabel();
            this.linkiOSSoftware = new System.Windows.Forms.LinkLabel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bReaderOpen,
            this.toolStripSeparator1,
            this.bReaderClose,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(681, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bReaderOpen
            // 
            this.bReaderOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bReaderOpen.Image = ((System.Drawing.Image)(resources.GetObject("bReaderOpen.Image")));
            this.bReaderOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bReaderOpen.Name = "bReaderOpen";
            this.bReaderOpen.Size = new System.Drawing.Size(79, 22);
            this.bReaderOpen.Text = "Open Reader";
            this.bReaderOpen.Click += new System.EventHandler(this.bReaderOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bReaderClose
            // 
            this.bReaderClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bReaderClose.Enabled = false;
            this.bReaderClose.Image = ((System.Drawing.Image)(resources.GetObject("bReaderClose.Image")));
            this.bReaderClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bReaderClose.Name = "bReaderClose";
            this.bReaderClose.Size = new System.Drawing.Size(79, 22);
            this.bReaderClose.Text = "Close Reader";
            this.bReaderClose.Click += new System.EventHandler(this.bReaderClose_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkiOSSoftware);
            this.groupBox1.Controls.Add(this.linkAndroidSoftware);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.eMsgPhone);
            this.groupBox1.Controls.Add(this.eMsgCustom);
            this.groupBox1.Controls.Add(this.eMsgDef);
            this.groupBox1.Controls.Add(this.isMsgCustom);
            this.groupBox1.Controls.Add(this.isMsgDef);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 202);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messages";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Phone Msg:";
            // 
            // eMsgPhone
            // 
            this.eMsgPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eMsgPhone.Location = new System.Drawing.Point(75, 85);
            this.eMsgPhone.Name = "eMsgPhone";
            this.eMsgPhone.ReadOnly = true;
            this.eMsgPhone.Size = new System.Drawing.Size(594, 20);
            this.eMsgPhone.TabIndex = 9;
            // 
            // eMsgCustom
            // 
            this.eMsgCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eMsgCustom.Location = new System.Drawing.Point(75, 44);
            this.eMsgCustom.MaxLength = 95;
            this.eMsgCustom.Name = "eMsgCustom";
            this.eMsgCustom.Size = new System.Drawing.Size(594, 20);
            this.eMsgCustom.TabIndex = 4;
            // 
            // eMsgDef
            // 
            this.eMsgDef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eMsgDef.Location = new System.Drawing.Point(75, 18);
            this.eMsgDef.Name = "eMsgDef";
            this.eMsgDef.ReadOnly = true;
            this.eMsgDef.Size = new System.Drawing.Size(594, 20);
            this.eMsgDef.TabIndex = 3;
            this.eMsgDef.Text = "Hi mobile device, I am here";
            // 
            // isMsgCustom
            // 
            this.isMsgCustom.AutoSize = true;
            this.isMsgCustom.Location = new System.Drawing.Point(12, 45);
            this.isMsgCustom.Name = "isMsgCustom";
            this.isMsgCustom.Size = new System.Drawing.Size(59, 17);
            this.isMsgCustom.TabIndex = 1;
            this.isMsgCustom.Text = "custom";
            this.isMsgCustom.UseVisualStyleBackColor = true;
            // 
            // isMsgDef
            // 
            this.isMsgDef.AutoSize = true;
            this.isMsgDef.Checked = true;
            this.isMsgDef.Location = new System.Drawing.Point(12, 19);
            this.isMsgDef.Name = "isMsgDef";
            this.isMsgDef.Size = new System.Drawing.Size(57, 17);
            this.isMsgDef.TabIndex = 0;
            this.isMsgDef.TabStop = true;
            this.isMsgDef.Text = "default";
            this.isMsgDef.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 205);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(681, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(45, 17);
            this.statusLabel.Text = "STATUS";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Android software:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "iOS software:";
            // 
            // linkAndroidSoftware
            // 
            this.linkAndroidSoftware.AutoSize = true;
            this.linkAndroidSoftware.Location = new System.Drawing.Point(104, 127);
            this.linkAndroidSoftware.Name = "linkAndroidSoftware";
            this.linkAndroidSoftware.Size = new System.Drawing.Size(572, 13);
            this.linkAndroidSoftware.TabIndex = 15;
            this.linkAndroidSoftware.TabStop = true;
            this.linkAndroidSoftware.Text = "https://www.d-logic.net/code/nfc-rfid-reader-sdk/ufr-examples-android-nfc_data_ex" +
    "change_through_card_emulation.git";
            this.linkAndroidSoftware.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAndroidSoftware_LinkClicked);
            // 
            // linkiOSSoftware
            // 
            this.linkiOSSoftware.AutoSize = true;
            this.linkiOSSoftware.Location = new System.Drawing.Point(104, 152);
            this.linkiOSSoftware.Name = "linkiOSSoftware";
            this.linkiOSSoftware.Size = new System.Drawing.Size(550, 13);
            this.linkiOSSoftware.TabIndex = 16;
            this.linkiOSSoftware.TabStop = true;
            this.linkiOSSoftware.Text = "https://www.d-logic.net/code/nfc-rfid-reader-sdk/ufr-examples-ios-nfc_data_exchan" +
    "ge_through_card_emulation.git";
            this.linkiOSSoftware.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkiOSSoftware_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 227);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "NFC Data Exchange v1.2.1.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bReaderOpen;
        private System.Windows.Forms.ToolStripButton bReaderClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox eMsgCustom;
        private System.Windows.Forms.TextBox eMsgDef;
        private System.Windows.Forms.RadioButton isMsgCustom;
        private System.Windows.Forms.RadioButton isMsgDef;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eMsgPhone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkAndroidSoftware;
        private System.Windows.Forms.LinkLabel linkiOSSoftware;
    }
}

