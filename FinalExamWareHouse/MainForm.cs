using Newtonsoft.Json;

namespace FinalExamWareHouse
{
    public partial class MainForm : Form
    {

        ListViewItem lsttemp = new ListViewItem();

        public static User user = new User();

        public static Order order = new Order();

        public static Product product = new Product();



        private HttpClient _httpClient;
        public MainForm()
        {
            InitializeComponent();
            mainpanel.Show();
            this.Height = 500;
            this.Width = 858;
            clientpanel.Hide();
            ProductPanel.Hide();
            OrderPanel.Hide();
            OrderPanel.Dock = DockStyle.Fill;
            mainpanel.Dock = DockStyle.Fill;
            clientpanel.Dock = DockStyle.Fill;
            ProductPanel.Dock = DockStyle.Fill;
            Filterlabel.Visible = false;
            filtertextBox.Visible = false;
            OrderPanel.Size = new Size(600, 600);
            ProductPanel.Size = new Size(600, 600);
            clientpanel.Size = new Size(600, 600);
            mainmenuStrip.Visible = false;
        }

        private async void signinbtn_Click(object sender, EventArgs e)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost:5194"); // Замените на URL вашего API

            try
            {
                // Выполняем GET-запрос к API
                HttpResponseMessage response = await _httpClient.GetAsync("api/User");

                // Проверяем, успешен ли ответ
                if (response.IsSuccessStatusCode)
                {
                    // Читаем ответ как строку
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // Десериализуем строку в список пользователей
                    var users = JsonConvert.DeserializeObject<List<User>>(responseContent);

                    // Далее вы можете использовать список пользователей в вашем Windows Forms приложении
                }
                else
                {
                    MessageBox.Show("Ошибка при выполнении запроса: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message);
            }
        }
    }
}