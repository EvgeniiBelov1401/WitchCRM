namespace WitchCRM
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            txtName = new TextBox();
            dateTimePicker = new DateTimePicker();
            btnSave = new Button();
            grNewClient = new GroupBox();
            grStatus = new GroupBox();
            rbRepeatClient = new RadioButton();
            rbNewClient = new RadioButton();
            grDesсription = new GroupBox();
            txtDescription = new TextBox();
            grPrise = new GroupBox();
            lbPrise = new Label();
            txtPrise = new TextBox();
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
            grStatus.SuspendLayout();
            grDesсription.SuspendLayout();
            grPrise.SuspendLayout();
            grSource.SuspendLayout();
            grDate.SuspendLayout();
            grName.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(7, 40);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 34);
            txtName.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(7, 40);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(249, 34);
            dateTimePicker.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Location = new Point(1016, 216);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(565, 64);
            btnSave.TabIndex = 2;
            btnSave.Text = "Записать";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // grNewClient
            // 
            grNewClient.Controls.Add(grStatus);
            grNewClient.Controls.Add(grDesсription);
            grNewClient.Controls.Add(btnSave);
            grNewClient.Controls.Add(grPrise);
            grNewClient.Controls.Add(grSource);
            grNewClient.Controls.Add(grDate);
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
            // grStatus
            // 
            grStatus.Controls.Add(rbRepeatClient);
            grStatus.Controls.Add(rbNewClient);
            grStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grStatus.Location = new Point(19, 168);
            grStatus.Name = "grStatus";
            grStatus.Size = new Size(613, 104);
            grStatus.TabIndex = 4;
            grStatus.TabStop = false;
            grStatus.Text = "Статус";
            // 
            // rbRepeatClient
            // 
            rbRepeatClient.AutoSize = true;
            rbRepeatClient.Location = new Point(368, 48);
            rbRepeatClient.Name = "rbRepeatClient";
            rbRepeatClient.Size = new Size(153, 29);
            rbRepeatClient.TabIndex = 1;
            rbRepeatClient.TabStop = true;
            rbRepeatClient.Text = "Повторный";
            rbRepeatClient.UseVisualStyleBackColor = true;
            rbRepeatClient.CheckedChanged += rbRepeatClient_CheckedChanged;
            // 
            // rbNewClient
            // 
            rbNewClient.AutoSize = true;
            rbNewClient.Location = new Point(72, 48);
            rbNewClient.Name = "rbNewClient";
            rbNewClient.Size = new Size(105, 29);
            rbNewClient.TabIndex = 0;
            rbNewClient.TabStop = true;
            rbNewClient.Text = "Новый";
            rbNewClient.UseVisualStyleBackColor = true;
            rbNewClient.CheckedChanged += rbNewClient_CheckedChanged;
            // 
            // grDesсription
            // 
            grDesсription.Controls.Add(txtDescription);
            grDesсription.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDesсription.Location = new Point(1240, 56);
            grDesсription.Name = "grDesсription";
            grDesсription.Size = new Size(350, 144);
            grDesсription.TabIndex = 4;
            grDesсription.TabStop = false;
            grDesсription.Text = "Особые отметки";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(16, 40);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(320, 96);
            txtDescription.TabIndex = 0;
            // 
            // grPrise
            // 
            grPrise.Controls.Add(lbPrise);
            grPrise.Controls.Add(txtPrise);
            grPrise.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grPrise.Location = new Point(1016, 56);
            grPrise.Name = "grPrise";
            grPrise.Size = new Size(208, 96);
            grPrise.TabIndex = 4;
            grPrise.TabStop = false;
            grPrise.Text = "К оплате";
            // 
            // lbPrise
            // 
            lbPrise.AutoSize = true;
            lbPrise.Location = new Point(136, 48);
            lbPrise.Name = "lbPrise";
            lbPrise.Size = new Size(24, 25);
            lbPrise.TabIndex = 1;
            lbPrise.Text = "₽";
            // 
            // txtPrise
            // 
            txtPrise.Location = new Point(16, 40);
            txtPrise.Name = "txtPrise";
            txtPrise.Size = new Size(120, 34);
            txtPrise.TabIndex = 0;
            txtPrise.TextAlign = HorizontalAlignment.Right;
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
            grSource.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grSource.Location = new Point(648, 56);
            grSource.Margin = new Padding(3, 4, 3, 4);
            grSource.Name = "grSource";
            grSource.Padding = new Padding(3, 4, 3, 4);
            grSource.Size = new Size(352, 224);
            grSource.TabIndex = 4;
            grSource.TabStop = false;
            grSource.Text = "Источник";
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.Location = new Point(88, 164);
            txtWhatsApp.Margin = new Padding(3, 4, 3, 4);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(248, 34);
            txtWhatsApp.TabIndex = 6;
            txtWhatsApp.Visible = false;
            // 
            // txtTelegram
            // 
            txtTelegram.Location = new Point(88, 100);
            txtTelegram.Margin = new Padding(3, 4, 3, 4);
            txtTelegram.Name = "txtTelegram";
            txtTelegram.Size = new Size(248, 34);
            txtTelegram.TabIndex = 5;
            txtTelegram.Visible = false;
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(88, 36);
            txtInstagram.Margin = new Padding(3, 4, 3, 4);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.Size = new Size(248, 34);
            txtInstagram.TabIndex = 3;
            txtInstagram.Visible = false;
            // 
            // rbInstagram
            // 
            rbInstagram.AutoSize = true;
            rbInstagram.Image = (Image)resources.GetObject("rbInstagram.Image");
            rbInstagram.ImageAlign = ContentAlignment.MiddleRight;
            rbInstagram.Location = new Point(16, 32);
            rbInstagram.Margin = new Padding(3, 4, 3, 4);
            rbInstagram.Name = "rbInstagram";
            rbInstagram.Size = new Size(69, 48);
            rbInstagram.TabIndex = 2;
            rbInstagram.TabStop = true;
            rbInstagram.Text = "      ";
            rbInstagram.UseVisualStyleBackColor = true;
            rbInstagram.CheckedChanged += rbInstagram_CheckedChanged;
            // 
            // rbTelegram
            // 
            rbTelegram.AutoSize = true;
            rbTelegram.Image = (Image)resources.GetObject("rbTelegram.Image");
            rbTelegram.ImageAlign = ContentAlignment.MiddleRight;
            rbTelegram.Location = new Point(16, 92);
            rbTelegram.Margin = new Padding(3, 4, 3, 4);
            rbTelegram.Name = "rbTelegram";
            rbTelegram.Size = new Size(69, 48);
            rbTelegram.TabIndex = 1;
            rbTelegram.TabStop = true;
            rbTelegram.Text = "      ";
            rbTelegram.UseVisualStyleBackColor = true;
            rbTelegram.CheckedChanged += rbTelegram_CheckedChanged;
            // 
            // rbWhatsApp
            // 
            rbWhatsApp.AutoSize = true;
            rbWhatsApp.Image = (Image)resources.GetObject("rbWhatsApp.Image");
            rbWhatsApp.ImageAlign = ContentAlignment.MiddleRight;
            rbWhatsApp.Location = new Point(16, 156);
            rbWhatsApp.Margin = new Padding(3, 4, 3, 4);
            rbWhatsApp.Name = "rbWhatsApp";
            rbWhatsApp.RightToLeft = RightToLeft.No;
            rbWhatsApp.Size = new Size(69, 48);
            rbWhatsApp.TabIndex = 0;
            rbWhatsApp.TabStop = true;
            rbWhatsApp.Text = "      ";
            rbWhatsApp.TextAlign = ContentAlignment.MiddleCenter;
            rbWhatsApp.UseVisualStyleBackColor = true;
            rbWhatsApp.CheckedChanged += rbWhatsApp_CheckedChanged;
            // 
            // grDate
            // 
            grDate.Controls.Add(dateTimePicker);
            grDate.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDate.Location = new Point(360, 57);
            grDate.Margin = new Padding(3, 4, 3, 4);
            grDate.Name = "grDate";
            grDate.Padding = new Padding(3, 4, 3, 4);
            grDate.Size = new Size(272, 100);
            grDate.TabIndex = 4;
            grDate.TabStop = false;
            grDate.Text = "Дата";
            // 
            // grName
            // 
            grName.Controls.Add(txtName);
            grName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grName.Location = new Point(19, 57);
            grName.Margin = new Padding(3, 4, 3, 4);
            grName.Name = "grName";
            grName.Padding = new Padding(3, 4, 3, 4);
            grName.Size = new Size(325, 100);
            grName.TabIndex = 0;
            grName.TabStop = false;
            grName.Text = "Имя";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1641, 891);
            Controls.Add(grNewClient);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бухгалтерия ведьмы";
            grNewClient.ResumeLayout(false);
            grStatus.ResumeLayout(false);
            grStatus.PerformLayout();
            grDesсription.ResumeLayout(false);
            grDesсription.PerformLayout();
            grPrise.ResumeLayout(false);
            grPrise.PerformLayout();
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
        private GroupBox grPrise;
        private TextBox txtPrise;
        private Label lbPrise;
        private GroupBox grDesсription;
        private TextBox txtDescription;
        private GroupBox grStatus;
        private RadioButton rbRepeatClient;
        private RadioButton rbNewClient;
    }
}
