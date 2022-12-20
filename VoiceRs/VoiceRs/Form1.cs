using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using System.IO;


namespace VoiceRs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += new EventHandler(button1_Click);
            

            foreach (InstalledVoice voice in sSynth.GetInstalledVoices())
            {
                Console.WriteLine(voice.VoiceInfo.Name);
            }
        }
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        PromptBuilder pBuilder = new PromptBuilder();
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(textBox1.Text);
            sSynth.SelectVoice("IVONA 2 Penélope");
            sSynth.SpeakAsync(pBuilder);
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
