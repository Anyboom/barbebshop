namespace BarberShop
{
    partial class ClientAddEditForm
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
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.DeleteImageButton = new System.Windows.Forms.Button();
            this.AvatarPicture = new System.Windows.Forms.PictureBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.MainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.DeleteImageButton);
            this.MainGroup.Controls.Add(this.AvatarPicture);
            this.MainGroup.Controls.Add(this.ActionButton);
            this.MainGroup.Controls.Add(this.PhoneTextBox);
            this.MainGroup.Controls.Add(this.PhoneLabel);
            this.MainGroup.Controls.Add(this.MiddleNameTextBox);
            this.MainGroup.Controls.Add(this.MiddleNameLabel);
            this.MainGroup.Controls.Add(this.LastNameTextBox);
            this.MainGroup.Controls.Add(this.LastNameLabel);
            this.MainGroup.Controls.Add(this.FirstNameTextBox);
            this.MainGroup.Controls.Add(this.FirstNameLabel);
            this.MainGroup.Location = new System.Drawing.Point(12, 12);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Padding = new System.Windows.Forms.Padding(10);
            this.MainGroup.Size = new System.Drawing.Size(360, 363);
            this.MainGroup.TabIndex = 0;
            this.MainGroup.TabStop = false;
            this.MainGroup.Text = "Добавление нового клиента";
            // 
            // DeleteImageButton
            // 
            this.DeleteImageButton.Location = new System.Drawing.Point(95, 27);
            this.DeleteImageButton.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteImageButton.Name = "DeleteImageButton";
            this.DeleteImageButton.Size = new System.Drawing.Size(20, 20);
            this.DeleteImageButton.TabIndex = 10;
            this.DeleteImageButton.Text = "X";
            this.DeleteImageButton.UseVisualStyleBackColor = true;
            this.DeleteImageButton.Click += new System.EventHandler(this.DeleteImageButton_Click);
            // 
            // AvatarPicture
            // 
            this.AvatarPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AvatarPicture.Location = new System.Drawing.Point(16, 26);
            this.AvatarPicture.Name = "AvatarPicture";
            this.AvatarPicture.Size = new System.Drawing.Size(100, 100);
            this.AvatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AvatarPicture.TabIndex = 9;
            this.AvatarPicture.TabStop = false;
            this.AvatarPicture.Click += new System.EventHandler(this.AvatarPicture_Click);
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(272, 329);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(75, 23);
            this.ActionButton.TabIndex = 8;
            this.ActionButton.Text = "Добавить";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(16, 296);
            this.PhoneTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(331, 20);
            this.PhoneTextBox.TabIndex = 7;
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.Location = new System.Drawing.Point(13, 280);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(55, 13);
            this.PhoneLabel.TabIndex = 6;
            this.PhoneLabel.Text = "Телефон:";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(16, 250);
            this.MiddleNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(331, 20);
            this.MiddleNameTextBox.TabIndex = 5;
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(13, 234);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(57, 13);
            this.MiddleNameLabel.TabIndex = 4;
            this.MiddleNameLabel.Text = "Отчество:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(16, 204);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(331, 20);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(13, 188);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(59, 13);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Фамилия:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(16, 158);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(331, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(13, 142);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(32, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Имя:";
            // 
            // ClientAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(382, 387);
            this.Controls.Add(this.MainGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientAddEditForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парикмахерская";
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.PictureBox AvatarPicture;
        private System.Windows.Forms.Button DeleteImageButton;
    }
}