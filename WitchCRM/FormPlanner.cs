using System.Windows.Forms;
using WitchCRM.Modules;

namespace WitchCRM
{
    public partial class FormPlanner : Form
    {
        private AppDbContext? _context;
        private string? _clientStatus = "Новый";
        private string _sourceName = String.Empty;
        private string _sourceData = String.Empty;

        private IStatistic? _statistic;

        public FormPlanner()
        {
            InitializeComponent();
            LoadOptions();//устанавливает начальные настройки при загрузке формы
            LoadClientsByDate();//отображает планировщик в зависимости от выбранной даты

            LoadStatAllTime();//загружает статистику "ЗА ВСЕ ВРЕМЯ" при загрузке формы
            yearChoose.ValueChanged += yearChoose_ValueChanged!;//меняет статистику "ЗА ГОД" в зависимости от выбранного года
            LoadStatYear();//загружает статистику "ЗА ГОД" при загрузке формы
        }

        

        ////
        //Органы управления
        ////

        //КНОПКА "ЗАПИСАТЬ"
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            InputData();
            LoadClientsByDate();//обновляет планировщик в зависимости от выбранной даты при записи нового клиента

            LoadStatAllTime();//обновляет статистику "ЗА ВСЕ ВРЕМЯ" при записи нового клиента
            LoadStatYear();//обновляет статистику "ЗА ГОД" при записи нового клиента
        }

        //ВЫБРАТЬ ИНСТАГРАМ
        private void rbInstagram_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbInstagram.Checked)
            {
                txtInstagram.Visible = true;
                _sourceName = "Instagram";
                txtInstagram.Focus();
                txtTelegram.Visible = false;
                txtWhatsApp.Visible = false;
            }
        }
        //ВЫБРАТЬ ТЕЛЕГРАМ
        private void rbTelegram_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbTelegram.Checked)
            {
                txtTelegram.Visible = true;
                _sourceName = "Telegram";
                txtTelegram.Focus();
                txtWhatsApp.Visible = false;
                txtInstagram.Visible = false;
            }
        }
        //ВЫБРАТЬ WHATSAPP
        private void rbWhatsApp_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbWhatsApp.Checked)
            {
                txtWhatsApp.Visible = true;
                _sourceName = "WhatsApp";
                txtWhatsApp.Focus();
                txtTelegram.Visible = false;
                txtInstagram.Visible = false;
            }
        }
        //УСТАНОВИТЬ СТАТУС ПОВТОРНЫЙ КЛИЕНТ
        private void cbRepeatClient_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbRepeatClient.Checked)
            {
                _clientStatus = "Повторный";
            }
        }

        

        //-------------------------------------------------------------------------------------------------------

        ////
        //Методы
        ////

        //Метод первоначальных настроек элементов при загрузке формы
        private void LoadOptions()
        {
            txtName.Focus();
            _context = new AppDbContext();
            _context.Database.EnsureCreated();


            txtTelegram.Mask = "+79990000000";
            txtWhatsApp.Mask = "+79990000000";


            plannerDate.Format = DateTimePickerFormat.Long;
            plannerDate.Value = DateTime.Today;
            plannerDate.ValueChanged += (s, e) => LoadClientsByDate();//обновляет планировщик во время смены даты

            plannerTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            plannerTable.AllowUserToAddRows = false;

            if (DateTime.Now.Year > yearChoose.Maximum)
            {
                yearChoose.Maximum = DateTime.Now.Year;
            }
            yearChoose.Value = DateTime.Now.Year;
        }

        //Метод ввода данных
        private void InputData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Поле 'Имя' не может быть пустым!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rbInstagram.Checked && !rbTelegram.Checked && !rbWhatsApp.Checked)
            {
                MessageBox.Show("Не выбран 'Источник'", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InputSourceData();


            if (String.IsNullOrWhiteSpace(txtPrise.Text))
            {
                MessageBox.Show("Поле 'К оплате' не может быть пустым!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (decimal.TryParse(txtPrise.Text, out decimal prise))
                {
                    var client = new Client
                    {
                        Name = txtName.Text,
                        Date = dateTimePicker.Value.Date,
                        SourceName = _sourceName,
                        SourceData = _sourceData,
                        Prise = prise,
                        Description = txtDescription.Text,
                        Status = _clientStatus
                    };

                    if (_context?.Clients != null)
                    {
                        _context.Clients.Add(client!);
                        _context.SaveChanges();
                    }


                    MessageBox.Show("Клиент успешно сохранен!", "Успех",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearInputtedData();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("В поле 'К оплате' необходимо ввести корректные данные!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrise.Clear();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Метод ввода данных для источника
        private void InputSourceData()
        {
            if (txtInstagram.Visible == true)
            {
                _sourceData = txtInstagram.Text;
                if (String.IsNullOrWhiteSpace(txtInstagram.Text))
                {
                    _sourceData = "@";
                }
            }
            if (txtTelegram.Visible == true)
            {
                _sourceData = txtTelegram.Text;
            }
            if (txtWhatsApp.Visible == true)
            {
                _sourceData = txtWhatsApp.Text;
            }
        }

        //Метод очистки органов ввода
        private void ClearInputtedData()
        {
            txtName.Clear();

            txtInstagram.Clear();
            txtTelegram.Clear();
            txtWhatsApp.Clear();
            txtPrise.Clear();
            txtDescription.Clear();

            rbInstagram.Checked = false;
            rbTelegram.Checked = false;
            rbWhatsApp.Checked = false;

            cbRepeatClient.Checked = false;

            txtInstagram.Visible = false;
            txtTelegram.Visible = false;
            txtWhatsApp.Visible = false;
            _clientStatus = "Новый";

            txtName.Focus();
        }

        //Метод загрузки плана на выбранную дату
        private void LoadClientsByDate()
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var clients = db.Clients
                        .Where(c => c.Date.Date == plannerDate.Value.Date)
                        .ToList();
                    if (clients.Count != 0)
                    {
                        lblPlannerClientCount.Text = $"Клиентов: {clients.Count}";
                        plannerTable.Visible = true;
                    }
                    else
                    {
                        lblPlannerClientCount.Text = $"Нет записи";
                        plannerTable.Visible = false;
                    }
                    var displayData = clients
                        .Select((c, index) => new
                        {
                            Дата = c.Date.ToShortDateString(),
                            Имя = c.Name,
                            Статус = c.Status,
                            Источник = c.SourceName,
                            Контакты = c.SourceData,
                            Оплачено = c.Prise,
                            Дополнительно = c.Description
                        })
                        .ToList();
                    plannerTable.DataSource = displayData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------


        //СТАТИСТИКА "ЗА ВСЕ ВРЕМЯ"
        //Метод выгрузки и отрисовки статистики "ЗА ВСЕ ВРЕМЯ"
        private void LoadStatAllTime()
        {
            try
            {
                _statistic = new StatisticAllTime()
                {
                    TotalClientsCount = _context?.Clients?.Count() ?? 0,
                    TotalClientsPrise = _context?.Clients?.Sum(c => (decimal?)c.Prise) ?? 0,
                    TotalWorkDays = (long)(_context?.Clients?.Select(c => c.Date.Date)?.Distinct()?.Count() ?? 0),
                    SourceInstagramCount = _context?.Clients?.Where(c => c.SourceName == "Instagram").Count() ?? 0,
                    SourceTelegramCount = _context?.Clients?.Where(c => c.SourceName == "Telegram").Count() ?? 0,
                    SourceWhatsAppCount = _context?.Clients?.Where(c => c.SourceName == "WhatsApp").Count() ?? 0,
                    StatusNewClientCount=_context?.Clients?.Where(c=>c.Status=="Новый").Count()??0,
                    StatusRepeatClientCount = _context?.Clients?.Where(c => c.Status == "Повторный").Count() ?? 0
                };


                _statistic.AvgDaylyPrise = _statistic.TotalWorkDays > 0
                    ? _statistic.TotalClientsPrise / _statistic.TotalWorkDays
                    : 0;

                _statistic.AvgPayCheque = _statistic.TotalClientsCount > 0
                    ? _statistic.TotalClientsPrise / _statistic.TotalClientsCount
                    : 0;

                _statistic.AvgDailyLoad = _statistic.TotalWorkDays > 0
                    ? _statistic.TotalClientsCount / _statistic.TotalWorkDays
                    : 0;


                txtStatAllTimeClientCount.Text = $"Количество обращений: {_statistic.TotalClientsCount}";
                txtStatAllTimeClientSumPrise.Text = $"Заработано: {_statistic.TotalClientsPrise:F2} руб.";
                txtStatAllTimeClientWorkDays.Text = $"Количество рабочих дней: {_statistic.TotalWorkDays}";

                txtStatAllTimeClientAvrCheque.Text = $"Средний чек: {_statistic.AvgPayCheque:F0} руб.";
                txtStatAllTimeClientAvrDaylyCheque.Text = $"Средний дневной заработок: {_statistic.AvgDaylyPrise:F0} руб.";
                txtStatAllTimeClientAvrCountDayly.Text = $"Средняя дневная загрузка: {_statistic.AvgDailyLoad:F0}";

                txtStatAllTimeSourceInstagram.Text = $"Instagram: {_statistic.SourceInstagramCount}";
                txtStatAllTimeSourceTelegram.Text = $"Telegram: {_statistic.SourceTelegramCount}";
                txtStatAllTimeSourceWhatsApp.Text = $"WhatsApp: {_statistic.SourceWhatsAppCount}";

                txtStatAllTimeStatusNew.Text = $"Обращений новых клиентов: {_statistic.StatusNewClientCount}";
                txtStatAllTimeStatusRepeat.Text = $"Повторных обращений клиентов: {_statistic.StatusRepeatClientCount}";

            }           
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //----------------------------------------------------------------------------------------------------------

        //СТАТИСТИКА "ЗА ГОД"
        //Метод выгрузки и отрисовки статистики "ЗА ГОД"
        private void LoadStatYear()
        {
            int selectedYear = (int)yearChoose.Value;
            var clientsInYear = _context?.Clients?
                .Where(c => c.Date.Year == selectedYear)
                .ToList();
            try
            {
                _statistic = new StatisticYear()
                {
                    TotalClientsCount = clientsInYear?.Count ?? 0,
                    TotalClientsPrise = clientsInYear?.Sum(c => (decimal?)c.Prise) ?? 0,
                    TotalWorkDays = (long)(clientsInYear?.Select(c => c.Date.Date)?.Distinct()?.Count() ?? 0),
                    SourceInstagramCount = clientsInYear?.Count(c => c.SourceName == "Instagram") ?? 0,
                    SourceTelegramCount = clientsInYear?.Count(c => c.SourceName == "Telegram") ?? 0,
                    SourceWhatsAppCount = clientsInYear?.Count(c => c.SourceName == "WhatsApp") ?? 0,
                    StatusNewClientCount = clientsInYear?.Count(c => c.Status == "Новый") ?? 0,
                    StatusRepeatClientCount = clientsInYear?.Count(c => c.Status == "Повторный") ?? 0
                };


                _statistic.AvgDaylyPrise = _statistic.TotalWorkDays > 0
                    ? _statistic.TotalClientsPrise / _statistic.TotalWorkDays
                    : 0;

                _statistic.AvgPayCheque = _statistic.TotalClientsCount > 0
                    ? _statistic.TotalClientsPrise / _statistic.TotalClientsCount
                    : 0;

                _statistic.AvgDailyLoad = _statistic.TotalWorkDays > 0
                    ? (decimal)_statistic.TotalClientsCount / _statistic.TotalWorkDays 
                    : 0;

                txtStatYearClientCount.Text = $"Количество обращений: {_statistic.TotalClientsCount}";
                txtStatYearClientSumPrise.Text = $"Заработано: {_statistic.TotalClientsPrise:F2} руб.";
                txtStatYearClientWorkDays.Text = $"Количество рабочих дней: {_statistic.TotalWorkDays}";

                txtStatYearClientAvrCheque.Text = $"Средний чек: {_statistic.AvgPayCheque:F0} руб.";
                txtStatYearClientAvrDaylyCheque.Text = $"Средний дневной заработок: {_statistic.AvgDaylyPrise:F0} руб.";
                txtStatYearClientAvrCountDayly.Text = $"Средняя дневная загрузка: {_statistic.AvgDailyLoad:F0}";

                txtStatYearSourceInstagram.Text = $"Instagram: {_statistic.SourceInstagramCount}";
                txtStatYearSourceTelegram.Text = $"Telegram: {_statistic.SourceTelegramCount}";
                txtStatYearSourceWhatsApp.Text = $"WhatsApp: {_statistic.SourceWhatsAppCount}";

                txtStatYearStatusNew.Text = $"Обращений новых клиентов: {_statistic.StatusNewClientCount}";
                txtStatYearStatusRepeat.Text = $"Повторных обращений клиентов: {_statistic.StatusRepeatClientCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Метод обновления статистики "ЗА ГОД" в зависимости от выбранного года при загрузке формы
        private void FormPlanner_Load(object sender, EventArgs e)
        {
            UpdateStatisticsYear();
            UpdateTextBoxesForStatisticYear();
        }
        //Метод обновления статистики "ЗА ГОД" в зависимости от выбранного года
        private void yearChoose_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatisticsYear();
            UpdateTextBoxesForStatisticYear();
        }
        //Метод обновления свойств класса StatisticAllTime для статистики "ЗА ГОД"
        private void UpdateStatisticsYear()
        {
            int selectedYear = (int)yearChoose.Value;
            var clientsInYear = _context?.Clients?.Where(c => c.Date.Year == selectedYear).ToList();

            _statistic = new StatisticAllTime()
            {
                TotalClientsCount = clientsInYear?.Count ?? 0,
                TotalClientsPrise = clientsInYear?.Sum(c => (decimal?)c.Prise) ?? 0,
                TotalWorkDays = (long)(clientsInYear?.Select(c => c.Date.Date)?.Distinct()?.Count() ?? 0),
                SourceInstagramCount = clientsInYear?.Count(c => c.SourceName == "Instagram") ?? 0,
                SourceTelegramCount = clientsInYear?.Count(c => c.SourceName == "Telegram") ?? 0,
                SourceWhatsAppCount = clientsInYear?.Count(c => c.SourceName == "WhatsApp") ?? 0,
                StatusNewClientCount = clientsInYear?.Count(c => c.Status == "Новый") ?? 0,
                StatusRepeatClientCount = clientsInYear?.Count(c => c.Status == "Повторный") ?? 0
            };

            _statistic.AvgDaylyPrise = _statistic.TotalWorkDays > 0
                ? _statistic.TotalClientsPrise / _statistic.TotalWorkDays
                : 0;

            _statistic.AvgPayCheque = _statistic.TotalClientsCount > 0
                ? _statistic.TotalClientsPrise / _statistic.TotalClientsCount
                : 0;

            _statistic.AvgDailyLoad = _statistic.TotalWorkDays > 0
                ? (decimal)_statistic.TotalClientsCount / _statistic.TotalWorkDays
                : 0;
        }

        //Метод обновления тектовых полей для статистики "ЗА ГОД"
        private void UpdateTextBoxesForStatisticYear()
        {
            txtStatYearClientCount.Text = $"Количество обращений: {_statistic.TotalClientsCount}";
            txtStatYearClientSumPrise.Text = $"Заработано: {_statistic?.TotalClientsPrise:F2} руб.";
            txtStatYearClientWorkDays.Text = $"Количество рабочих дней: {_statistic.TotalWorkDays}";
            txtStatYearSourceInstagram.Text = $"Instagram: {_statistic.SourceInstagramCount}";
            txtStatYearSourceTelegram.Text = $"Telegram: {_statistic.SourceTelegramCount}";
            txtStatYearSourceWhatsApp.Text = $"WhatsApp: {_statistic.SourceWhatsAppCount}";
            txtStatYearStatusNew.Text = $"Обращений новых клиентов: {_statistic.StatusNewClientCount}";
            txtStatYearStatusRepeat.Text = $"Повторных обращений клиентов: {_statistic.StatusRepeatClientCount}";
            txtStatYearClientAvrDaylyCheque.Text = $"Средний дневной заработок: {_statistic.AvgDaylyPrise:F0} руб.";
            txtStatYearClientAvrCheque.Text = $"Средний чек: {_statistic.AvgPayCheque:F0} руб.";
            txtStatYearClientAvrCountDayly.Text = $"Средняя дневная загрузка: {_statistic.AvgDailyLoad:F0}";
        }
        //----------------------------------------------------------------------------------------------------------
















        //-------------------------------------------------------------------------------------------------------
    }
}
