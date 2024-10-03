namespace clinicaVet
{
    public partial class paginainicial : Form
    {
        public paginainicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes ClientesForm = new Clientes();
            ClientesForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Animais AnimaisForm = new Animais();
            AnimaisForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Agendamento AgendamentoForm = new Agendamento();
            AgendamentoForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ficha_Médica Ficha_MédicaForm = new Ficha_Médica();
            Ficha_MédicaForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Funcionários FuncionáriosForm = new Funcionários();
            FuncionáriosForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Atos_e_Produtos Atos_e_ProdutosForm = new Atos_e_Produtos();
            Atos_e_ProdutosForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}