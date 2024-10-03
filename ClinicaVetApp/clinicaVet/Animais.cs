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
    public partial class Animais : Form
    {
        public Animais()
        {
            InitializeComponent();
        }

        private void Animais_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM pacientes", connection);
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
            string query = "INSERT INTO pacientes (Nome, DataNascimento, DataFalecimento, DataUltimaConsulta, TipoAnimal, Raca, Sexo, Peso, Estado) VALUES (@value3, @value4, @value5, @value6, @value7, @value8, value9, value10, value11)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@value3", textBox5.Text);
                    command.Parameters.AddWithValue("@value4", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@value5", dateTimePicker2.Text);
                    command.Parameters.AddWithValue("@value6", dateTimePicker3.Text);
                    command.Parameters.AddWithValue("@value7", comboBox3.Text);
                    command.Parameters.AddWithValue("@value8", textBox3.Text);
                    command.Parameters.AddWithValue("@value9", comboBox1.Text);
                    command.Parameters.AddWithValue("@value10", textBox8.Text);
                    command.Parameters.AddWithValue("@value11", comboBox2.Text);
                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Animal " + textBox5.Text + " foi adicionado/a com sucesso.");
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao adicionar animal.");
                    }
                }
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM pacientes", connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
                dataGridView1.ReadOnly = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;password=11/12gon;database=dbclinicavet";
            string query = "UPDATE pacientes SET Nome = @value3, DataNascimento = @value4, DataFalecimento = @value5, DataUltimaConsulta = @value6, TipoAnimal = @value7, Raca = @value8, Sexo = @value9, Peso = @value10, Estado = @value11 WHERE IdPaciente = @value1";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@value1", textBox1.Text); // Supondo que textBox1 contém o IdPaciente
                    command.Parameters.AddWithValue("@value3", textBox5.Text);
                    command.Parameters.AddWithValue("@value4", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@value5", dateTimePicker2.Text);
                    command.Parameters.AddWithValue("@value6", dateTimePicker3.Text);
                    command.Parameters.AddWithValue("@value7", comboBox3.Text);
                    command.Parameters.AddWithValue("@value8", textBox3.Text);
                    command.Parameters.AddWithValue("@value9", comboBox1.Text);
                    command.Parameters.AddWithValue("@value10", textBox8.Text);
                    command.Parameters.AddWithValue("@value11", comboBox2.Text);

                    try
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Animal " + textBox5.Text + " foi atualizado/a com sucesso.");
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi atualizado. Verifique se o IdPaciente é válido.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Erro ao atualizar animal.");
                    }
                }
            }

            // Após a atualização, preencher novamente o DataGridView com os dados atualizados da tabela
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM pacientes", connection))
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
                dateTimePicker2.Text = row.Cells[3].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                dateTimePicker3.Text = row.Cells[4].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboBox3.Text = row.Cells[5].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox3.Text = row.Cells[6].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboBox1.Text = row.Cells[7].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox8.Text = row.Cells[8].Value.ToString();
            }

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                comboBox2.Text = row.Cells[9].Value.ToString();
            }
        }
    }
}
