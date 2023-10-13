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
            _httpClient.BaseAddress = new Uri("http://localhost:5194"); // �������� �� URL ������ API

            try
            {
                // ��������� GET-������ � API
                HttpResponseMessage response = await _httpClient.GetAsync("api/User");

                // ���������, ������� �� �����
                if (response.IsSuccessStatusCode)
                {
                    // ������ ����� ��� ������
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // ������������� ������ � ������ �������������
                    var users = JsonConvert.DeserializeObject<List<User>>(responseContent);

                    // ����� �� ������ ������������ ������ ������������� � ����� Windows Forms ����������
                }
                else
                {
                    MessageBox.Show("������ ��� ���������� �������: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������: " + ex.Message);
            }
        }
    }
}