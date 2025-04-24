using System.Globalization;
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

        private int selectedMonthNumber;
        private int selectedYear;
        private int selectedYearForStatYear;

        private string? exMonthClientsPrise;
        private string? exMonthClientsCount;

        private string? exYearClientsPrise;
        private string? exYearClientsCount;

        private string? allYears = String.Empty;
        int daysInYear = DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365;

        public FormPlanner()
        {
            InitializeComponent();
            LoadOptions();//устанавливает начальные настройки при загрузке формы
            LoadClientsByDate();//отображает планировщик в зависимости от выбранной даты

            LoadStatAllTime();//загружает статистику "ЗА ВСЕ ВРЕМЯ" при загрузке формы
            yearChoose.ValueChanged += yearChoose_ValueChanged!;//меняет статистику "ЗА ГОД" в зависимости от выбранного года
            LoadStatYear();//загружает статистику "ЗА ГОД" при загрузке формы
            monthChoose.ValueMemberChanged += yearChoose_ValueChanged!;//меняет статистику "ЗА МЕСЯЦ" в зависимости от выбранного месяца
            LoadStatMonth();//загружает статистику "ЗА МЕСЯЦ" при загрузке формы
        }

        //Метод-событие обновления формы
        private void FormPlanner_Load(object sender, EventArgs e)
        {
            UpdateStatisticsYear();
            UpdateTextBoxesForStatisticYear();
            UpdateStatisticsMonth();
            UpdateTextBoxesForStatisticMonth();

            string[] months = new string[]
            {
                "Январь", "Февраль", "Март",
                "Апрель", "Май", "Июнь",
                "Июль", "Август", "Сентябрь",
                "Октябрь", "Ноябрь", "Декабрь"
            };

            monthChoose.Items.AddRange(months);

            monthChoose.SelectedIndex = DateTime.Now.Month - 1;//устанавливает значение по умочаниею - текущий месяц
            monthChoose_SelectedIndexChanged(null!, EventArgs.Empty);// Можно сразу вызвать обработчик для первоначальной загрузки данных
        }

        //Метод-событие обновления статистики "ЗА МЕСЯЦ" в зависимости от выбранного месяца
        private void monthChoose_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (monthChoose.SelectedItem != null && monthChoose.SelectedIndex != -1)
            {
                selectedMonthNumber = monthChoose.SelectedIndex + 1;
                selectedYear = DateTime.Now.Year;
            }
            UpdateStatisticsMonth();
            UpdateTextBoxesForStatisticMonth();
        }

        //Метод-событие обновления статистики "ЗА ГОД" в зависимости от выбранного года
        private void yearChoose_ValueChanged(object sender, EventArgs e)
        {
            UpdateStatisticsYear();
            UpdateTextBoxesForStatisticYear();
        }


        ////
        //Органы управления
        ////

        //КНОПКА "ЗАПИСАТЬ"
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            InputData();
            plannerDate.Value = dateTimePicker.Value;
            LoadClientsByDate();//обновляет планировщик в зависимости от выбранной даты при записи нового клиента

            LoadStatAllTime();//обновляет статистику "ЗА ВСЕ ВРЕМЯ" при записи нового клиента
            LoadStatYear();//обновляет статистику "ЗА ГОД" при записи нового клиента
            LoadStatMonth();//обновляет статистику "ЗА МЕСЯЦ" при записи нового клиента
            dateTimePicker.Value = DateTime.Now;//после клика "Записать" возвращает в dateTimePicker текущую дату
            allYears = String.Empty;//затирает данные всех годов работы
            ShowAllYears();//метод, который показывает все года работы
        }

        //КНОПКА "Сделать BackUp базы данных"
        private void btnBackUp_Click(object sender, EventArgs e)
        {
            DoBackUpDB();
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
            allYears = String.Empty;
            lblCurrentYear.Text = DateTime.Now.Year.ToString();


            txtTelegram.Mask = "+79990000000";
            txtWhatsApp.Mask = "+79990000000";


            plannerDate.Format = DateTimePickerFormat.Long;
            plannerDate.Value = DateTime.Today;
            plannerDate.ValueChanged += (s, e) => LoadClientsByDate();//обновляет планировщик во время смены даты

            plannerTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            plannerTable.AllowUserToAddRows = false;

            if (DateTime.Now.Year > (int)yearChoose.Maximum)//ПРОВЕРИТЬ ЭТОТ МОМЕНТ!!!!!!!!!!!!!!
            {
                yearChoose.Maximum = DateTime.Now.Year;
            }
            yearChoose.Value = DateTime.Now.Year;//устанавливает значение текущего года как значение по умолчанию для статистики "ЗА ГОД"
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
                    StatusNewClientCount = _context?.Clients?.Where(c => c.Status == "Новый").Count() ?? 0,
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
                txtStatAllTimeClientSumPrise.Text = $"Заработано: {_statistic.TotalClientsPrise:F2} ₽";
                txtStatAllTimeClientWorkDays.Text = $"Количество рабочих дней: {_statistic.TotalWorkDays}";

                txtStatAllTimeClientAvrCheque.Text = $"Средний чек: {_statistic.AvgPayCheque:F2} ₽";
                txtStatAllTimeClientAvrDaylyCheque.Text = $"Средний дневной заработок: {_statistic.AvgDaylyPrise:F2} ₽";
                txtStatAllTimeClientAvrCountDayly.Text = $"Средняя дневная загрузка: {_statistic.AvgDailyLoad:F1}";

                txtStatAllTimeSourceInstagram.Text = $"Instagram: {_statistic.SourceInstagramCount}";
                txtStatAllTimeSourceTelegram.Text = $"Telegram: {_statistic.SourceTelegramCount}";
                txtStatAllTimeSourceWhatsApp.Text = $"WhatsApp: {_statistic.SourceWhatsAppCount}";

                txtStatAllTimeStatusNew.Text = $"Обращений новых клиентов: {_statistic.StatusNewClientCount}";
                txtStatAllTimeStatusRepeat.Text = $"Повторных обращений клиентов: {_statistic.StatusRepeatClientCount}";

                ShowAllYears();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Метод, который показывает все года работы
        private void ShowAllYears()
        {
            for (decimal i = yearChoose.Minimum; i <= yearChoose.Maximum; i++)
            {
                allYears += $"{i}г., ";
            }
            txtAllYears.Text = allYears;
        }

        //----------------------------------------------------------------------------------------------------------

        //СТАТИСТИКА "ЗА ГОД"
        //Метод выгрузки и отрисовки статистики "ЗА ГОД"
        private void LoadStatYear()
        {
            selectedYearForStatYear = (int)yearChoose.Value;
            var clientsInYear = _context?.Clients?
                .Where(c => c.Date.Year == selectedYearForStatYear)
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

                //для отображения информации "Ожидание"
                if ((int)yearChoose.Value == DateTime.Now.Year)
                {
                    _statistic.ExTotalClientsPrise = _statistic.AvgDaylyPrise * daysInYear;
                    _statistic.ExTotalClientsCount = _statistic.AvgDailyLoad * daysInYear;

                    exYearClientsPrise = $"(Ожидание: {_statistic.ExTotalClientsPrise:F2} ₽)";
                    exYearClientsCount = $"(Ожидание: {_statistic.ExTotalClientsCount:F0})";
                }
                else
                {
                    _statistic.ExTotalClientsPrise = null;
                    _statistic.ExTotalClientsCount = null;
                    exYearClientsPrise = String.Empty;
                    exYearClientsCount = String.Empty;
                }

                txtStatYearClientCount.Text = $"Количество обращений: {_statistic.TotalClientsCount} " + exYearClientsCount;
                txtStatYearClientSumPrise.Text = $"Заработано: {_statistic.TotalClientsPrise:F2} ₽ " + exYearClientsPrise;
                txtStatYearClientWorkDays.Text = $"Количество рабочих дней: {_statistic.TotalWorkDays}";

                txtStatYearClientAvrCheque.Text = $"Средний чек: {_statistic.AvgPayCheque:F2} ₽";
                txtStatYearClientAvrDaylyCheque.Text = $"Средний дневной заработок: {_statistic.AvgDaylyPrise:F2} ₽";
                txtStatYearClientAvrCountDayly.Text = $"Средняя дневная загрузка: {_statistic.AvgDailyLoad:F1}";

                txtStatYearSourceInstagram.Text = $"Instagram: {_statistic.SourceInstagramCount}";
                txtStatYearSourceTelegram.Text = $"Telegram: {_statistic.SourceTelegramCount}";
                txtStatYearSourceWhatsApp.Text = $"WhatsApp: {_statistic.SourceWhatsAppCount}";

                txtStatYearStatusNew.Text = $"Обращений новых клиентов: {_statistic.StatusNewClientCount}";
                txtStatYearStatusRepeat.Text = $"Повторных обращений клиентов: {_statistic.StatusRepeatClientCount}";

                bool hasDataForYear = _context?.Clients?.Any(c => c.Date.Year == selectedYearForStatYear) ?? false;

                if (!hasDataForYear)
                {
                    txtBestMonth.Text = $"Нет данных за {selectedYearForStatYear} год.";
                    return;
                }

                var productiveMonth = _context?.Clients
                    .Where(c => c.Date.Year == selectedYearForStatYear)
                    .AsEnumerable()
                    .GroupBy(c => c.Date.Month)
                    .Select(g => new
                    {
                        MonthNumber = g.Key,
                        MonthName = new DateTime(selectedYearForStatYear, g.Key, 1).ToString("MMMM", new CultureInfo("ru-RU")),
                        TotalPrise = g.Sum(c => (double)c.Prise!),
                        Count = g.Count()
                    })
                    .OrderByDescending(x => x.TotalPrise)
                    .FirstOrDefault();
                if (productiveMonth != null)
                {

                    txtBestMonth.Text = $"Месяц: {productiveMonth.MonthName.ToUpper()} ({selectedYearForStatYear}){Environment.NewLine}" +
                        $"Заработано: {productiveMonth.TotalPrise:F2} ₽{Environment.NewLine}" +
                        $"Количество обращений: {productiveMonth.Count}";
                }
                else
                {
                    txtBestMonth.Text = "Нет данных за выбранный год...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Метод обновления свойств класса StatisticYear для статистики "ЗА ГОД"
        private void UpdateStatisticsYear()
        {
            selectedYearForStatYear = (int)yearChoose.Value;
            var clientsInYear = _context?.Clients?.Where(c => c.Date.Year == selectedYearForStatYear).ToList();

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

            //для отображения информации "Ожидание"
            if ((int)yearChoose.Value == DateTime.Now.Year)
            {
                _statistic.ExTotalClientsPrise = _statistic.AvgDaylyPrise * daysInYear;
                _statistic.ExTotalClientsCount = _statistic.AvgDailyLoad * daysInYear;

                exYearClientsPrise = $"(Ожидание: {_statistic.ExTotalClientsPrise:F2} ₽)";
                exYearClientsCount = $"(Ожидание: {_statistic.ExTotalClientsCount:F0})";
            }
            else
            {
                _statistic.ExTotalClientsPrise = null;
                _statistic.ExTotalClientsCount = null;
                exYearClientsPrise = String.Empty;
                exYearClientsCount = String.Empty;
            }
        }

        //Метод обновления тектовых полей для статистики "ЗА ГОД"
        private void UpdateTextBoxesForStatisticYear()
        {
            txtStatYearClientCount.Text = $"Количество обращений: {_statistic?.TotalClientsCount} " + exYearClientsCount;
            txtStatYearClientSumPrise.Text = $"Заработано: {_statistic?.TotalClientsPrise:F2} ₽ " + exYearClientsPrise;
            txtStatYearClientWorkDays.Text = $"Количество рабочих дней: {_statistic?.TotalWorkDays}";
            txtStatYearSourceInstagram.Text = $"Instagram: {_statistic?.SourceInstagramCount}";
            txtStatYearSourceTelegram.Text = $"Telegram: {_statistic?.SourceTelegramCount}";
            txtStatYearSourceWhatsApp.Text = $"WhatsApp: {_statistic?.SourceWhatsAppCount}";
            txtStatYearStatusNew.Text = $"Обращений новых клиентов: {_statistic?.StatusNewClientCount}";
            txtStatYearStatusRepeat.Text = $"Повторных обращений клиентов: {_statistic?.StatusRepeatClientCount}";
            txtStatYearClientAvrDaylyCheque.Text = $"Средний дневной заработок: {_statistic?.AvgDaylyPrise:F2} ₽";
            txtStatYearClientAvrCheque.Text = $"Средний чек: {_statistic?.AvgPayCheque:F2} ₽";
            txtStatYearClientAvrCountDayly.Text = $"Средняя дневная загрузка: {_statistic?.AvgDailyLoad:F1}";

            bool hasDataForYear = _context?.Clients?.Any(c => c.Date.Year == selectedYearForStatYear) ?? false;

            if (!hasDataForYear)
            {
                txtBestMonth.Text = $"Нет данных за {selectedYearForStatYear} год.";
                return;
            }

            var productiveMonth = _context?.Clients
                .Where(c => c.Date.Year == selectedYearForStatYear)
                .AsEnumerable()
                .GroupBy(c => c.Date.Month)
                .Select(g => new
                {
                    MonthNumber = g.Key,
                    MonthName = new DateTime(selectedYearForStatYear, g.Key, 1).ToString("MMMM", new CultureInfo("ru-RU")),
                    TotalPrise = g.Sum(c => (double)c.Prise!),
                    Count = g.Count()
                })
                .OrderByDescending(x => x.TotalPrise)
                .FirstOrDefault();
            if (productiveMonth != null)
            {

                txtBestMonth.Text = $"Месяц: {productiveMonth.MonthName.ToUpper()} ({selectedYearForStatYear}){Environment.NewLine}" +
                    $"Заработано: {productiveMonth.TotalPrise:F2} ₽{Environment.NewLine}" +
                    $"Количество обращений: {productiveMonth.Count}";
            }
            else
            {
                txtBestMonth.Text = "Нет данных за выбранный год...";
            }
        }
        //----------------------------------------------------------------------------------------------------------

        //СТАТИСТИКА "ЗА МЕСЯЦ"
        //Метод выгрузки и отрисовки статистики "ЗА МЕСЯЦ"
        private void LoadStatMonth()
        {
            var clientsInMonth = _context?.Clients?
            .Where(c => c.Date.Year == selectedYear &&
                        c.Date.Month == selectedMonthNumber)
            .ToList();
            try
            {
                _statistic = new StatisticMonth()
                {
                    TotalClientsCount = clientsInMonth?.Count ?? 0,
                    TotalClientsPrise = clientsInMonth?.Sum(c => (decimal?)c.Prise) ?? 0,
                    TotalWorkDays = (long)(clientsInMonth?.Select(c => c.Date.Date)?.Distinct()?.Count() ?? 0),
                    SourceInstagramCount = clientsInMonth?.Count(c => c.SourceName == "Instagram") ?? 0,
                    SourceTelegramCount = clientsInMonth?.Count(c => c.SourceName == "Telegram") ?? 0,
                    SourceWhatsAppCount = clientsInMonth?.Count(c => c.SourceName == "WhatsApp") ?? 0,
                    StatusNewClientCount = clientsInMonth?.Count(c => c.Status == "Новый") ?? 0,
                    StatusRepeatClientCount = clientsInMonth?.Count(c => c.Status == "Повторный") ?? 0
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

                //для отображения информации "Ожидание"
                if (selectedMonthNumber == DateTime.Now.Month)
                {
                    _statistic.ExTotalClientsPrise = _statistic.AvgDaylyPrise * (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                    _statistic.ExTotalClientsCount = _statistic.AvgDailyLoad * (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

                    exMonthClientsPrise = $"(Ожидание: {_statistic.ExTotalClientsPrise:F2} ₽)";
                    exMonthClientsCount = $"(Ожидание: {_statistic.ExTotalClientsCount:F0})";
                }
                else
                {
                    _statistic.ExTotalClientsPrise = null;
                    _statistic.ExTotalClientsCount = null;
                    exMonthClientsPrise = String.Empty;
                    exMonthClientsCount = String.Empty;
                }

                txtStatMonthClientCount.Text = $"Количество обращений: {_statistic.TotalClientsCount} " + exMonthClientsCount;
                txtStatMonthClientSumPrise.Text = $"Заработано: {_statistic.TotalClientsPrise:F2} ₽ " + exMonthClientsPrise;
                txtStatMonthClientWorkDays.Text = $"Количество рабочих дней: {_statistic.TotalWorkDays}";

                txtStatMonthClientAvrCheque.Text = $"Средний чек: {_statistic.AvgPayCheque:F2} ₽";
                txtStatMonthClientAvrDaylyCheque.Text = $"Средний дневной заработок: {_statistic.AvgDaylyPrise:F2} ₽";
                txtStatMonthClientAvrCountDayly.Text = $"Средняя дневная загрузка: {_statistic.AvgDailyLoad:F1}";

                txtStatMonthSourceInstagram.Text = $"Instagram: {_statistic.SourceInstagramCount}";
                txtStatMonthSourceTelegram.Text = $"Telegram: {_statistic.SourceTelegramCount}";
                txtStatMonthSourceWhatsApp.Text = $"WhatsApp: {_statistic.SourceWhatsAppCount}";

                txtStatMonthStatusNew.Text = $"Обращений новых клиентов: {_statistic.StatusNewClientCount}";
                txtStatMonthStatusRepeat.Text = $"Повторных обращений клиентов: {_statistic.StatusRepeatClientCount}";


                var productiveDay = _context?.Clients
                    .Where(c => c.Date.Year == selectedYear &&
                        c.Date.Month == selectedMonthNumber)
                    .GroupBy(c => c.Date.Date)
                    .Select(g => new
                    {
                        Date = g.Key,
                        TotalPrise = g.Sum(c => (double)c.Prise!),
                        Count = g.Count(),
                        DayOfWeek = g.Key.DayOfWeek
                    })
                    .OrderByDescending(x => x.TotalPrise)
                    .FirstOrDefault();

                if (productiveDay!=null)
                {
                    var russianCulture = new CultureInfo("ru-RU");
                    string dayOfWeekName = russianCulture.DateTimeFormat.GetDayName(productiveDay.DayOfWeek);

                    txtBestDay.Text = $"Дата: {productiveDay.Date.ToShortDateString()} ({dayOfWeekName.ToUpper()}){Environment.NewLine}" +
                        $"Заработано: {productiveDay.TotalPrise:F2} ₽{Environment.NewLine}" +
                        $"Количество обращений: {productiveDay.Count}";
                }
                else
                {
                    txtBestDay.Text = "Нет данных за выбранный месяц...";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Метод обновления свойств класса StatisticMonth для статистики "ЗА МЕСЯЦ"
        private void UpdateStatisticsMonth()
        {
            var clientsInMonth = _context?.Clients?
            .Where(c => c.Date.Year == selectedYear &&
                        c.Date.Month == selectedMonthNumber)
            .ToList();

            _statistic = new StatisticMonth()
            {
                TotalClientsCount = clientsInMonth?.Count ?? 0,
                TotalClientsPrise = clientsInMonth?.Sum(c => (decimal?)c.Prise) ?? 0,
                TotalWorkDays = (long)(clientsInMonth?.Select(c => c.Date.Date)?.Distinct()?.Count() ?? 0),
                SourceInstagramCount = clientsInMonth?.Count(c => c.SourceName == "Instagram") ?? 0,
                SourceTelegramCount = clientsInMonth?.Count(c => c.SourceName == "Telegram") ?? 0,
                SourceWhatsAppCount = clientsInMonth?.Count(c => c.SourceName == "WhatsApp") ?? 0,
                StatusNewClientCount = clientsInMonth?.Count(c => c.Status == "Новый") ?? 0,
                StatusRepeatClientCount = clientsInMonth?.Count(c => c.Status == "Повторный") ?? 0
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

            //для отображения информации "Ожидание"
            if (selectedMonthNumber == DateTime.Now.Month)
            {
                _statistic.ExTotalClientsPrise = _statistic.AvgDaylyPrise * (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
                _statistic.ExTotalClientsCount = _statistic.AvgDailyLoad * (DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

                exMonthClientsPrise = $"(Ожидание: {_statistic.ExTotalClientsPrise:F2} ₽)";
                exMonthClientsCount = $"(Ожидание: {_statistic.ExTotalClientsCount:F0})";
            }
            else
            {
                _statistic.ExTotalClientsPrise = null;
                _statistic.ExTotalClientsCount = null;
                exMonthClientsPrise = String.Empty;
                exMonthClientsCount = String.Empty;
            }
        }

        //Метод обновления тектовых полей для статистики "ЗА МЕСЯЦ"
        private void UpdateTextBoxesForStatisticMonth()
        {
            txtStatMonthClientCount.Text = $"Количество обращений: {_statistic?.TotalClientsCount} " + exMonthClientsCount;
            txtStatMonthClientSumPrise.Text = $"Заработано: {_statistic?.TotalClientsPrise:F2} ₽ " + exMonthClientsPrise;
            txtStatMonthClientWorkDays.Text = $"Количество рабочих дней: {_statistic?.TotalWorkDays}";

            txtStatMonthClientAvrCheque.Text = $"Средний чек: {_statistic?.AvgPayCheque:F2} ₽";
            txtStatMonthClientAvrDaylyCheque.Text = $"Средний дневной заработок: {_statistic?.AvgDaylyPrise:F2} ₽";
            txtStatMonthClientAvrCountDayly.Text = $"Средняя дневная загрузка: {_statistic?.AvgDailyLoad:F1}";

            txtStatMonthSourceInstagram.Text = $"Instagram: {_statistic?.SourceInstagramCount}";
            txtStatMonthSourceTelegram.Text = $"Telegram: {_statistic?.SourceTelegramCount}";
            txtStatMonthSourceWhatsApp.Text = $"WhatsApp: {_statistic?.SourceWhatsAppCount}";

            txtStatMonthStatusNew.Text = $"Обращений новых клиентов: {_statistic?.StatusNewClientCount}";
            txtStatMonthStatusRepeat.Text = $"Повторных обращений клиентов: {_statistic?.StatusRepeatClientCount}";

            var productiveDay = _context?.Clients
                    .Where(c => c.Date.Year == selectedYear &&
                        c.Date.Month == selectedMonthNumber)
                    .GroupBy(c => c.Date.Date)
                    .Select(g => new
                    {
                        Date = g.Key,
                        TotalPrise = g.Sum(c => (double)c.Prise!),
                        Count = g.Count(),
                        DayOfWeek = g.Key.DayOfWeek
                    })
                    .OrderByDescending(x => x.TotalPrise)
                    .FirstOrDefault();

            if (productiveDay != null)
            {
                var russianCulture = new CultureInfo("ru-RU");
                string dayOfWeekName = russianCulture.DateTimeFormat.GetDayName(productiveDay.DayOfWeek);

                txtBestDay.Text = $"Дата: {productiveDay.Date.ToShortDateString()} ({dayOfWeekName.ToUpper()}){Environment.NewLine}" +
                    $"Заработано: {productiveDay.TotalPrise:F2} ₽{Environment.NewLine}" +
                    $"Количество обращений: {productiveDay.Count}";
            }
            else
            {
                txtBestDay.Text = "Нет данных за выбранный месяц...";
            }
        }

        //----------------------------------------------------------------------------------------------------------

        //Метод, который делает бэкап базы данных
        private void DoBackUpDB()
        {
            string sourceDbDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "Source"));
            string sourceDbPath = Path.Combine(sourceDbDirectory, "ClientsDB.db");

            string backupFolder = @"C:\Backup";
            string backupPath = Path.Combine(backupFolder, $"ClientsDB_{DateTime.Now:yyyyMMdd_HHmmss}.db");

            try
            {
                if (!File.Exists(sourceDbPath))
                {
                    MessageBox.Show($"Исходная база данных не найдена!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Directory.CreateDirectory(backupFolder);

                if (Directory.Exists(backupFolder))
                {
                    foreach (string file in Directory.EnumerateFiles(backupFolder, "*", SearchOption.AllDirectories))
                    {
                        File.Delete(file);
                    }
                }

                File.Copy(sourceDbPath, backupPath, overwrite: true);
                MessageBox.Show($"Бэкап успешно создан: {backupPath}", "Успех",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании Backup(а): {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-------------------------------------------------------------------------------------------------------
    }
}
