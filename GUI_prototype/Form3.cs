using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI_prototype
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            Form1 newWindow = new Form1();

            newWindow.Show();
            this.Hide();
        }

        private void ArtistButton_Click(object sender, EventArgs e)
        {
            Form1 newWindow = new Form1();

            newWindow.Show();
            this.Hide();
        }
    }
}
