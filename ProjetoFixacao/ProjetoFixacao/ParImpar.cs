namespace ProjetoFixacao
{
    public partial class FrmParImpar : Form
    {
        public FrmParImpar()
        {
            InitializeComponent();
            btnCalcular.Enabled = false;
        }

        private void txtParImpar_TextChanged(object sender, EventArgs e)
        {
            if (txtParImpar.Text == string.Empty)
            {
                btnCalcular.Enabled = false;
            }
            else
            {
                btnCalcular.Enabled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {           
            int numero;
            numero = txtParImpar.Text.Length;

            if (numero %2 == 0)            
                MessageBox.Show("NÚMERO PAR");

            
            else            
                MessageBox.Show("NÚMERO IMPAR");                
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtParImpar.Text = string.Empty;
        }
    }
}