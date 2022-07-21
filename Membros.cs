using System;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace RoboIME_store
{
    public partial class Membros : Form
    {
        public Membros()
        {
            InitializeComponent();
            this.Text = "Lojinha RoboIME";
            atualizarTbl();
        }
        public void clearInfo()
        {
            MbrNome.Text = "";
            MbrSenha.Text = "";
           
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\enzog\source\repos\RoboIME_store\RoboStoreDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MbrNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void MbrSenha_TextChanged(object sender, EventArgs e)
        {

        }
       private void atualizarTbl()
        {
            string query = "select * from MembrosTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new RoboStoreDBDataSet();
            sda.Fill(ds);
            MembrosData.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void MbrSalvar_Click(object sender, EventArgs e)
        {
            if(MbrNome.Text == "" || MbrSenha.Text == "")
            {
                MessageBox.Show("Erro, falta dados");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into MembrosTbl values('"+MbrNome.Text+"','"+MbrSenha.Text+"')",Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro Adicionado!");
                    Con.Close();
                    atualizarTbl();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int Key = 0;
        private void MembrosData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                MbrNome.Text = MembrosData.SelectedRows[0].Cells[1].Value.ToString();
                MbrSenha.Text = MembrosData.SelectedRows[0].Cells[2].Value.ToString();
                if (MbrNome.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(MembrosData.SelectedRows[0].Cells[0].Value.ToString());
                }
            
        }

        private void MbrDel_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Selecione o Membro a ser deletado");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "Delete from MembrosTbl where MbrId =" + Key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro Deletado!");
                    Con.Close();
                    atualizarTbl();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }   
        }

        private void MbrEditar_Click(object sender, EventArgs e)
        {
            if (MbrNome.Text == "" || MbrSenha.Text == "")
            {
                MessageBox.Show("Selecione o Membro para editar");
            }
           
            else
            {
                try
                {
                    Con.Open();
                    string query = "Update from MembrosTbl set MbrNome ='"+MbrNome.Text+"',MbrSenha='"+MbrSenha.Text+"' where MbrId ="+Key+";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Membro Atualizado!");
                    Con.Close();
                    atualizarTbl();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            clearInfo();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Compras Comp = new Compras();
            Comp.StartPosition = FormStartPosition.CenterScreen;
            Comp.Show();
            this.Hide();
        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Hist_Click(object sender, EventArgs e)
        {
            Data Hist  = new Data();
            Hist.StartPosition = FormStartPosition.CenterScreen;
            Hist.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Membros_Load(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.StartPosition = FormStartPosition.CenterScreen;
            Obj.Show();
            this.Hide();
           
            
        }
    }   
        
}
