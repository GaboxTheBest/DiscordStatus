using System;
using System.Windows.Forms;
using DiscordRPC;

namespace Discord_Status
{
    public partial class Form1 : Form
    {
        public DiscordRpcClient client;
        public Form1()
        {
            //Aca pone toda la informacion para que ande
            InitializeComponent();
            client = new DiscordRpcClient("901623467508637736");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = "Discord Status",
                State = "Discord Status",
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    SmallImageKey = "logo",
                    SmallImageText = "By Gabox"
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void x(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form github = new Form2();
            github.Show();
        }
    }
}
