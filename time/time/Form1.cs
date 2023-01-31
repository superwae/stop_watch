using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace time
{

    public partial class Form1 : Form
    {
        double _ticks=00.00;
        int h = 0,m=0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
            button3.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
            button3.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            _ticks= _ticks+0.015;
            label5.Text = _ticks.ToString("00.00");
            if (_ticks>=60.00)
            {
                
                m++;
                label4.Text =m.ToString("00") ;
                _ticks = 0;
            }
            if(m>=60)
            {
                h++;
                label3.Text = h.ToString("00");
                m = 0;
                label4.Text = m.ToString("00");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            _ticks = 0;
            m = 0;
            h = 0;
            label3.Text = h.ToString("00");
            label4.Text = m.ToString("00");
            label5.Text = _ticks.ToString("00.00");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
    }
}
