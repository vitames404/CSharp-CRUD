namespace CRUD_Simples
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
            this.components = new System.ComponentModel.Container();
            this.dadoscadastroDataSet = new CRUD_Simples.dadoscadastroDataSet();
            this.dadoscadastroDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.logintext = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.senhaText = new System.Windows.Forms.Label();
            this.nomeText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.Databse = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.dadoscadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadoscadastroDataSetBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Databse.SuspendLayout();
            this.SuspendLayout();
            // 
            // dadoscadastroDataSet
            // 
            this.dadoscadastroDataSet.DataSetName = "dadoscadastroDataSet";
            this.dadoscadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dadoscadastroDataSetBindingSource
            // 
            this.dadoscadastroDataSetBindingSource.DataSource = this.dadoscadastroDataSet;
            this.dadoscadastroDataSetBindingSource.Position = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.nomeText);
            this.tabPage1.Controls.Add(this.senhaText);
            this.tabPage1.Controls.Add(this.emailText);
            this.tabPage1.Controls.Add(this.logintext);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(604, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 65);
            this.button1.TabIndex = 9;
            this.button1.Text = "Realizar cadastro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // logintext
            // 
            this.logintext.AutoSize = true;
            this.logintext.Location = new System.Drawing.Point(22, 180);
            this.logintext.Name = "logintext";
            this.logintext.Size = new System.Drawing.Size(33, 13);
            this.logintext.TabIndex = 10;
            this.logintext.Text = "Login";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(23, 133);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(32, 13);
            this.emailText.TabIndex = 11;
            this.emailText.Text = "Email";
            // 
            // senhaText
            // 
            this.senhaText.AutoSize = true;
            this.senhaText.Location = new System.Drawing.Point(22, 225);
            this.senhaText.Name = "senhaText";
            this.senhaText.Size = new System.Drawing.Size(38, 13);
            this.senhaText.TabIndex = 12;
            this.senhaText.Text = "Senha";
            // 
            // nomeText
            // 
            this.nomeText.AutoSize = true;
            this.nomeText.Location = new System.Drawing.Point(22, 92);
            this.nomeText.Name = "nomeText";
            this.nomeText.Size = new System.Drawing.Size(35, 13);
            this.nomeText.TabIndex = 13;
            this.nomeText.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 65);
            this.button2.TabIndex = 19;
            this.button2.Text = "Deletar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(61, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(61, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(204, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(61, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(204, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Location = new System.Drawing.Point(61, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(204, 20);
            this.textBox5.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(17, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 65);
            this.button3.TabIndex = 21;
            this.button3.Text = "Atualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 355);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 168);
            this.dataGridView1.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(271, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 22);
            this.button4.TabIndex = 23;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Databse
            // 
            this.Databse.Controls.Add(this.tabPage1);
            this.Databse.Location = new System.Drawing.Point(2, 5);
            this.Databse.Name = "Databse";
            this.Databse.SelectedIndex = 0;
            this.Databse.Size = new System.Drawing.Size(612, 564);
            this.Databse.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 581);
            this.Controls.Add(this.Databse);
            this.Name = "Form1";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadoscadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dadoscadastroDataSetBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Databse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dadoscadastroDataSetBindingSource;
        private dadoscadastroDataSet dadoscadastroDataSet;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nomeText;
        private System.Windows.Forms.Label senhaText;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.Label logintext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Databse;
    }
}

