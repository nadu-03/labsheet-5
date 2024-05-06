
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //Check if password and confirm password match
            if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Check if any field is empty
            if (String.IsNullOrEmpty(fnTextBox.Text) ||
                String.IsNullOrEmpty(LnTextBox.Text) ||
                String.IsNullOrEmpty(Dob.Text) ||
                String.IsNullOrEmpty(EmailTextBox.Text) ||
                String.IsNullOrEmpty(UsernameTextBox.Text) ||
                String.IsNullOrEmpty(PasswordTextBox.Text) ||
                String.IsNullOrEmpty(ConfirmPasswordTextBox.Text)
                )
            {
                MessageBox.Show("Please Fill in all fields", "Error");
                return;
            }
            //create object and pass user information
            HomePage userInfo = new HomePage($"{fnTextBox.Text}{LnTextBox.Text}",
            UsernameTextBox.Text,//pass username
            EmailTextBox.Text//pass email);
            );

            //Link with Homepage
            userInfo.Show();
            this.Hide();

        }

        //Method to check if a given text is a string
        private bool IsString(String text)
        {
            //check if all characters in the text are letters 
            return !string.IsNullOrEmpty(text) && text.All(char.IsLetter);
        }

        private void Reset_Click_Click(object sender, EventArgs e)
        {
            //Clear the text all textboxes when the "Reset" button is clicked
            fnTextBox.Text = "";
            LnTextBox.Text = "";
            Dob.Text = "";
            EmailTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";


        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}