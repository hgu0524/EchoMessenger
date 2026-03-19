namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            // 1. 입력값 가져오기
            string msg = textmessage.Text;

            // 2. 리스트박스에 추가
            listBoxchat.Items.Add(msg);

            // 3. 입력창 비우기
            textmessage.Clear();
        }
    }
}
