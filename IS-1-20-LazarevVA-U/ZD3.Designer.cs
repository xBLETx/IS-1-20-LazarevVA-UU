namespace IS_1_20_LazarevVA_U
{
    partial class ZD3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZD3));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TupeEl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufactur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tupelist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emploe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(743, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.Client,
            this.TupeEl,
            this.Manufactur,
            this.Tupelist,
            this.Emploe,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(26, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 257);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Order
            // 
            this.Order.HeaderText = "Номер заказа";
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "Клиент";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // TupeEl
            // 
            this.TupeEl.HeaderText = "Тип электроники";
            this.TupeEl.Name = "TupeEl";
            this.TupeEl.ReadOnly = true;
            // 
            // Manufactur
            // 
            this.Manufactur.HeaderText = "Производитель";
            this.Manufactur.Name = "Manufactur";
            this.Manufactur.ReadOnly = true;
            // 
            // Tupelist
            // 
            this.Tupelist.HeaderText = "Тип услуги";
            this.Tupelist.Name = "Tupelist";
            this.Tupelist.ReadOnly = true;
            // 
            // Emploe
            // 
            this.Emploe.HeaderText = "Принял";
            this.Emploe.Name = "Emploe";
            this.Emploe.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус заказа";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ZD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ZD3";
            this.Text = "ZD3";
            this.Load += new System.EventHandler(this.ZD3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn TupeEl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufactur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tupelist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emploe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}