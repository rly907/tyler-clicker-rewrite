using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tyler_rewrite
{
    public partial class Form1 : Form
    {

        int score = 0;
        int mult = 1;
        int multPrice = 10;
        int auto = 0;
        int autoPrice = 20;
        int skinPrice = 100;
        Random rand = new Random();
        int generated = 0;
        int picked = 0;
        int clickCount = 2;
        bool rebirth = false;

        int skin = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<int, string> websiteUrls = new Dictionary<int, string>()
        {
            { 0, "https://www.youtube-nocookie.com/embed/8kGRtHafKJA?playlist=8kGRtHafKJA&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 1, "https://www.youtube-nocookie.com/embed/raFX6zoKH44?playlist=raFX6zoKH44&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 2, "https://www.youtube-nocookie.com/embed/4sEcfGHc5QE?playlist=4sEcfGHc5QE&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 3, "https://www.youtube-nocookie.com/embed/smpbjV1uIt4?playlist=smpbjV1uIt4&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 4, "https://www.youtube-nocookie.com/embed/epjtyXfFOc0?playlist=epjtyXfFOc0&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 5, "https://www.youtube-nocookie.com/embed/Oy9SkqUDCl4?playlist=Oy9SkqUDCl4&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 6, "https://www.youtube-nocookie.com/embed/5HK4JCTmQI4?playlist=5HK4JCTmQI4&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 7, "https://www.youtube-nocookie.com/embed/DRhiNWu0jF8?playlist=DRhiNWu0jF8&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 8, "https://www.youtube-nocookie.com/embed/nb__56mzgKw?playlist=nb__56mzgKw&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 9, "https://www.youtube-nocookie.com/embed/1J6VVBoKtVk?playlist=1J6VVBoKtVk&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 10,"https://www.youtube-nocookie.com/embed/w9sSw3oIhO8?playlist=w9sSw3oIhO8&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 11, "https://www.youtube-nocookie.com/embed/bAN3KmTSy2Q?playlist=bAN3KmTSy2Q&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 12, "https://www.youtube-nocookie.com/embed/cbF_HMIOhRU?playlist=cbF_HMIOhRU&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 13, "https://www.youtube-nocookie.com/embed/TQHEJj68Jew?list=PLJ-qODNIUEEtPdKZNLfbx7JOuRA_JjUxI&autoplay=1&iv_load_policy=3&loop=1&start=" },
            { 14, "https://www.google.com/" },
        };


        private Dictionary<int, string> skins = new Dictionary<int, string>()
        {
            { 0, "" },
            { 1, "" },
            { 2, "" },
            { 3, "" },
            { 4, "" },
            { 5, "" },
            { 6, "" },
            { 7, "" },
            { 8, "" },
            { 9, "" },
            { 10,"" },
            { 11, "" },
            { 12, "" },
            { 13, "" },
            { 14, "" },
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1 second
            timer1.Tick += timer1_Tick;
            timer1.Start();
            skinPick.Items.Add("Skin 1");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            score = score + auto;
            if (rebirth == true)
            {
                score = score * 2;
            }
            labelScore.Text = score.ToString();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            score = score + (1 * mult);
            labelScore.Text = score.ToString();
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            if (score >= multPrice)
            {
                score = score - multPrice;
                multPrice = multPrice * 2;
                labelScore.Text = score.ToString();
                multBtn.Text = "Power - " + multPrice.ToString();
                mult++;
                multLbl.Text = mult.ToString();
            }
        }

        private void autoBtn_Click(object sender, EventArgs e)
        {
            if (score >= autoPrice)
            {
                score = score - autoPrice;
                autoPrice = autoPrice * 3;
                labelScore.Text = score.ToString();
                autoBtn.Text = "Auto - " + autoPrice.ToString();
                auto++;
                autoLbl.Text = auto.ToString();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (websiteUrls.ContainsKey(selectedIndex))
            {
                webView21.Source = new Uri(websiteUrls[selectedIndex]);
            }
        }

        private void gambleBtn_Click(object sender, EventArgs e)
        {
            generated = rand.Next(0, 4);
            picked = trackBar1.Value;
            if (generated == picked)
            {
                score = score * 3;
            }
            else
            {
                score = 0;
            }
            labelScore.Text = score.ToString();
        }

        private void skinBtn_Click(object sender, EventArgs e)
        {
            if (score >= skinPrice)
            {
                score = score - skinPrice;
                skinPrice = skinPrice + 100;
                labelScore.Text = score.ToString();
                skinLbl.Text = skinPrice.ToString();
                AddSkin();
            }
        }
        private void AddSkin()
        {
            string newOption = "Skin " + clickCount;

            skinPick.Items.Add(newOption);

            clickCount++;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (score >= 10000)
            {
                score = score - 10000;
                rebirth = true;
                label1.Text = "✔";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (score >= 10000)
            {
                score = score - 10000;
                rebirth = true;
                label1.Text = "✔";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = score * 10;
            labelScore.Text = score.ToString();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            //score = score * 10;
            //labelScore.Text = score.ToString();
        }
    }
}
