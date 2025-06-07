namespace Ejemplo2
{
    public partial class FormPrincipal : Form
    {
        int contador = 0;
        double[] valores = new double[100];
        public FormPrincipal()
        {
            InitializeComponent();
            lbRegistrarAviso.Visible = false;
            lbResultadoAviso.Visible = false;
        }

        private void tbRegistrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            lbResultadoAviso.Visible = false;
            double num;
            if (tbRegistrar.Text != String.Empty)
            {
                num = Convert.ToDouble(tbRegistrar.Text);
                lbRegistrarAviso.Visible = false;
                valores[contador] = num;
                contador++;
                tbRegistrar.Text = string.Empty;
            }
            else
            {
                lbRegistrarAviso.Text = "No hay número para agregar";
                lbRegistrarAviso.Visible = true;
            }
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double acumulador = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }

            if (contador > 0)
            {
                double promedio = acumulador / contador;
                tbResultado.Text = $"El resultado es: {promedio:f2}";
            }
            else
            {
                tbResultado.Text = "No se han cargado numeros";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            contador = 0;
            valores = new double[100];
            tbResultado.Text = string.Empty;
            lbResultadoAviso.Visible = true;
        }
    }
}
