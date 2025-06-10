namespace Ejemplo5_MayoresPromedio_MaximoYMinimo
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbBuscar = new Label();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            btnListarOrdenado = new Button();
            tbValor = new TextBox();
            btnCalcularPromedio = new Button();
            btnRegistrar = new Button();
            lbValor = new Label();
            lbPromedio = new Label();
            lbResultado = new Label();
            tbResultado = new TextBox();
            btnMaximo = new Button();
            lbMaximoResultado = new Label();
            lbMaximo = new Label();
            btnMinimo = new Button();
            lbMinimoResultado = new Label();
            lbMinimo = new Label();
            btnMayoresAlPromedio = new Button();
            SuspendLayout();
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbBuscar.Location = new Point(32, 290);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(116, 19);
            lbBuscar.TabIndex = 33;
            lbBuscar.Text = "Buscar Número:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(176, 322);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 25);
            btnBuscar.TabIndex = 32;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Font = new Font("Segoe UI", 10F);
            tbBuscar.Location = new Point(32, 322);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(136, 25);
            tbBuscar.TabIndex = 31;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Font = new Font("Segoe UI", 10F);
            btnListarOrdenado.Location = new Point(311, 362);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(89, 48);
            btnListarOrdenado.TabIndex = 30;
            btnListarOrdenado.Text = "Listar Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 10F);
            tbValor.Location = new Point(129, 30);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(136, 25);
            tbValor.TabIndex = 26;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Font = new Font("Segoe UI", 10F);
            btnCalcularPromedio.Location = new Point(283, 91);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(89, 54);
            btnCalcularPromedio.TabIndex = 28;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.Location = new Point(283, 15);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 52);
            btnRegistrar.TabIndex = 27;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbValor.Location = new Point(32, 33);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(49, 19);
            lbValor.TabIndex = 23;
            lbValor.Text = "Valor:";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbPromedio.Location = new Point(32, 110);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(80, 19);
            lbPromedio.TabIndex = 24;
            lbPromedio.Text = "Promedio:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 10F);
            lbResultado.Location = new Point(129, 110);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 19);
            lbResultado.TabIndex = 25;
            lbResultado.Text = "Resultado";
            // 
            // tbResultado
            // 
            tbResultado.Font = new Font("Segoe UI", 10F);
            tbResultado.Location = new Point(32, 362);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(262, 131);
            tbResultado.TabIndex = 29;
            // 
            // btnMaximo
            // 
            btnMaximo.Font = new Font("Segoe UI", 10F);
            btnMaximo.Location = new Point(283, 151);
            btnMaximo.Name = "btnMaximo";
            btnMaximo.Size = new Size(89, 54);
            btnMaximo.TabIndex = 36;
            btnMaximo.Text = "Calcular Máximo";
            btnMaximo.UseVisualStyleBackColor = true;
            btnMaximo.Click += btnMaximo_Click;
            // 
            // lbMaximoResultado
            // 
            lbMaximoResultado.AutoSize = true;
            lbMaximoResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbMaximoResultado.Location = new Point(32, 170);
            lbMaximoResultado.Name = "lbMaximoResultado";
            lbMaximoResultado.Size = new Size(68, 19);
            lbMaximoResultado.TabIndex = 34;
            lbMaximoResultado.Text = "Máximo:";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.Font = new Font("Segoe UI", 10F);
            lbMaximo.Location = new Point(129, 170);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(110, 19);
            lbMaximo.TabIndex = 35;
            lbMaximo.Text = "Máximo número";
            // 
            // btnMinimo
            // 
            btnMinimo.Font = new Font("Segoe UI", 10F);
            btnMinimo.Location = new Point(283, 211);
            btnMinimo.Name = "btnMinimo";
            btnMinimo.Size = new Size(89, 54);
            btnMinimo.TabIndex = 39;
            btnMinimo.Text = "Calcular Mínimo";
            btnMinimo.UseVisualStyleBackColor = true;
            btnMinimo.Click += btnMinimo_Click;
            // 
            // lbMinimoResultado
            // 
            lbMinimoResultado.AutoSize = true;
            lbMinimoResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbMinimoResultado.Location = new Point(32, 230);
            lbMinimoResultado.Name = "lbMinimoResultado";
            lbMinimoResultado.Size = new Size(64, 19);
            lbMinimoResultado.TabIndex = 37;
            lbMinimoResultado.Text = "Mínimo:";
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.Font = new Font("Segoe UI", 10F);
            lbMinimo.Location = new Point(129, 230);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(108, 19);
            lbMinimo.TabIndex = 38;
            lbMinimo.Text = "Mínimo número";
            // 
            // btnMayoresAlPromedio
            // 
            btnMayoresAlPromedio.Font = new Font("Segoe UI", 10F);
            btnMayoresAlPromedio.Location = new Point(311, 416);
            btnMayoresAlPromedio.Name = "btnMayoresAlPromedio";
            btnMayoresAlPromedio.Size = new Size(89, 77);
            btnMayoresAlPromedio.TabIndex = 41;
            btnMayoresAlPromedio.Text = "Listado Superior al Promedio";
            btnMayoresAlPromedio.UseVisualStyleBackColor = true;
            btnMayoresAlPromedio.Click += btnMayoresAlPromedio_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 505);
            Controls.Add(btnMayoresAlPromedio);
            Controls.Add(btnMinimo);
            Controls.Add(lbMinimoResultado);
            Controls.Add(lbMinimo);
            Controls.Add(btnMaximo);
            Controls.Add(lbMaximoResultado);
            Controls.Add(lbMaximo);
            Controls.Add(lbBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(btnListarOrdenado);
            Controls.Add(tbValor);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(lbValor);
            Controls.Add(lbPromedio);
            Controls.Add(lbResultado);
            Controls.Add(tbResultado);
            Name = "FormPrincipal";
            Text = "Ejemplo5 - Promedio, Máximo y Mínimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBuscar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private Button btnListarOrdenado;
        private TextBox tbValor;
        private Button btnCalcularPromedio;
        private Button btnRegistrar;
        private Label lbValor;
        private Label lbPromedio;
        private Label lbResultado;
        private TextBox tbResultado;
        private Button btnMaximo;
        private Label lbMaximoResultado;
        private Label lbMaximo;
        private Button btnMinimo;
        private Label lbMinimoResultado;
        private Label lbMinimo;
        private Button btnMayoresAlPromedio;
    }
}
