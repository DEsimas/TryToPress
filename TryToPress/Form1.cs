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
        private string str = "Console\n";
        int size_x, size_y, x, y, counter;
        public Form1()
        {
            InitializeComponent();
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
            size_x = Int32.Parse(width.Text);
            size_y = Int32.Parse(height.Text);
            this.Width = size_x;
            this.Height = size_y;
            this.Location = new Point(0, 0);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            console.Show();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            x = rand.Next(1,size_x - button1.Width - 100);
            y = rand.Next(1,size_y - button1.Height - 100);
            str += ++counter + ".X." + x +" Y." + y + "\n";
            console.str = this.str;
            console.change();
            button.Location = new Point(x, y);
        }
    }
}
