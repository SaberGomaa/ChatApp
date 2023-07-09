using Microsoft.AspNet.SignalR.Client;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HubConnection con = new HubConnection("https://localhost:44393/");
            IHubProxy _proxy = con.CreateHubProxy("chat");
            con.Start();
            list_msg.Items.Add("Name    MessageContent   date");

            _proxy.On<message>("newMessage", (m) =>
            list_msg.Items.Add(m.Name+" "+ m.MessageContent+" "+ m.Date.Hour+":"+m.Date.Minute));
        }
    }
}