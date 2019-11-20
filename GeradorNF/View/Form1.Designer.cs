namespace GeradorNF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboxRegiao = new System.Windows.Forms.ComboBox();
            this.txtboxQuanVendida = new System.Windows.Forms.NumericUpDown();
            this.txtboxPrecoUnitario = new System.Windows.Forms.NumericUpDown();
            this.txtboxNomeProduto = new System.Windows.Forms.TextBox();
            this.txtboxVendedorNome = new System.Windows.Forms.TextBox();
            this.txtboxClienteNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxFiltroVendedor = new System.Windows.Forms.TextBox();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtboxFiltroCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaiorRegiao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxQuanVendida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxPrecoUnitario)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(878, 396);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboxRegiao
            // 
            this.comboxRegiao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxRegiao.FormattingEnabled = true;
            this.comboxRegiao.Items.AddRange(new object[] {
            "NORTE",
            "NORDESTE",
            "CENTRO-OESTE",
            "SUDESTE",
            "SUL"});
            this.comboxRegiao.Location = new System.Drawing.Point(192, 154);
            this.comboxRegiao.Name = "comboxRegiao";
            this.comboxRegiao.Size = new System.Drawing.Size(184, 26);
            this.comboxRegiao.TabIndex = 1;
            // 
            // txtboxQuanVendida
            // 
            this.txtboxQuanVendida.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxQuanVendida.Location = new System.Drawing.Point(201, 49);
            this.txtboxQuanVendida.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtboxQuanVendida.Name = "txtboxQuanVendida";
            this.txtboxQuanVendida.Size = new System.Drawing.Size(120, 25);
            this.txtboxQuanVendida.TabIndex = 2;
            // 
            // txtboxPrecoUnitario
            // 
            this.txtboxPrecoUnitario.DecimalPlaces = 1;
            this.txtboxPrecoUnitario.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPrecoUnitario.Location = new System.Drawing.Point(201, 75);
            this.txtboxPrecoUnitario.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtboxPrecoUnitario.Name = "txtboxPrecoUnitario";
            this.txtboxPrecoUnitario.Size = new System.Drawing.Size(120, 25);
            this.txtboxPrecoUnitario.TabIndex = 3;
            // 
            // txtboxNomeProduto
            // 
            this.txtboxNomeProduto.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNomeProduto.Location = new System.Drawing.Point(192, 24);
            this.txtboxNomeProduto.Name = "txtboxNomeProduto";
            this.txtboxNomeProduto.Size = new System.Drawing.Size(184, 25);
            this.txtboxNomeProduto.TabIndex = 4;
            // 
            // txtboxVendedorNome
            // 
            this.txtboxVendedorNome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxVendedorNome.Location = new System.Drawing.Point(192, 102);
            this.txtboxVendedorNome.Name = "txtboxVendedorNome";
            this.txtboxVendedorNome.Size = new System.Drawing.Size(184, 25);
            this.txtboxVendedorNome.TabIndex = 5;
            // 
            // txtboxClienteNome
            // 
            this.txtboxClienteNome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxClienteNome.Location = new System.Drawing.Point(192, 128);
            this.txtboxClienteNome.Name = "txtboxClienteNome";
            this.txtboxClienteNome.Size = new System.Drawing.Size(184, 25);
            this.txtboxClienteNome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade Vendida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nome do Vendedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nome do Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Região:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(192, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Incluir NF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxFiltroVendedor
            // 
            this.txtboxFiltroVendedor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFiltroVendedor.Location = new System.Drawing.Point(516, 66);
            this.txtboxFiltroVendedor.Name = "txtboxFiltroVendedor";
            this.txtboxFiltroVendedor.Size = new System.Drawing.Size(118, 25);
            this.txtboxFiltroVendedor.TabIndex = 14;
            // 
            // btnVendedor
            // 
            this.btnVendedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnVendedor.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendedor.Location = new System.Drawing.Point(516, 97);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(118, 30);
            this.btnVendedor.TabIndex = 15;
            this.btnVendedor.Text = "Vendedor Filtro";
            this.btnVendedor.UseVisualStyleBackColor = false;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(674, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Cliente Filtro";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtboxFiltroCliente
            // 
            this.txtboxFiltroCliente.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxFiltroCliente.Location = new System.Drawing.Point(674, 66);
            this.txtboxFiltroCliente.Name = "txtboxFiltroCliente";
            this.txtboxFiltroCliente.Size = new System.Drawing.Size(115, 25);
            this.txtboxFiltroCliente.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(408, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(424, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Atualmente o maior número de vendas se concentra em:";
            // 
            // lblMaiorRegiao
            // 
            this.lblMaiorRegiao.AutoSize = true;
            this.lblMaiorRegiao.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaiorRegiao.Location = new System.Drawing.Point(408, 172);
            this.lblMaiorRegiao.Name = "lblMaiorRegiao";
            this.lblMaiorRegiao.Size = new System.Drawing.Size(16, 18);
            this.lblMaiorRegiao.TabIndex = 19;
            this.lblMaiorRegiao.Text = "a";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1170, 651);
            this.Controls.Add(this.lblMaiorRegiao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtboxFiltroCliente);
            this.Controls.Add(this.btnVendedor);
            this.Controls.Add(this.txtboxFiltroVendedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxClienteNome);
            this.Controls.Add(this.txtboxVendedorNome);
            this.Controls.Add(this.txtboxNomeProduto);
            this.Controls.Add(this.txtboxPrecoUnitario);
            this.Controls.Add(this.txtboxQuanVendida);
            this.Controls.Add(this.comboxRegiao);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Nota Fiscal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxQuanVendida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtboxPrecoUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboxRegiao;
        private System.Windows.Forms.NumericUpDown txtboxQuanVendida;
        private System.Windows.Forms.NumericUpDown txtboxPrecoUnitario;
        private System.Windows.Forms.TextBox txtboxNomeProduto;
        private System.Windows.Forms.TextBox txtboxVendedorNome;
        private System.Windows.Forms.TextBox txtboxClienteNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtboxFiltroVendedor;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtboxFiltroCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaiorRegiao;
    }
}

