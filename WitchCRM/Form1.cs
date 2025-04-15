using WitchCRM.Modules;

namespace WitchCRM
{
    public partial class FormMain : Form
    {
        private AppDbContext _context;
        private string? _clientStatus;
        public FormMain()
        {
            InitializeComponent();
            txtName.Focus();
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
        }

        ////
        //������ ����������
        ////

        //������ "��������"
        private void btnSave_Click(object sender, EventArgs e)
        {
            InputData();
        }

        //������� ���������
        private void rbInstagram_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInstagram.Checked)
            {
                txtInstagram.Visible = true;
                txtTelegram.Visible = false;
                txtWhatsApp.Visible = false;
            }
        }

        //������� ��������
        private void rbTelegram_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTelegram.Checked)
            {
                txtTelegram.Visible = true;
                txtWhatsApp.Visible = false;
                txtInstagram.Visible = false;
            }
        }

        //������� WHATSAPP
        private void rbWhatsApp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWhatsApp.Checked)
            {
                txtWhatsApp.Visible = true;
                txtTelegram.Visible = false;
                txtInstagram.Visible = false;
            }
        }

        //������� ������ "�����"
        private void rbNewClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNewClient.Checked)
            {
                _clientStatus = "�����";
            }
        }

        //������� ������ "���������"
        private void rbRepeatClient_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRepeatClient.Checked)
            {
                _clientStatus = "���������";
            }
        }
        //-------------------------------------------------------------------------------------------------------

        ////
        //������
        ////


        //����� ����� ������
        private void InputData()
        {
            var source = String.Empty;
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
            if (txtInstagram.Visible == true)
            {
                if (txtInstagram.Text != String.Empty)
                {
                    source = $"Instagram ({txtInstagram.Text})";
                }
                else
                {
                    source = $"Instagram ( - )";
                }
            }
            if (txtTelegram.Visible == true)
            {
                if (txtTelegram.Text != String.Empty)
                {
                    source = $"Telegram ({txtTelegram.Text})";
                }
                else
                {
                    source = $"Telegram ( - )";
                }
            }
            if (txtWhatsApp.Visible == true)
            {
                if (txtWhatsApp.Text != String.Empty)
                {
                    source = $"WhatsApp ({txtWhatsApp.Text})";
                }
                else
                {
                    source = $"WhatsApp ( - )";
                }
            }
            txtPrise.Focus();
            if (String.IsNullOrWhiteSpace(txtPrise.Text))
            {
                MessageBox.Show("���� '� ������' �� ����� ���� ������!", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!rbNewClient.Checked && !rbRepeatClient.Checked)
            {

                MessageBox.Show("�� ������ '������' �������!", "������",
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
                        Source = source,
                        Prise = prise,
                        Description = txtDescription.Text,
                        Status=_clientStatus
                    };

                    _context.Clients.Add(client);
                    _context.SaveChanges();

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

        //����� ������� �������� �����
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
            rbNewClient.Checked = false;
            rbRepeatClient.Checked = false;

            txtInstagram.Visible = false;
            txtTelegram.Visible = false;
            txtWhatsApp.Visible = false;

            txtName.Focus();
        }

        





        //-------------------------------------------------------------------------------------------------------
    }
}
