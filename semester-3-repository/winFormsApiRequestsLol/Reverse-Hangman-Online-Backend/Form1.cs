using System.Net.Http.Headers;

namespace Reverse_Hangman_Online_Backend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            client.BaseAddress = new Uri("http://localhost:8080/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        static HttpClient client = new HttpClient();

        private async void BTN_GET_Click(object sender, EventArgs e)
        {
            var response = await client.GetStringAsync("app/ping");
            MessageBox.Show(response.ToString());
        }

        private async void BTN_POST_Click(object sender, EventArgs e)
        {
            string word = "help";
            var response = await client.PostAsJsonAsync("word/check", word);
            MessageBox.Show(response.ToString());
        }
    }
}