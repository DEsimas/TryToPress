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
    public partial class Console : Form
    {
        public string str, oldstr;
        public Console()
        {
            InitializeComponent();
        }
private void Console_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void change()
        {
            if (oldstr != str)
            {
                label2.Text = str;
                oldstr = str;
            }
        }
    }
}
