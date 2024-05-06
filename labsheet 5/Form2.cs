
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
    public partial class HomePage : Form
    {
        public HomePage(string fullname, string username, string email)
        {
            InitializeComponent();

            //dispaly user information  
            NameLabel.Text = $"Name:{fullname}";
            UsernameLabel.Text = $"Username:{username}";
            EmailLabel.Text = $"Email:{email}";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
