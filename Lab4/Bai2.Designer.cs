namespace Lab4
{
    partial class Bai2
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
            this.rtbHTML = new System.Windows.Forms.RichTextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbHTML
            // 
            this.rtbHTML.Location = new System.Drawing.Point(17, 116);
            this.rtbHTML.Name = "rtbHTML";
            this.rtbHTML.Size = new System.Drawing.Size(1020, 517);
            this.rtbHTML.TabIndex = 5;
            this.rtbHTML.Text = "";
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(884, 35);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(150, 50);
            this.btnPost.TabIndex = 4;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbUrl.Location = new System.Drawing.Point(17, 28);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(861, 30);
            this.tbUrl.TabIndex = 3;
            // 
            // tbData
            // 
            this.tbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbData.Location = new System.Drawing.Point(17, 64);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(861, 30);
            this.tbData.TabIndex = 6;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 659);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.rtbHTML);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.tbUrl);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbHTML;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TextBox tbData;
    }
}