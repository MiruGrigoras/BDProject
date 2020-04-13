namespace BDProject
{
    partial class FormDeleteSinger
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
            this.Delete = new System.Windows.Forms.Button();
            this.SingerKeyTextBox = new System.Windows.Forms.TextBox();
            this.SingerKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(96, 53);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(138, 31);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // SingerKeyTextBox
            // 
            this.SingerKeyTextBox.Location = new System.Drawing.Point(161, 14);
            this.SingerKeyTextBox.Name = "SingerKeyTextBox";
            this.SingerKeyTextBox.Size = new System.Drawing.Size(172, 20);
            this.SingerKeyTextBox.TabIndex = 13;
            // 
            // SingerKey
            // 
            this.SingerKey.AutoSize = true;
            this.SingerKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SingerKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SingerKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingerKey.Location = new System.Drawing.Point(17, 17);
            this.SingerKey.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.SingerKey.Name = "SingerKey";
            this.SingerKey.Size = new System.Drawing.Size(125, 15);
            this.SingerKey.TabIndex = 12;
            this.SingerKey.Text = "SingerKey to be deleted:";
            this.SingerKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDeleteSinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(349, 96);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.SingerKeyTextBox);
            this.Controls.Add(this.SingerKey);
            this.Name = "FormDeleteSinger";
            this.Text = "FormDeleteSinger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox SingerKeyTextBox;
        private System.Windows.Forms.Label SingerKey;
    }
}