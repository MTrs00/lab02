using System.Text.Json;
using lab02;

namespace GUI
{
    public partial class Form1 : Form
    {
        private spaceRecord spacerecord;
        private HttpClient client;
        private peopleInSpace people;

        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            spacerecord = new spaceRecord();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string call = " http://api.open-notify.org/astros.json ";
            string response = await client.GetStringAsync(call);
            people = JsonSerializer.Deserialize<peopleInSpace>(response);
            textBox1.Text = people.ToString();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //spacerecord.PeopleInSpaces.Add(new peopleInSpace() { message = "success", number = 0 });
            //spacerecord.SaveChanges();
            //textBox2.Text = spacerecord.PeopleInSpaces.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
