namespace WCFWinForm
{
    partial class WCF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WCF));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            listURL = new System.Windows.Forms.ListBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnSendURL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // listURL
            // 
            listURL.FormattingEnabled = true;
            listURL.Items.AddRange(new object[] {
            "www.google.com"});
            listURL.Location = new System.Drawing.Point(12, 270);
            listURL.Name = "listURL";
            listURL.Size = new System.Drawing.Size(477, 95);
            listURL.TabIndex = 1;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(381, 371);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(108, 23);
            this.btnBrowser.TabIndex = 2;
            this.btnBrowser.Text = "Open in Browser";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "URL Share";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // btnSendURL
            // 
            this.btnSendURL.Location = new System.Drawing.Point(163, 7);
            this.btnSendURL.Name = "btnSendURL";
            this.btnSendURL.Size = new System.Drawing.Size(93, 23);
            this.btnSendURL.TabIndex = 3;
            this.btnSendURL.Text = "Send URL";
            this.btnSendURL.UseVisualStyleBackColor = true;
            // 
            // WCF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 406);
            this.Controls.Add(this.btnSendURL);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(listURL);
            this.Controls.Add(this.comboBox1);
            this.Name = "WCF";
            this.Text = "WCF";
            this.Load += new System.EventHandler(WCF_Load);
            this.Resize += new System.EventHandler(this.WCF_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        public static System.Windows.Forms.ListBox listURL;
        public System.Windows.Forms.Button btnBrowser;
        public System.Windows.Forms.Button btnSendURL;

    }
}

