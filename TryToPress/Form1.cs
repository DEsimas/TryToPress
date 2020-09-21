using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryToPress
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Console console = new Console();
        private int x, y,size_x = 1300,size_y = 700, a = 1;
        private string str = "Console\n";
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Читер!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            console.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            console.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            size_x = 650;
            size_y = 350;
            this.Width = 650;
            this.Height = 350;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            size_x = 325;
            size_y = 175;
            this.Width = 325;
            this.Height = 175;
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            x = rand.Next(1,size_x);
            y = rand.Next(1,size_y);
            str += a + ".X." + x +" Y." + y + "\n";
            a += 1;
            console.str = this.str;
            console.change();
            button.Location = new Point(x, y);
        }
    }
}
