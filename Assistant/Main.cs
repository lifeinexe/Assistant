using Assistant_v1;
using Microsoft.Speech.Recognition;
using Microsoft.Speech.Synthesis;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assistant_v1.TempInfo;

namespace Assistant
{

    public partial class Main : Form
    {
       
        public Main()
        {
            InitializeComponent();
        }


        static SpeechSynthesizer Elena = new SpeechSynthesizer();
        static Label l;
        static string tempOmsk = String.Empty;

        public static async Task ConnectAsync()
        {
            string url = "http://api.openweathermap.org/data/2.5/weather?q=Omsk&units=metric&appid=0bfea7c2fc5bdfa284ecf6d931ca0c38";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
            
            tempOmsk = "Погода за окном в Омске составляет" + Convert.ToInt32(weatherResponse.Main.Temp);

        }

        public void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Elena.SetOutputToDefaultAudioDevice();
            if (e.Result.Confidence > 0.7)
            {
                l.Text = e.Result.Text;

                if (l.Text == "Открой проводник")
                {
                    Process.Start("explorer");
                }

                if (l.Text == "Открой калькулятор")
                {
                    Process.Start("Calc");
                }

                if (l.Text == "Следующий слайд")
                {
                    KeyboardSend.KeyDown(Keys.Right);
                }

                if (l.Text == "Предыдущий слайд")
                {
                    KeyboardSend.KeyDown(Keys.Left);
                }

                if (l.Text == "Сколько времени")
                {
                    Elena.SpeakAsync(DateTime.Now.ToString("HH:mm"));
                }

                if (l.Text == "Открой Яндекс")
                {
                    Process.Start("https://yandex.ru/");
                }

                if (l.Text == "Открой Гугл")
                {
                    Process.Start("https://google.ru/");
                }

                if (l.Text == "Открой Ютуб")
                {
                    Process.Start("https://youtube.com/");
                }

                if (l.Text == "Спасибо")
                {
                    Elena.SpeakAsync("Всегда пожалуйста");
                }

                if (l.Text == "Привет")
                {
                    Elena.SpeakAsync("Здравствуйте! Чем могу помочь?");
                }

                if (l.Text == "Пока")
                {
                    Elena.SpeakAsync("Всего доброго!");
                    Thread.Sleep(1500);
                    Application.Exit();
                }

                if (l.Text == "Какая погода за окном")
                {
                    ConnectAsync();
                    Elena.SpeakAsync(tempOmsk.ToString() + "градусов");
                    
                }

                if (l.Text == "Покажи команды")
                {
                    commandList.Items.AddRange(File.ReadAllLines(Environment.CurrentDirectory + @"\commands.txt"));
                    commandList.Visible = true;
                }

                if (l.Text == "Как дела")
                {
                    Elena.SpeakAsync("Отлично, у вас как?");
                }

                if (l.Text == "Какое сегодня число")
                {
                    Elena.SpeakAsync(DateTime.Now.ToLongDateString());
                }



            }
                
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void bugReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void bugReport_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(bugReport, "Сообщить об ошибке");
        }

        private void recon()
        {
            l = label1;

            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("ru-ru");
            SpeechRecognitionEngine sre = new SpeechRecognitionEngine(ci);
            sre.SetInputToDefaultAudioDevice();

            sre.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sre_SpeechRecognized);

            Choices numbers = new Choices();
            numbers.Add(new string[] {
                "Привет",
                "Пока",
                "Как дела",
                "Покажи команды",
                "Какая погода за окном",
                "Какое сегодня число",
                "Открой проводник",
                "Открой калькулятор",
                "Следующий слайд",
                "Предыдущий слайд",
                "Спасибо",
                "Сколько времени",
                "Открой Яндекс",
                "Открой Гугл",
                "Открой Ютуб"
            });

            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = ci;
            gb.Append(numbers);


            Grammar g = new Grammar(gb);
            sre.LoadGrammarAsync(g);

            sre.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\tenor.gif";
            pictureBox1.LoadAsync();
            recon();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = Environment.CurrentDirectory + @"\tenor.gif";
            pictureBox1.LoadAsync();
            recon();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
