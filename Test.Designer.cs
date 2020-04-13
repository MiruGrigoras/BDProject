namespace BDProject
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            System.Windows.Forms.Label singerKeyLabel;
            System.Windows.Forms.Label singerNameLabel;
            System.Windows.Forms.Label noAlbumsLabel;
            System.Windows.Forms.Label noAwardsLabel;
            System.Windows.Forms.Label recordLabelLabel;
            this.myDatabaseDataSet1 = new BDProject.MyDatabaseDataSet();
            this.singerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singerTableAdapter = new BDProject.MyDatabaseDataSetTableAdapters.SingerTableAdapter();
            this.tableAdapterManager = new BDProject.MyDatabaseDataSetTableAdapters.TableAdapterManager();
            this.singerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.singerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.singerKeyTextBox = new System.Windows.Forms.TextBox();
            this.singerNameTextBox = new System.Windows.Forms.TextBox();
            this.noAlbumsTextBox = new System.Windows.Forms.TextBox();
            this.noAwardsTextBox = new System.Windows.Forms.TextBox();
            this.recordLabelTextBox = new System.Windows.Forms.TextBox();
            singerKeyLabel = new System.Windows.Forms.Label();
            singerNameLabel = new System.Windows.Forms.Label();
            noAlbumsLabel = new System.Windows.Forms.Label();
            noAwardsLabel = new System.Windows.Forms.Label();
            recordLabelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singerBindingNavigator)).BeginInit();
            this.singerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // myDatabaseDataSet1
            // 
            this.myDatabaseDataSet1.DataSetName = "MyDatabaseDataSet";
            this.myDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // singerBindingSource
            // 
            this.singerBindingSource.DataMember = "Singer";
            this.singerBindingSource.DataSource = this.myDatabaseDataSet1;
            // 
            // singerTableAdapter
            // 
            this.singerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlbumTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Singer1TableAdapter = null;
            this.tableAdapterManager.SingerTableAdapter = this.singerTableAdapter;
            this.tableAdapterManager.UpdateOrder = BDProject.MyDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // singerBindingNavigator
            // 
            this.singerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.singerBindingNavigator.BindingSource = this.singerBindingSource;
            this.singerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.singerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.singerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.singerBindingNavigatorSaveItem});
            this.singerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.singerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.singerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.singerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.singerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.singerBindingNavigator.Name = "singerBindingNavigator";
            this.singerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.singerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.singerBindingNavigator.TabIndex = 0;
            this.singerBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // singerBindingNavigatorSaveItem
            // 
            this.singerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.singerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("singerBindingNavigatorSaveItem.Image")));
            this.singerBindingNavigatorSaveItem.Name = "singerBindingNavigatorSaveItem";
            this.singerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.singerBindingNavigatorSaveItem.Text = "Save Data";
            this.singerBindingNavigatorSaveItem.Click += new System.EventHandler(this.SingerBindingNavigatorSaveItem_Click);
            // 
            // singerKeyLabel
            // 
            singerKeyLabel.AutoSize = true;
            singerKeyLabel.Location = new System.Drawing.Point(102, 90);
            singerKeyLabel.Name = "singerKeyLabel";
            singerKeyLabel.Size = new System.Drawing.Size(61, 13);
            singerKeyLabel.TabIndex = 1;
            singerKeyLabel.Text = "Singer Key:";
            // 
            // singerKeyTextBox
            // 
            this.singerKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "SingerKey", true));
            this.singerKeyTextBox.Location = new System.Drawing.Point(182, 87);
            this.singerKeyTextBox.Name = "singerKeyTextBox";
            this.singerKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.singerKeyTextBox.TabIndex = 2;
            // 
            // singerNameLabel
            // 
            singerNameLabel.AutoSize = true;
            singerNameLabel.Location = new System.Drawing.Point(102, 116);
            singerNameLabel.Name = "singerNameLabel";
            singerNameLabel.Size = new System.Drawing.Size(71, 13);
            singerNameLabel.TabIndex = 3;
            singerNameLabel.Text = "Singer Name:";
            // 
            // singerNameTextBox
            // 
            this.singerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "SingerName", true));
            this.singerNameTextBox.Location = new System.Drawing.Point(182, 113);
            this.singerNameTextBox.Name = "singerNameTextBox";
            this.singerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.singerNameTextBox.TabIndex = 4;
            // 
            // noAlbumsLabel
            // 
            noAlbumsLabel.AutoSize = true;
            noAlbumsLabel.Location = new System.Drawing.Point(102, 142);
            noAlbumsLabel.Name = "noAlbumsLabel";
            noAlbumsLabel.Size = new System.Drawing.Size(61, 13);
            noAlbumsLabel.TabIndex = 5;
            noAlbumsLabel.Text = "No Albums:";
            // 
            // noAlbumsTextBox
            // 
            this.noAlbumsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "NoAlbums", true));
            this.noAlbumsTextBox.Location = new System.Drawing.Point(182, 139);
            this.noAlbumsTextBox.Name = "noAlbumsTextBox";
            this.noAlbumsTextBox.Size = new System.Drawing.Size(100, 20);
            this.noAlbumsTextBox.TabIndex = 6;
            // 
            // noAwardsLabel
            // 
            noAwardsLabel.AutoSize = true;
            noAwardsLabel.Location = new System.Drawing.Point(102, 168);
            noAwardsLabel.Name = "noAwardsLabel";
            noAwardsLabel.Size = new System.Drawing.Size(62, 13);
            noAwardsLabel.TabIndex = 7;
            noAwardsLabel.Text = "No Awards:";
            // 
            // noAwardsTextBox
            // 
            this.noAwardsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "NoAwards", true));
            this.noAwardsTextBox.Location = new System.Drawing.Point(182, 165);
            this.noAwardsTextBox.Name = "noAwardsTextBox";
            this.noAwardsTextBox.Size = new System.Drawing.Size(100, 20);
            this.noAwardsTextBox.TabIndex = 8;
            // 
            // recordLabelLabel
            // 
            recordLabelLabel.AutoSize = true;
            recordLabelLabel.Location = new System.Drawing.Point(102, 194);
            recordLabelLabel.Name = "recordLabelLabel";
            recordLabelLabel.Size = new System.Drawing.Size(74, 13);
            recordLabelLabel.TabIndex = 9;
            recordLabelLabel.Text = "Record Label:";
            // 
            // recordLabelTextBox
            // 
            this.recordLabelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.singerBindingSource, "RecordLabel", true));
            this.recordLabelTextBox.Location = new System.Drawing.Point(182, 191);
            this.recordLabelTextBox.Name = "recordLabelTextBox";
            this.recordLabelTextBox.Size = new System.Drawing.Size(100, 20);
            this.recordLabelTextBox.TabIndex = 10;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(singerKeyLabel);
            this.Controls.Add(this.singerKeyTextBox);
            this.Controls.Add(singerNameLabel);
            this.Controls.Add(this.singerNameTextBox);
            this.Controls.Add(noAlbumsLabel);
            this.Controls.Add(this.noAlbumsTextBox);
            this.Controls.Add(noAwardsLabel);
            this.Controls.Add(this.noAwardsTextBox);
            this.Controls.Add(recordLabelLabel);
            this.Controls.Add(this.recordLabelTextBox);
            this.Controls.Add(this.singerBindingNavigator);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singerBindingNavigator)).EndInit();
            this.singerBindingNavigator.ResumeLayout(false);
            this.singerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyDatabaseDataSet myDatabaseDataSet1;
        private System.Windows.Forms.BindingSource singerBindingSource;
        private MyDatabaseDataSetTableAdapters.SingerTableAdapter singerTableAdapter;
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
        private System.Windows.Forms.TextBox singerKeyTextBox;
        private System.Windows.Forms.TextBox singerNameTextBox;
        private System.Windows.Forms.TextBox noAlbumsTextBox;
        private System.Windows.Forms.TextBox noAwardsTextBox;
        private System.Windows.Forms.TextBox recordLabelTextBox;
    }
}