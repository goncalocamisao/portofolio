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
    public partial class Funcionários : Form
    {
        public Funcionários()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void lblState_Click(object sender, EventArgs e)
        {
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {
        }

        private void lblNIF_Click(object sender, EventArgs e)
        {
        }

        private void lblDate_Click(object sender, EventArgs e)
        {
        }

        private void lblNome_Click(object sender, EventArgs e)
        {
        }

        private void lblID_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Funcionários_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM funcionarios", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            dataGridView1.ReadOnly = true;
        }

        private void txtboxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtboxSearch.Text.ToLower(); // convert search term to lowercase
            if (searchTerm != "")
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool found = false;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm)) // convert cell value to lowercase
                        {
                            found = true;
                            break;
                        }
                    }
                    row.Selected = found;
                }
            }
            else
            {
                // Clear any previous selection
                dataGridView1.ClearSelection();
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            string query = "INSERT INTO funcionarios (Nome, DataNascimento, NIF, TipoColaborador, Funcao, DataInicioColaboracao, DataFimColaboracao, Contatos) VALUES (@value2, @value3, @value4, @value5, @value6, @value7, @value8, value9)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@value2", textBox5.Text);
                    command.Parameters.AddWithValue("@value3", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@value4", textBox2.Text);
                    command.Parameters.AddWithValue("@value5", textBox6.Text);
                    command.Parameters.AddWithValue("@value6", textBox7.Text);
                    command.Parameters.AddWithValue("@value7", dateTimePicker2.Text);
                    command.Parameters.AddWithValue("@value8", dateTimePicker3.Text);
                    command.Parameters.AddWithValue("@value9", textBox3.Text);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Funcionário " + textBox6.Text + " foi adicionado/a com sucesso.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao adicionar Funcionário.");
                    }
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM funcionarios", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            string query = "UPDATE funcionarios SET Nome = @value2, DataNascimento = @value3, NIF = @value4, TipoColaborador = @value5, Funcao = @value6, DataInicioColaboracao = @value7, DataFimColaboracao = @value8, Contatos = @value9 WHERE IdFuncionario = @value1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@value1", textBox1.Text); // Supondo que textBox1 contém o IdFuncionario
                    command.Parameters.AddWithValue("@value2", textBox5.Text);
                    command.Parameters.AddWithValue("@value3", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@value4", textBox2.Text);
                    command.Parameters.AddWithValue("@value5", textBox6.Text);
                    command.Parameters.AddWithValue("@value6", textBox7.Text);
                    command.Parameters.AddWithValue("@value7", dateTimePicker2.Text);
                    command.Parameters.AddWithValue("@value8", dateTimePicker3.Text);
                    command.Parameters.AddWithValue("@value9", textBox3.Text);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Funcionário foi atualizado com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado. Verifique se o IdFuncionario é válido.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao atualizar Funcionário.");
                    }
                }
            }

            // Após a atualização, preencher novamente o DataGridView com os dados atualizados da tabela
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM funcionarios", connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                    dataGridView1.ReadOnly = true;
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox5.Text = row.Cells[1].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[3].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox6.Text = row.Cells[4].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox7.Text = row.Cells[5].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                dateTimePicker2.Text = row.Cells[6].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                dateTimePicker3.Text = row.Cells[7].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox3.Text = row.Cells[8].Value.ToString();
            }
        }
    }
}
