namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SendMessage()
        {
            string msg = textmessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(msg))
                return;

            string time = DateTime.Now.ToString("HH:mm:ss");

            listBoxchat.Items.Add($"[{time}] {msg}");

            lblCount.Text = $"현재 대화: {listBoxchat.Items.Count}개";

            textmessage.Clear();
            textmessage.Focus();
        
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void listBoxchat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textmessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();

                // 엔터 입력 소리/줄바꿈 방지
                e.SuppressKeyPress = true;
            }
        }
    }
}