namespace Ejemplo4_Busqueda_Ordenamiento
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            double numBuscar = Convert.ToDouble(tbBuscar.Text);
            int indice = -1;

            for (int i = 0; i < contador && indice == -1; i++)
            {
                if (numBuscar == valores[i])
                {
                    indice = i;
                }
            }

            if (indice != -1)
            {
                tbResultado.Text = $"El numero {numBuscar} se encuentra en la posicion {indice}.";
            }
            else
            {
                tbResultado.Text = $"El numero {numBuscar} no se ha encontrado.";
            }
        }

        private void btnListarOrdenado_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < contador - 1; n++)
            {
                for (int m = n+1; m < contador; m++)
                {
                    if (valores[n] > valores[m])
                    {
                        double aux = valores[n];
                        valores[n] = valores[m];
                        valores[m] = aux;
                    }

                }
            }
            tbResultado.Text = "Los numeros ordenados son: ";
            for (int i = 0; i < contador; i++)
            {
                tbResultado.Text += $"{valores[i]} ";
            }
        }
    }
}
