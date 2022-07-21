using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoboIME_store
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            this.Text = "Lojinha RoboIME";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "barreto")
            {
                Membros Mbr = new Membros();
                Mbr.StartPosition = FormStartPosition.CenterScreen;
                Mbr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Senha incorreta!");
            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
