using WitchCRM.Modules;

namespace WitchCRM
{
    public partial class FormPlanner : Form
    {
        private AppDbContext? _context;
        private string? _clientStatus = "Новый";
        private string _sourceName = String.Empty;
        private string _sourceData = String.Empty;


        public FormPlanner()
        {
            InitializeComponent();
            LoadOptions();
            LoadClientsByDate();
        }


        ////
        //Органы управления
        ////

        //КНОПКА "ЗАПИСАТЬ"
        private void btnSave_Click(object sender, EventArgs e)
        {
            InputData();
            LoadClientsByDate();
        }

        //ВЫБРАТЬ ИНСТАГРАМ
        private void rbInstagram_CheckedChanged(object sender, EventArgs e)
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
        private void rbTelegram_CheckedChanged(object sender, EventArgs e)
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
        private void rbWhatsApp_CheckedChanged(object sender, EventArgs e)
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
        private void cbRepeatClient_CheckedChanged(object sender, EventArgs e)
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

        





        //-------------------------------------------------------------------------------------------------------
    }
}
