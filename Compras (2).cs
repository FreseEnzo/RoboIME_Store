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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
            atualizarTbl();
            this.Text = "Lojinha RoboIME";
        }
        public void clearInfo()
        {
            ItemNome.Text = "";
            ItemQte.Text = "";
            ItemPreço.Text = "";
        }
            SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\enzog\source\repos\RoboIME_store\RoboStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void atualizarTbl()
        {
            string query = "select * from ItemTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new RoboStoreDBDataSet();
            sda.Fill(ds);
            ItensData.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (ItemNome.Text == "" || ItemQte.Text == "" || ItemPreço.Text == "")
            {
                MessageBox.Show("Erro, falta dados");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ItemTbl values('" + ItemNome.Text + "','" + ItemQte.Text +"','"+ float.Parse(ItemPreço.Text) +"')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Adicionado!");
                    Con.Close();
                    atualizarTbl();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0; 
        
        private void ApagarBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selecione o ITEM a ser deletado");
            }
            else
            {
                var result = MessageBox.Show("Deseja REMOVER item adicionado?", "Form Closing",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                { 
                    try
                    {
                        Con.Open();
                        string query = "Delete from ItemTbl where ItID =" + Key + ";";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item Deletado!");
                        Con.Close();
                        atualizarTbl();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
            }
            }
        }

        private void ItemData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ItensData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNome.Text = ItensData.SelectedRows[0].Cells[1].Value.ToString();
            ItemQte.Text = ItensData.SelectedRows[0].Cells[2].Value.ToString();
            ItemPreço.Text= ItensData.SelectedRows[0].Cells[3].Value.ToString();
            if (ItemNome.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ItensData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void ItemNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearInfo();
        }

        private void retBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Hist_Click(object sender, EventArgs e)
        {
            Data Hist = new Data();
            Hist.StartPosition = FormStartPosition.CenterScreen;
            Hist.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Membros Mbr = new Membros();
            Mbr.StartPosition = FormStartPosition.CenterScreen;
            Mbr.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }
    }
}
