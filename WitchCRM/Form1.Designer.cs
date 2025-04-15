namespace WitchCRM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtName = new TextBox();
            dateTimePicker = new DateTimePicker();
            btnSave = new Button();
            grNewClient = new GroupBox();
            grSource = new GroupBox();
            txtWhatsApp = new TextBox();
            txtTelegram = new TextBox();
            txtInstagram = new TextBox();
            rbInstagram = new RadioButton();
            rbTelegram = new RadioButton();
            rbWhatsApp = new RadioButton();
            grDate = new GroupBox();
            grName = new GroupBox();
            grNewClient.SuspendLayout();
            grSource.SuspendLayout();
            grDate.SuspendLayout();
            grName.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(7, 29);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 39);
            txtName.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(7, 29);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(265, 39);
            dateTimePicker.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(24, 216);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(269, 64);
            btnSave.TabIndex = 2;
            btnSave.Text = "Записать";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grNewClient
            // 
            grNewClient.Controls.Add(grSource);
            grNewClient.Controls.Add(grDate);
            grNewClient.Controls.Add(btnSave);
            grNewClient.Controls.Add(grName);
            grNewClient.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grNewClient.Location = new Point(14, 16);
            grNewClient.Margin = new Padding(3, 4, 3, 4);
            grNewClient.Name = "grNewClient";
            grNewClient.Padding = new Padding(3, 4, 3, 4);
            grNewClient.Size = new Size(1602, 296);
            grNewClient.TabIndex = 3;
            grNewClient.TabStop = false;
            grNewClient.Text = "Новый клиент";
            // 
            // grSource
            // 
            grSource.Controls.Add(txtWhatsApp);
            grSource.Controls.Add(txtTelegram);
            grSource.Controls.Add(txtInstagram);
            grSource.Controls.Add(rbInstagram);
            grSource.Controls.Add(rbTelegram);
            grSource.Controls.Add(rbWhatsApp);
            grSource.FlatStyle = FlatStyle.Flat;
            grSource.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grSource.Location = new Point(656, 56);
            grSource.Margin = new Padding(3, 4, 3, 4);
            grSource.Name = "grSource";
            grSource.Padding = new Padding(3, 4, 3, 4);
            grSource.Size = new Size(440, 224);
            grSource.TabIndex = 4;
            grSource.TabStop = false;
            grSource.Text = "Источник";
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.Location = new Point(112, 160);
            txtWhatsApp.Margin = new Padding(3, 4, 3, 4);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(312, 39);
            txtWhatsApp.TabIndex = 6;
            txtWhatsApp.Visible = false;
            // 
            // txtTelegram
            // 
            txtTelegram.Location = new Point(112, 104);
            txtTelegram.Margin = new Padding(3, 4, 3, 4);
            txtTelegram.Name = "txtTelegram";
            txtTelegram.Size = new Size(312, 39);
            txtTelegram.TabIndex = 5;
            txtTelegram.Visible = false;
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(112, 48);
            txtInstagram.Margin = new Padding(3, 4, 3, 4);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.Size = new Size(312, 39);
            txtInstagram.TabIndex = 3;
            txtInstagram.Visible = false;
            // 
            // rbInstagram
            // 
            rbInstagram.AutoSize = true;
            rbInstagram.Image = (Image)resources.GetObject("rbInstagram.Image");
            rbInstagram.ImageAlign = ContentAlignment.MiddleRight;
            rbInstagram.Location = new Point(17, 44);
            rbInstagram.Margin = new Padding(3, 4, 3, 4);
            rbInstagram.Name = "rbInstagram";
            rbInstagram.Size = new Size(84, 48);
            rbInstagram.TabIndex = 2;
            rbInstagram.TabStop = true;
            rbInstagram.Text = "       ";
            rbInstagram.UseVisualStyleBackColor = true;
            rbInstagram.CheckedChanged += rbInstagram_CheckedChanged;
            // 
            // rbTelegram
            // 
            rbTelegram.AutoSize = true;
            rbTelegram.Image = (Image)resources.GetObject("rbTelegram.Image");
            rbTelegram.ImageAlign = ContentAlignment.MiddleRight;
            rbTelegram.Location = new Point(16, 104);
            rbTelegram.Margin = new Padding(3, 4, 3, 4);
            rbTelegram.Name = "rbTelegram";
            rbTelegram.Size = new Size(84, 48);
            rbTelegram.TabIndex = 1;
            rbTelegram.TabStop = true;
            rbTelegram.Text = "       ";
            rbTelegram.UseVisualStyleBackColor = true;
            rbTelegram.CheckedChanged += rbTelegram_CheckedChanged;
            // 
            // rbWhatsApp
            // 
            rbWhatsApp.AutoSize = true;
            rbWhatsApp.Image = (Image)resources.GetObject("rbWhatsApp.Image");
            rbWhatsApp.ImageAlign = ContentAlignment.MiddleRight;
            rbWhatsApp.Location = new Point(17, 160);
            rbWhatsApp.Margin = new Padding(3, 4, 3, 4);
            rbWhatsApp.Name = "rbWhatsApp";
            rbWhatsApp.RightToLeft = RightToLeft.No;
            rbWhatsApp.Size = new Size(84, 48);
            rbWhatsApp.TabIndex = 0;
            rbWhatsApp.TabStop = true;
            rbWhatsApp.Text = "       ";
            rbWhatsApp.TextAlign = ContentAlignment.MiddleCenter;
            rbWhatsApp.UseVisualStyleBackColor = true;
            rbWhatsApp.CheckedChanged += rbWhatsApp_CheckedChanged;
            // 
            // grDate
            // 
            grDate.Controls.Add(dateTimePicker);
            grDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDate.Location = new Point(360, 57);
            grDate.Margin = new Padding(3, 4, 3, 4);
            grDate.Name = "grDate";
            grDate.Padding = new Padding(3, 4, 3, 4);
            grDate.Size = new Size(283, 100);
            grDate.TabIndex = 4;
            grDate.TabStop = false;
            grDate.Text = "Дата";
            // 
            // grName
            // 
            grName.Controls.Add(txtName);
            grName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grName.Location = new Point(19, 57);
            grName.Margin = new Padding(3, 4, 3, 4);
            grName.Name = "grName";
            grName.Padding = new Padding(3, 4, 3, 4);
            grName.Size = new Size(325, 100);
            grName.TabIndex = 0;
            grName.TabStop = false;
            grName.Text = "Имя";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 891);
            Controls.Add(grNewClient);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Бухгалтерия ведьмы";
            grNewClient.ResumeLayout(false);
            grSource.ResumeLayout(false);
            grSource.PerformLayout();
            grDate.ResumeLayout(false);
            grName.ResumeLayout(false);
            grName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtName;
        private DateTimePicker dateTimePicker;
        private Button btnSave;
        private GroupBox grNewClient;
        private GroupBox grName;
        private GroupBox grDate;
        private GroupBox grSource;
        private RadioButton rbWhatsApp;
        private RadioButton rbInstagram;
        private RadioButton rbTelegram;
        private TextBox txtWhatsApp;
        private TextBox txtTelegram;
        private TextBox txtInstagram;
    }
}
