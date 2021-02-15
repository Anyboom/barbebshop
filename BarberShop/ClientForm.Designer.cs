namespace BarberShop
{
    partial class ClientForm
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
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAvatarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchIdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchLastNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMiddleNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPhoneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchRefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.MainGrid);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(611, 390);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Клиенты";
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.ContextMenuStrip = this.MainMenu;
            this.MainGrid.Location = new System.Drawing.Point(13, 26);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(585, 351);
            this.MainGrid.TabIndex = 0;
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMenuItem,
            this.RemoveMenuItem,
            this.EditMenuItem,
            this.ShowAvatarMenuItem,
            this.SearchMenuItem});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(181, 136);
            // 
            // AddMenuItem
            // 
            this.AddMenuItem.Name = "AddMenuItem";
            this.AddMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AddMenuItem.Text = "Создать";
            this.AddMenuItem.Click += new System.EventHandler(this.AddMenuItem_Click);
            // 
            // RemoveMenuItem
            // 
            this.RemoveMenuItem.Name = "RemoveMenuItem";
            this.RemoveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RemoveMenuItem.Text = "Удалить";
            this.RemoveMenuItem.Click += new System.EventHandler(this.RemoveMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditMenuItem.Text = "Изменить";
            this.EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // ShowAvatarMenuItem
            // 
            this.ShowAvatarMenuItem.Name = "ShowAvatarMenuItem";
            this.ShowAvatarMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowAvatarMenuItem.Text = "Показать аватар";
            this.ShowAvatarMenuItem.Click += new System.EventHandler(this.ShowAvatarMenuItem_Click);
            // 
            // SearchMenuItem
            // 
            this.SearchMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchIdMenuItem,
            this.SearchNameMenuItem,
            this.SearchLastNameMenuItem,
            this.SearchMiddleNameMenuItem,
            this.SearchPhoneMenuItem,
            this.toolStripSeparator1,
            this.SearchRefreshMenuItem});
            this.SearchMenuItem.Name = "SearchMenuItem";
            this.SearchMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SearchMenuItem.Text = "Поиск по";
            // 
            // SearchIdMenuItem
            // 
            this.SearchIdMenuItem.Name = "SearchIdMenuItem";
            this.SearchIdMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SearchIdMenuItem.Text = "Ид";
            this.SearchIdMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchNameMenuItem
            // 
            this.SearchNameMenuItem.Name = "SearchNameMenuItem";
            this.SearchNameMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SearchNameMenuItem.Text = "Имя";
            this.SearchNameMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchLastNameMenuItem
            // 
            this.SearchLastNameMenuItem.Name = "SearchLastNameMenuItem";
            this.SearchLastNameMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SearchLastNameMenuItem.Text = "Фамилия";
            this.SearchLastNameMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchMiddleNameMenuItem
            // 
            this.SearchMiddleNameMenuItem.Name = "SearchMiddleNameMenuItem";
            this.SearchMiddleNameMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SearchMiddleNameMenuItem.Text = "Отчество";
            this.SearchMiddleNameMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchPhoneMenuItem
            // 
            this.SearchPhoneMenuItem.Name = "SearchPhoneMenuItem";
            this.SearchPhoneMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SearchPhoneMenuItem.Text = "Телефон";
            this.SearchPhoneMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // SearchRefreshMenuItem
            // 
            this.SearchRefreshMenuItem.Name = "SearchRefreshMenuItem";
            this.SearchRefreshMenuItem.Size = new System.Drawing.Size(128, 22);
            this.SearchRefreshMenuItem.Text = "Обнулить";
            this.SearchRefreshMenuItem.Click += new System.EventHandler(this.SearchRefreshMenuItem_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 414);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парикмахерская";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.MainGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem AddMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchIdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchLastNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchMiddleNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchPhoneMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SearchRefreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowAvatarMenuItem;
    }
}