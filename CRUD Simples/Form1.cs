using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Simples
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source= ;Initial Catalog=;Integrated Security=True");


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindData();
        }


        public void button1_Click_1(object sender, EventArgs e)
        {

            string sql = "INSERT INTO dadoscadastro (id, login, email, senha, data_cadastro, nome_completo) VALUES (@id, @login, @email, @senha, @data_cadastro, @nome_completo)";
            string sqlx = "SELECT id FROM dadoscadastro where login = @login";

            Random numeroID = new Random();
            DateTime dataCAD = DateTime.Now;

            MessageBox.Show("Comando executado");

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);
                SqlCommand x = new SqlCommand(sqlx, conn);

                c.Parameters.Add(new SqlParameter("@id", numeroID.Next()));
                c.Parameters.Add(new SqlParameter("@nome_completo", this.textBox1.Text));
                c.Parameters.Add(new SqlParameter("@email", this.textBox2.Text));
                c.Parameters.Add(new SqlParameter("@senha", this.textBox4.Text));
                c.Parameters.Add(new SqlParameter("@data_cadastro", dataCAD));
                c.Parameters.Add(new SqlParameter("@login", this.textBox3.Text));

                conn.Open();

                c.ExecuteNonQuery();

                conn.Close();

                BindData();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand delete = new SqlCommand("delete from dadoscadastro where id = @id", conn);

            delete.Parameters.Add(new SqlParameter("@id", this.textBox5.Text));

            delete.ExecuteNonQuery();

            conn.Close();

            BindData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand update = new SqlCommand("update dadoscadastro set login = @login, email = @email, senha = @senha, nome_completo = @nome_completo where id = @id", conn);

            update.Parameters.Add(new SqlParameter("@id", this.textBox5.Text));
            update.Parameters.Add(new SqlParameter("@nome_completo", this.textBox1.Text));
            update.Parameters.Add(new SqlParameter("@email", this.textBox2.Text));
            update.Parameters.Add(new SqlParameter("@senha", this.textBox4.Text));
            update.Parameters.Add(new SqlParameter("@data_cadastro", DateTime.Now));
            update.Parameters.Add(new SqlParameter("@login", this.textBox3.Text));

            update.ExecuteNonQuery();

            conn.Close();

            BindData();

        }


        void BindData()
        {

            SqlCommand sqld = new SqlCommand("select * from dadoscadastro", conn);

            SqlDataAdapter sd = new SqlDataAdapter(sqld);
            DataTable dt = new DataTable();

            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand search = new SqlCommand("select * from dadoscadastro where id = @id", conn);

            search.Parameters.Add(new SqlParameter ("@id", this.textBox5.Text));

            conn.Open();

            SqlDataReader reader = search.ExecuteReader();

            if (reader.Read())
            {

                this.textBox1.Text = reader["nome_completo"].ToString();
                this.textBox2.Text = reader["email"].ToString();
                this.textBox3.Text = reader["login"].ToString();
                this.textBox4.Text = reader["senha"].ToString();

            }

            conn.Close();


        }
    }
}
