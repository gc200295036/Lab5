using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5___password_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     // If/Else statement used so that my login message will change notifications depending on if the email + password are correct or incorrect//
        private void button1_Click(object sender, EventArgs e)
        {
            if ( emailInput.Text == "nick brazda" && passwordInput.Text == "password123" )
            {
              loginMessage1.Text = "Password accepted. Please continue";
            }
           else 
            {
                 loginMessage1.Text = "Incorrect password. Please try again.";
            }
            //CREATED BY: NICK BRAZDA - SIMPLE PASSWORD NOTIFICATION 
            //Last Updated on Saturday November 17, 2018
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
