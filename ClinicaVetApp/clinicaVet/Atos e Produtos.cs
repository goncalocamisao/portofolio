using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace clinicaVet
{
    public partial class Atos_e_Produtos : Form
    {
        public Atos_e_Produtos()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Atos_e_Produtos_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM produtos", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;

            string connectionString2 = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            MySqlConnection connection2 = new MySqlConnection(connectionString2);
            MySqlDataAdapter adapter2 = new MySqlDataAdapter("SELECT * FROM atosmedicos", connection);
            DataTable table2 = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            dataGridView2.ReadOnly = true;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            string query = "INSERT INTO atosmedicos (Nome, Preco) VALUES (@value2, @value3)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@value2", textBox4.Text);
                    command.Parameters.AddWithValue("@value3", textBox5.Text);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Ato Médico " + textBox4.Text + " foi adicionado/a com sucesso.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao adicionar Ato Médico.");
                    }
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM atosmedicos", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;
                dataGridView2.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            string query = "INSERT INTO produtos (TipoFamilia, Descricao, QuantidadeArmazem, PrecoUnitario) VALUES (@value2, @value3, @value4, @value5)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@value2", textBox7.Text);
                    command.Parameters.AddWithValue("@value3", textBox9.Text);
                    command.Parameters.AddWithValue("@value4", textBox8.Text);
                    command.Parameters.AddWithValue("@value5", textBox6.Text);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Produto foi adicionado/a com sucesso.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao adicionar Produto.");
                    }
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM produtos", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView2.DataSource = table;
                dataGridView2.ReadOnly = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            string query = "UPDATE atosmedicos SET Nome = @value2, Preco = @value3 WHERE IdAtosMedicos = @value1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@value1", textBox2.Text); // Supondo que textBox2 contém o IdAtosMedicos
                    command.Parameters.AddWithValue("@value2", textBox4.Text);
                    command.Parameters.AddWithValue("@value3", textBox5.Text);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ato Médico foi atualizado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado. Verifique se o IdAtosMedicos é válido.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao atualizar Ato Médico.");
                    }
                }
            }

            // Após a atualização, preencher novamente o DataGridView com os dados atualizados da tabela
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM atosmedicos", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;
                    dataGridView2.ReadOnly = true;
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            string query = "UPDATE produtos SET TipoFamilia = @value2, Descricao = @value3, QuantidadeArmazem = @value4, PrecoUnitario = @value5 WHERE IdProduto = @value1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@value1", textBox10.Text); // Supondo que textBox10 contém o IdProduto
                    command.Parameters.AddWithValue("@value2", textBox7.Text);
                    command.Parameters.AddWithValue("@value3", textBox9.Text);
                    command.Parameters.AddWithValue("@value4", textBox8.Text);
                    command.Parameters.AddWithValue("@value5", textBox6.Text);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Produto foi atualizado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado. Verifique se o IdProduto é válido.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao atualizar Produto.");
                    }
                }
            }

            // Após a atualização, preencher novamente o DataGridView com os dados atualizados da tabela
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM produtos", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView2.DataSource = table;
                    dataGridView2.ReadOnly = true;
                }
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBox2.Text = row.Cells[0].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBox4.Text = row.Cells[1].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                textBox5.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox10.Text = row.Cells[0].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox7.Text = row.Cells[1].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox9.Text = row.Cells[2].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox8.Text = row.Cells[3].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox6.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
