
namespace RoboIME_store
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            this.ItensData = new System.Windows.Forms.DataGridView();
            this.ContaData = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.ItemPreço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemQte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemBtn = new System.Windows.Forms.Button();
            this.Conta = new System.Windows.Forms.Label();
            this.TotalConta = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.User = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItensData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContaData)).BeginInit();
            this.SuspendLayout();
            // 
            // ItensData
            // 
            this.ItensData.AllowUserToAddRows = false;
            this.ItensData.AllowUserToDeleteRows = false;
            this.ItensData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItensData.BackgroundColor = System.Drawing.Color.White;
            this.ItensData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItensData.Location = new System.Drawing.Point(47, 121);
            this.ItensData.Name = "ItensData";
            this.ItensData.ReadOnly = true;
            this.ItensData.RowHeadersVisible = false;
            this.ItensData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItensData.Size = new System.Drawing.Size(355, 342);
            this.ItensData.TabIndex = 0;
            this.ItensData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItensData_CellContentClick);
            // 
            // ContaData
            // 
            this.ContaData.AllowUserToAddRows = false;
            this.ContaData.AllowUserToDeleteRows = false;
            this.ContaData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ContaData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ContaData.BackgroundColor = System.Drawing.Color.White;
            this.ContaData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Item,
            this.Qte,
            this.Preço,
            this.Total});
            this.ContaData.Enabled = false;
            this.ContaData.Location = new System.Drawing.Point(597, 121);
            this.ContaData.Name = "ContaData";
            this.ContaData.ReadOnly = true;
            this.ContaData.RowHeadersVisible = false;
            this.ContaData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContaData.Size = new System.Drawing.Size(432, 342);
            this.ContaData.TabIndex = 1;
            this.ContaData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContaData_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "ID";
            this.ID.MaxInputLength = 3276;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.HeaderText = "Nome";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Qte
            // 
            this.Qte.HeaderText = "Qte";
            this.Qte.MaxInputLength = 3276;
            this.Qte.Name = "Qte";
            this.Qte.ReadOnly = true;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // ItemNome
            // 
            this.ItemNome.BackColor = System.Drawing.Color.White;
            this.ItemNome.Enabled = false;
            this.ItemNome.Location = new System.Drawing.Point(423, 152);
            this.ItemNome.Name = "ItemNome";
            this.ItemNome.Size = new System.Drawing.Size(156, 20);
            this.ItemNome.TabIndex = 28;
            this.ItemNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Snow;
            this.Nome.Location = new System.Drawing.Point(481, 121);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 25);
            this.Nome.TabIndex = 27;
            this.Nome.Text = "Item";
            // 
            // ItemPreço
            // 
            this.ItemPreço.Enabled = false;
            this.ItemPreço.Location = new System.Drawing.Point(493, 193);
            this.ItemPreço.Name = "ItemPreço";
            this.ItemPreço.Size = new System.Drawing.Size(52, 20);
            this.ItemPreço.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(442, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Preço";
            // 
            // ItemQte
            // 
            this.ItemQte.Location = new System.Drawing.Point(493, 231);
            this.ItemQte.Name = "ItemQte";
            this.ItemQte.Size = new System.Drawing.Size(52, 20);
            this.ItemQte.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(451, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Qte.";
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Lime;
            this.AddBtn.Location = new System.Drawing.Point(423, 274);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(156, 65);
            this.AddBtn.TabIndex = 22;
            this.AddBtn.Text = "Adicionar";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemBtn
            // 
            this.RemBtn.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemBtn.ForeColor = System.Drawing.Color.Red;
            this.RemBtn.Location = new System.Drawing.Point(423, 345);
            this.RemBtn.Name = "RemBtn";
            this.RemBtn.Size = new System.Drawing.Size(156, 65);
            this.RemBtn.TabIndex = 29;
            this.RemBtn.Text = "Remover";
            this.RemBtn.UseVisualStyleBackColor = true;
            this.RemBtn.Click += new System.EventHandler(this.RemBtn_Click);
            // 
            // Conta
            // 
            this.Conta.AutoSize = true;
            this.Conta.BackColor = System.Drawing.Color.Transparent;
            this.Conta.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conta.ForeColor = System.Drawing.Color.Snow;
            this.Conta.Location = new System.Drawing.Point(590, 76);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(84, 42);
            this.Conta.TabIndex = 30;
            this.Conta.Text = "Conta";
            this.Conta.Click += new System.EventHandler(this.Conta_Click);
            // 
            // TotalConta
            // 
            this.TotalConta.AutoSize = true;
            this.TotalConta.BackColor = System.Drawing.Color.Transparent;
            this.TotalConta.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalConta.ForeColor = System.Drawing.Color.Snow;
            this.TotalConta.Location = new System.Drawing.Point(521, 429);
            this.TotalConta.Name = "TotalConta";
            this.TotalConta.Size = new System.Drawing.Size(27, 34);
            this.TotalConta.TabIndex = 31;
            this.TotalConta.Text = "0";
            this.TotalConta.Click += new System.EventHandler(this.TotalConta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(440, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 34);
            this.label1.TabIndex = 32;
            this.label1.Text = "Total: R$";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.Font = new System.Drawing.Font("Agency FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.ForeColor = System.Drawing.Color.White;
            this.User.Location = new System.Drawing.Point(41, 21);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(56, 34);
            this.User.TabIndex = 33;
            this.User.Text = "User";
            this.User.Click += new System.EventHandler(this.User_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(40, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 42);
            this.label4.TabIndex = 34;
            this.label4.Text = "Loja";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Font = new System.Drawing.Font("Agency FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Logout.Location = new System.Drawing.Point(974, 475);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(69, 34);
            this.Logout.TabIndex = 35;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1074, 518);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TotalConta);
            this.Controls.Add(this.Conta);
            this.Controls.Add(this.RemBtn);
            this.Controls.Add(this.ItemNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.ItemPreço);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemQte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.ContaData);
            this.Controls.Add(this.ItensData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Billing";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItensData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContaData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItensData;
        private System.Windows.Forms.DataGridView ContaData;
        private System.Windows.Forms.TextBox ItemNome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox ItemPreço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemBtn;
        private System.Windows.Forms.Label Conta;
        private System.Windows.Forms.Label TotalConta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Logout;
    }
}