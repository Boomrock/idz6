using System;
using System.Windows.Forms;

namespace idz6
{
    public partial class Form1 : Form
    {

        private string DefaultString, ResultString;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DefaultString = textBox1.Text;
            ResultString = "";
            int i = 0,
                n = 0;
            do
            {
                if (DefaultString[i] == ' ')
                {
                    
                    ResultString += DefaultString[i];
                    i++;
                }
                else
                {

                    ResultString += DefaultString[i];
                }
                i++;
            } while (i < DefaultString.Length);
            textBox1.Text = ResultString;
        }
    }
}
