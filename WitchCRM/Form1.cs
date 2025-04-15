using WitchCRM.Modules;

namespace WitchCRM
{
    public partial class Form1 : Form
    {
        private AppDbContext _context;
        public Form1()
        {
            InitializeComponent();
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
        //-------------------------------------------------------------------------------------------------------

        ////
        //������
        ////

        
        //����� ����� ������
        private void InputData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("���� ����� �� ����� ���� ������!", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var client = new Client
                {
                    Name = txtName.Text,
                    Date = dateTimePicker.Value
                };

                _context.Clients.Add(client);
                _context.SaveChanges();

                MessageBox.Show("������ ������� ��������!", "�����",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Clear();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������ ��� ����������: {ex.Message}", "������",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //-------------------------------------------------------------------------------------------------------
    }
}
