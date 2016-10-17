using System;
using System.Windows.Forms;

namespace _2016002627_Lab_2
{
    public partial class Form1 : Form
    {
        DateTime Date = DateTime.Today;
       

        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime Birthdate = monthCalendar1.SelectionStart;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Birthdate = monthCalendar1.SelectionStart;             //calls inputed data from the monthcalender to calculate the howw many days a person has
            int age = (int)((DateTime.Now - Birthdate).TotalDays);          //been alive for since the date of there birth
            Daysold.Text = age.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
