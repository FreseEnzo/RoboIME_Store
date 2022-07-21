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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            this.Text = "Lojinha RoboIME";
            atualizarTbl();
            User.Text = Login.MemberName;
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
        private void button1_Click(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void ItensData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNome.Text = ItensData.SelectedRows[0].Cells[1].Value.ToString();
            //ItemQte.Text = ItensData.SelectedRows[0].Cells[2].Value.ToString();
            ItemPreço.Text = ItensData.SelectedRows[0].Cells[3].Value.ToString();
            if (ItemNome.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ItensData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        int n = 0;
        float contaTotal = 0;
        string MbrName = Login.MemberName;        
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(ItemQte.Text == "")
            {
                MessageBox.Show("Coloque a quantidade!");
            }
            else
            {

                float total = Convert.ToInt32(ItemQte.Text) * float.Parse(ItemPreço.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(ContaData);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = ItemNome.Text;
                newRow.Cells[2].Value = ItemQte.Text;
                newRow.Cells[3].Value = ItemPreço.Text;
                newRow.Cells[4].Value = total;
                ContaData.Rows.Add(newRow);
                contaTotal += total;
                TotalConta.Text =  ""+contaTotal;
                n++;
                remKey++;
                ContaData.CurrentCell = ContaData.Rows[ContaData.Rows.Count - 1].Cells[0];
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CntTbl values('" + MbrName + "','" + ItemNome.Text + "','" + ItemQte.Text + "','" + ItemPreço.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    atualizarTbl();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void ContaData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNome.Text = ItensData.SelectedRows[0].Cells[1].Value.ToString();
            ItemQte.Text = ItensData.SelectedRows[0].Cells[2].Value.ToString();
            ItemPreço.Text = ItensData.SelectedRows[0].Cells[3].Value.ToString();
            if (ItemNome.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ItensData.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TotalConta_Click(object sender, EventArgs e)
        {
            
        }

        private void User_Click(object sender, EventArgs e)
        {
           
        }

        private void Conta_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int remKey = 0;
        private void RemBtn_Click(object sender, EventArgs e)
        {
            if(remKey == 0 )
            {
                MessageBox.Show("Não há itens para remover");
            }
          
            else
            {
                var result = MessageBox.Show("Deseja REMOVER o último item adicionado?", "Form Closing",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
               if(result == DialogResult.Yes)
                {
                    try
                {
                    Con.Open();
                    string query = "delete from CntTbl where id = (select MAX(id) from CntTbl)";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Removido!");
                    remKey--;
                       
                    Con.Close();
                        contaTotal -= float.Parse(ContaData.Rows[ContaData.Rows.Count - 1].Cells[4].Value.ToString());

                        if (contaTotal > -0.02 && contaTotal < 0.02)
                            contaTotal = 0;
                        TotalConta.Text = "" + contaTotal;
                        ContaData.Rows.Remove(ContaData.Rows[ContaData.CurrentRow.Index]);
                        atualizarTbl();
                      
                       
                    }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                } 
                }
               
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }
    }
}
