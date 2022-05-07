using System;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // SHOW
        {
            groupBox1.Show();
        }

        private void button2_Click(object sender, EventArgs e) // HIDE
        {
            groupBox1.Hide();
        }

        private void button3_Click(object sender, EventArgs e) // EXIT
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString("dddd, dd MMMM yyyy");
            textBox2.Text = DateTime.Now.ToString("h:mm tt");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
