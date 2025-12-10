namespace ConsultaCEP
{
    public partial class Menu : Form
    {
        private readonly API.ApiService _apiService = new();

        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var cep = textBox1.Text;
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Por favor, insira um CEP válido.");

                    return;
                }

                button1.Enabled = false;

                var response = await _apiService.BuscaCepAsync(cep);

                textBox2.Text = response.Logradouro;
                textBox3.Text = response.Complemento;
                textBox4.Text = response.UF;
                textBox5.Text = response.Estado;
                textBox6.Text = response.Numero;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na requisição: " + ex.Message);
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
