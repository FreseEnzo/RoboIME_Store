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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
            this.Text = "Lojinha RoboIME";
            atualizarTblGeral();
            atualizarTblNomes();
        }
        string KeyNomes = "";
        private void atualizarTblGeral()
        {
            string query = "select MbrItem, MbrQte, MbrPreço from CntTbl where MbrName='"+KeyNomes+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new RoboStoreDBDataSet();
            sda.Fill(ds);
            DataGeral.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void atualizarTblNomes()
        {
            string query = "select MbrName from CntTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new RoboStoreDBDataSet();
            sda.Fill(ds);
            DataNomes.DataSource = ds.Tables[0];
            Con.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\enzog\source\repos\RoboIME_store\RoboStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void somarConta()
        {
            Decimal total = 0;
            foreach (DataGridViewRow row in DataGeral.Rows)
            {
                total += Convert.ToDecimal(row.Cells[1].Value) * Convert.ToDecimal(row.Cells[2].Value);
            }
            totalTxt.Text= "" + total;
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void DataNomes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Nome.Text = DataNomes.SelectedRows[0].Cells[0].Value.ToString();
           
            if (Nome.Text == "")
            {
                KeyNomes = "";
            }
            else
            {
                KeyNomes = DataNomes.SelectedRows[0].Cells[0].Value.ToString();
                atualizarTblGeral();
                somarConta();
            }

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (KeyNomes == "")
            {
                MessageBox.Show("Selecione o Histório de Compras a ser deletada!");
            }
            else
            {
                var result = MessageBox.Show("Você deseja remover todo o histórico de compras de "+KeyNomes+"?", "Form Closing",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        Con.Open();
                        string query = "Delete from CntTbl where MbrName ='" + KeyNomes + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Histórico Deletado!");
                        Con.Close();
                        atualizarTblGeral();
                        atualizarTblNomes();
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
            }
        }

        private void rtnBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Compras Comp = new Compras();
            Comp.StartPosition = FormStartPosition.CenterScreen;
            Comp.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Membros Mbr = new Membros();
           Mbr.StartPosition = FormStartPosition.CenterScreen;
            Mbr.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }
    }
}
