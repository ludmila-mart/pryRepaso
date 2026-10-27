namespace pryRepaso
{
    public partial class frmCargadedatos : Form
    {
        public frmCargadedatos()

        {
            InitializeComponent();
        }
        
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int ValorRegistradoCodigo = Convert.ToInt32(txtCodigo.Text);
            string ValorRegistradoNombre = txtNombre.Text;

            MessageBox.Show("Codigo: " + ValorRegistradoCodigo + " Nombre: " + ValorRegistradoNombre);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
