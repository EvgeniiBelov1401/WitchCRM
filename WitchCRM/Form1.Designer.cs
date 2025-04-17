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
            cbRepeatClient = new CheckBox();
            grDesсription = new GroupBox();
            txtDescription = new TextBox();
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
            grName = new GroupBox();
            plannerDate = new DateTimePicker();
            grPlanner = new GroupBox();
            plannerTable = new DataGridView();
            lblPlannerClientCount = new Label();
            grNewClient.SuspendLayout();
            grStatus.SuspendLayout();
            grDesсription.SuspendLayout();
            grPrise.SuspendLayout();
            grSource.SuspendLayout();
            grDate.SuspendLayout();
            grName.SuspendLayout();
            grPlanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plannerTable).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(267, 29);
            txtName.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(6, 35);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(218, 29);
            dateTimePicker.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(889, 168);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 48);
            btnSave.TabIndex = 2;
            btnSave.Text = "Записать";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            grNewClient.Location = new Point(12, 12);
            grNewClient.Name = "grNewClient";
            grNewClient.Size = new Size(1402, 222);
            grNewClient.TabIndex = 3;
            grNewClient.TabStop = false;
            grNewClient.Text = "Новый клиент";
            // 
            // grStatus
            // 
            grStatus.Controls.Add(cbRepeatClient);
            grStatus.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grStatus.Location = new Point(17, 126);
            grStatus.Margin = new Padding(3, 2, 3, 2);
            grStatus.Name = "grStatus";
            grStatus.Padding = new Padding(3, 2, 3, 2);
            grStatus.Size = new Size(536, 84);
            grStatus.TabIndex = 4;
            grStatus.TabStop = false;
            grStatus.Text = "Статус";
            // 
            // cbRepeatClient
            // 
            cbRepeatClient.AutoSize = true;
            cbRepeatClient.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cbRepeatClient.Location = new Point(104, 33);
            cbRepeatClient.Name = "cbRepeatClient";
            cbRepeatClient.Size = new Size(334, 28);
            cbRepeatClient.TabIndex = 0;
            cbRepeatClient.Text = "Повторный/Постоянный клиент";
            cbRepeatClient.UseVisualStyleBackColor = true;
            cbRepeatClient.CheckedChanged += cbRepeatClient_CheckedChanged;
            // 
            // grDesсription
            // 
            grDesсription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grDesсription.Controls.Add(txtDescription);
            grDesсription.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDesсription.Location = new Point(1085, 42);
            grDesсription.Margin = new Padding(3, 2, 3, 2);
            grDesсription.Name = "grDesсription";
            grDesсription.Padding = new Padding(3, 2, 3, 2);
            grDesсription.Size = new Size(306, 117);
            grDesсription.TabIndex = 4;
            grDesсription.TabStop = false;
            grDesсription.Text = "Особые отметки";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(14, 30);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(280, 73);
            txtDescription.TabIndex = 0;
            // 
            // grPrise
            // 
            grPrise.Controls.Add(lbPrise);
            grPrise.Controls.Add(txtPrise);
            grPrise.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grPrise.Location = new Point(889, 42);
            grPrise.Margin = new Padding(3, 2, 3, 2);
            grPrise.Name = "grPrise";
            grPrise.Padding = new Padding(3, 2, 3, 2);
            grPrise.Size = new Size(182, 72);
            grPrise.TabIndex = 4;
            grPrise.TabStop = false;
            grPrise.Text = "К оплате";
            // 
            // lbPrise
            // 
            lbPrise.AutoSize = true;
            lbPrise.Location = new Point(142, 36);
            lbPrise.Name = "lbPrise";
            lbPrise.Size = new Size(20, 22);
            lbPrise.TabIndex = 1;
            lbPrise.Text = "₽";
            // 
            // txtPrise
            // 
            txtPrise.Location = new Point(35, 30);
            txtPrise.Margin = new Padding(3, 2, 3, 2);
            txtPrise.Name = "txtPrise";
            txtPrise.Size = new Size(106, 29);
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
            grSource.Location = new Point(567, 42);
            grSource.Name = "grSource";
            grSource.Size = new Size(308, 168);
            grSource.TabIndex = 4;
            grSource.TabStop = false;
            grSource.Text = "Источник";
            // 
            // txtWhatsApp
            // 
            txtWhatsApp.Location = new Point(81, 124);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(218, 29);
            txtWhatsApp.TabIndex = 4;
            txtWhatsApp.Visible = false;
            // 
            // txtTelegram
            // 
            txtTelegram.Location = new Point(81, 78);
            txtTelegram.Name = "txtTelegram";
            txtTelegram.Size = new Size(218, 29);
            txtTelegram.TabIndex = 4;
            txtTelegram.Visible = false;
            // 
            // txtInstagram
            // 
            txtInstagram.Location = new Point(81, 33);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.Size = new Size(218, 29);
            txtInstagram.TabIndex = 4;
            txtInstagram.Visible = false;
            // 
            // rbInstagram
            // 
            rbInstagram.AutoSize = true;
            rbInstagram.Image = (Image)resources.GetObject("rbInstagram.Image");
            rbInstagram.ImageAlign = ContentAlignment.MiddleRight;
            rbInstagram.Location = new Point(14, 24);
            rbInstagram.Name = "rbInstagram";
            rbInstagram.Size = new Size(68, 48);
            rbInstagram.TabIndex = 2;
            rbInstagram.TabStop = true;
            rbInstagram.Text = "        ";
            rbInstagram.UseVisualStyleBackColor = true;
            rbInstagram.CheckedChanged += rbInstagram_CheckedChanged;
            // 
            // rbTelegram
            // 
            rbTelegram.AutoSize = true;
            rbTelegram.Image = (Image)resources.GetObject("rbTelegram.Image");
            rbTelegram.ImageAlign = ContentAlignment.MiddleRight;
            rbTelegram.Location = new Point(14, 69);
            rbTelegram.Name = "rbTelegram";
            rbTelegram.Size = new Size(68, 48);
            rbTelegram.TabIndex = 1;
            rbTelegram.TabStop = true;
            rbTelegram.Text = "        ";
            rbTelegram.UseVisualStyleBackColor = true;
            rbTelegram.CheckedChanged += rbTelegram_CheckedChanged;
            // 
            // rbWhatsApp
            // 
            rbWhatsApp.AutoSize = true;
            rbWhatsApp.Image = (Image)resources.GetObject("rbWhatsApp.Image");
            rbWhatsApp.ImageAlign = ContentAlignment.MiddleRight;
            rbWhatsApp.Location = new Point(14, 117);
            rbWhatsApp.Name = "rbWhatsApp";
            rbWhatsApp.RightToLeft = RightToLeft.No;
            rbWhatsApp.Size = new Size(68, 48);
            rbWhatsApp.TabIndex = 0;
            rbWhatsApp.TabStop = true;
            rbWhatsApp.Text = "        ";
            rbWhatsApp.TextAlign = ContentAlignment.MiddleCenter;
            rbWhatsApp.UseVisualStyleBackColor = true;
            rbWhatsApp.CheckedChanged += rbWhatsApp_CheckedChanged;
            // 
            // grDate
            // 
            grDate.Controls.Add(dateTimePicker);
            grDate.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDate.Location = new Point(315, 43);
            grDate.Name = "grDate";
            grDate.Size = new Size(238, 75);
            grDate.TabIndex = 4;
            grDate.TabStop = false;
            grDate.Text = "Дата";
            // 
            // grName
            // 
            grName.Controls.Add(txtName);
            grName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grName.Location = new Point(17, 43);
            grName.Name = "grName";
            grName.Size = new Size(284, 75);
            grName.TabIndex = 0;
            grName.TabStop = false;
            grName.Text = "Имя";
            // 
            // plannerDate
            // 
            plannerDate.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            plannerDate.Location = new Point(17, 33);
            plannerDate.Name = "plannerDate";
            plannerDate.Size = new Size(218, 29);
            plannerDate.TabIndex = 4;
            // 
            // grPlanner
            // 
            grPlanner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grPlanner.Controls.Add(plannerTable);
            grPlanner.Controls.Add(lblPlannerClientCount);
            grPlanner.Controls.Add(plannerDate);
            grPlanner.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grPlanner.Location = new Point(12, 240);
            grPlanner.Name = "grPlanner";
            grPlanner.Size = new Size(1402, 405);
            grPlanner.TabIndex = 7;
            grPlanner.TabStop = false;
            grPlanner.Text = "Планировщик";
            // 
            // plannerTable
            // 
            plannerTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plannerTable.BackgroundColor = SystemColors.Window;
            plannerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            plannerTable.Location = new Point(17, 68);
            plannerTable.Name = "plannerTable";
            plannerTable.Size = new Size(1374, 321);
            plannerTable.TabIndex = 8;
            // 
            // lblPlannerClientCount
            // 
            lblPlannerClientCount.AutoSize = true;
            lblPlannerClientCount.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPlannerClientCount.Location = new Point(241, 40);
            lblPlannerClientCount.Name = "lblPlannerClientCount";
            lblPlannerClientCount.Size = new Size(0, 22);
            lblPlannerClientCount.TabIndex = 7;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 668);
            Controls.Add(grPlanner);
            Controls.Add(grNewClient);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            grPlanner.ResumeLayout(false);
            grPlanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)plannerTable).EndInit();
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
        private GroupBox grPrise;
        private TextBox txtPrise;
        private Label lbPrise;
        private GroupBox grDesсription;
        private TextBox txtDescription;
        private GroupBox grStatus;
        private MaskedTextBox txtInstagram;
        private MaskedTextBox txtWhatsApp;
        private MaskedTextBox txtTelegram;
        private DateTimePicker plannerDate;
        private GroupBox grPlanner;
        private CheckBox cbRepeatClient;
        private Label lblPlannerClientCount;
        private DataGridView plannerTable;

    }
}
