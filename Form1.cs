using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer drum = new System.Media.SoundPlayer(@"D:\商務謝師夜\典禮音樂\鼓聲.wav");
        System.Media.SoundPlayer penny = new System.Media.SoundPlayer(@"D:\商務謝師夜\典禮音樂\頒獎人出場.wav");
        System.Media.SoundPlayer winner = new System.Media.SoundPlayer(@"D:\商務謝師夜\典禮音樂\金馬頒獎.wav");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            drum.Play();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            drum.Stop();
            penny.Stop();
            winner.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            penny.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            winner.Play();
        }
    }
}
