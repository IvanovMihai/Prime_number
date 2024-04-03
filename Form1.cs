using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prime_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isPrime = true;
            bool isNumber=Int32.TryParse(PrimeNumberTextBox.Text, out result);
            if(isNumber)
            {
                for (int i = 2; i < result/2; i++) 
                {
                    if (result%i == 0)
                    {
                        isPrime = false;
                    }
                }
                if (isPrime)
                {
                    this.BackColor = Color.Green;
                }
                else
                {
                    this.BackColor = Color.Red;
                }
            }
            else
            {
                this.BackColor = Color.Yellow;
                MessageBox.Show("S-a introdus un text!");
                PrimeNumberTextBox.Text = "";
            }
        }


    }
}
