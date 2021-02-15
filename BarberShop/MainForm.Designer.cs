namespace BarberShop
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.BuildButton = new System.Windows.Forms.Button();
            this.AfterDatePicker = new System.Windows.Forms.DateTimePicker();
            this.LabelDatePicker = new System.Windows.Forms.Label();
            this.BeforeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReceptionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WriteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChooseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowJobsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchIdMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchENameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchELastNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchPositionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchCNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchCLastNameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SearchRefreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeInformationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeeInformationShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientInformationMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientInformationShowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.MainMenuStrip.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.BuildButton);
            this.MainGroup.Controls.Add(this.AfterDatePicker);
            this.MainGroup.Controls.Add(this.LabelDatePicker);
            this.MainGroup.Controls.Add(this.BeforeDatePicker);
            this.MainGroup.Controls.Add(this.MainGrid);
            this.MainGroup.Location = new System.Drawing.Point(12, 27);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(814, 426);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Записи";
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(293, 18);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(75, 23);
            this.BuildButton.TabIndex = 5;
            this.BuildButton.Text = "Построить";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // AfterDatePicker
            // 
            this.AfterDatePicker.Location = new System.Drawing.Point(164, 20);
            this.AfterDatePicker.Name = "AfterDatePicker";
            this.AfterDatePicker.Size = new System.Drawing.Size(123, 20);
            this.AfterDatePicker.TabIndex = 4;
            // 
            // LabelDatePicker
            // 
            this.LabelDatePicker.AutoSize = true;
            this.LabelDatePicker.Location = new System.Drawing.Point(142, 23);
            this.LabelDatePicker.Name = "LabelDatePicker";
            this.LabelDatePicker.Size = new System.Drawing.Size(16, 13);
            this.LabelDatePicker.TabIndex = 3;
            this.LabelDatePicker.Text = "— ";
            // 
            // BeforeDatePicker
            // 
            this.BeforeDatePicker.Location = new System.Drawing.Point(13, 20);
            this.BeforeDatePicker.Name = "BeforeDatePicker";
            this.BeforeDatePicker.Size = new System.Drawing.Size(123, 20);
            this.BeforeDatePicker.TabIndex = 1;
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.ContextMenuStrip = this.MainMenuStrip;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGrid.Location = new System.Drawing.Point(13, 49);
            this.MainGrid.MultiSelect = false;
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.ShowEditingIcon = false;
            this.MainGrid.Size = new System.Drawing.Size(788, 364);
            this.MainGrid.TabIndex = 0;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReceptionMenuItem,
            this.ChooseMenuItem,
            this.SearchMenuItem,
            this.EmployeeInformationMenuItem,
            this.ClientInformationMenuItem});
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(181, 136);
            // 
            // ReceptionMenuItem
            // 
            this.ReceptionMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WriteMenuItem,
            this.CancelMenuItem});
            this.ReceptionMenuItem.Name = "ReceptionMenuItem";
            this.ReceptionMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ReceptionMenuItem.Text = "Прием";
            // 
            // WriteMenuItem
            // 
            this.WriteMenuItem.Name = "WriteMenuItem";
            this.WriteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.WriteMenuItem.Text = "Записать";
            this.WriteMenuItem.Click += new System.EventHandler(this.WriteMenuItem_Click);
            // 
            // CancelMenuItem
            // 
            this.CancelMenuItem.Name = "CancelMenuItem";
            this.CancelMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CancelMenuItem.Text = "Отменить";
            this.CancelMenuItem.Click += new System.EventHandler(this.CancelMenuItem_Click);
            // 
            // ChooseMenuItem
            // 
            this.ChooseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowJobsMenuItem,
            this.PayMenuItem});
            this.ChooseMenuItem.Name = "ChooseMenuItem";
            this.ChooseMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ChooseMenuItem.Text = "Чек";
            // 
            // ShowJobsMenuItem
            // 
            this.ShowJobsMenuItem.Name = "ShowJobsMenuItem";
            this.ShowJobsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowJobsMenuItem.Text = "Показать";
            this.ShowJobsMenuItem.Click += new System.EventHandler(this.ShowJobsMenuItem_Click);
            // 
            // PayMenuItem
            // 
            this.PayMenuItem.Name = "PayMenuItem";
            this.PayMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PayMenuItem.Text = "Оплатить";
            this.PayMenuItem.Click += new System.EventHandler(this.PayMenuItem_Click);
            // 
            // SearchMenuItem
            // 
            this.SearchMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchIdMenuItem,
            this.SearchENameMenuItem,
            this.SearchELastNameMenuItem,
            this.SearchPositionMenuItem,
            this.SearchCNameMenuItem,
            this.SearchCLastNameMenuItem,
            this.SearchSeparator,
            this.SearchRefreshMenuItem});
            this.SearchMenuItem.Name = "SearchMenuItem";
            this.SearchMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SearchMenuItem.Text = "Поиск";
            // 
            // SearchIdMenuItem
            // 
            this.SearchIdMenuItem.Name = "SearchIdMenuItem";
            this.SearchIdMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SearchIdMenuItem.Text = "Ид";
            this.SearchIdMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchENameMenuItem
            // 
            this.SearchENameMenuItem.Name = "SearchENameMenuItem";
            this.SearchENameMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SearchENameMenuItem.Text = "Имя сотрудника";
            this.SearchENameMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchELastNameMenuItem
            // 
            this.SearchELastNameMenuItem.Name = "SearchELastNameMenuItem";
            this.SearchELastNameMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SearchELastNameMenuItem.Text = "Фамилия сотрудника";
            this.SearchELastNameMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchPositionMenuItem
            // 
            this.SearchPositionMenuItem.Name = "SearchPositionMenuItem";
            this.SearchPositionMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SearchPositionMenuItem.Text = "Должность сотрудника";
            this.SearchPositionMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchCNameMenuItem
            // 
            this.SearchCNameMenuItem.Name = "SearchCNameMenuItem";
            this.SearchCNameMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SearchCNameMenuItem.Text = "Имя клиента";
            this.SearchCNameMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchCLastNameMenuItem
            // 
            this.SearchCLastNameMenuItem.Name = "SearchCLastNameMenuItem";
            this.SearchCLastNameMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SearchCLastNameMenuItem.Text = "Фамилия клиента";
            this.SearchCLastNameMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // SearchSeparator
            // 
            this.SearchSeparator.Name = "SearchSeparator";
            this.SearchSeparator.Size = new System.Drawing.Size(199, 6);
            // 
            // SearchRefreshMenuItem
            // 
            this.SearchRefreshMenuItem.Name = "SearchRefreshMenuItem";
            this.SearchRefreshMenuItem.Size = new System.Drawing.Size(202, 22);
            this.SearchRefreshMenuItem.Text = "Обнулить";
            this.SearchRefreshMenuItem.Click += new System.EventHandler(this.SearchRefreshMenuItem_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(838, 24);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // ListMenuItem
            // 
            this.ListMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeMenuItem,
            this.ClientMenuItem});
            this.ListMenuItem.Name = "ListMenuItem";
            this.ListMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ListMenuItem.Text = "Списки";
            // 
            // EmployeeMenuItem
            // 
            this.EmployeeMenuItem.Name = "EmployeeMenuItem";
            this.EmployeeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EmployeeMenuItem.Text = "Сотрудники";
            this.EmployeeMenuItem.Click += new System.EventHandler(this.EmployeeMenuItem_Click);
            // 
            // ClientMenuItem
            // 
            this.ClientMenuItem.Name = "ClientMenuItem";
            this.ClientMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClientMenuItem.Text = "Клиенты";
            this.ClientMenuItem.Click += new System.EventHandler(this.ClientMenuItem_Click);
            // 
            // EmployeeInformationMenuItem
            // 
            this.EmployeeInformationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmployeeInformationShowMenuItem});
            this.EmployeeInformationMenuItem.Name = "EmployeeInformationMenuItem";
            this.EmployeeInformationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EmployeeInformationMenuItem.Text = "Сотрудник";
            // 
            // EmployeeInformationShowMenuItem
            // 
            this.EmployeeInformationShowMenuItem.Name = "EmployeeInformationShowMenuItem";
            this.EmployeeInformationShowMenuItem.Size = new System.Drawing.Size(203, 22);
            this.EmployeeInformationShowMenuItem.Text = "Показать информацию";
            // 
            // ClientInformationMenuItem
            // 
            this.ClientInformationMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClientInformationShowMenuItem});
            this.ClientInformationMenuItem.Name = "ClientInformationMenuItem";
            this.ClientInformationMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ClientInformationMenuItem.Text = "Клиент";
            // 
            // ClientInformationShowMenuItem
            // 
            this.ClientInformationShowMenuItem.Name = "ClientInformationShowMenuItem";
            this.ClientInformationShowMenuItem.Size = new System.Drawing.Size(203, 22);
            this.ClientInformationShowMenuItem.Text = "Показать информацию";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 466);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парикмахерская";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.ContextMenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ReceptionMenuItem;
        private System.Windows.Forms.DateTimePicker BeforeDatePicker;
        private System.Windows.Forms.Label LabelDatePicker;
        private System.Windows.Forms.ToolStripMenuItem ChooseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowJobsMenuItem;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientMenuItem;
        private System.Windows.Forms.DateTimePicker AfterDatePicker;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.ToolStripMenuItem PayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchIdMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchENameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchELastNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchPositionMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchCNameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SearchCLastNameMenuItem;
        private System.Windows.Forms.ToolStripSeparator SearchSeparator;
        private System.Windows.Forms.ToolStripMenuItem SearchRefreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WriteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeInformationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmployeeInformationShowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientInformationMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClientInformationShowMenuItem;
    }
}

