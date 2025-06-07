namespace Ejemplo2_Sin_Vectores
{
    public partial class FormPrincipal : Form
    {
        int contador = 0;
        double acumulador = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(tbValor.Text);
            acumulador += num;
            contador++;
            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;
            lbResultado.Text = $"{promedio:f2}";
            tbResultado.Text = $"El resultado es: {promedio:f2}";
        }
    }
}
