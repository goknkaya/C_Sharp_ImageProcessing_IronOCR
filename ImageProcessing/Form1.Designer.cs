namespace ImageProcessing
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
            this.pbFile = new System.Windows.Forms.PictureBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnConvertFile = new System.Windows.Forms.Button();
            this.rbFile = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFile
            // 
            this.pbFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFile.Location = new System.Drawing.Point(0, 51);
            this.pbFile.Name = "pbFile";
            this.pbFile.Size = new System.Drawing.Size(271, 361);
            this.pbFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFile.TabIndex = 0;
            this.pbFile.TabStop = false;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectFile.Location = new System.Drawing.Point(195, 13);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(225, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "SELECT FILE";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // btnConvertFile
            // 
            this.btnConvertFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnConvertFile.Location = new System.Drawing.Point(195, 438);
            this.btnConvertFile.Name = "btnConvertFile";
            this.btnConvertFile.Size = new System.Drawing.Size(225, 23);
            this.btnConvertFile.TabIndex = 2;
            this.btnConvertFile.Text = "CONVERT FILE";
            this.btnConvertFile.UseVisualStyleBackColor = true;
            this.btnConvertFile.Click += new System.EventHandler(this.btnConvertFile_Click);
            // 
            // rbFile
            // 
            this.rbFile.Location = new System.Drawing.Point(305, 51);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(271, 361);
            this.rbFile.TabIndex = 3;
            this.rbFile.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 476);
            this.Controls.Add(this.rbFile);
            this.Controls.Add(this.btnConvertFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.pbFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnConvertFile;
        private System.Windows.Forms.RichTextBox rbFile;
    }
}

