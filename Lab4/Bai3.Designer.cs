namespace Lab4
{
    partial class Bai3
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
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.rtbSrccode = new System.Windows.Forms.RichTextBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbUrl.Location = new System.Drawing.Point(43, 30);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(847, 30);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.TextChanged += new System.EventHandler(this.tbUrl_TextChanged);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(913, 30);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(150, 30);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // rtbSrccode
            // 
            this.rtbSrccode.Location = new System.Drawing.Point(43, 113);
            this.rtbSrccode.Name = "rtbSrccode";
            this.rtbSrccode.Size = new System.Drawing.Size(1020, 494);
            this.rtbSrccode.TabIndex = 2;
            this.rtbSrccode.Text = "";
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPath.Location = new System.Drawing.Point(43, 77);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(847, 30);
            this.tbPath.TabIndex = 3;
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 639);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.rtbSrccode);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.tbUrl);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.RichTextBox rtbSrccode;
        private System.Windows.Forms.TextBox tbPath;
    }
}