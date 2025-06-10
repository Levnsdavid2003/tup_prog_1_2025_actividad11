using Ejemplo6_Todo_Clase_Servicio.Models;

namespace Ejemplo6_Todo_Clase_Servicio
{
    public partial class FormPrincipal : Form
    {
        Servicio servicio = new Servicio();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            servicio.RegistrarValor(Convert.ToDouble(tbValor.Text));
            tbValor.Clear();
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            double promedio = servicio.CalcularPromedio();

            lbResultado.Text = $"{promedio:f2}";
            tbResultado.Text = $@"Promedio:
    {promedio:f2}";
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            double maximo = servicio.CalcularMaximo();
            lbMaximo.Text = $"{maximo:f2}";
            tbResultado.Text = $@"Número máximo:
    {maximo:f2}";
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            double minimo = servicio.CalcularMinimo();
            lbMinimo.Text = $"{minimo:f2}";
            tbResultado.Text = $@"Número mínimo:
    {minimo:f2}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            double numBuscar = Convert.ToDouble(tbBuscar.Text);
            int indice = servicio.BuscarNumero(numBuscar);

            if (indice != -1)
            {
                tbResultado.Text = $@"El número se encuentra en la posición:
    {indice}";
            }
            else
            {
                tbResultado.Text = "No se encontró el número buscado.";
            }
        }

        private void btnListarOrdenado_Click(object sender, EventArgs e)
        {
            servicio.ReordenarNums();

            tbResultado.Text = "Los numeros ordenados son: ";
            for (int i = 0; i < servicio.contador; i++)
            {
                tbResultado.Text += $"{servicio.valores[i]} ";
            }
        }

        private void btnMayoresAlPromedio_Click(object sender, EventArgs e)
        {
            int cantidadMayores = 0;
            int[] indiceMayores = servicio.CalcularMayoresAlPromedio(out cantidadMayores);

            tbResultado.Text = "Los números mayores al promedio son: \n";

            for (int n = 0; n < cantidadMayores; n++)
            {
                int indice = indiceMayores[n];
                tbResultado.Text += $"{servicio.valores[indice],5:f2}, ";
            }

        }
    }
}
