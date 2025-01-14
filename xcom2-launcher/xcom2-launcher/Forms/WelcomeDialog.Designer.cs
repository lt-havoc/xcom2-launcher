namespace XCOM2Launcher.Forms {
	partial class WelcomeDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeDialog));
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            bContinue = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            rSentryEnabled = new System.Windows.Forms.RadioButton();
            rSentryDisabled = new System.Windows.Forms.RadioButton();
            label5 = new System.Windows.Forms.Label();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            rGameXCom2 = new System.Windows.Forms.RadioButton();
            rGameChimera = new System.Windows.Forms.RadioButton();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(36, 6);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(561, 23);
            label1.TabIndex = 0;
            label1.Text = "Please help us to improve AML, by enabling anonymous error reporting!";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(189, 78);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(286, 127);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // bContinue
            // 
            bContinue.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            bContinue.AutoSize = true;
            bContinue.Enabled = false;
            bContinue.Image = (System.Drawing.Image)resources.GetObject("bContinue.Image");
            bContinue.Location = new System.Drawing.Point(257, 530);
            bContinue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bContinue.Name = "bContinue";
            bContinue.Size = new System.Drawing.Size(154, 38);
            bContinue.TabIndex = 2;
            bContinue.UseVisualStyleBackColor = true;
            bContinue.Click += bContinue_Click;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.Location = new System.Drawing.Point(19, 44);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(637, 23);
            label2.TabIndex = 3;
            label2.Text = "You are seeing this dialog, because you are starting AML for the first time.";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.Location = new System.Drawing.Point(19, 14);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(637, 23);
            label3.TabIndex = 4;
            label3.Text = "Welcome to the Alternative Mod Launcher!";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rSentryEnabled
            // 
            rSentryEnabled.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            rSentryEnabled.Appearance = System.Windows.Forms.Appearance.Button;
            rSentryEnabled.Checked = true;
            rSentryEnabled.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(84, 179, 94);
            rSentryEnabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rSentryEnabled.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rSentryEnabled.Location = new System.Drawing.Point(346, 36);
            rSentryEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rSentryEnabled.Name = "rSentryEnabled";
            rSentryEnabled.Size = new System.Drawing.Size(121, 28);
            rSentryEnabled.TabIndex = 6;
            rSentryEnabled.TabStop = true;
            rSentryEnabled.Text = "ENABLED";
            rSentryEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rSentryEnabled.UseVisualStyleBackColor = true;
            // 
            // rSentryDisabled
            // 
            rSentryDisabled.Appearance = System.Windows.Forms.Appearance.Button;
            rSentryDisabled.FlatAppearance.CheckedBackColor = System.Drawing.Color.Red;
            rSentryDisabled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rSentryDisabled.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            rSentryDisabled.Location = new System.Drawing.Point(167, 36);
            rSentryDisabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rSentryDisabled.Name = "rSentryDisabled";
            rSentryDisabled.Size = new System.Drawing.Size(121, 28);
            rSentryDisabled.TabIndex = 7;
            rSentryDisabled.Text = "DISABLED";
            rSentryDisabled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rSentryDisabled.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.Location = new System.Drawing.Point(12, 66);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(612, 24);
            label5.TabIndex = 9;
            label5.Text = "You can enable/disable this feature at any time from the Settings dialog.";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(rGameXCom2, 0, 0);
            tableLayoutPanel1.Controls.Add(rGameChimera, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(113, 32);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new System.Drawing.Size(410, 159);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // rGameXCom2
            // 
            rGameXCom2.Anchor = System.Windows.Forms.AnchorStyles.None;
            rGameXCom2.Appearance = System.Windows.Forms.Appearance.Button;
            rGameXCom2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(84, 179, 94);
            rGameXCom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rGameXCom2.Image = (System.Drawing.Image)resources.GetObject("rGameXCom2.Image");
            rGameXCom2.Location = new System.Drawing.Point(26, 4);
            rGameXCom2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rGameXCom2.Name = "rGameXCom2";
            rGameXCom2.Size = new System.Drawing.Size(152, 150);
            rGameXCom2.TabIndex = 9;
            rGameXCom2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rGameXCom2.UseVisualStyleBackColor = true;
            rGameXCom2.CheckedChanged += GameSelectionChanged;
            // 
            // rGameChimera
            // 
            rGameChimera.Anchor = System.Windows.Forms.AnchorStyles.None;
            rGameChimera.Appearance = System.Windows.Forms.Appearance.Button;
            rGameChimera.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(84, 179, 94);
            rGameChimera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rGameChimera.Image = (System.Drawing.Image)resources.GetObject("rGameChimera.Image");
            rGameChimera.Location = new System.Drawing.Point(231, 4);
            rGameChimera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            rGameChimera.Name = "rGameChimera";
            rGameChimera.Size = new System.Drawing.Size(152, 150);
            rGameChimera.TabIndex = 8;
            rGameChimera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            rGameChimera.UseVisualStyleBackColor = true;
            rGameChimera.CheckedChanged += GameSelectionChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(rSentryEnabled);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(rSentryDisabled);
            panel1.Location = new System.Drawing.Point(14, 417);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(636, 100);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new System.Drawing.Point(14, 212);
            panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(636, 197);
            panel2.TabIndex = 15;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.Location = new System.Drawing.Point(36, 6);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(561, 23);
            label4.TabIndex = 10;
            label4.Text = "Select the game you want to use this copy of AML for!";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WelcomeDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(670, 572);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bContinue);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WelcomeDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Welcome to AML";
            Load += WelcomeDialog_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button bContinue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rSentryEnabled;
		private System.Windows.Forms.RadioButton rSentryDisabled;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.RadioButton rGameXCom2;
		private System.Windows.Forms.RadioButton rGameChimera;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
	}
}