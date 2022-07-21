
namespace RoboIME_store
{
    partial class Membros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membros));
            this.MbrNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Hist = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MbrSenha = new System.Windows.Forms.TextBox();
            this.MbrDel = new System.Windows.Forms.Button();
            this.MbrSalvar = new System.Windows.Forms.Button();
            this.MembrosData = new System.Windows.Forms.DataGridView();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MembrosData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MbrNome
            // 
            this.MbrNome.Location = new System.Drawing.Point(73, 134);
            this.MbrNome.Name = "MbrNome";
            this.MbrNome.Size = new System.Drawing.Size(134, 20);
            this.MbrNome.TabIndex = 0;
            this.MbrNome.TextChanged += new System.EventHandler(this.MbrNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(226, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Membros";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(366, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Itens";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Hist
            // 
            this.Hist.AutoSize = true;
            this.Hist.BackColor = System.Drawing.Color.Transparent;
            this.Hist.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hist.ForeColor = System.Drawing.Color.Black;
            this.Hist.Location = new System.Drawing.Point(460, 0);
            this.Hist.Name = "Hist";
            this.Hist.Size = new System.Drawing.Size(114, 45);
            this.Hist.TabIndex = 15;
            this.Hist.Text = "Histórico";
            this.Hist.UseCompatibleTextRendering = true;
            this.Hist.Click += new System.EventHandler(this.Hist_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(17, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // MbrSenha
            // 
            this.MbrSenha.Location = new System.Drawing.Point(61, 136);
            this.MbrSenha.Name = "MbrSenha";
            this.MbrSenha.Size = new System.Drawing.Size(134, 20);
            this.MbrSenha.TabIndex = 2;
            this.MbrSenha.TextChanged += new System.EventHandler(this.MbrSenha_TextChanged);
            // 
            // MbrDel
            // 
            this.MbrDel.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MbrDel.ForeColor = System.Drawing.Color.Black;
            this.MbrDel.Location = new System.Drawing.Point(83, 234);
            this.MbrDel.Name = "MbrDel";
            this.MbrDel.Size = new System.Drawing.Size(97, 25);
            this.MbrDel.TabIndex = 7;
            this.MbrDel.Text = "Deletar";
            this.MbrDel.UseVisualStyleBackColor = true;
            this.MbrDel.Click += new System.EventHandler(this.MbrDel_Click);
            // 
            // MbrSalvar
            // 
            this.MbrSalvar.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MbrSalvar.ForeColor = System.Drawing.Color.Black;
            this.MbrSalvar.Location = new System.Drawing.Point(83, 203);
            this.MbrSalvar.Name = "MbrSalvar";
            this.MbrSalvar.Size = new System.Drawing.Size(97, 25);
            this.MbrSalvar.TabIndex = 11;
            this.MbrSalvar.Text = "Salvar";
            this.MbrSalvar.UseVisualStyleBackColor = true;
            this.MbrSalvar.Click += new System.EventHandler(this.MbrSalvar_Click);
            // 
            // MembrosData
            // 
            this.MembrosData.AllowUserToAddRows = false;
            this.MembrosData.AllowUserToDeleteRows = false;
            this.MembrosData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembrosData.BackgroundColor = System.Drawing.Color.White;
            this.MembrosData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MembrosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembrosData.Location = new System.Drawing.Point(292, 15);
            this.MembrosData.Name = "MembrosData";
            this.MembrosData.ReadOnly = true;
            this.MembrosData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembrosData.Size = new System.Drawing.Size(467, 361);
            this.MembrosData.TabIndex = 10;
            this.MembrosData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembrosData_CellContentClick);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.Black;
            this.ClearBtn.Location = new System.Drawing.Point(83, 265);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(97, 25);
            this.ClearBtn.TabIndex = 12;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.MembrosData);
            this.panel1.Controls.Add(this.MbrSalvar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.MbrDel);
            this.panel1.Controls.Add(this.MbrSenha);
            this.panel1.Controls.Add(this.label3);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 390);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Font = new System.Drawing.Font("Agency FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(702, 5);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(69, 34);
            this.Logout.TabIndex = 38;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Membros
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Hist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MbrNome);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Membros";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Membros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MembrosData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MbrNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Hist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MbrSenha;
        private System.Windows.Forms.Button MbrDel;
        private System.Windows.Forms.Button MbrSalvar;
        private System.Windows.Forms.DataGridView MembrosData;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Logout;
    }
}