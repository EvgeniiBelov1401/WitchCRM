using System.Windows.Forms;
using WitchCRM.Modules;

namespace WitchCRM
{
    public partial class FormPlanner : Form
    {
        private AppDbContext? _context;
        private string? _clientStatus = "�����";
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
        //������ ����������
        ////

        //������ "��������"
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            InputData();
            LoadClientsByDate();

            LoadStatAllTime();
        }

        //������� ���������
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
        //������� ��������
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
        //������� WHATSAPP
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
        //���������� ������ ��������� ������
        private void cbRepeatClient_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cbRepeatClient.Checked)
            {
                _clientStatus = "���������";
            }
        }

        //-------------------------------------------------------------------------------------------------------

        ////
        //������
        ////

        //����� �������������� �������� ��������� ��� �������� �����
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

        //����� ����� ������
        private void InputData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("���� '���' �� ����� ���� ������!", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rbInstagram.Checked && !rbTelegram.Checked && !rbWhatsApp.Checked)
            {
                MessageBox.Show("�� ������ '��������'", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            InputSourceData();


            if (String.IsNullOrWhiteSpace(txtPrise.Text))
            {
                MessageBox.Show("���� '� ������' �� ����� ���� ������!", "������",
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


                    MessageBox.Show("������ ������� ��������!", "�����",
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
                MessageBox.Show("� ���� '� ������' ���������� ������ ���������� ������!", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrise.Clear();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ����������: {ex.Message}", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //����� ����� ������ ��� ���������
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

        //����� ������� ������� �����
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
            _clientStatus = "�����";

            txtName.Focus();
        }

        //����� �������� ����� �� ��������� ����
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
                        lblPlannerClientCount.Text = $"��������: {clients.Count}";
                        plannerTable.Visible = true;
                    }
                    else
                    {
                        lblPlannerClientCount.Text = $"��� ������";
                        plannerTable.Visible = false;
                    }
                    var displayData = clients
                        .Select((c, index) => new
                        {
                            ���� = c.Date.ToShortDateString(),
                            ��� = c.Name,
                            ������ = c.Status,
                            �������� = c.SourceName,
                            �������� = c.SourceData,
                            �������� = c.Prise,
                            ������������� = c.Description
                        })
                        .ToList();
                    plannerTable.DataSource = displayData;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������� ������: {ex.Message}", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //����� �������� ���������� "�� ��� �����"
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
                    StatusNewClientCount=_context?.Clients?.Where(c=>c.Status=="�����").Count()??0,
                    StatusRepeatClientCount = _context?.Clients?.Where(c => c.Status == "���������").Count() ?? 0
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
                    txtStatAllTimeClientCount.Text = $"���������� ���������: {_statistic.TotalClientsCount}";
                    txtStatAllTimeClientSumPrise.Text = $"����������: {_statistic.TotalClientsPrise:F2} ���.";
                    txtStatAllTimeClientWorkDays.Text = $"���������� ������� ����: {_statistic.TotalWorkDays}";

                    txtStatAllTimeClientAvrCheque.Text = $"������� ���: {_statistic.AvgPayCheque:F0} ���.";
                    txtStatAllTimeClientAvrDaylyCheque.Text = $"������� ������� ���������: {_statistic.AvgDaylyPrise:F0} ���.";
                    txtStatAllTimeClientAvrCountDayly.Text = $"������� ������� ��������: {_statistic.AvgDailyLoad:F0}";

                    txtStatAllTimeSourceInstagram.Text = $"Instagram: {_statistic.SourceInstagramCount}";
                    txtStatAllTimeSourceTelegram.Text = $"Telegram: {_statistic.SourceTelegramCount}";
                    txtStatAllTimeSourceWhatsApp.Text = $"WhatsApp: {_statistic.SourceWhatsAppCount}";

                    txtStatAllTimeStatusNew.Text = $"��������� ����� ��������: {_statistic.StatusNewClientCount}";
                    txtStatAllTimeStatusRepeat.Text = $"��������� ��������� ��������: {_statistic.StatusRepeatClientCount}";
                }
                else
                {
                    throw new NoStatisticException();
                }
            }
            catch (NoStatisticException)
            {
                MessageBox.Show($"������ �������� ����������: ��� �� ������ ���������", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ �������� ����������: {ex.Message}", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


















        //-------------------------------------------------------------------------------------------------------
    }
}
