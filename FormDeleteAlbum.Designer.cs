namespace BDProject
{
    partial class FormDeleteAlbum
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
            this.AlbumName = new System.Windows.Forms.Label();
            this.AlbumNameTextBox = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlbumName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlbumName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumName.Location = new System.Drawing.Point(21, 15);
            this.AlbumName.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(134, 15);
            this.AlbumName.TabIndex = 5;
            this.AlbumName.Text = "AlbumName to be deleted:";
            this.AlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlbumNameTextBox
            // 
            this.AlbumNameTextBox.ForeColor = System.Drawing.Color.YellowGreen;
            this.AlbumNameTextBox.Location = new System.Drawing.Point(165, 12);
            this.AlbumNameTextBox.Name = "AlbumNameTextBox";
            this.AlbumNameTextBox.Size = new System.Drawing.Size(172, 20);
            this.AlbumNameTextBox.TabIndex = 10;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(100, 51);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(138, 31);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FormDeleteAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(349, 94);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AlbumNameTextBox);
            this.Controls.Add(this.AlbumName);
            this.Name = "FormDeleteAlbum";
            this.Text = "FormDeleteAlbum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.TextBox AlbumNameTextBox;
        private System.Windows.Forms.Button Delete;
    }
}