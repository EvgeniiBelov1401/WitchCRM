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
            txtName.Location = new Point(6, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 33);
            txtName.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(6, 22);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 33);
            dateTimePicker.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(971, 208);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(235, 48);
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
            grNewClient.Location = new Point(12, 12);
            grNewClient.Name = "grNewClient";
            grNewClient.Size = new Size(1212, 262);
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
            grSource.Location = new Point(462, 43);
            grSource.Name = "grSource";
            grSource.Size = new Size(311, 205);
            grSource.TabIndex = 4;
            grSource.TabStop = false;
            grSource.Text = "Источник";
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.Location = new Point(101, 150);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(193, 33);
            txtWhatsApp.TabIndex = 6;
            txtWhatsApp.Visible = false;
            // 
            // txtTelegram
            // 
            txtTelegram.Location = new Point(101, 96);
            txtTelegram.Name = "txtTelegram";
            txtTelegram.Size = new Size(193, 33);
            txtTelegram.TabIndex = 5;
            txtTelegram.Visible = false;
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(101, 42);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.Size = new Size(193, 33);
            txtInstagram.TabIndex = 3;
            txtInstagram.Visible = false;
            // 
            // rbInstagram
            // 
            rbInstagram.AutoSize = true;
            rbInstagram.Image = (Image)resources.GetObject("rbInstagram.Image");
            rbInstagram.ImageAlign = ContentAlignment.MiddleRight;
            rbInstagram.Location = new Point(15, 33);
            rbInstagram.Name = "rbInstagram";
            rbInstagram.Size = new Size(80, 48);
            rbInstagram.TabIndex = 2;
            rbInstagram.TabStop = true;
            rbInstagram.Text = "          ";
            rbInstagram.UseVisualStyleBackColor = true;
            // 
            // rbTelegram
            // 
            rbTelegram.AutoSize = true;
            rbTelegram.Image = (Image)resources.GetObject("rbTelegram.Image");
            rbTelegram.ImageAlign = ContentAlignment.MiddleRight;
            rbTelegram.Location = new Point(15, 87);
            rbTelegram.Name = "rbTelegram";
            rbTelegram.Size = new Size(80, 48);
            rbTelegram.TabIndex = 1;
            rbTelegram.TabStop = true;
            rbTelegram.Text = "          ";
            rbTelegram.UseVisualStyleBackColor = true;
            // 
            // rbWhatsApp
            // 
            rbWhatsApp.AutoSize = true;
            rbWhatsApp.Image = (Image)resources.GetObject("rbWhatsApp.Image");
            rbWhatsApp.ImageAlign = ContentAlignment.MiddleRight;
            rbWhatsApp.Location = new Point(15, 141);
            rbWhatsApp.Name = "rbWhatsApp";
            rbWhatsApp.RightToLeft = RightToLeft.No;
            rbWhatsApp.Size = new Size(80, 48);
            rbWhatsApp.TabIndex = 0;
            rbWhatsApp.TabStop = true;
            rbWhatsApp.Text = "          ";
            rbWhatsApp.TextAlign = ContentAlignment.MiddleCenter;
            rbWhatsApp.UseVisualStyleBackColor = true;
            // 
            // grDate
            // 
            grDate.Controls.Add(dateTimePicker);
            grDate.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDate.Location = new Point(242, 43);
            grDate.Name = "grDate";
            grDate.Size = new Size(214, 75);
            grDate.TabIndex = 4;
            grDate.TabStop = false;
            grDate.Text = "Дата";
            // 
            // grName
            // 
            grName.Controls.Add(txtName);
            grName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grName.Location = new Point(17, 43);
            grName.Name = "grName";
            grName.Size = new Size(219, 75);
            grName.TabIndex = 0;
            grName.TabStop = false;
            grName.Text = "Имя";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 617);
            Controls.Add(grNewClient);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
