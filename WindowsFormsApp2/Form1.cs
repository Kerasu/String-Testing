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
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string firstName;
            string messageText;
            string copyText;

            messageText = "Your name is: ";

            firstName = textBox1.Text;

            copyText = takeText.Text;

            TextMessage.Text = messageText + firstName;
            takeText.Text = messageText + firstName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
    }
}
