namespace URL_Shortener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Функция за съкращаване на URL чрез TinyURL API
        private string ShrinkURL(string strURL)
        {
            // Създаване на пълния API URL с входния URL
            string URL = "http://tinyurl.com/api-create.php?url=" + strURL.ToLower();

            // Обект за изпращане на заявка до TinyURL API
            System.Net.HttpWebRequest objWebRequest;
            System.Net.HttpWebResponse objWebResponse;

            // Четец за извличане на отговор от API
            System.IO.StreamReader srReader;
            string strHTML;

            // Създаване и конфигуриране на GET заявка
            objWebRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(URL);
            objWebRequest.Method = "GET";

            // Изпращане на заявката и получаване на отговор
            objWebResponse = (System.Net.HttpWebResponse)objWebRequest.GetResponse();
            srReader = new System.IO.StreamReader(objWebResponse.GetResponseStream());

            // Четене на отговор от API, който съдържа съкратения URL
            strHTML = srReader.ReadToEnd();

            // Затваряне на ресурсите за четене и отговор
            srReader.Close();
            objWebResponse.Close();
            objWebRequest.Abort();

            // Връщане на съкратения URL
            return strHTML;
        }

        // Събитие при натискане на button1, което съкращава URL от txtURL и показва резултата в txtOutput
        private void button1_Click(object sender, EventArgs e)
        {
            // Забавяне за 1 секунда
            System.Threading.Thread.Sleep(1000);

            // Извикване на ShrinkURL и показване на резултата в txtOutput
            txtOutput.Text = ShrinkURL(txtURL.Text);
            txtURL.Text = ""; // Изчистване на входното поле
        }

        // Събитие при натискане на button2, което копира съкратения URL от txtOutput в клипборда
        private void button2_Click(object sender, EventArgs e)
        {
            // Копиране на текста от txtOutput в клипборда
            Clipboard.SetText(txtOutput.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
