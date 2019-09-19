namespace Website_Saver3
{
    partial class LandingForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.URLInputBox = new System.Windows.Forms.TextBox();
            this.DownloadToInputBox = new System.Windows.Forms.TextBox();
            this.DefaultSmallLabel = new System.Windows.Forms.Label();
            this.ToFolderLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.URLDownloadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "This happens recursively until all the pages are downloaded.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "That page is saved and any URLs with the same domain are saved.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "This program works by taking the input URL and downloading that page.";
            // 
            // URLInputBox
            // 
            this.URLInputBox.Location = new System.Drawing.Point(100, 54);
            this.URLInputBox.Name = "URLInputBox";
            this.URLInputBox.Size = new System.Drawing.Size(324, 20);
            this.URLInputBox.TabIndex = 14;
            this.URLInputBox.TextChanged += new System.EventHandler(this.URLInputBox_TextChanged);
            // 
            // DownloadToInputBox
            // 
            this.DownloadToInputBox.Location = new System.Drawing.Point(100, 118);
            this.DownloadToInputBox.Name = "DownloadToInputBox";
            this.DownloadToInputBox.Size = new System.Drawing.Size(324, 20);
            this.DownloadToInputBox.TabIndex = 13;
            this.DownloadToInputBox.TextChanged += new System.EventHandler(this.DownloadToInputBox_TextChanged);
            // 
            // DefaultSmallLabel
            // 
            this.DefaultSmallLabel.AutoSize = true;
            this.DefaultSmallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.DefaultSmallLabel.Location = new System.Drawing.Point(98, 141);
            this.DefaultSmallLabel.Name = "DefaultSmallLabel";
            this.DefaultSmallLabel.Size = new System.Drawing.Size(386, 12);
            this.DefaultSmallLabel.TabIndex = 12;
            this.DefaultSmallLabel.Text = "If left blank then files will be downloaded to directory of this program in folde" +
    "r named after URL";
            // 
            // ToFolderLabel
            // 
            this.ToFolderLabel.AutoSize = true;
            this.ToFolderLabel.Location = new System.Drawing.Point(97, 102);
            this.ToFolderLabel.Name = "ToFolderLabel";
            this.ToFolderLabel.Size = new System.Drawing.Size(115, 13);
            this.ToFolderLabel.TabIndex = 11;
            this.ToFolderLabel.Text = "Folder to Download To";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(174, 295);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(132, 23);
            this.StartButton.TabIndex = 10;
            this.StartButton.Text = "Start Downloading";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // URLDownloadLabel
            // 
            this.URLDownloadLabel.AutoSize = true;
            this.URLDownloadLabel.Location = new System.Drawing.Point(97, 38);
            this.URLDownloadLabel.Name = "URLDownloadLabel";
            this.URLDownloadLabel.Size = new System.Drawing.Size(92, 13);
            this.URLDownloadLabel.TabIndex = 9;
            this.URLDownloadLabel.Text = "URL to Download";
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URLInputBox);
            this.Controls.Add(this.DownloadToInputBox);
            this.Controls.Add(this.DefaultSmallLabel);
            this.Controls.Add(this.ToFolderLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.URLDownloadLabel);
            this.Name = "LandingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox URLInputBox;
        private System.Windows.Forms.TextBox DownloadToInputBox;
        private System.Windows.Forms.Label DefaultSmallLabel;
        private System.Windows.Forms.Label ToFolderLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label URLDownloadLabel;
    }
}

