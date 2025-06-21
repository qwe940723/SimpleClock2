using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;           
using System.IO;             


namespace SimpleClock2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboboxInitialzation();  

            timerClcok.Start();      
        }
        List<string> hours = new List<string>();           
        List<string> minutes = new List<string>();          

        string strSelectTime = "";                         

        private WaveOutEvent waveOut;                       
        private AudioFileReader audioFileReader;
        private void comboboxInitialzation()
        {
           
            for (int i = 0; i <= 23; i++)
                cmbHour.Items.Add(string.Format("{0:00}", i));
            cmbHour.SelectedIndex = 0;

           
            for (int i = 0; i <= 59; i++)
                cmbMin.Items.Add(string.Format("{0:00}", i));
            cmbMin.SelectedIndex = 0;
        }

        private void timerClcok_Tick(object sender, EventArgs e)
        {

        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {

        }
    }
}
