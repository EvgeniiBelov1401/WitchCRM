namespace WitchCRM
{
    partial class FormPlanner
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanner));
            grPlanner = new GroupBox();
            plannerTable = new DataGridView();
            lblPlannerClientCount = new Label();
            plannerDate = new DateTimePicker();
            grNewClient = new GroupBox();
            grStatus = new GroupBox();
            cbRepeatClient = new CheckBox();
            grDesсription = new GroupBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            grPrise = new GroupBox();
            lbPrise = new Label();
            txtPrise = new TextBox();
            grSource = new GroupBox();
            txtWhatsApp = new MaskedTextBox();
            txtTelegram = new MaskedTextBox();
            txtInstagram = new MaskedTextBox();
            rbInstagram = new RadioButton();
            rbTelegram = new RadioButton();
            rbWhatsApp = new RadioButton();
            grDate = new GroupBox();
            dateTimePicker = new DateTimePicker();
            grName = new GroupBox();
            txtName = new TextBox();
            grPlanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plannerTable).BeginInit();
            grNewClient.SuspendLayout();
            grStatus.SuspendLayout();
            grDesсription.SuspendLayout();
            grPrise.SuspendLayout();
            grSource.SuspendLayout();
            grDate.SuspendLayout();
            grName.SuspendLayout();
            SuspendLayout();
            // 
            // grPlanner
            // 
            grPlanner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grPlanner.Controls.Add(plannerTable);
            grPlanner.Controls.Add(lblPlannerClientCount);
            grPlanner.Controls.Add(plannerDate);
            grPlanner.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grPlanner.Location = new Point(8, 280);
            grPlanner.Name = "grPlanner";
            grPlanner.Size = new Size(1608, 464);
            grPlanner.TabIndex = 16;
            grPlanner.TabStop = false;
            grPlanner.Text = "Планировщик";
            // 
            // plannerTable
            // 
            plannerTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plannerTable.BackgroundColor = SystemColors.Window;
            plannerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            plannerTable.Location = new Point(16, 88);
            plannerTable.Name = "plannerTable";
            plannerTable.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            plannerTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            plannerTable.Size = new Size(1576, 360);
            plannerTable.TabIndex = 8;
            // 
            // lblPlannerClientCount
            // 
            lblPlannerClientCount.AutoSize = true;
            lblPlannerClientCount.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPlannerClientCount.Location = new Point(275, 45);
            lblPlannerClientCount.Name = "lblPlannerClientCount";
            lblPlannerClientCount.Size = new Size(0, 26);
            lblPlannerClientCount.TabIndex = 7;
            // 
            // plannerDate
            // 
            plannerDate.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            plannerDate.Location = new Point(24, 32);
            plannerDate.Name = "plannerDate";
            plannerDate.Size = new Size(249, 35);
            plannerDate.TabIndex = 4;
            // 
            // grNewClient
            // 
            grNewClient.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grNewClient.Controls.Add(grStatus);
            grNewClient.Controls.Add(grDesсription);
            grNewClient.Controls.Add(btnSave);
            grNewClient.Controls.Add(grPrise);
            grNewClient.Controls.Add(grSource);
            grNewClient.Controls.Add(grDate);
            grNewClient.Controls.Add(grName);
            grNewClient.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grNewClient.Location = new Point(8, 8);
            grNewClient.Name = "grNewClient";
            grNewClient.Size = new Size(1608, 264);
            grNewClient.TabIndex = 15;
            grNewClient.TabStop = false;
            grNewClient.Text = "Новый клиент";
            // 
            // grStatus
            // 
            grStatus.Controls.Add(cbRepeatClient);
            grStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grStatus.Location = new Point(19, 143);
            grStatus.Name = "grStatus";
            grStatus.Size = new Size(613, 95);
            grStatus.TabIndex = 4;
            grStatus.TabStop = false;
            grStatus.Text = "Статус";
            // 
            // cbRepeatClient
            // 
            cbRepeatClient.AutoSize = true;
            cbRepeatClient.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbRepeatClient.Location = new Point(119, 37);
            cbRepeatClient.Name = "cbRepeatClient";
            cbRepeatClient.Size = new Size(436, 35);
            cbRepeatClient.TabIndex = 0;
            cbRepeatClient.Text = "Повторный/Постоянный клиент";
            cbRepeatClient.UseVisualStyleBackColor = true;
            cbRepeatClient.CheckedChanged += cbRepeatClient_CheckedChanged_1;
            // 
            // grDesсription
            // 
            grDesсription.Controls.Add(txtDescription);
            grDesсription.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDesсription.Location = new Point(1232, 48);
            grDesсription.Name = "grDesсription";
            grDesсription.Size = new Size(368, 160);
            grDesсription.TabIndex = 4;
            grDesсription.TabStop = false;
            grDesсription.Text = "Особые отметки";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(16, 32);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(336, 112);
            txtDescription.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(1016, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(208, 54);
            btnSave.TabIndex = 2;
            btnSave.Text = "Записать";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // grPrise
            // 
            grPrise.Controls.Add(lbPrise);
            grPrise.Controls.Add(txtPrise);
            grPrise.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grPrise.Location = new Point(1016, 48);
            grPrise.Name = "grPrise";
            grPrise.Size = new Size(208, 82);
            grPrise.TabIndex = 4;
            grPrise.TabStop = false;
            grPrise.Text = "К оплате";
            // 
            // lbPrise
            // 
            lbPrise.AutoSize = true;
            lbPrise.Location = new Point(162, 41);
            lbPrise.Name = "lbPrise";
            lbPrise.Size = new Size(24, 25);
            lbPrise.TabIndex = 1;
            lbPrise.Text = "₽";
            // 
            // txtPrise
            // 
            txtPrise.Location = new Point(32, 34);
            txtPrise.Name = "txtPrise";
            txtPrise.Size = new Size(121, 34);
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
            grSource.Location = new Point(648, 48);
            grSource.Name = "grSource";
            grSource.Size = new Size(352, 190);
            grSource.TabIndex = 4;
            grSource.TabStop = false;
            grSource.Text = "Источник";
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.Location = new Point(93, 140);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(249, 34);
            txtWhatsApp.TabIndex = 4;
            txtWhatsApp.Visible = false;
            // 
            // txtTelegram
            // 
            txtTelegram.Location = new Point(93, 88);
            txtTelegram.Name = "txtTelegram";
            txtTelegram.Size = new Size(249, 34);
            txtTelegram.TabIndex = 4;
            txtTelegram.Visible = false;
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(93, 37);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.Size = new Size(249, 34);
            txtInstagram.TabIndex = 4;
            txtInstagram.Visible = false;
            // 
            // rbInstagram
            // 
            rbInstagram.AutoSize = true;
            rbInstagram.Image = (Image)resources.GetObject("rbInstagram.Image");
            rbInstagram.ImageAlign = ContentAlignment.MiddleRight;
            rbInstagram.Location = new Point(16, 27);
            rbInstagram.Name = "rbInstagram";
            rbInstagram.Size = new Size(81, 48);
            rbInstagram.TabIndex = 2;
            rbInstagram.TabStop = true;
            rbInstagram.Text = "        ";
            rbInstagram.UseVisualStyleBackColor = true;
            rbInstagram.CheckedChanged += rbInstagram_CheckedChanged_1;
            // 
            // rbTelegram
            // 
            rbTelegram.AutoSize = true;
            rbTelegram.Image = (Image)resources.GetObject("rbTelegram.Image");
            rbTelegram.ImageAlign = ContentAlignment.MiddleRight;
            rbTelegram.Location = new Point(16, 78);
            rbTelegram.Name = "rbTelegram";
            rbTelegram.Size = new Size(81, 48);
            rbTelegram.TabIndex = 1;
            rbTelegram.TabStop = true;
            rbTelegram.Text = "        ";
            rbTelegram.UseVisualStyleBackColor = true;
            rbTelegram.CheckedChanged += rbTelegram_CheckedChanged_1;
            // 
            // rbWhatsApp
            // 
            rbWhatsApp.AutoSize = true;
            rbWhatsApp.Image = (Image)resources.GetObject("rbWhatsApp.Image");
            rbWhatsApp.ImageAlign = ContentAlignment.MiddleRight;
            rbWhatsApp.Location = new Point(16, 133);
            rbWhatsApp.Name = "rbWhatsApp";
            rbWhatsApp.RightToLeft = RightToLeft.No;
            rbWhatsApp.Size = new Size(81, 48);
            rbWhatsApp.TabIndex = 0;
            rbWhatsApp.TabStop = true;
            rbWhatsApp.Text = "        ";
            rbWhatsApp.TextAlign = ContentAlignment.MiddleCenter;
            rbWhatsApp.UseVisualStyleBackColor = true;
            rbWhatsApp.CheckedChanged += rbWhatsApp_CheckedChanged_1;
            // 
            // grDate
            // 
            grDate.Controls.Add(dateTimePicker);
            grDate.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDate.Location = new Point(360, 48);
            grDate.Name = "grDate";
            grDate.Size = new Size(272, 85);
            grDate.TabIndex = 4;
            grDate.TabStop = false;
            grDate.Text = "Дата";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(7, 40);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(249, 34);
            dateTimePicker.TabIndex = 1;
            // 
            // grName
            // 
            grName.Controls.Add(txtName);
            grName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grName.Location = new Point(19, 48);
            grName.Name = "grName";
            grName.Size = new Size(325, 85);
            grName.TabIndex = 0;
            grName.TabStop = false;
            grName.Text = "Имя";
            // 
            // txtName
            // 
            txtName.Location = new Point(7, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 34);
            txtName.TabIndex = 0;
            // 
            // FormPlanner
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1642, 803);
            Controls.Add(grPlanner);
            Controls.Add(grNewClient);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPlanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бухгалтерия ведьмы";
            grPlanner.ResumeLayout(false);
            grPlanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)plannerTable).EndInit();
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

        private GroupBox grPlanner;
        private DataGridView plannerTable;
        private Label lblPlannerClientCount;
        private DateTimePicker plannerDate;
        private GroupBox grNewClient;
        private GroupBox grStatus;
        private CheckBox cbRepeatClient;
        private GroupBox grDesсription;
        private TextBox txtDescription;
        private Button btnSave;
        private GroupBox grPrise;
        private Label lbPrise;
        private TextBox txtPrise;
        private GroupBox grSource;
        private MaskedTextBox txtWhatsApp;
        private MaskedTextBox txtTelegram;
        private MaskedTextBox txtInstagram;
        private RadioButton rbInstagram;
        private RadioButton rbTelegram;
        private RadioButton rbWhatsApp;
        private GroupBox grDate;
        private DateTimePicker dateTimePicker;
        private GroupBox grName;
        private TextBox txtName;
    }
}
