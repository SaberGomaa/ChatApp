using Microsoft.AspNet.SignalR.Client;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace ChatApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IHubProxy _proxy;
        private void Form1_Load(object sender, EventArgs e)
        {
            HubConnection con = new HubConnection("https://localhost:44393/");
            _proxy = con.CreateHubProxy("chat");
            con.Start();
            list_msg.Items.Add("Name    MessageContent   date");


            // Subscriber Methods
            _proxy.On<message>("newMessage", (m) => list_msg.Invoke(new Action(() => //use deleget to subscribe 
            list_msg.Items.Add(m.Name + " " + m.MessageContent + " " + m.Date.Hour + ":" + m.Date.Minute))));
            //list_msg.Items.Add(m.Name+" "+ m.MessageContent+" "+ m.Date.Hour+":"+m.Date.Minute));

            _proxy.On<string, string>("newMember", ( name, groupName) => list_msg.Invoke(new Action(() => //use deleget to subscribe 
            list_msg.Items.Add(name + " Joined To Group" + groupName))));

            _proxy.On<string, string, string>("sendMessage", (name, message, groupName ) => list_msg.Invoke(new Action(() => //use deleget to subscribe 
            list_msg.Items.Add(name + " Send Message " + message + " To Group" + groupName))));

        }
        private void btn_send_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("sendMessage", new message()
            {
                Name = txt_name.Text,
                Date = DateTime.Now,
                MessageContent = txt_msg.Text
            });
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("joinGroup", txt_grp.Text, txt_name.Text);

        }

        private void btn_send_grp_Click(object sender, EventArgs e)
        {
            _proxy.Invoke("sendGroupMessage", txt_grp.Text, txt_msg.Text, txt_name.Text);
        }
    }
}