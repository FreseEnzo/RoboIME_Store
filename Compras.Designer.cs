
namespace RoboIME_store
{
    partial class Compras
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ItensData = new System.Windows.Forms.DataGridView();
            this.ItemNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemPreço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemQte = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApagarBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.roboStoreDBDataSet = new RoboIME_store.RoboStoreDBDataSet();
            this.roboStoreDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Hist = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItensData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboStoreDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboStoreDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.ItensData);
            this.panel1.Controls.Add(this.ItemNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ItemPreço);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ItemQte);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ApagarBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 379);
            this.panel1.TabIndex = 0;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(77, 300);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(192, 41);
            this.ClearBtn.TabIndex = 23;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ItensData
            // 
            this.ItensData.AllowUserToAddRows = false;
            this.ItensData.AllowUserToDeleteRows = false;
            this.ItensData.AllowUserToOrderColumns = true;
            this.ItensData.AllowUserToResizeRows = false;
            this.ItensData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItensData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ItensData.BackgroundColor = System.Drawing.Color.White;
            this.ItensData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItensData.Location = new System.Drawing.Point(389, 25);
            this.ItensData.Name = "ItensData";
            this.ItensData.ReadOnly = true;
            this.ItensData.RowHeadersWidth = 60;
            this.ItensData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItensData.Size = new System.Drawing.Size(343, 322);
            this.ItensData.TabIndex = 10;
            this.ItensData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItensData_CellContentClick);
            // 
            // ItemNome
            // 
            this.ItemNome.Location = new System.Drawing.Point(115, 79);
            this.ItemNome.Name = "ItemNome";
            this.ItemNome.Size = new System.Drawing.Size(186, 20);
            this.ItemNome.TabIndex = 21;
            this.ItemNome.TextChanged += new System.EventHandler(this.ItemNome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // ItemPreço
            // 
            this.ItemPreço.AllowDrop = true;
            this.ItemPreço.Location = new System.Drawing.Point(115, 131);
            this.ItemPreço.Name = "ItemPreço";
            this.ItemPreço.Size = new System.Drawing.Size(52, 20);
            this.ItemPreço.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Preço";
            // 
            // ItemQte
            // 
            this.ItemQte.Location = new System.Drawing.Point(115, 105);
            this.ItemQte.Name = "ItemQte";
            this.ItemQte.Size = new System.Drawing.Size(52, 20);
            this.ItemQte.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ApagarBtn
            // 
            this.ApagarBtn.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApagarBtn.ForeColor = System.Drawing.Color.Red;
            this.ApagarBtn.Location = new System.Drawing.Point(77, 253);
            this.ApagarBtn.Name = "ApagarBtn";
            this.ApagarBtn.Size = new System.Drawing.Size(192, 41);
            this.ApagarBtn.TabIndex = 11;
            this.ApagarBtn.Text = "Remover";
            this.ApagarBtn.UseVisualStyleBackColor = true;
            this.ApagarBtn.Click += new System.EventHandler(this.ApagarBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Lime;
            this.AddBtn.Location = new System.Drawing.Point(77, 206);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(192, 41);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Adicionar";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // roboStoreDBDataSet
            // 
            this.roboStoreDBDataSet.DataSetName = "RoboStoreDBDataSet";
            this.roboStoreDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roboStoreDBDataSetBindingSource
            // 
            this.roboStoreDBDataSetBindingSource.DataSource = this.roboStoreDBDataSet;
            this.roboStoreDBDataSetBindingSource.Position = 0;
            // 
            // Hist
            // 
            this.Hist.AutoSize = true;
            this.Hist.BackColor = System.Drawing.Color.Transparent;
            this.Hist.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hist.ForeColor = System.Drawing.Color.Black;
            this.Hist.Location = new System.Drawing.Point(455, 9);
            this.Hist.Name = "Hist";
            this.Hist.Size = new System.Drawing.Size(114, 45);
            this.Hist.TabIndex = 18;
            this.Hist.Text = "Histórico";
            this.Hist.UseCompatibleTextRendering = true;
            this.Hist.Click += new System.EventHandler(this.Hist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Agency FB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(361, 9);
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
            this.label4.Location = new System.Drawing.Point(221, 9);
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
            this.Logout.Location = new System.Drawing.Point(707, 9);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(69, 34);
            this.Logout.TabIndex = 36;
            this.Logout.Text = "Logout";
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Compras
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
            this.Name = "Compras";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItensData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboStoreDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roboStoreDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ApagarBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.BindingSource roboStoreDBDataSetBindingSource;
        private RoboStoreDBDataSet roboStoreDBDataSet;
        private System.Windows.Forms.TextBox ItemPreço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemQte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ItemNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ItensData;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label Hist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Logout;
    }
}