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
            tbResultado.Text = $@"N�mero m�ximo:
    {maximo:f2}";
        }

        private void btnMinimo_Click(object sender, EventArgs e)
        {
            double minimo = servicio.CalcularMinimo();
            lbMinimo.Text = $"{minimo:f2}";
            tbResultado.Text = $@"N�mero m�nimo:
    {minimo:f2}";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            double numBuscar = Convert.ToDouble(tbBuscar.Text);
            int indice = servicio.BuscarNumero(numBuscar);

            if (indice != -1)
            {
                tbResultado.Text = $@"El n�mero se encuentra en la posici�n:
    {indice}";
            }
            else
            {
                tbResultado.Text = "No se encontr� el n�mero buscado.";
            }
        }



    }
}
