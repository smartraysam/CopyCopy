namespace FunnelCopy
{
    partial class AddMore
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
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.richTextBoxNewword = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cornerButtonCancel = new FunnelCopy.CornerButton();
            this.cornerButtonOk = new FunnelCopy.CornerButton();
            this.SuspendLayout();
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Headlines",
            "Sub-headlines",
            "Copy Opener",
            "Bullet Points",
            "Guarantees",
            "Post Scripts",
            "Smiles",
            "Copy Connectors",
            "Power Word"});
            this.comboBoxCategory.Location = new System.Drawing.Point(12, 29);
            this.comboBoxCategory.MaxDropDownItems = 10;
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(380, 21);
            this.comboBoxCategory.TabIndex = 0;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // richTextBoxNewword
            // 
            this.richTextBoxNewword.Location = new System.Drawing.Point(13, 69);
            this.richTextBoxNewword.Name = "richTextBoxNewword";
            this.richTextBoxNewword.Size = new System.Drawing.Size(380, 141);
            this.richTextBoxNewword.TabIndex = 1;
            this.richTextBoxNewword.Text = "";
            this.richTextBoxNewword.TextChanged += new System.EventHandler(this.richTextBoxNewword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter new input sentence on new line";
            // 
            // cornerButtonCancel
            // 
            this.cornerButtonCancel.BackColor = System.Drawing.Color.White;
            this.cornerButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cornerButtonCancel.FlatAppearance.BorderSize = 5;
            this.cornerButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cornerButtonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cornerButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.cornerButtonCancel.Location = new System.Drawing.Point(289, 228);
            this.cornerButtonCancel.Name = "cornerButtonCancel";
            this.cornerButtonCancel.Size = new System.Drawing.Size(104, 41);
            this.cornerButtonCancel.TabIndex = 3;
            this.cornerButtonCancel.Text = "Cancel";
            this.cornerButtonCancel.UseVisualStyleBackColor = false;
            this.cornerButtonCancel.Click += new System.EventHandler(this.cornerButtonCancel_Click);
            // 
            // cornerButtonOk
            // 
            this.cornerButtonOk.BackColor = System.Drawing.Color.White;
            this.cornerButtonOk.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cornerButtonOk.FlatAppearance.BorderSize = 5;
            this.cornerButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cornerButtonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cornerButtonOk.ForeColor = System.Drawing.Color.Black;
            this.cornerButtonOk.Location = new System.Drawing.Point(13, 228);
            this.cornerButtonOk.Name = "cornerButtonOk";
            this.cornerButtonOk.Size = new System.Drawing.Size(104, 41);
            this.cornerButtonOk.TabIndex = 2;
            this.cornerButtonOk.Text = "Ok";
            this.cornerButtonOk.UseVisualStyleBackColor = false;
            this.cornerButtonOk.Click += new System.EventHandler(this.cornerButtonOk_Click);
            // 
            // AddMore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 287);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cornerButtonCancel);
            this.Controls.Add(this.cornerButtonOk);
            this.Controls.Add(this.richTextBoxNewword);
            this.Controls.Add(this.comboBoxCategory);
            this.Name = "AddMore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add More";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.RichTextBox richTextBoxNewword;
        private CornerButton cornerButtonOk;
        private CornerButton cornerButtonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}