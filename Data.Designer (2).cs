
namespace RoboIME_store
{
    partial class Data
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data));
            this.DataGeral = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.TextBox();
            this.totalTxt = new System.Windows.Forms.Label();
            this.DataNomes = new System.Windows.Forms.DataGridView();
            this.delBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Hist = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGeral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNomes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGeral
            // 
            this.DataGeral.AllowUserToAddRows = false;
            this.DataGeral.AllowUserToDeleteRows = false;
            this.DataGeral.AllowUserToResizeRows = false;
            this.DataGeral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGeral.BackgroundColor = System.Drawing.Color.White;
            this.DataGeral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGeral.Location = new System.Drawing.Point(404, 22);
            this.DataGeral.Name = "DataGeral";
            this.DataGeral.ReadOnly = true;
            this.DataGeral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGeral.Size = new System.Drawing.Size(354, 327);
            this.DataGeral.TabIndex = 0;
            this.DataGeral.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(81, 22);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 1;
            // 
            // totalTxt
            // 
            this.totalTxt.AutoSize = true;
            this.totalTxt.BackColor = System.Drawing.Color.Transparent;
            this.totalTxt.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTxt.ForeColor = System.Drawing.Color.Lime;
            this.totalTxt.Location = new System.Drawing.Point(137, 173);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(31, 39);
            this.totalTxt.TabIndex = 2;
            this.totalTxt.Text = "0";
            // 
            // DataNomes
            // 
            this.DataNomes.AllowUserToAddRows = false;
            this.DataNomes.AllowUserToDeleteRows = false;
            this.DataNomes.BackgroundColor = System.Drawing.Color.White;
            this.DataNomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataNomes.Location = new System.Drawing.Point(241, 22);
            this.DataNomes.Name = "DataNomes";
            this.DataNomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataNomes.Size = new System.Drawing.Size(146, 327);
            this.DataNomes.TabIndex = 3;
            this.DataNomes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataNomes_CellContentClick);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delBtn.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.Red;
            this.delBtn.Location = new System.Drawing.Point(139, 311);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(75, 38);
            this.delBtn.TabIndex = 4;
            this.delBtn.Text = "Deletar";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.totalTxt);
            this.panel1.Controls.Add(this.DataNomes);
            this.panel1.Controls.Add(this.delBtn);
            this.panel1.Controls.Add(this.DataGeral);
            this.panel1.Controls.Add(this.Nome);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 367);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(23, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total: R$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // Hist
            // 
            this.Hist.AutoSize = true;
            this.Hist.BackColor = System.Drawing.Color.Transparent;
            this.Hist.Font = new System.Drawing.Font("Agency FB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hist.ForeColor = System.Drawing.Color.Black;
            this.Hist.Location = new System.Drawing.Point(466, 18);
            this.Hist.Name = "Hist";
            this.Hist.Size = new System.Drawing.Size(114, 45);
            this.Hist.TabIndex = 18;
            this.Hist.Text = "Histórico";
            this.Hist.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(372, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = "Itens";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(232, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 39);
            this.label4.TabIndex = 16;
            this.label4.Text = "Membros";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.BackColor = System.Drawing.Color.Transparent;
            this.Logout.Font = new System.Drawing.Font("Agency FB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(701, 22);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(69, 34);
            this.Logout.TabIndex = 37;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Hist);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Data";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGeral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataNomes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGeral;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label totalTxt;
        private System.Windows.Forms.DataGridView DataNomes;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Hist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Logout;
    }
}