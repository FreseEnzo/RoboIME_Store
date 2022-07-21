using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RoboIME_store
{
     
    public partial class Login : Form
    {
        public Login()
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Lojinha RoboIME";
        }
        public static string MemberName = "";
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Membros Mbr = new Membros();
            Mbr.StartPosition = FormStartPosition.CenterScreen;
            Mbr.Show();
            this.Hide();
             
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\enzog\source\repos\RoboIME_store\RoboStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select count(*) from MembrosTbl where MbrNome='" + UserName.Text + "' and MbrSenha='" + Senha.Text + "';";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MemberName = UserName.Text;
                Billing Obj = new Billing();
                Obj.StartPosition = FormStartPosition.CenterScreen;
                Obj.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos!");
                Con.Close();
            }   
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void admBtn_Click(object sender, EventArgs e)
        {
            AdminLogin adm = new AdminLogin();
            adm.StartPosition = FormStartPosition.CenterScreen;
            adm.Show();
            this.Hide();
        }
    }
}
