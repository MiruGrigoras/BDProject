namespace BDProject
{
    partial class FormAddAlbum
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
            this.myDatabaseDataSet = new BDProject.MyDatabaseDataSet();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumTableAdapter = new BDProject.MyDatabaseDataSetTableAdapters.AlbumTableAdapter();
            this.tableAdapterManager = new BDProject.MyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.Add = new System.Windows.Forms.Button();
            this.NoSongs = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.AlbumName = new System.Windows.Forms.Label();
            this.SingerKeyAlbum = new System.Windows.Forms.Label();
            this.NoSongsTextBox = new System.Windows.Forms.TextBox();
            this.AlbumNameTextBox = new System.Windows.Forms.TextBox();
            this.SingerKeyTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseDatePicker = new System.Windows.Forms.DateTimePicker();
            this.AlbumKeyTextBox = new System.Windows.Forms.TextBox();
            this.AlbumKey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // myDatabaseDataSet
            // 
            this.myDatabaseDataSet.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataMember = "Album";
            this.albumBindingSource.DataSource = this.myDatabaseDataSet;
            // 
            // albumTableAdapter
            // 
            this.albumTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumTableAdapter = this.albumTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SingerTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BDProject.MyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(101, 185);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(138, 31);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NoSongs
            // 
            this.NoSongs.AutoSize = true;
            this.NoSongs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NoSongs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoSongs.Location = new System.Drawing.Point(32, 147);
            this.NoSongs.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.NoSongs.Name = "NoSongs";
            this.NoSongs.Size = new System.Drawing.Size(92, 15);
            this.NoSongs.TabIndex = 5;
            this.NoSongs.Text = "Number of songs:";
            this.NoSongs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReleaseDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReleaseDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReleaseDate.Location = new System.Drawing.Point(32, 120);
            this.ReleaseDate.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(77, 15);
            this.ReleaseDate.TabIndex = 6;
            this.ReleaseDate.Text = "ReleaseDate: ";
            this.ReleaseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlbumName
            // 
            this.AlbumName.AutoSize = true;
            this.AlbumName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlbumName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlbumName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumName.Location = new System.Drawing.Point(32, 93);
            this.AlbumName.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.AlbumName.Name = "AlbumName";
            this.AlbumName.Size = new System.Drawing.Size(72, 15);
            this.AlbumName.TabIndex = 7;
            this.AlbumName.Text = "AlbumName: ";
            this.AlbumName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingerKeyAlbum
            // 
            this.SingerKeyAlbum.AutoSize = true;
            this.SingerKeyAlbum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SingerKeyAlbum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SingerKeyAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingerKeyAlbum.Location = new System.Drawing.Point(32, 66);
            this.SingerKeyAlbum.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.SingerKeyAlbum.Name = "SingerKeyAlbum";
            this.SingerKeyAlbum.Size = new System.Drawing.Size(60, 15);
            this.SingerKeyAlbum.TabIndex = 8;
            this.SingerKeyAlbum.Text = "SingerKey:";
            this.SingerKeyAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoSongsTextBox
            // 
            this.NoSongsTextBox.Location = new System.Drawing.Point(138, 144);
            this.NoSongsTextBox.Name = "NoSongsTextBox";
            this.NoSongsTextBox.Size = new System.Drawing.Size(203, 20);
            this.NoSongsTextBox.TabIndex = 10;
            // 
            // AlbumNameTextBox
            // 
            this.AlbumNameTextBox.Location = new System.Drawing.Point(138, 88);
            this.AlbumNameTextBox.Name = "AlbumNameTextBox";
            this.AlbumNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.AlbumNameTextBox.TabIndex = 12;
            // 
            // SingerKeyTextBox
            // 
            this.SingerKeyTextBox.Location = new System.Drawing.Point(138, 61);
            this.SingerKeyTextBox.Name = "SingerKeyTextBox";
            this.SingerKeyTextBox.Size = new System.Drawing.Size(203, 20);
            this.SingerKeyTextBox.TabIndex = 13;
            // 
            // ReleaseDatePicker
            // 
            this.ReleaseDatePicker.Location = new System.Drawing.Point(138, 114);
            this.ReleaseDatePicker.Name = "ReleaseDatePicker";
            this.ReleaseDatePicker.Size = new System.Drawing.Size(200, 20);
            this.ReleaseDatePicker.TabIndex = 14;
            this.ReleaseDatePicker.Value = new System.DateTime(2019, 5, 21, 0, 0, 0, 0);
            // 
            // AlbumKeyTextBox
            // 
            this.AlbumKeyTextBox.Location = new System.Drawing.Point(138, 36);
            this.AlbumKeyTextBox.Name = "AlbumKeyTextBox";
            this.AlbumKeyTextBox.Size = new System.Drawing.Size(203, 20);
            this.AlbumKeyTextBox.TabIndex = 9;
            // 
            // AlbumKey
            // 
            this.AlbumKey.AutoSize = true;
            this.AlbumKey.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlbumKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlbumKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlbumKey.Location = new System.Drawing.Point(32, 39);
            this.AlbumKey.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.AlbumKey.Name = "AlbumKey";
            this.AlbumKey.Size = new System.Drawing.Size(59, 15);
            this.AlbumKey.TabIndex = 4;
            this.AlbumKey.Text = "AlbumKey:";
            this.AlbumKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(353, 450);
            this.Controls.Add(this.ReleaseDatePicker);
            this.Controls.Add(this.SingerKeyTextBox);
            this.Controls.Add(this.AlbumNameTextBox);
            this.Controls.Add(this.NoSongsTextBox);
            this.Controls.Add(this.AlbumKeyTextBox);
            this.Controls.Add(this.SingerKeyAlbum);
            this.Controls.Add(this.AlbumName);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.NoSongs);
            this.Controls.Add(this.AlbumKey);
            this.Controls.Add(this.Add);
            this.Name = "FormAddAlbum";
            this.Text = "FormAddAlbum";
            this.Load += new System.EventHandler(this.FormAddAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDatabaseDataSet myDatabaseDataSet;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private MyDatabaseDataSetTableAdapters.AlbumTableAdapter albumTableAdapter;
        private MyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label NoSongs;
        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.Label AlbumName;
        private System.Windows.Forms.Label SingerKeyAlbum;
        private System.Windows.Forms.TextBox NoSongsTextBox;
        private System.Windows.Forms.TextBox AlbumNameTextBox;
        private System.Windows.Forms.TextBox SingerKeyTextBox;
        private System.Windows.Forms.DateTimePicker ReleaseDatePicker;
        private System.Windows.Forms.TextBox AlbumKeyTextBox;
        private System.Windows.Forms.Label AlbumKey;
    }
}