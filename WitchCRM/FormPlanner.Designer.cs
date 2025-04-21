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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanner));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            tabControl1 = new TabControl();
            tabPagePlan = new TabPage();
            grPlanner = new GroupBox();
            plannerTable = new DataGridView();
            lblPlannerClientCount = new Label();
            plannerDate = new DateTimePicker();
            tabPageStatistic = new TabPage();
            grStatAllTime = new GroupBox();
            grStatAllTimeCommonValues = new GroupBox();
            txtStatAllTimeClientSumPrise = new TextBox();
            txtStatAllTimeClientWorkDays = new TextBox();
            txtStatAllTimeClientCount = new TextBox();
            grStatAllTimeStatus = new GroupBox();
            txtStatAllTimeStatusRepeat = new TextBox();
            txtStatAllTimeStatusNew = new TextBox();
            grStatAllTimeSource = new GroupBox();
            txtStatAllTimeSourceWhatsApp = new TextBox();
            txtStatAllTimeSourceTelegram = new TextBox();
            txtStatAllTimeSourceInstagram = new TextBox();
            grStatAllTimeAvgValues = new GroupBox();
            txtStatAllTimeClientAvrCountDayly = new TextBox();
            txtStatAllTimeClientAvrCheque = new TextBox();
            txtStatAllTimeClientAvrDaylyCheque = new TextBox();
            grNewClient.SuspendLayout();
            grStatus.SuspendLayout();
            grDesсription.SuspendLayout();
            grPrise.SuspendLayout();
            grSource.SuspendLayout();
            grDate.SuspendLayout();
            grName.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagePlan.SuspendLayout();
            grPlanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)plannerTable).BeginInit();
            tabPageStatistic.SuspendLayout();
            grStatAllTime.SuspendLayout();
            grStatAllTimeCommonValues.SuspendLayout();
            grStatAllTimeStatus.SuspendLayout();
            grStatAllTimeSource.SuspendLayout();
            grStatAllTimeAvgValues.SuspendLayout();
            SuspendLayout();
            // 
            // grNewClient
            // 
            grNewClient.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grNewClient.Controls.Add(grStatus);
            grNewClient.Controls.Add(grDesсription);
            grNewClient.Controls.Add(btnSave);
            grNewClient.Controls.Add(grPrise);
            grNewClient.Controls.Add(grSource);
            grNewClient.Controls.Add(grDate);
            grNewClient.Controls.Add(grName);
            grNewClient.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grNewClient.Location = new Point(3, 6);
            grNewClient.Name = "grNewClient";
            grNewClient.Size = new Size(1661, 261);
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
            cbRepeatClient.Size = new Size(334, 28);
            cbRepeatClient.TabIndex = 0;
            cbRepeatClient.Text = "Повторный/Постоянный клиент";
            cbRepeatClient.UseVisualStyleBackColor = true;
            cbRepeatClient.CheckedChanged += cbRepeatClient_CheckedChanged_1;
            // 
            // grDesсription
            // 
            grDesсription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grDesсription.Controls.Add(txtDescription);
            grDesсription.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDesсription.Location = new Point(1346, 48);
            grDesсription.Name = "grDesсription";
            grDesсription.Size = new Size(309, 190);
            grDesсription.TabIndex = 4;
            grDesсription.TabStop = false;
            grDesсription.Text = "Особые отметки";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.ForeColor = Color.FromArgb(192, 0, 0);
            txtDescription.Location = new Point(19, 32);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(274, 137);
            txtDescription.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(1016, 169);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(310, 69);
            btnSave.TabIndex = 2;
            btnSave.Text = "Записать";
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
            grPrise.Size = new Size(310, 101);
            grPrise.TabIndex = 4;
            grPrise.TabStop = false;
            grPrise.Text = "К оплате";
            // 
            // lbPrise
            // 
            lbPrise.AutoSize = true;
            lbPrise.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbPrise.Location = new Point(264, 42);
            lbPrise.Name = "lbPrise";
            lbPrise.Size = new Size(28, 31);
            lbPrise.TabIndex = 1;
            lbPrise.Text = "₽";
            // 
            // txtPrise
            // 
            txtPrise.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPrise.ForeColor = Color.DarkGreen;
            txtPrise.Location = new Point(19, 27);
            txtPrise.Name = "txtPrise";
            txtPrise.Size = new Size(239, 63);
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
            txtWhatsApp.ForeColor = Color.FromArgb(0, 192, 0);
            txtWhatsApp.Location = new Point(93, 140);
            txtWhatsApp.Name = "txtWhatsApp";
            txtWhatsApp.Size = new Size(249, 29);
            txtWhatsApp.TabIndex = 4;
            txtWhatsApp.Visible = false;
            // 
            // txtTelegram
            // 
            txtTelegram.ForeColor = Color.Blue;
            txtTelegram.Location = new Point(93, 88);
            txtTelegram.Name = "txtTelegram";
            txtTelegram.Size = new Size(249, 29);
            txtTelegram.TabIndex = 4;
            txtTelegram.Visible = false;
            // 
            // txtInstagram
            // 
            txtInstagram.ForeColor = Color.FromArgb(192, 0, 192);
            txtInstagram.Location = new Point(93, 37);
            txtInstagram.Name = "txtInstagram";
            txtInstagram.Size = new Size(249, 29);
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
            rbInstagram.Size = new Size(68, 48);
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
            rbTelegram.Size = new Size(68, 48);
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
            rbWhatsApp.Size = new Size(68, 48);
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
            dateTimePicker.Location = new Point(6, 35);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(249, 29);
            dateTimePicker.TabIndex = 1;
            // 
            // grName
            // 
            grName.Controls.Add(txtName);
            grName.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grName.Location = new Point(20, 48);
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
            txtName.Size = new Size(305, 29);
            txtName.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPagePlan);
            tabControl1.Controls.Add(tabPageStatistic);
            tabControl1.Location = new Point(8, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1675, 805);
            tabControl1.TabIndex = 17;
            // 
            // tabPagePlan
            // 
            tabPagePlan.BackColor = Color.WhiteSmoke;
            tabPagePlan.Controls.Add(grPlanner);
            tabPagePlan.Controls.Add(grNewClient);
            tabPagePlan.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPagePlan.Location = new Point(4, 24);
            tabPagePlan.Name = "tabPagePlan";
            tabPagePlan.Padding = new Padding(3);
            tabPagePlan.Size = new Size(1667, 777);
            tabPagePlan.TabIndex = 0;
            tabPagePlan.Text = "Планирование";
            // 
            // grPlanner
            // 
            grPlanner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grPlanner.Controls.Add(plannerTable);
            grPlanner.Controls.Add(lblPlannerClientCount);
            grPlanner.Controls.Add(plannerDate);
            grPlanner.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grPlanner.Location = new Point(3, 273);
            grPlanner.Name = "grPlanner";
            grPlanner.Size = new Size(1661, 490);
            grPlanner.TabIndex = 17;
            grPlanner.TabStop = false;
            grPlanner.Text = "Планировщик";
            // 
            // plannerTable
            // 
            plannerTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plannerTable.BackgroundColor = SystemColors.Window;
            plannerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            plannerTable.Location = new Point(19, 70);
            plannerTable.Name = "plannerTable";
            plannerTable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            plannerTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            plannerTable.Size = new Size(1636, 414);
            plannerTable.TabIndex = 8;
            // 
            // lblPlannerClientCount
            // 
            lblPlannerClientCount.AutoSize = true;
            lblPlannerClientCount.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPlannerClientCount.Location = new Point(275, 45);
            lblPlannerClientCount.Name = "lblPlannerClientCount";
            lblPlannerClientCount.Size = new Size(0, 22);
            lblPlannerClientCount.TabIndex = 7;
            // 
            // plannerDate
            // 
            plannerDate.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            plannerDate.Location = new Point(20, 35);
            plannerDate.Name = "plannerDate";
            plannerDate.Size = new Size(249, 29);
            plannerDate.TabIndex = 4;
            // 
            // tabPageStatistic
            // 
            tabPageStatistic.BackColor = Color.WhiteSmoke;
            tabPageStatistic.Controls.Add(grStatAllTime);
            tabPageStatistic.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPageStatistic.Location = new Point(4, 24);
            tabPageStatistic.Name = "tabPageStatistic";
            tabPageStatistic.Padding = new Padding(3);
            tabPageStatistic.Size = new Size(1667, 777);
            tabPageStatistic.TabIndex = 1;
            tabPageStatistic.Text = "Статистика";
            // 
            // grStatAllTime
            // 
            grStatAllTime.Controls.Add(grStatAllTimeCommonValues);
            grStatAllTime.Controls.Add(grStatAllTimeStatus);
            grStatAllTime.Controls.Add(grStatAllTimeSource);
            grStatAllTime.Controls.Add(grStatAllTimeAvgValues);
            grStatAllTime.Location = new Point(1207, 56);
            grStatAllTime.Name = "grStatAllTime";
            grStatAllTime.Size = new Size(454, 556);
            grStatAllTime.TabIndex = 0;
            grStatAllTime.TabStop = false;
            grStatAllTime.Text = "За все время";
            // 
            // grStatAllTimeCommonValues
            // 
            grStatAllTimeCommonValues.Controls.Add(txtStatAllTimeClientSumPrise);
            grStatAllTimeCommonValues.Controls.Add(txtStatAllTimeClientWorkDays);
            grStatAllTimeCommonValues.Controls.Add(txtStatAllTimeClientCount);
            grStatAllTimeCommonValues.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grStatAllTimeCommonValues.Location = new Point(21, 44);
            grStatAllTimeCommonValues.Name = "grStatAllTimeCommonValues";
            grStatAllTimeCommonValues.Size = new Size(427, 129);
            grStatAllTimeCommonValues.TabIndex = 1;
            grStatAllTimeCommonValues.TabStop = false;
            grStatAllTimeCommonValues.Text = "Основные показатели";
            // 
            // txtStatAllTimeClientSumPrise
            // 
            txtStatAllTimeClientSumPrise.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientSumPrise.Enabled = false;
            txtStatAllTimeClientSumPrise.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientSumPrise.Location = new Point(6, 31);
            txtStatAllTimeClientSumPrise.Name = "txtStatAllTimeClientSumPrise";
            txtStatAllTimeClientSumPrise.Size = new Size(414, 26);
            txtStatAllTimeClientSumPrise.TabIndex = 2;
            txtStatAllTimeClientSumPrise.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeClientWorkDays
            // 
            txtStatAllTimeClientWorkDays.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientWorkDays.Enabled = false;
            txtStatAllTimeClientWorkDays.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientWorkDays.Location = new Point(6, 95);
            txtStatAllTimeClientWorkDays.Name = "txtStatAllTimeClientWorkDays";
            txtStatAllTimeClientWorkDays.Size = new Size(414, 26);
            txtStatAllTimeClientWorkDays.TabIndex = 4;
            txtStatAllTimeClientWorkDays.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeClientCount
            // 
            txtStatAllTimeClientCount.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientCount.Enabled = false;
            txtStatAllTimeClientCount.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientCount.Location = new Point(6, 63);
            txtStatAllTimeClientCount.Name = "txtStatAllTimeClientCount";
            txtStatAllTimeClientCount.Size = new Size(414, 26);
            txtStatAllTimeClientCount.TabIndex = 1;
            txtStatAllTimeClientCount.TextAlign = HorizontalAlignment.Center;
            // 
            // grStatAllTimeStatus
            // 
            grStatAllTimeStatus.Controls.Add(txtStatAllTimeStatusRepeat);
            grStatAllTimeStatus.Controls.Add(txtStatAllTimeStatusNew);
            grStatAllTimeStatus.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grStatAllTimeStatus.Location = new Point(21, 451);
            grStatAllTimeStatus.Name = "grStatAllTimeStatus";
            grStatAllTimeStatus.Size = new Size(427, 97);
            grStatAllTimeStatus.TabIndex = 6;
            grStatAllTimeStatus.TabStop = false;
            grStatAllTimeStatus.Text = "Кол-во обращений по статусам";
            // 
            // txtStatAllTimeStatusRepeat
            // 
            txtStatAllTimeStatusRepeat.BackColor = SystemColors.ControlLight;
            txtStatAllTimeStatusRepeat.Enabled = false;
            txtStatAllTimeStatusRepeat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeStatusRepeat.Location = new Point(6, 63);
            txtStatAllTimeStatusRepeat.Name = "txtStatAllTimeStatusRepeat";
            txtStatAllTimeStatusRepeat.Size = new Size(414, 26);
            txtStatAllTimeStatusRepeat.TabIndex = 5;
            txtStatAllTimeStatusRepeat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeStatusNew
            // 
            txtStatAllTimeStatusNew.BackColor = SystemColors.ControlLight;
            txtStatAllTimeStatusNew.Enabled = false;
            txtStatAllTimeStatusNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeStatusNew.Location = new Point(6, 31);
            txtStatAllTimeStatusNew.Name = "txtStatAllTimeStatusNew";
            txtStatAllTimeStatusNew.Size = new Size(414, 26);
            txtStatAllTimeStatusNew.TabIndex = 4;
            txtStatAllTimeStatusNew.TextAlign = HorizontalAlignment.Center;
            // 
            // grStatAllTimeSource
            // 
            grStatAllTimeSource.Controls.Add(txtStatAllTimeSourceWhatsApp);
            grStatAllTimeSource.Controls.Add(txtStatAllTimeSourceTelegram);
            grStatAllTimeSource.Controls.Add(txtStatAllTimeSourceInstagram);
            grStatAllTimeSource.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grStatAllTimeSource.Location = new Point(21, 314);
            grStatAllTimeSource.Name = "grStatAllTimeSource";
            grStatAllTimeSource.Size = new Size(427, 131);
            grStatAllTimeSource.TabIndex = 5;
            grStatAllTimeSource.TabStop = false;
            grStatAllTimeSource.Text = "Кол-во обращений по источникам";
            // 
            // txtStatAllTimeSourceWhatsApp
            // 
            txtStatAllTimeSourceWhatsApp.BackColor = SystemColors.ControlLight;
            txtStatAllTimeSourceWhatsApp.Enabled = false;
            txtStatAllTimeSourceWhatsApp.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeSourceWhatsApp.Location = new Point(6, 95);
            txtStatAllTimeSourceWhatsApp.Name = "txtStatAllTimeSourceWhatsApp";
            txtStatAllTimeSourceWhatsApp.Size = new Size(414, 26);
            txtStatAllTimeSourceWhatsApp.TabIndex = 6;
            txtStatAllTimeSourceWhatsApp.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeSourceTelegram
            // 
            txtStatAllTimeSourceTelegram.BackColor = SystemColors.ControlLight;
            txtStatAllTimeSourceTelegram.Enabled = false;
            txtStatAllTimeSourceTelegram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeSourceTelegram.Location = new Point(6, 63);
            txtStatAllTimeSourceTelegram.Name = "txtStatAllTimeSourceTelegram";
            txtStatAllTimeSourceTelegram.Size = new Size(414, 26);
            txtStatAllTimeSourceTelegram.TabIndex = 5;
            txtStatAllTimeSourceTelegram.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeSourceInstagram
            // 
            txtStatAllTimeSourceInstagram.BackColor = SystemColors.ControlLight;
            txtStatAllTimeSourceInstagram.Enabled = false;
            txtStatAllTimeSourceInstagram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeSourceInstagram.Location = new Point(6, 31);
            txtStatAllTimeSourceInstagram.Name = "txtStatAllTimeSourceInstagram";
            txtStatAllTimeSourceInstagram.Size = new Size(414, 26);
            txtStatAllTimeSourceInstagram.TabIndex = 4;
            txtStatAllTimeSourceInstagram.TextAlign = HorizontalAlignment.Center;
            // 
            // grStatAllTimeAvgValues
            // 
            grStatAllTimeAvgValues.Controls.Add(txtStatAllTimeClientAvrCountDayly);
            grStatAllTimeAvgValues.Controls.Add(txtStatAllTimeClientAvrCheque);
            grStatAllTimeAvgValues.Controls.Add(txtStatAllTimeClientAvrDaylyCheque);
            grStatAllTimeAvgValues.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grStatAllTimeAvgValues.Location = new Point(21, 179);
            grStatAllTimeAvgValues.Name = "grStatAllTimeAvgValues";
            grStatAllTimeAvgValues.Size = new Size(427, 129);
            grStatAllTimeAvgValues.TabIndex = 1;
            grStatAllTimeAvgValues.TabStop = false;
            grStatAllTimeAvgValues.Text = "Средние значения";
            // 
            // txtStatAllTimeClientAvrCountDayly
            // 
            txtStatAllTimeClientAvrCountDayly.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientAvrCountDayly.Enabled = false;
            txtStatAllTimeClientAvrCountDayly.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientAvrCountDayly.Location = new Point(6, 95);
            txtStatAllTimeClientAvrCountDayly.Name = "txtStatAllTimeClientAvrCountDayly";
            txtStatAllTimeClientAvrCountDayly.Size = new Size(414, 26);
            txtStatAllTimeClientAvrCountDayly.TabIndex = 6;
            txtStatAllTimeClientAvrCountDayly.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeClientAvrCheque
            // 
            txtStatAllTimeClientAvrCheque.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientAvrCheque.Enabled = false;
            txtStatAllTimeClientAvrCheque.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientAvrCheque.Location = new Point(6, 31);
            txtStatAllTimeClientAvrCheque.Name = "txtStatAllTimeClientAvrCheque";
            txtStatAllTimeClientAvrCheque.Size = new Size(414, 26);
            txtStatAllTimeClientAvrCheque.TabIndex = 3;
            txtStatAllTimeClientAvrCheque.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeClientAvrDaylyCheque
            // 
            txtStatAllTimeClientAvrDaylyCheque.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientAvrDaylyCheque.Enabled = false;
            txtStatAllTimeClientAvrDaylyCheque.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientAvrDaylyCheque.Location = new Point(6, 63);
            txtStatAllTimeClientAvrDaylyCheque.Name = "txtStatAllTimeClientAvrDaylyCheque";
            txtStatAllTimeClientAvrDaylyCheque.Size = new Size(414, 26);
            txtStatAllTimeClientAvrDaylyCheque.TabIndex = 5;
            txtStatAllTimeClientAvrDaylyCheque.TextAlign = HorizontalAlignment.Center;
            // 
            // FormPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1695, 829);
            Controls.Add(tabControl1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPlanner";
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
            tabControl1.ResumeLayout(false);
            tabPagePlan.ResumeLayout(false);
            grPlanner.ResumeLayout(false);
            grPlanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)plannerTable).EndInit();
            tabPageStatistic.ResumeLayout(false);
            grStatAllTime.ResumeLayout(false);
            grStatAllTimeCommonValues.ResumeLayout(false);
            grStatAllTimeCommonValues.PerformLayout();
            grStatAllTimeStatus.ResumeLayout(false);
            grStatAllTimeStatus.PerformLayout();
            grStatAllTimeSource.ResumeLayout(false);
            grStatAllTimeSource.PerformLayout();
            grStatAllTimeAvgValues.ResumeLayout(false);
            grStatAllTimeAvgValues.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private TabControl tabControl1;
        private TabPage tabPagePlan;
        private GroupBox grPlanner;
        private DataGridView plannerTable;
        private Label lblPlannerClientCount;
        private DateTimePicker plannerDate;
        private TabPage tabPageStatistic;
        private GroupBox grStatAllTime;
        private TextBox txtStatAllTimeClientCount;
        private TextBox txtStatAllTimeClientSumPrise;
        private TextBox txtStatAllTimeClientAvrCheque;
        private TextBox txtStatAllTimeClientWorkDays;
        private TextBox txtStatAllTimeClientAvrDaylyCheque;
        private GroupBox grStatAllTimeAvgValues;
        private TextBox txtStatAllTimeClientAvrCountDayly;
        private GroupBox grStatAllTimeSource;
        private TextBox txtStatAllTimeSourceWhatsApp;
        private TextBox txtStatAllTimeSourceTelegram;
        private TextBox txtStatAllTimeSourceInstagram;
        private GroupBox grStatAllTimeStatus;
        private TextBox txtStatAllTimeStatusRepeat;
        private TextBox txtStatAllTimeStatusNew;
        private GroupBox grStatAllTimeCommonValues;
    }
}
