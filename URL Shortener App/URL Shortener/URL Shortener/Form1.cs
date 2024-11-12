namespace URL_Shortener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ������� �� ����������� �� URL ���� TinyURL API
        private string ShrinkURL(string strURL)
        {
            // ��������� �� ������ API URL � ������� URL
            string URL = "http://tinyurl.com/api-create.php?url=" + strURL.ToLower();

            // ����� �� ��������� �� ������ �� TinyURL API
            System.Net.HttpWebRequest objWebRequest;
            System.Net.HttpWebResponse objWebResponse;

            // ����� �� ��������� �� ������� �� API
            System.IO.StreamReader srReader;
            string strHTML;

            // ��������� � ������������� �� GET ������
            objWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(URL);
            objWebRequest.Method = "GET";

            // ��������� �� �������� � ���������� �� �������
            objWebResponse = (System.Net.HttpWebResponse)objWebRequest.GetResponse();
            srReader = new System.IO.StreamReader(objWebResponse.GetResponseStream());

            // ������ �� ������� �� API, ����� ������� ���������� URL
            strHTML = srReader.ReadToEnd();

            // ��������� �� ��������� �� ������ � �������
            srReader.Close();
            objWebResponse.Close();
            objWebRequest.Abort();

            // ������� �� ���������� URL
            return strHTML;
        }

        // ������� ��� ��������� �� button1, ����� ��������� URL �� txtURL � ������� ��������� � txtOutput
        private void button1_Click(object sender, EventArgs e)
        {
            // �������� �� 1 �������
            System.Threading.Thread.Sleep(1000);

            // ��������� �� ShrinkURL � ��������� �� ��������� � txtOutput
            txtOutput.Text = ShrinkURL(txtURL.Text);
            txtURL.Text = ""; // ���������� �� �������� ����
        }

        // ������� ��� ��������� �� button2, ����� ������ ���������� URL �� txtOutput � ���������
        private void button2_Click(object sender, EventArgs e)
        {
            // �������� �� ������ �� txtOutput � ���������
            Clipboard.SetText(txtOutput.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
