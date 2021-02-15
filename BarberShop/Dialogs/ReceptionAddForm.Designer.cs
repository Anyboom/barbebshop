namespace BarberShop
{
    partial class ReceptionAddForm
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
            System.Windows.Forms.Label ClientLabel;
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.JobLabel = new System.Windows.Forms.Label();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.MainDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.EmployeeComboBox = new System.Windows.Forms.ComboBox();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.ClientComboBox = new System.Windows.Forms.ComboBox();
            ClientLabel = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientLabel
            // 
            ClientLabel.AutoSize = true;
            ClientLabel.Location = new System.Drawing.Point(13, 23);
            ClientLabel.Name = "ClientLabel";
            ClientLabel.Size = new System.Drawing.Size(46, 13);
            ClientLabel.TabIndex = 0;
            ClientLabel.Text = "Клиент:";
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Controls.Add(this.MainTimePicker);
            this.MainGroup.Controls.Add(this.SaveButton);
            this.MainGroup.Controls.Add(this.JobLabel);
            this.MainGroup.Controls.Add(this.MainGrid);
            this.MainGroup.Controls.Add(this.MainDatePicker);
            this.MainGroup.Controls.Add(this.DateLabel);
            this.MainGroup.Controls.Add(this.EmployeeComboBox);
            this.MainGroup.Controls.Add(this.EmployeeLabel);
            this.MainGroup.Controls.Add(this.ClientComboBox);
            this.MainGroup.Controls.Add(ClientLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(360, 369);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Записать на прием";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Время:";
            // 
            // MainTimePicker
            // 
            this.MainTimePicker.CustomFormat = "HH:mm";
            this.MainTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MainTimePicker.Location = new System.Drawing.Point(269, 133);
            this.MainTimePicker.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.MainTimePicker.Name = "MainTimePicker";
            this.MainTimePicker.ShowUpDown = true;
            this.MainTimePicker.Size = new System.Drawing.Size(78, 20);
            this.MainTimePicker.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(272, 335);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Добавить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(13, 163);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(43, 13);
            this.JobLabel.TabIndex = 7;
            this.JobLabel.Text = "Услуги";
            // 
            // MainGrid
            // 
            this.MainGrid.AllowUserToAddRows = false;
            this.MainGrid.AllowUserToDeleteRows = false;
            this.MainGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.MainGrid.Location = new System.Drawing.Point(16, 179);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.ReadOnly = true;
            this.MainGrid.RowHeadersVisible = false;
            this.MainGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MainGrid.Size = new System.Drawing.Size(331, 150);
            this.MainGrid.TabIndex = 6;
            // 
            // MainDatePicker
            // 
            this.MainDatePicker.Location = new System.Drawing.Point(16, 133);
            this.MainDatePicker.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.MainDatePicker.Name = "MainDatePicker";
            this.MainDatePicker.Size = new System.Drawing.Size(247, 20);
            this.MainDatePicker.TabIndex = 5;
            this.MainDatePicker.Value = new System.DateTime(2021, 2, 5, 0, 0, 0, 0);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(13, 117);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 13);
            this.DateLabel.TabIndex = 4;
            this.DateLabel.Text = "Дата:";
            // 
            // EmployeeComboBox
            // 
            this.EmployeeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeeComboBox.FormattingEnabled = true;
            this.EmployeeComboBox.Location = new System.Drawing.Point(16, 86);
            this.EmployeeComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.EmployeeComboBox.Name = "EmployeeComboBox";
            this.EmployeeComboBox.Size = new System.Drawing.Size(331, 21);
            this.EmployeeComboBox.TabIndex = 3;
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(13, 70);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(63, 13);
            this.EmployeeLabel.TabIndex = 2;
            this.EmployeeLabel.Text = "Сотрудник:";
            // 
            // ClientComboBox
            // 
            this.ClientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientComboBox.FormattingEnabled = true;
            this.ClientComboBox.Location = new System.Drawing.Point(16, 39);
            this.ClientComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ClientComboBox.Name = "ClientComboBox";
            this.ClientComboBox.Size = new System.Drawing.Size(331, 21);
            this.ClientComboBox.TabIndex = 1;
            // 
            // ReceptionAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 391);
            this.Controls.Add(this.MainGroup);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceptionAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парикмахерская";
            this.Load += new System.EventHandler(this.ReceptionAddForm_Load);
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.DateTimePicker MainDatePicker;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ComboBox EmployeeComboBox;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.ComboBox ClientComboBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker MainTimePicker;
    }
}