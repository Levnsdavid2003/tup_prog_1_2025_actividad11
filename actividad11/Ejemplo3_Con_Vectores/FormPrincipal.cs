namespace Ejemplo3_Con_Vectores
{
    public partial class FormPrincipal : Form
    {
        int contador = 0;
        double[] valores = new double[100];
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            double num;

            num = Convert.ToDouble(tbValor.Text);
            valores[contador] = num;
            contador++;
            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double acumulador = 0;
            double promedio = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }
            if (contador > 0)
            {
                promedio = acumulador / contador;
                lbResultado.Text = $"{promedio:f2}";
                tbResultado.Text = $"El resultado es: {promedio:f2}";
            }
            else
            {
                tbResultado.Text = "No se han cargado numeros";
            }
        }
    }
}
