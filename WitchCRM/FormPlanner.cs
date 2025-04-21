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
            LoadOptions();
            LoadClientsByDate();

            LoadStatAllTime();
        }


        ////
        //Органы управления
        ////

        //КНОПКА "ЗАПИСАТЬ"
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            InputData();
            LoadClientsByDate();

            LoadStatAllTime();
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
            plannerDate.ValueChanged += (s, e) => LoadClientsByDate();

            plannerTable.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            plannerTable.AllowUserToAddRows = false;
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

        //Метод загрузки статистики "ЗА ВСЕ ВРЕМЯ"
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


                if (_statistic.TotalClientsCount != 0)
                {
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
                else
                {
                    throw new NoStatisticException();
                }
            }
            catch (NoStatisticException)
            {
                MessageBox.Show($"Ошибка загрузки статистики: нет ни одного обращения", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


















        //-------------------------------------------------------------------------------------------------------
    }
}
