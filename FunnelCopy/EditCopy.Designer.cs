namespace FunnelCopy
{
    partial class EditCopy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCopy));
            this.cornerButtonCancel = new FunnelCopy.CornerButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCopy = new System.Windows.Forms.TextBox();
            this.copyReplaceword = new System.Windows.Forms.RichTextBox();
            this.cornerButtonOk = new FunnelCopy.CornerButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cornerButtonCancel
            // 
            this.cornerButtonCancel.BackColor = System.Drawing.Color.White;
            this.cornerButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cornerButtonCancel.FlatAppearance.BorderSize = 5;
            this.cornerButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cornerButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cornerButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.cornerButtonCancel.Location = new System.Drawing.Point(392, 229);
            this.cornerButtonCancel.Name = "cornerButtonCancel";
            this.cornerButtonCancel.Size = new System.Drawing.Size(79, 33);
            this.cornerButtonCancel.TabIndex = 0;
            this.cornerButtonCancel.Text = "Cancel";
            this.cornerButtonCancel.UseVisualStyleBackColor = false;
            this.cornerButtonCancel.Click += new System.EventHandler(this.cornerButtonCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCopy
            // 
            this.textBoxCopy.Location = new System.Drawing.Point(170, 76);
            this.textBoxCopy.Name = "textBoxCopy";
            this.textBoxCopy.Size = new System.Drawing.Size(301, 20);
            this.textBoxCopy.TabIndex = 2;
            // 
            // copyReplaceword
            // 
            this.copyReplaceword.Location = new System.Drawing.Point(170, 115);
            this.copyReplaceword.Name = "copyReplaceword";
            this.copyReplaceword.Size = new System.Drawing.Size(301, 108);
            this.copyReplaceword.TabIndex = 3;
            this.copyReplaceword.Text = "";
            // 
            // cornerButtonOk
            // 
            this.cornerButtonOk.BackColor = System.Drawing.Color.White;
            this.cornerButtonOk.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cornerButtonOk.FlatAppearance.BorderSize = 5;
            this.cornerButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cornerButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cornerButtonOk.ForeColor = System.Drawing.Color.Black;
            this.cornerButtonOk.Location = new System.Drawing.Point(170, 229);
            this.cornerButtonOk.Name = "cornerButtonOk";
            this.cornerButtonOk.Size = new System.Drawing.Size(79, 33);
            this.cornerButtonOk.TabIndex = 4;
            this.cornerButtonOk.Text = "Ok";
            this.cornerButtonOk.UseVisualStyleBackColor = false;
            this.cornerButtonOk.Click += new System.EventHandler(this.cornerButtonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Currently editing the line:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "In here you can choose to replace the underlines in the";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "currently selected text with a word (or multiple words) of";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "your choice.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter words to replace underlines with: (word per line)";
            // 
            // EditCopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 274);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cornerButtonOk);
            this.Controls.Add(this.copyReplaceword);
            this.Controls.Add(this.textBoxCopy);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cornerButtonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCopy";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace with your own words";
            this.Load += new System.EventHandler(this.EditCopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CornerButton cornerButtonCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxCopy;
        private System.Windows.Forms.RichTextBox copyReplaceword;
        private CornerButton cornerButtonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}