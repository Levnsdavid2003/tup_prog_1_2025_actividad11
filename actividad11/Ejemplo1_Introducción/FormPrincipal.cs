namespace Ejemplo1_Introducción
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Text = "Hola, mundo!";
        }
    }
}
