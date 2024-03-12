using Newtonsoft.Json;
using System.Text;

namespace ChatGPT_Copilot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;
        }


        //GerTrnanslate
        private void button3_Click(object sender, EventArgs e)
        {


            label1.Text = "Copilot-Anwendung";
            label2.Text = "Geben Sie Ihre Frage ein:";
            label3.Text = "Antwort :";
            button1.Text = "Antwort";

            tabPage1.Text = "Suchen";
            tabPage2.Text = "Datenbank";

            button2.Enabled = true;
            button3.Enabled = false;


        }


        //English Transation
        private void button2_Click(object sender, EventArgs e)
        {


            label1.Text = "Copilot Application";
            label2.Text = "Enter Your Question:";
            label3.Text = "Answer :";
            button1.Text = "Reply";

            tabPage1.Text = "Search";
            tabPage2.Text = "Database";

            button2.Enabled = false;
            button3.Enabled = true;

        }


        private const string ChatGptApiKey = "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";
        private const string ChatGptEndpoint = "https://api.openai.com/v1/chat/completions";


        private void button1_Click(object sender, EventArgs e)
        {
            GPTCall();
        }


        public async void GPTCall()
        {
            string userMessage = " ";
            userMessage += richTextBox1.Text.ToString() ;
            //string userMessage = "Hello, ChatGPT!";
            if (!string.IsNullOrEmpty(userMessage))
            {



                string response = await GetChatGptResponse(userMessage);
                //AppendToChatHistory("User: " + userMessage + Environment.NewLine);
                AppendToChatResponse("Answer: " + response + Environment.NewLine);
            }
        }


        private async Task<string> GetChatGptResponse(string userMessage)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
                httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer " + ChatGptApiKey);

                var requestBody = new { model = "gpt-3.5-turbo", messages = new[] { new { role = "system", content = "You are a helpful assistant." }, new { role = "user", content = userMessage } } };
                var jsonRequest = JsonConvert.SerializeObject(requestBody);

                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");


                //var response = await httpClient.PostAsync(ChatGptEndpoint, content);
                var response = await httpClient.PostAsync("https://api.openai.com/v1/chat/completions", content);
                var responseBody = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    dynamic responseObject = JsonConvert.DeserializeObject(jsonResponse);
                    var chatGptResponse = responseObject.choices[0].message.content;
                    return chatGptResponse;
                }
                else
                {
                    // Handle API error here
                    return "Error: Unable to get a response from System.";
                }
            }
        }



        private void AppendToChatResponse(string message)
        {

            richTextBox2.AppendText(message + "\n\n");
            richTextBox2.ScrollToCaret();
        }
    }
}