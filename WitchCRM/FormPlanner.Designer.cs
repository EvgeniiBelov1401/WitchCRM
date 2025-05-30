﻿namespace WitchCRM
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            grStatMonth = new GroupBox();
            lblCurrentYear = new Label();
            grBestDay = new GroupBox();
            txtBestDay = new TextBox();
            monthChoose = new ComboBox();
            groupBox6 = new GroupBox();
            txtStatMonthClientSumPrise = new TextBox();
            txtStatMonthClientWorkDays = new TextBox();
            txtStatMonthClientCount = new TextBox();
            groupBox7 = new GroupBox();
            txtStatMonthStatusRepeat = new TextBox();
            txtStatMonthStatusNew = new TextBox();
            groupBox8 = new GroupBox();
            txtStatMonthSourceWhatsApp = new TextBox();
            txtStatMonthSourceTelegram = new TextBox();
            txtStatMonthSourceInstagram = new TextBox();
            groupBox9 = new GroupBox();
            txtStatMonthClientAvrCountDayly = new TextBox();
            txtStatMonthClientAvrCheque = new TextBox();
            txtStatMonthClientAvrDaylyCheque = new TextBox();
            grStatYear = new GroupBox();
            grBestMonth = new GroupBox();
            txtBestMonth = new TextBox();
            yearChoose = new NumericUpDown();
            groupBox2 = new GroupBox();
            txtStatYearClientSumPrise = new TextBox();
            txtStatYearClientWorkDays = new TextBox();
            txtStatYearClientCount = new TextBox();
            groupBox3 = new GroupBox();
            txtStatYearStatusRepeat = new TextBox();
            txtStatYearStatusNew = new TextBox();
            groupBox4 = new GroupBox();
            txtStatYearSourceWhatsApp = new TextBox();
            txtStatYearSourceTelegram = new TextBox();
            txtStatYearSourceInstagram = new TextBox();
            groupBox5 = new GroupBox();
            txtStatYearClientAvrCountDayly = new TextBox();
            txtStatYearClientAvrCheque = new TextBox();
            txtStatYearClientAvrDaylyCheque = new TextBox();
            grStatAllTime = new GroupBox();
            grBestYear = new GroupBox();
            txtBestYear = new TextBox();
            txtAllYears = new TextBox();
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
            tabOptions = new TabPage();
            grBackup = new GroupBox();
            txtLastBackupDateTime = new TextBox();
            btnBackUp = new Button();
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
            grStatMonth.SuspendLayout();
            grBestDay.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox9.SuspendLayout();
            grStatYear.SuspendLayout();
            grBestMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)yearChoose).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            grStatAllTime.SuspendLayout();
            grBestYear.SuspendLayout();
            grStatAllTimeCommonValues.SuspendLayout();
            grStatAllTimeStatus.SuspendLayout();
            grStatAllTimeSource.SuspendLayout();
            grStatAllTimeAvgValues.SuspendLayout();
            tabOptions.SuspendLayout();
            grBackup.SuspendLayout();
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
            grNewClient.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grNewClient.Location = new Point(3, 6);
            grNewClient.Name = "grNewClient";
            grNewClient.Size = new Size(1681, 261);
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
            cbRepeatClient.CheckedChanged += CbRepeatClient_CheckedChanged_1;
            // 
            // grDesсription
            // 
            grDesсription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grDesсription.Controls.Add(txtDescription);
            grDesсription.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grDesсription.Location = new Point(1346, 48);
            grDesсription.Name = "grDesсription";
            grDesсription.Size = new Size(329, 190);
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
            txtDescription.Size = new Size(294, 137);
            txtDescription.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSave.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleRight;
            btnSave.Location = new Point(1016, 168);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(310, 80);
            btnSave.TabIndex = 2;
            btnSave.Text = "Записать";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += BtnSave_Click_1;
            // 
            // grPrise
            // 
            grPrise.Controls.Add(lbPrise);
            grPrise.Controls.Add(txtPrise);
            grPrise.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grPrise.Location = new Point(1016, 48);
            grPrise.Name = "grPrise";
            grPrise.Size = new Size(310, 120);
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
            lbPrise.Size = new Size(34, 38);
            lbPrise.TabIndex = 1;
            lbPrise.Text = "₽";
            // 
            // txtPrise
            // 
            txtPrise.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPrise.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtPrise.ForeColor = Color.DarkGreen;
            txtPrise.Location = new Point(16, 32);
            txtPrise.Name = "txtPrise";
            txtPrise.Size = new Size(239, 76);
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
            txtWhatsApp.Size = new Size(249, 34);
            txtWhatsApp.TabIndex = 4;
            txtWhatsApp.Visible = false;
            // 
            // txtTelegram
            // 
            txtTelegram.ForeColor = Color.Blue;
            txtTelegram.Location = new Point(93, 88);
            txtTelegram.Name = "txtTelegram";
            txtTelegram.Size = new Size(249, 34);
            txtTelegram.TabIndex = 4;
            txtTelegram.Visible = false;
            // 
            // txtInstagram
            // 
            txtInstagram.ForeColor = Color.FromArgb(192, 0, 192);
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
            rbInstagram.CheckedChanged += RbInstagram_CheckedChanged_1;
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
            rbTelegram.CheckedChanged += RbTelegram_CheckedChanged_1;
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
            rbWhatsApp.CheckedChanged += RbWhatsApp_CheckedChanged_1;
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
            dateTimePicker.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dateTimePicker.Location = new Point(6, 35);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(258, 42);
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
            txtName.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtName.Location = new Point(7, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(305, 42);
            txtName.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPagePlan);
            tabControl1.Controls.Add(tabPageStatistic);
            tabControl1.Controls.Add(tabOptions);
            tabControl1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabControl1.HotTrack = true;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1695, 824);
            tabControl1.TabIndex = 17;
            // 
            // tabPagePlan
            // 
            tabPagePlan.BackColor = Color.WhiteSmoke;
            tabPagePlan.Controls.Add(grPlanner);
            tabPagePlan.Controls.Add(grNewClient);
            tabPagePlan.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPagePlan.ImeMode = ImeMode.NoControl;
            tabPagePlan.Location = new Point(4, 43);
            tabPagePlan.Name = "tabPagePlan";
            tabPagePlan.Padding = new Padding(3);
            tabPagePlan.Size = new Size(1687, 777);
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
            grPlanner.Size = new Size(1681, 478);
            grPlanner.TabIndex = 17;
            grPlanner.TabStop = false;
            grPlanner.Text = "Планировщик";
            // 
            // plannerTable
            // 
            plannerTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            plannerTable.BackgroundColor = SystemColors.Window;
            plannerTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            plannerTable.Location = new Point(19, 80);
            plannerTable.Name = "plannerTable";
            plannerTable.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            plannerTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            plannerTable.Size = new Size(1656, 392);
            plannerTable.TabIndex = 8;
            // 
            // lblPlannerClientCount
            // 
            lblPlannerClientCount.AutoSize = true;
            lblPlannerClientCount.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblPlannerClientCount.Location = new Point(288, 40);
            lblPlannerClientCount.Name = "lblPlannerClientCount";
            lblPlannerClientCount.Size = new Size(0, 26);
            lblPlannerClientCount.TabIndex = 7;
            // 
            // plannerDate
            // 
            plannerDate.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            plannerDate.Location = new Point(16, 32);
            plannerDate.Name = "plannerDate";
            plannerDate.Size = new Size(260, 42);
            plannerDate.TabIndex = 4;
            // 
            // tabPageStatistic
            // 
            tabPageStatistic.BackColor = Color.WhiteSmoke;
            tabPageStatistic.Controls.Add(grStatMonth);
            tabPageStatistic.Controls.Add(grStatYear);
            tabPageStatistic.Controls.Add(grStatAllTime);
            tabPageStatistic.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabPageStatistic.Location = new Point(4, 43);
            tabPageStatistic.Name = "tabPageStatistic";
            tabPageStatistic.Padding = new Padding(3);
            tabPageStatistic.Size = new Size(1687, 777);
            tabPageStatistic.TabIndex = 1;
            tabPageStatistic.Text = "Статистика";
            // 
            // grStatMonth
            // 
            grStatMonth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grStatMonth.Controls.Add(lblCurrentYear);
            grStatMonth.Controls.Add(grBestDay);
            grStatMonth.Controls.Add(monthChoose);
            grStatMonth.Controls.Add(groupBox6);
            grStatMonth.Controls.Add(groupBox7);
            grStatMonth.Controls.Add(groupBox8);
            grStatMonth.Controls.Add(groupBox9);
            grStatMonth.Location = new Point(8, 56);
            grStatMonth.Name = "grStatMonth";
            grStatMonth.Size = new Size(545, 712);
            grStatMonth.TabIndex = 2;
            grStatMonth.TabStop = false;
            grStatMonth.Text = "За месяц";
            // 
            // lblCurrentYear
            // 
            lblCurrentYear.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCurrentYear.AutoSize = true;
            lblCurrentYear.ImageAlign = ContentAlignment.BottomCenter;
            lblCurrentYear.Location = new Point(207, 45);
            lblCurrentYear.Name = "lblCurrentYear";
            lblCurrentYear.Size = new Size(0, 39);
            lblCurrentYear.TabIndex = 9;
            lblCurrentYear.TextAlign = ContentAlignment.BottomLeft;
            // 
            // grBestDay
            // 
            grBestDay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            grBestDay.Controls.Add(txtBestDay);
            grBestDay.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grBestDay.Location = new Point(6, 595);
            grBestDay.Name = "grBestDay";
            grBestDay.Size = new Size(533, 109);
            grBestDay.TabIndex = 8;
            grBestDay.TabStop = false;
            grBestDay.Text = "Самый продуктивный день";
            // 
            // txtBestDay
            // 
            txtBestDay.BackColor = SystemColors.ControlLight;
            txtBestDay.Enabled = false;
            txtBestDay.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBestDay.Location = new Point(6, 31);
            txtBestDay.Multiline = true;
            txtBestDay.Name = "txtBestDay";
            txtBestDay.Size = new Size(520, 73);
            txtBestDay.TabIndex = 0;
            txtBestDay.TextAlign = HorizontalAlignment.Center;
            // 
            // monthChoose
            // 
            monthChoose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            monthChoose.DropDownStyle = ComboBoxStyle.DropDownList;
            monthChoose.FormattingEnabled = true;
            monthChoose.Location = new Point(12, 40);
            monthChoose.Name = "monthChoose";
            monthChoose.Size = new Size(190, 47);
            monthChoose.TabIndex = 7;
            monthChoose.SelectedIndexChanged += MonthChoose_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox6.Controls.Add(txtStatMonthClientSumPrise);
            groupBox6.Controls.Add(txtStatMonthClientWorkDays);
            groupBox6.Controls.Add(txtStatMonthClientCount);
            groupBox6.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox6.Location = new Point(6, 85);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(533, 129);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Основные показатели";
            // 
            // txtStatMonthClientSumPrise
            // 
            txtStatMonthClientSumPrise.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthClientSumPrise.BackColor = SystemColors.ControlLight;
            txtStatMonthClientSumPrise.Enabled = false;
            txtStatMonthClientSumPrise.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtStatMonthClientSumPrise.ForeColor = SystemColors.WindowText;
            txtStatMonthClientSumPrise.Location = new Point(6, 31);
            txtStatMonthClientSumPrise.Name = "txtStatMonthClientSumPrise";
            txtStatMonthClientSumPrise.Size = new Size(520, 30);
            txtStatMonthClientSumPrise.TabIndex = 2;
            txtStatMonthClientSumPrise.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatMonthClientWorkDays
            // 
            txtStatMonthClientWorkDays.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthClientWorkDays.BackColor = SystemColors.ControlLight;
            txtStatMonthClientWorkDays.Enabled = false;
            txtStatMonthClientWorkDays.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthClientWorkDays.Location = new Point(6, 95);
            txtStatMonthClientWorkDays.Name = "txtStatMonthClientWorkDays";
            txtStatMonthClientWorkDays.Size = new Size(520, 30);
            txtStatMonthClientWorkDays.TabIndex = 4;
            txtStatMonthClientWorkDays.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatMonthClientCount
            // 
            txtStatMonthClientCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthClientCount.BackColor = SystemColors.ControlLight;
            txtStatMonthClientCount.Enabled = false;
            txtStatMonthClientCount.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtStatMonthClientCount.ForeColor = SystemColors.WindowText;
            txtStatMonthClientCount.Location = new Point(6, 63);
            txtStatMonthClientCount.Name = "txtStatMonthClientCount";
            txtStatMonthClientCount.Size = new Size(520, 30);
            txtStatMonthClientCount.TabIndex = 1;
            txtStatMonthClientCount.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox7.Controls.Add(txtStatMonthStatusRepeat);
            groupBox7.Controls.Add(txtStatMonthStatusNew);
            groupBox7.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox7.Location = new Point(6, 492);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(533, 97);
            groupBox7.TabIndex = 6;
            groupBox7.TabStop = false;
            groupBox7.Text = "Кол-во обращений по статусам";
            // 
            // txtStatMonthStatusRepeat
            // 
            txtStatMonthStatusRepeat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthStatusRepeat.BackColor = SystemColors.ControlLight;
            txtStatMonthStatusRepeat.Enabled = false;
            txtStatMonthStatusRepeat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthStatusRepeat.Location = new Point(6, 63);
            txtStatMonthStatusRepeat.Name = "txtStatMonthStatusRepeat";
            txtStatMonthStatusRepeat.Size = new Size(520, 30);
            txtStatMonthStatusRepeat.TabIndex = 5;
            txtStatMonthStatusRepeat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatMonthStatusNew
            // 
            txtStatMonthStatusNew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthStatusNew.BackColor = SystemColors.ControlLight;
            txtStatMonthStatusNew.Enabled = false;
            txtStatMonthStatusNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthStatusNew.Location = new Point(6, 31);
            txtStatMonthStatusNew.Name = "txtStatMonthStatusNew";
            txtStatMonthStatusNew.Size = new Size(520, 30);
            txtStatMonthStatusNew.TabIndex = 4;
            txtStatMonthStatusNew.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox8.Controls.Add(txtStatMonthSourceWhatsApp);
            groupBox8.Controls.Add(txtStatMonthSourceTelegram);
            groupBox8.Controls.Add(txtStatMonthSourceInstagram);
            groupBox8.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox8.Location = new Point(6, 355);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(533, 131);
            groupBox8.TabIndex = 5;
            groupBox8.TabStop = false;
            groupBox8.Text = "Кол-во обращений по источникам";
            // 
            // txtStatMonthSourceWhatsApp
            // 
            txtStatMonthSourceWhatsApp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthSourceWhatsApp.BackColor = SystemColors.ControlLight;
            txtStatMonthSourceWhatsApp.Enabled = false;
            txtStatMonthSourceWhatsApp.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthSourceWhatsApp.Location = new Point(6, 95);
            txtStatMonthSourceWhatsApp.Name = "txtStatMonthSourceWhatsApp";
            txtStatMonthSourceWhatsApp.Size = new Size(520, 30);
            txtStatMonthSourceWhatsApp.TabIndex = 6;
            txtStatMonthSourceWhatsApp.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatMonthSourceTelegram
            // 
            txtStatMonthSourceTelegram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthSourceTelegram.BackColor = SystemColors.ControlLight;
            txtStatMonthSourceTelegram.Enabled = false;
            txtStatMonthSourceTelegram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthSourceTelegram.Location = new Point(6, 63);
            txtStatMonthSourceTelegram.Name = "txtStatMonthSourceTelegram";
            txtStatMonthSourceTelegram.Size = new Size(520, 30);
            txtStatMonthSourceTelegram.TabIndex = 5;
            txtStatMonthSourceTelegram.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatMonthSourceInstagram
            // 
            txtStatMonthSourceInstagram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthSourceInstagram.BackColor = SystemColors.ControlLight;
            txtStatMonthSourceInstagram.Enabled = false;
            txtStatMonthSourceInstagram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthSourceInstagram.Location = new Point(6, 31);
            txtStatMonthSourceInstagram.Name = "txtStatMonthSourceInstagram";
            txtStatMonthSourceInstagram.Size = new Size(520, 30);
            txtStatMonthSourceInstagram.TabIndex = 4;
            txtStatMonthSourceInstagram.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            groupBox9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox9.Controls.Add(txtStatMonthClientAvrCountDayly);
            groupBox9.Controls.Add(txtStatMonthClientAvrCheque);
            groupBox9.Controls.Add(txtStatMonthClientAvrDaylyCheque);
            groupBox9.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox9.Location = new Point(6, 220);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(533, 129);
            groupBox9.TabIndex = 1;
            groupBox9.TabStop = false;
            groupBox9.Text = "Средние значения";
            // 
            // txtStatMonthClientAvrCountDayly
            // 
            txtStatMonthClientAvrCountDayly.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthClientAvrCountDayly.BackColor = SystemColors.ControlLight;
            txtStatMonthClientAvrCountDayly.Enabled = false;
            txtStatMonthClientAvrCountDayly.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthClientAvrCountDayly.Location = new Point(6, 95);
            txtStatMonthClientAvrCountDayly.Name = "txtStatMonthClientAvrCountDayly";
            txtStatMonthClientAvrCountDayly.Size = new Size(520, 30);
            txtStatMonthClientAvrCountDayly.TabIndex = 6;
            txtStatMonthClientAvrCountDayly.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatMonthClientAvrCheque
            // 
            txtStatMonthClientAvrCheque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthClientAvrCheque.BackColor = SystemColors.ControlLight;
            txtStatMonthClientAvrCheque.Enabled = false;
            txtStatMonthClientAvrCheque.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthClientAvrCheque.Location = new Point(6, 31);
            txtStatMonthClientAvrCheque.Name = "txtStatMonthClientAvrCheque";
            txtStatMonthClientAvrCheque.Size = new Size(520, 30);
            txtStatMonthClientAvrCheque.TabIndex = 3;
            txtStatMonthClientAvrCheque.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatMonthClientAvrDaylyCheque
            // 
            txtStatMonthClientAvrDaylyCheque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatMonthClientAvrDaylyCheque.BackColor = SystemColors.ControlLight;
            txtStatMonthClientAvrDaylyCheque.Enabled = false;
            txtStatMonthClientAvrDaylyCheque.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatMonthClientAvrDaylyCheque.Location = new Point(6, 63);
            txtStatMonthClientAvrDaylyCheque.Name = "txtStatMonthClientAvrDaylyCheque";
            txtStatMonthClientAvrDaylyCheque.Size = new Size(520, 30);
            txtStatMonthClientAvrDaylyCheque.TabIndex = 5;
            txtStatMonthClientAvrDaylyCheque.TextAlign = HorizontalAlignment.Center;
            // 
            // grStatYear
            // 
            grStatYear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            grStatYear.Controls.Add(grBestMonth);
            grStatYear.Controls.Add(yearChoose);
            grStatYear.Controls.Add(groupBox2);
            grStatYear.Controls.Add(groupBox3);
            grStatYear.Controls.Add(groupBox4);
            grStatYear.Controls.Add(groupBox5);
            grStatYear.Location = new Point(569, 56);
            grStatYear.Name = "grStatYear";
            grStatYear.Size = new Size(545, 712);
            grStatYear.TabIndex = 1;
            grStatYear.TabStop = false;
            grStatYear.Text = "За год";
            // 
            // grBestMonth
            // 
            grBestMonth.Anchor = AnchorStyles.Bottom;
            grBestMonth.Controls.Add(txtBestMonth);
            grBestMonth.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grBestMonth.Location = new Point(6, 595);
            grBestMonth.Name = "grBestMonth";
            grBestMonth.Size = new Size(532, 109);
            grBestMonth.TabIndex = 9;
            grBestMonth.TabStop = false;
            grBestMonth.Text = "Самый продуктивный месяц";
            // 
            // txtBestMonth
            // 
            txtBestMonth.BackColor = SystemColors.ControlLight;
            txtBestMonth.Enabled = false;
            txtBestMonth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBestMonth.Location = new Point(6, 31);
            txtBestMonth.Multiline = true;
            txtBestMonth.Name = "txtBestMonth";
            txtBestMonth.Size = new Size(519, 73);
            txtBestMonth.TabIndex = 0;
            txtBestMonth.TextAlign = HorizontalAlignment.Center;
            // 
            // yearChoose
            // 
            yearChoose.Anchor = AnchorStyles.Bottom;
            yearChoose.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yearChoose.Location = new Point(12, 38);
            yearChoose.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            yearChoose.Minimum = new decimal(new int[] { 2022, 0, 0, 0 });
            yearChoose.Name = "yearChoose";
            yearChoose.Size = new Size(120, 46);
            yearChoose.TabIndex = 7;
            yearChoose.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom;
            groupBox2.Controls.Add(txtStatYearClientSumPrise);
            groupBox2.Controls.Add(txtStatYearClientWorkDays);
            groupBox2.Controls.Add(txtStatYearClientCount);
            groupBox2.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(6, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(532, 129);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Основные показатели";
            // 
            // txtStatYearClientSumPrise
            // 
            txtStatYearClientSumPrise.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearClientSumPrise.BackColor = SystemColors.ControlLight;
            txtStatYearClientSumPrise.Enabled = false;
            txtStatYearClientSumPrise.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtStatYearClientSumPrise.Location = new Point(6, 31);
            txtStatYearClientSumPrise.Name = "txtStatYearClientSumPrise";
            txtStatYearClientSumPrise.Size = new Size(519, 30);
            txtStatYearClientSumPrise.TabIndex = 2;
            txtStatYearClientSumPrise.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatYearClientWorkDays
            // 
            txtStatYearClientWorkDays.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearClientWorkDays.BackColor = SystemColors.ControlLight;
            txtStatYearClientWorkDays.Enabled = false;
            txtStatYearClientWorkDays.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearClientWorkDays.Location = new Point(6, 95);
            txtStatYearClientWorkDays.Name = "txtStatYearClientWorkDays";
            txtStatYearClientWorkDays.Size = new Size(519, 30);
            txtStatYearClientWorkDays.TabIndex = 4;
            txtStatYearClientWorkDays.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatYearClientCount
            // 
            txtStatYearClientCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearClientCount.BackColor = SystemColors.ControlLight;
            txtStatYearClientCount.Enabled = false;
            txtStatYearClientCount.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtStatYearClientCount.Location = new Point(6, 63);
            txtStatYearClientCount.Name = "txtStatYearClientCount";
            txtStatYearClientCount.Size = new Size(519, 30);
            txtStatYearClientCount.TabIndex = 1;
            txtStatYearClientCount.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Bottom;
            groupBox3.Controls.Add(txtStatYearStatusRepeat);
            groupBox3.Controls.Add(txtStatYearStatusNew);
            groupBox3.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox3.Location = new Point(6, 492);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(533, 97);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Кол-во обращений по статусам";
            // 
            // txtStatYearStatusRepeat
            // 
            txtStatYearStatusRepeat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearStatusRepeat.BackColor = SystemColors.ControlLight;
            txtStatYearStatusRepeat.Enabled = false;
            txtStatYearStatusRepeat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearStatusRepeat.Location = new Point(6, 63);
            txtStatYearStatusRepeat.Name = "txtStatYearStatusRepeat";
            txtStatYearStatusRepeat.Size = new Size(520, 30);
            txtStatYearStatusRepeat.TabIndex = 5;
            txtStatYearStatusRepeat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatYearStatusNew
            // 
            txtStatYearStatusNew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearStatusNew.BackColor = SystemColors.ControlLight;
            txtStatYearStatusNew.Enabled = false;
            txtStatYearStatusNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearStatusNew.Location = new Point(6, 31);
            txtStatYearStatusNew.Name = "txtStatYearStatusNew";
            txtStatYearStatusNew.Size = new Size(520, 30);
            txtStatYearStatusNew.TabIndex = 4;
            txtStatYearStatusNew.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Bottom;
            groupBox4.Controls.Add(txtStatYearSourceWhatsApp);
            groupBox4.Controls.Add(txtStatYearSourceTelegram);
            groupBox4.Controls.Add(txtStatYearSourceInstagram);
            groupBox4.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox4.Location = new Point(6, 355);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(533, 131);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Кол-во обращений по источникам";
            // 
            // txtStatYearSourceWhatsApp
            // 
            txtStatYearSourceWhatsApp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearSourceWhatsApp.BackColor = SystemColors.ControlLight;
            txtStatYearSourceWhatsApp.Enabled = false;
            txtStatYearSourceWhatsApp.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearSourceWhatsApp.Location = new Point(6, 95);
            txtStatYearSourceWhatsApp.Name = "txtStatYearSourceWhatsApp";
            txtStatYearSourceWhatsApp.Size = new Size(520, 30);
            txtStatYearSourceWhatsApp.TabIndex = 6;
            txtStatYearSourceWhatsApp.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatYearSourceTelegram
            // 
            txtStatYearSourceTelegram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearSourceTelegram.BackColor = SystemColors.ControlLight;
            txtStatYearSourceTelegram.Enabled = false;
            txtStatYearSourceTelegram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearSourceTelegram.Location = new Point(6, 63);
            txtStatYearSourceTelegram.Name = "txtStatYearSourceTelegram";
            txtStatYearSourceTelegram.Size = new Size(520, 30);
            txtStatYearSourceTelegram.TabIndex = 5;
            txtStatYearSourceTelegram.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatYearSourceInstagram
            // 
            txtStatYearSourceInstagram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearSourceInstagram.BackColor = SystemColors.ControlLight;
            txtStatYearSourceInstagram.Enabled = false;
            txtStatYearSourceInstagram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearSourceInstagram.Location = new Point(6, 31);
            txtStatYearSourceInstagram.Name = "txtStatYearSourceInstagram";
            txtStatYearSourceInstagram.Size = new Size(520, 30);
            txtStatYearSourceInstagram.TabIndex = 4;
            txtStatYearSourceInstagram.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Bottom;
            groupBox5.Controls.Add(txtStatYearClientAvrCountDayly);
            groupBox5.Controls.Add(txtStatYearClientAvrCheque);
            groupBox5.Controls.Add(txtStatYearClientAvrDaylyCheque);
            groupBox5.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox5.Location = new Point(6, 220);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(533, 129);
            groupBox5.TabIndex = 1;
            groupBox5.TabStop = false;
            groupBox5.Text = "Средние значения";
            // 
            // txtStatYearClientAvrCountDayly
            // 
            txtStatYearClientAvrCountDayly.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearClientAvrCountDayly.BackColor = SystemColors.ControlLight;
            txtStatYearClientAvrCountDayly.Enabled = false;
            txtStatYearClientAvrCountDayly.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearClientAvrCountDayly.Location = new Point(6, 95);
            txtStatYearClientAvrCountDayly.Name = "txtStatYearClientAvrCountDayly";
            txtStatYearClientAvrCountDayly.Size = new Size(520, 30);
            txtStatYearClientAvrCountDayly.TabIndex = 6;
            txtStatYearClientAvrCountDayly.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatYearClientAvrCheque
            // 
            txtStatYearClientAvrCheque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearClientAvrCheque.BackColor = SystemColors.ControlLight;
            txtStatYearClientAvrCheque.Enabled = false;
            txtStatYearClientAvrCheque.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearClientAvrCheque.Location = new Point(6, 31);
            txtStatYearClientAvrCheque.Name = "txtStatYearClientAvrCheque";
            txtStatYearClientAvrCheque.Size = new Size(520, 30);
            txtStatYearClientAvrCheque.TabIndex = 3;
            txtStatYearClientAvrCheque.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatYearClientAvrDaylyCheque
            // 
            txtStatYearClientAvrDaylyCheque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatYearClientAvrDaylyCheque.BackColor = SystemColors.ControlLight;
            txtStatYearClientAvrDaylyCheque.Enabled = false;
            txtStatYearClientAvrDaylyCheque.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatYearClientAvrDaylyCheque.Location = new Point(6, 63);
            txtStatYearClientAvrDaylyCheque.Name = "txtStatYearClientAvrDaylyCheque";
            txtStatYearClientAvrDaylyCheque.Size = new Size(520, 30);
            txtStatYearClientAvrDaylyCheque.TabIndex = 5;
            txtStatYearClientAvrDaylyCheque.TextAlign = HorizontalAlignment.Center;
            // 
            // grStatAllTime
            // 
            grStatAllTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            grStatAllTime.Controls.Add(grBestYear);
            grStatAllTime.Controls.Add(txtAllYears);
            grStatAllTime.Controls.Add(grStatAllTimeCommonValues);
            grStatAllTime.Controls.Add(grStatAllTimeStatus);
            grStatAllTime.Controls.Add(grStatAllTimeSource);
            grStatAllTime.Controls.Add(grStatAllTimeAvgValues);
            grStatAllTime.Location = new Point(1130, 56);
            grStatAllTime.Name = "grStatAllTime";
            grStatAllTime.Size = new Size(545, 712);
            grStatAllTime.TabIndex = 0;
            grStatAllTime.TabStop = false;
            grStatAllTime.Text = "За все время";
            // 
            // grBestYear
            // 
            grBestYear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grBestYear.Controls.Add(txtBestYear);
            grBestYear.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grBestYear.Location = new Point(6, 595);
            grBestYear.Name = "grBestYear";
            grBestYear.Size = new Size(533, 109);
            grBestYear.TabIndex = 10;
            grBestYear.TabStop = false;
            grBestYear.Text = "Самый продуктивный год";
            // 
            // txtBestYear
            // 
            txtBestYear.BackColor = SystemColors.ControlLight;
            txtBestYear.Enabled = false;
            txtBestYear.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtBestYear.Location = new Point(6, 31);
            txtBestYear.Multiline = true;
            txtBestYear.Name = "txtBestYear";
            txtBestYear.Size = new Size(520, 73);
            txtBestYear.TabIndex = 0;
            txtBestYear.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAllYears
            // 
            txtAllYears.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtAllYears.Enabled = false;
            txtAllYears.Font = new Font("Times New Roman", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            txtAllYears.Location = new Point(12, 37);
            txtAllYears.Multiline = true;
            txtAllYears.Name = "txtAllYears";
            txtAllYears.Size = new Size(526, 40);
            txtAllYears.TabIndex = 7;
            // 
            // grStatAllTimeCommonValues
            // 
            grStatAllTimeCommonValues.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grStatAllTimeCommonValues.Controls.Add(txtStatAllTimeClientSumPrise);
            grStatAllTimeCommonValues.Controls.Add(txtStatAllTimeClientWorkDays);
            grStatAllTimeCommonValues.Controls.Add(txtStatAllTimeClientCount);
            grStatAllTimeCommonValues.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grStatAllTimeCommonValues.Location = new Point(6, 85);
            grStatAllTimeCommonValues.Name = "grStatAllTimeCommonValues";
            grStatAllTimeCommonValues.Size = new Size(533, 129);
            grStatAllTimeCommonValues.TabIndex = 1;
            grStatAllTimeCommonValues.TabStop = false;
            grStatAllTimeCommonValues.Text = "Основные показатели";
            // 
            // txtStatAllTimeClientSumPrise
            // 
            txtStatAllTimeClientSumPrise.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeClientSumPrise.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientSumPrise.Enabled = false;
            txtStatAllTimeClientSumPrise.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtStatAllTimeClientSumPrise.Location = new Point(6, 31);
            txtStatAllTimeClientSumPrise.Name = "txtStatAllTimeClientSumPrise";
            txtStatAllTimeClientSumPrise.Size = new Size(520, 30);
            txtStatAllTimeClientSumPrise.TabIndex = 2;
            txtStatAllTimeClientSumPrise.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeClientWorkDays
            // 
            txtStatAllTimeClientWorkDays.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeClientWorkDays.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientWorkDays.Enabled = false;
            txtStatAllTimeClientWorkDays.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientWorkDays.Location = new Point(6, 95);
            txtStatAllTimeClientWorkDays.Name = "txtStatAllTimeClientWorkDays";
            txtStatAllTimeClientWorkDays.Size = new Size(520, 30);
            txtStatAllTimeClientWorkDays.TabIndex = 4;
            txtStatAllTimeClientWorkDays.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeClientCount
            // 
            txtStatAllTimeClientCount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeClientCount.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientCount.Enabled = false;
            txtStatAllTimeClientCount.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            txtStatAllTimeClientCount.Location = new Point(6, 63);
            txtStatAllTimeClientCount.Name = "txtStatAllTimeClientCount";
            txtStatAllTimeClientCount.Size = new Size(520, 30);
            txtStatAllTimeClientCount.TabIndex = 1;
            txtStatAllTimeClientCount.TextAlign = HorizontalAlignment.Center;
            // 
            // grStatAllTimeStatus
            // 
            grStatAllTimeStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grStatAllTimeStatus.Controls.Add(txtStatAllTimeStatusRepeat);
            grStatAllTimeStatus.Controls.Add(txtStatAllTimeStatusNew);
            grStatAllTimeStatus.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grStatAllTimeStatus.Location = new Point(6, 492);
            grStatAllTimeStatus.Name = "grStatAllTimeStatus";
            grStatAllTimeStatus.Size = new Size(533, 97);
            grStatAllTimeStatus.TabIndex = 6;
            grStatAllTimeStatus.TabStop = false;
            grStatAllTimeStatus.Text = "Кол-во обращений по статусам";
            // 
            // txtStatAllTimeStatusRepeat
            // 
            txtStatAllTimeStatusRepeat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeStatusRepeat.BackColor = SystemColors.ControlLight;
            txtStatAllTimeStatusRepeat.Enabled = false;
            txtStatAllTimeStatusRepeat.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeStatusRepeat.Location = new Point(6, 63);
            txtStatAllTimeStatusRepeat.Name = "txtStatAllTimeStatusRepeat";
            txtStatAllTimeStatusRepeat.Size = new Size(520, 30);
            txtStatAllTimeStatusRepeat.TabIndex = 5;
            txtStatAllTimeStatusRepeat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeStatusNew
            // 
            txtStatAllTimeStatusNew.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeStatusNew.BackColor = SystemColors.ControlLight;
            txtStatAllTimeStatusNew.Enabled = false;
            txtStatAllTimeStatusNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeStatusNew.Location = new Point(6, 31);
            txtStatAllTimeStatusNew.Name = "txtStatAllTimeStatusNew";
            txtStatAllTimeStatusNew.Size = new Size(520, 30);
            txtStatAllTimeStatusNew.TabIndex = 4;
            txtStatAllTimeStatusNew.TextAlign = HorizontalAlignment.Center;
            // 
            // grStatAllTimeSource
            // 
            grStatAllTimeSource.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grStatAllTimeSource.Controls.Add(txtStatAllTimeSourceWhatsApp);
            grStatAllTimeSource.Controls.Add(txtStatAllTimeSourceTelegram);
            grStatAllTimeSource.Controls.Add(txtStatAllTimeSourceInstagram);
            grStatAllTimeSource.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grStatAllTimeSource.Location = new Point(6, 355);
            grStatAllTimeSource.Name = "grStatAllTimeSource";
            grStatAllTimeSource.Size = new Size(533, 131);
            grStatAllTimeSource.TabIndex = 5;
            grStatAllTimeSource.TabStop = false;
            grStatAllTimeSource.Text = "Кол-во обращений по источникам";
            // 
            // txtStatAllTimeSourceWhatsApp
            // 
            txtStatAllTimeSourceWhatsApp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeSourceWhatsApp.BackColor = SystemColors.ControlLight;
            txtStatAllTimeSourceWhatsApp.Enabled = false;
            txtStatAllTimeSourceWhatsApp.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeSourceWhatsApp.Location = new Point(6, 95);
            txtStatAllTimeSourceWhatsApp.Name = "txtStatAllTimeSourceWhatsApp";
            txtStatAllTimeSourceWhatsApp.Size = new Size(520, 30);
            txtStatAllTimeSourceWhatsApp.TabIndex = 6;
            txtStatAllTimeSourceWhatsApp.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeSourceTelegram
            // 
            txtStatAllTimeSourceTelegram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeSourceTelegram.BackColor = SystemColors.ControlLight;
            txtStatAllTimeSourceTelegram.Enabled = false;
            txtStatAllTimeSourceTelegram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeSourceTelegram.Location = new Point(6, 63);
            txtStatAllTimeSourceTelegram.Name = "txtStatAllTimeSourceTelegram";
            txtStatAllTimeSourceTelegram.Size = new Size(520, 30);
            txtStatAllTimeSourceTelegram.TabIndex = 5;
            txtStatAllTimeSourceTelegram.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeSourceInstagram
            // 
            txtStatAllTimeSourceInstagram.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeSourceInstagram.BackColor = SystemColors.ControlLight;
            txtStatAllTimeSourceInstagram.Enabled = false;
            txtStatAllTimeSourceInstagram.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeSourceInstagram.Location = new Point(6, 31);
            txtStatAllTimeSourceInstagram.Name = "txtStatAllTimeSourceInstagram";
            txtStatAllTimeSourceInstagram.Size = new Size(520, 30);
            txtStatAllTimeSourceInstagram.TabIndex = 4;
            txtStatAllTimeSourceInstagram.TextAlign = HorizontalAlignment.Center;
            // 
            // grStatAllTimeAvgValues
            // 
            grStatAllTimeAvgValues.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            grStatAllTimeAvgValues.Controls.Add(txtStatAllTimeClientAvrCountDayly);
            grStatAllTimeAvgValues.Controls.Add(txtStatAllTimeClientAvrCheque);
            grStatAllTimeAvgValues.Controls.Add(txtStatAllTimeClientAvrDaylyCheque);
            grStatAllTimeAvgValues.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            grStatAllTimeAvgValues.Location = new Point(6, 220);
            grStatAllTimeAvgValues.Name = "grStatAllTimeAvgValues";
            grStatAllTimeAvgValues.Size = new Size(533, 129);
            grStatAllTimeAvgValues.TabIndex = 1;
            grStatAllTimeAvgValues.TabStop = false;
            grStatAllTimeAvgValues.Text = "Средние значения";
            // 
            // txtStatAllTimeClientAvrCountDayly
            // 
            txtStatAllTimeClientAvrCountDayly.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeClientAvrCountDayly.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientAvrCountDayly.Enabled = false;
            txtStatAllTimeClientAvrCountDayly.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientAvrCountDayly.Location = new Point(6, 95);
            txtStatAllTimeClientAvrCountDayly.Name = "txtStatAllTimeClientAvrCountDayly";
            txtStatAllTimeClientAvrCountDayly.Size = new Size(520, 30);
            txtStatAllTimeClientAvrCountDayly.TabIndex = 6;
            txtStatAllTimeClientAvrCountDayly.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeClientAvrCheque
            // 
            txtStatAllTimeClientAvrCheque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeClientAvrCheque.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientAvrCheque.Enabled = false;
            txtStatAllTimeClientAvrCheque.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientAvrCheque.Location = new Point(6, 31);
            txtStatAllTimeClientAvrCheque.Name = "txtStatAllTimeClientAvrCheque";
            txtStatAllTimeClientAvrCheque.Size = new Size(520, 30);
            txtStatAllTimeClientAvrCheque.TabIndex = 3;
            txtStatAllTimeClientAvrCheque.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStatAllTimeClientAvrDaylyCheque
            // 
            txtStatAllTimeClientAvrDaylyCheque.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtStatAllTimeClientAvrDaylyCheque.BackColor = SystemColors.ControlLight;
            txtStatAllTimeClientAvrDaylyCheque.Enabled = false;
            txtStatAllTimeClientAvrDaylyCheque.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtStatAllTimeClientAvrDaylyCheque.Location = new Point(6, 63);
            txtStatAllTimeClientAvrDaylyCheque.Name = "txtStatAllTimeClientAvrDaylyCheque";
            txtStatAllTimeClientAvrDaylyCheque.Size = new Size(520, 30);
            txtStatAllTimeClientAvrDaylyCheque.TabIndex = 5;
            txtStatAllTimeClientAvrDaylyCheque.TextAlign = HorizontalAlignment.Center;
            // 
            // tabOptions
            // 
            tabOptions.BackColor = Color.WhiteSmoke;
            tabOptions.Controls.Add(grBackup);
            tabOptions.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            tabOptions.Location = new Point(4, 43);
            tabOptions.Name = "tabOptions";
            tabOptions.Size = new Size(1687, 777);
            tabOptions.TabIndex = 2;
            tabOptions.Text = "Настройки";
            // 
            // grBackup
            // 
            grBackup.Controls.Add(txtLastBackupDateTime);
            grBackup.Controls.Add(btnBackUp);
            grBackup.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            grBackup.Location = new Point(32, 38);
            grBackup.Name = "grBackup";
            grBackup.Size = new Size(488, 178);
            grBackup.TabIndex = 1;
            grBackup.TabStop = false;
            grBackup.Text = "Back up";
            // 
            // txtLastBackupDateTime
            // 
            txtLastBackupDateTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLastBackupDateTime.BackColor = SystemColors.ControlLight;
            txtLastBackupDateTime.Enabled = false;
            txtLastBackupDateTime.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtLastBackupDateTime.Location = new Point(8, 38);
            txtLastBackupDateTime.Name = "txtLastBackupDateTime";
            txtLastBackupDateTime.Size = new Size(469, 30);
            txtLastBackupDateTime.TabIndex = 1;
            txtLastBackupDateTime.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBackUp
            // 
            btnBackUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBackUp.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnBackUp.Location = new Point(8, 82);
            btnBackUp.Name = "btnBackUp";
            btnBackUp.Size = new Size(464, 82);
            btnBackUp.TabIndex = 0;
            btnBackUp.Text = "Сделать BackUp базы данных";
            btnBackUp.UseVisualStyleBackColor = true;
            btnBackUp.Click += BtnBackUp_Click;
            // 
            // FormPlanner
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1695, 829);
            Controls.Add(tabControl1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormPlanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Бухгалтерия ведьмы";
            Load += FormPlanner_Load;
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
            grStatMonth.ResumeLayout(false);
            grStatMonth.PerformLayout();
            grBestDay.ResumeLayout(false);
            grBestDay.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            grStatYear.ResumeLayout(false);
            grBestMonth.ResumeLayout(false);
            grBestMonth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)yearChoose).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            grStatAllTime.ResumeLayout(false);
            grStatAllTime.PerformLayout();
            grBestYear.ResumeLayout(false);
            grBestYear.PerformLayout();
            grStatAllTimeCommonValues.ResumeLayout(false);
            grStatAllTimeCommonValues.PerformLayout();
            grStatAllTimeStatus.ResumeLayout(false);
            grStatAllTimeStatus.PerformLayout();
            grStatAllTimeSource.ResumeLayout(false);
            grStatAllTimeSource.PerformLayout();
            grStatAllTimeAvgValues.ResumeLayout(false);
            grStatAllTimeAvgValues.PerformLayout();
            tabOptions.ResumeLayout(false);
            grBackup.ResumeLayout(false);
            grBackup.PerformLayout();
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
        private GroupBox grStatYear;
        private GroupBox groupBox2;
        private TextBox txtStatYearClientSumPrise;
        private TextBox txtStatYearClientWorkDays;
        private TextBox txtStatYearClientCount;
        private GroupBox groupBox3;
        private TextBox txtStatYearStatusRepeat;
        private TextBox txtStatYearStatusNew;
        private GroupBox groupBox4;
        private TextBox txtStatYearSourceWhatsApp;
        private TextBox txtStatYearSourceTelegram;
        private TextBox txtStatYearSourceInstagram;
        private GroupBox groupBox5;
        private TextBox txtStatYearClientAvrCountDayly;
        private TextBox txtStatYearClientAvrCheque;
        private TextBox txtStatYearClientAvrDaylyCheque;
        private NumericUpDown yearChoose;
        private GroupBox grStatMonth;
        private GroupBox groupBox6;
        private TextBox txtStatMonthClientSumPrise;
        private TextBox txtStatMonthClientWorkDays;
        private TextBox txtStatMonthClientCount;
        private GroupBox groupBox7;
        private TextBox txtStatMonthStatusRepeat;
        private TextBox txtStatMonthStatusNew;
        private GroupBox groupBox8;
        private TextBox txtStatMonthSourceWhatsApp;
        private TextBox txtStatMonthSourceTelegram;
        private TextBox txtStatMonthSourceInstagram;
        private GroupBox groupBox9;
        private TextBox txtStatMonthClientAvrCountDayly;
        private TextBox txtStatMonthClientAvrCheque;
        private TextBox txtStatMonthClientAvrDaylyCheque;
        private ComboBox monthChoose;
        private TextBox txtAllYears;
        private TabPage tabOptions;
        private Button btnBackUp;
        private GroupBox grBackup;
        private GroupBox grBestDay;
        private TextBox txtBestDay;
        private GroupBox grBestMonth;
        private TextBox txtBestMonth;
        private Label lblCurrentYear;
        private GroupBox grBestYear;
        private TextBox txtBestYear;
        private TextBox txtLastBackupDateTime;
    }
}
