namespace BDProject
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.AddSinger = new System.Windows.Forms.Button();
            this.SingerName = new System.Windows.Forms.Label();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.singerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myDatabaseDataSet1 = new BDProject.MyDatabaseDataSet();
            this.NoAlbums = new System.Windows.Forms.Label();
            this.NoAwards = new System.Windows.Forms.Label();
            this.NoAwardsTextBox = new System.Windows.Forms.TextBox();
            this.NoAlbumsTextBox = new System.Windows.Forms.TextBox();
            this.RecordLabelTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.UpdateSinger = new System.Windows.Forms.Button();
            this.DeleteAlbum = new System.Windows.Forms.Button();
            this.DeleteSinger = new System.Windows.Forms.Button();
            this.AddAlbum = new System.Windows.Forms.Button();
            this.SearchSinger = new System.Windows.Forms.Label();
            this.SearchArtistTextBox = new System.Windows.Forms.TextBox();
            this.SingerKey = new System.Windows.Forms.Label();
            this.SingerKeyTextBox = new System.Windows.Forms.TextBox();
            this.singerTableAdapter1 = new BDProject.MyDatabaseDataSetTableAdapters.SingerTableAdapter();
            this.ShowAlbums = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.singerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(189, 291);
            this.Next.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(87, 38);
            this.Next.TabIndex = 0;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(84, 291);
            this.Previous.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(87, 38);
            this.Previous.TabIndex = 1;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // AddSinger
            // 
            this.AddSinger.Location = new System.Drawing.Point(423, 254);
            this.AddSinger.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AddSinger.Name = "AddSinger";
            this.AddSinger.Size = new System.Drawing.Size(194, 29);
            this.AddSinger.TabIndex = 2;
            this.AddSinger.Text = "Add Singer";
            this.AddSinger.UseVisualStyleBackColor = true;
            this.AddSinger.Click += new System.EventHandler(this.AddSinger_Click);
            // 
            // SingerName
            // 
            this.SingerName.AutoSize = true;
            this.SingerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SingerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingerName.Location = new System.Drawing.Point(117, 55);
            this.SingerName.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.SingerName.Name = "SingerName";
            this.SingerName.Size = new System.Drawing.Size(55, 20);
            this.SingerName.TabIndex = 3;
            this.SingerName.Text = "Name:";
            this.SingerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordLabel.Location = new System.Drawing.Point(59, 105);
            this.RecordLabel.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(113, 20);
            this.RecordLabel.TabIndex = 4;
            this.RecordLabel.Text = "Record Label:";
            this.RecordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "SingerName", true));
            this.NameTextBox.Location = new System.Drawing.Point(189, 52);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(188, 25);
            this.NameTextBox.TabIndex = 5;
            // 
            // singerBindingSource
            // 
            this.singerBindingSource.DataMember = "Singer";
            this.singerBindingSource.DataSource = this.myDatabaseDataSet1;
            // 
            // myDatabaseDataSet1
            // 
            this.myDatabaseDataSet1.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NoAlbums
            // 
            this.NoAlbums.AutoSize = true;
            this.NoAlbums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoAlbums.Location = new System.Drawing.Point(21, 162);
            this.NoAlbums.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.NoAlbums.Name = "NoAlbums";
            this.NoAlbums.Size = new System.Drawing.Size(151, 20);
            this.NoAlbums.TabIndex = 6;
            this.NoAlbums.Text = "Number of albums:";
            this.NoAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoAwards
            // 
            this.NoAwards.AutoSize = true;
            this.NoAwards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoAwards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NoAwards.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoAwards.Location = new System.Drawing.Point(32, 214);
            this.NoAwards.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.NoAwards.Name = "NoAwards";
            this.NoAwards.Size = new System.Drawing.Size(140, 19);
            this.NoAwards.TabIndex = 7;
            this.NoAwards.Text = "Number of awards:";
            this.NoAwards.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NoAwardsTextBox
            // 
            this.NoAwardsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "NoAwards", true));
            this.NoAwardsTextBox.Location = new System.Drawing.Point(189, 210);
            this.NoAwardsTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NoAwardsTextBox.Name = "NoAwardsTextBox";
            this.NoAwardsTextBox.Size = new System.Drawing.Size(188, 25);
            this.NoAwardsTextBox.TabIndex = 8;
            // 
            // NoAlbumsTextBox
            // 
            this.NoAlbumsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "NoAlbums", true));
            this.NoAlbumsTextBox.Location = new System.Drawing.Point(189, 159);
            this.NoAlbumsTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NoAlbumsTextBox.Name = "NoAlbumsTextBox";
            this.NoAlbumsTextBox.Size = new System.Drawing.Size(188, 25);
            this.NoAlbumsTextBox.TabIndex = 9;
            // 
            // RecordLabelTextBox
            // 
            this.RecordLabelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "RecordLabel", true));
            this.RecordLabelTextBox.Location = new System.Drawing.Point(189, 102);
            this.RecordLabelTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RecordLabelTextBox.Name = "RecordLabelTextBox";
            this.RecordLabelTextBox.Size = new System.Drawing.Size(188, 25);
            this.RecordLabelTextBox.TabIndex = 10;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(423, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(665, 183);
            this.dataGridView.TabIndex = 11;
            // 
            // UpdateSinger
            // 
            this.UpdateSinger.Location = new System.Drawing.Point(423, 334);
            this.UpdateSinger.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UpdateSinger.Name = "UpdateSinger";
            this.UpdateSinger.Size = new System.Drawing.Size(194, 29);
            this.UpdateSinger.TabIndex = 12;
            this.UpdateSinger.Text = "Update Singer";
            this.UpdateSinger.UseVisualStyleBackColor = true;
            this.UpdateSinger.Click += new System.EventHandler(this.UpdateSinger_Click);
            // 
            // DeleteAlbum
            // 
            this.DeleteAlbum.Location = new System.Drawing.Point(633, 291);
            this.DeleteAlbum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeleteAlbum.Name = "DeleteAlbum";
            this.DeleteAlbum.Size = new System.Drawing.Size(194, 29);
            this.DeleteAlbum.TabIndex = 13;
            this.DeleteAlbum.Text = "Delete Album";
            this.DeleteAlbum.UseVisualStyleBackColor = true;
            this.DeleteAlbum.Click += new System.EventHandler(this.DeleteAlbum_Click);
            // 
            // DeleteSinger
            // 
            this.DeleteSinger.Location = new System.Drawing.Point(423, 291);
            this.DeleteSinger.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DeleteSinger.Name = "DeleteSinger";
            this.DeleteSinger.Size = new System.Drawing.Size(194, 29);
            this.DeleteSinger.TabIndex = 14;
            this.DeleteSinger.Text = "Delete Singer";
            this.DeleteSinger.UseVisualStyleBackColor = true;
            this.DeleteSinger.Click += new System.EventHandler(this.DeleteSinger_Click);
            // 
            // AddAlbum
            // 
            this.AddAlbum.Location = new System.Drawing.Point(633, 254);
            this.AddAlbum.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AddAlbum.Name = "AddAlbum";
            this.AddAlbum.Size = new System.Drawing.Size(194, 29);
            this.AddAlbum.TabIndex = 15;
            this.AddAlbum.Text = "Add Album";
            this.AddAlbum.UseVisualStyleBackColor = true;
            this.AddAlbum.Click += new System.EventHandler(this.AddAlbum_Click);
            // 
            // SearchSinger
            // 
            this.SearchSinger.AutoSize = true;
            this.SearchSinger.Location = new System.Drawing.Point(12, 339);
            this.SearchSinger.Name = "SearchSinger";
            this.SearchSinger.Size = new System.Drawing.Size(154, 18);
            this.SearchSinger.TabIndex = 16;
            this.SearchSinger.Text = "Search for a singer:";
            // 
            // SearchArtistTextBox
            // 
            this.SearchArtistTextBox.Location = new System.Drawing.Point(189, 336);
            this.SearchArtistTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SearchArtistTextBox.Name = "SearchArtistTextBox";
            this.SearchArtistTextBox.Size = new System.Drawing.Size(188, 25);
            this.SearchArtistTextBox.TabIndex = 18;
            // 
            // SingerKey
            // 
            this.SingerKey.AutoSize = true;
            this.SingerKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SingerKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SingerKey.Location = new System.Drawing.Point(69, 259);
            this.SingerKey.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.SingerKey.Name = "SingerKey";
            this.SingerKey.Size = new System.Drawing.Size(102, 20);
            this.SingerKey.TabIndex = 19;
            this.SingerKey.Text = "Singer Key: ";
            this.SingerKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SingerKeyTextBox
            // 
            this.SingerKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "SingerKey", true));
            this.SingerKeyTextBox.Location = new System.Drawing.Point(189, 256);
            this.SingerKeyTextBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.SingerKeyTextBox.Name = "SingerKeyTextBox";
            this.SingerKeyTextBox.Size = new System.Drawing.Size(188, 25);
            this.SingerKeyTextBox.TabIndex = 20;
            // 
            // singerTableAdapter1
            // 
            this.singerTableAdapter1.ClearBeforeFill = true;
            // 
            // ShowAlbums
            // 
            this.ShowAlbums.Location = new System.Drawing.Point(633, 334);
            this.ShowAlbums.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ShowAlbums.Name = "ShowAlbums";
            this.ShowAlbums.Size = new System.Drawing.Size(194, 29);
            this.ShowAlbums.TabIndex = 21;
            this.ShowAlbums.Text = "Show Albums";
            this.ShowAlbums.UseVisualStyleBackColor = true;
            this.ShowAlbums.Click += new System.EventHandler(this.ShowAlbums_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(189, 375);
            this.Search.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(87, 38);
            this.Search.TabIndex = 22;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 426);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ShowAlbums);
            this.Controls.Add(this.SingerKeyTextBox);
            this.Controls.Add(this.SingerKey);
            this.Controls.Add(this.SearchArtistTextBox);
            this.Controls.Add(this.SearchSinger);
            this.Controls.Add(this.AddAlbum);
            this.Controls.Add(this.DeleteSinger);
            this.Controls.Add(this.DeleteAlbum);
            this.Controls.Add(this.UpdateSinger);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.RecordLabelTextBox);
            this.Controls.Add(this.NoAlbumsTextBox);
            this.Controls.Add(this.NoAwardsTextBox);
            this.Controls.Add(this.NoAwards);
            this.Controls.Add(this.NoAlbums);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.SingerName);
            this.Controls.Add(this.AddSinger);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.singerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button AddSinger;
        private System.Windows.Forms.Label SingerName;
        private System.Windows.Forms.Label RecordLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NoAlbums;
        private System.Windows.Forms.Label NoAwards;
        private System.Windows.Forms.TextBox NoAwardsTextBox;
        private System.Windows.Forms.TextBox NoAlbumsTextBox;
        private System.Windows.Forms.TextBox RecordLabelTextBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button UpdateSinger;
        private System.Windows.Forms.Button DeleteAlbum;
        private System.Windows.Forms.Button DeleteSinger;
        private System.Windows.Forms.Button AddAlbum;
        private System.Windows.Forms.Label SearchSinger;
        private System.Windows.Forms.TextBox SearchArtistTextBox;
        private System.Windows.Forms.Label SingerKey;
        private System.Windows.Forms.TextBox SingerKeyTextBox;
        private MyDatabaseDataSetTableAdapters.SingerTableAdapter singerTableAdapter1;
        private System.Windows.Forms.BindingSource singerBindingSource;
        private MyDatabaseDataSet myDatabaseDataSet1;
        private MyDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator singerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton singerBindingNavigatorSaveItem;
        private System.Windows.Forms.Button ShowAlbums;
        private System.Windows.Forms.Button Search;
    }
}

