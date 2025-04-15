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
        //Органы управления
        ////

        //КНОПКА "ЗАПИСАТЬ"
        private void btnSave_Click(object sender, EventArgs e)
        {
            InputData();
        }
        //-------------------------------------------------------------------------------------------------------

        ////
        //Методы
        ////

        
        //Метод ввода данных
        private void InputData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Поле имени не может быть пустым!", "Ошибка",
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

                MessageBox.Show("Клиент успешно сохранен!", "Успех",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Clear();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //-------------------------------------------------------------------------------------------------------
    }
}
