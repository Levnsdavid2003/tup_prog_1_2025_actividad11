namespace Ejemplo6_Todo_Clase_Servicio
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
            btnMinimo = new Button();
            lbMinimoResultado = new Label();
            lbMinimo = new Label();
            btnMaximo = new Button();
            lbMaximoResultado = new Label();
            lbMaximo = new Label();
            lbBuscar = new Label();
            btnBuscar = new Button();
            tbBuscar = new TextBox();
            tbValor = new TextBox();
            btnCalcularPromedio = new Button();
            btnRegistrar = new Button();
            lbValor = new Label();
            lbPromedio = new Label();
            lbResultado = new Label();
            tbResultado = new TextBox();
            btnMayoresAlPromedio = new Button();
            btnListarOrdenado = new Button();
            SuspendLayout();
            // 
            // btnMinimo
            // 
            btnMinimo.Font = new Font("Segoe UI", 10F);
            btnMinimo.Location = new Point(270, 208);
            btnMinimo.Name = "btnMinimo";
            btnMinimo.Size = new Size(89, 54);
            btnMinimo.TabIndex = 56;
            btnMinimo.Text = "Calcular Mínimo";
            btnMinimo.UseVisualStyleBackColor = true;
            btnMinimo.Click += btnMinimo_Click;
            // 
            // lbMinimoResultado
            // 
            lbMinimoResultado.AutoSize = true;
            lbMinimoResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbMinimoResultado.Location = new Point(19, 227);
            lbMinimoResultado.Name = "lbMinimoResultado";
            lbMinimoResultado.Size = new Size(64, 19);
            lbMinimoResultado.TabIndex = 54;
            lbMinimoResultado.Text = "Mínimo:";
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.Font = new Font("Segoe UI", 10F);
            lbMinimo.Location = new Point(116, 227);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(108, 19);
            lbMinimo.TabIndex = 55;
            lbMinimo.Text = "Mínimo número";
            // 
            // btnMaximo
            // 
            btnMaximo.Font = new Font("Segoe UI", 10F);
            btnMaximo.Location = new Point(270, 148);
            btnMaximo.Name = "btnMaximo";
            btnMaximo.Size = new Size(89, 54);
            btnMaximo.TabIndex = 53;
            btnMaximo.Text = "Calcular Máximo";
            btnMaximo.UseVisualStyleBackColor = true;
            btnMaximo.Click += btnMaximo_Click;
            // 
            // lbMaximoResultado
            // 
            lbMaximoResultado.AutoSize = true;
            lbMaximoResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbMaximoResultado.Location = new Point(19, 167);
            lbMaximoResultado.Name = "lbMaximoResultado";
            lbMaximoResultado.Size = new Size(68, 19);
            lbMaximoResultado.TabIndex = 51;
            lbMaximoResultado.Text = "Máximo:";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.Font = new Font("Segoe UI", 10F);
            lbMaximo.Location = new Point(116, 167);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(110, 19);
            lbMaximo.TabIndex = 52;
            lbMaximo.Text = "Máximo número";
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbBuscar.Location = new Point(19, 287);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(116, 19);
            lbBuscar.TabIndex = 50;
            lbBuscar.Text = "Buscar Número:";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(163, 319);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 25);
            btnBuscar.TabIndex = 49;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Font = new Font("Segoe UI", 10F);
            tbBuscar.Location = new Point(19, 319);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(136, 25);
            tbBuscar.TabIndex = 48;
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 10F);
            tbValor.Location = new Point(116, 27);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(136, 25);
            tbValor.TabIndex = 43;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Font = new Font("Segoe UI", 10F);
            btnCalcularPromedio.Location = new Point(270, 88);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(89, 54);
            btnCalcularPromedio.TabIndex = 45;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.Location = new Point(270, 12);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 52);
            btnRegistrar.TabIndex = 44;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbValor.Location = new Point(19, 30);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(49, 19);
            lbValor.TabIndex = 40;
            lbValor.Text = "Valor:";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbPromedio.Location = new Point(19, 107);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(80, 19);
            lbPromedio.TabIndex = 41;
            lbPromedio.Text = "Promedio:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 10F);
            lbResultado.Location = new Point(116, 107);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 19);
            lbResultado.TabIndex = 42;
            lbResultado.Text = "Resultado";
            // 
            // tbResultado
            // 
            tbResultado.Font = new Font("Segoe UI", 10F);
            tbResultado.Location = new Point(19, 359);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(262, 131);
            tbResultado.TabIndex = 46;
            // 
            // btnMayoresAlPromedio
            // 
            btnMayoresAlPromedio.Font = new Font("Segoe UI", 10F);
            btnMayoresAlPromedio.Location = new Point(296, 413);
            btnMayoresAlPromedio.Name = "btnMayoresAlPromedio";
            btnMayoresAlPromedio.Size = new Size(89, 77);
            btnMayoresAlPromedio.TabIndex = 58;
            btnMayoresAlPromedio.Text = "Listado Superior al Promedio";
            btnMayoresAlPromedio.UseVisualStyleBackColor = true;
            btnMayoresAlPromedio.Click += btnMayoresAlPromedio_Click;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Font = new Font("Segoe UI", 10F);
            btnListarOrdenado.Location = new Point(296, 359);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(89, 48);
            btnListarOrdenado.TabIndex = 57;
            btnListarOrdenado.Text = "Listar Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 498);
            Controls.Add(btnMayoresAlPromedio);
            Controls.Add(btnListarOrdenado);
            Controls.Add(btnMinimo);
            Controls.Add(lbMinimoResultado);
            Controls.Add(lbMinimo);
            Controls.Add(btnMaximo);
            Controls.Add(lbMaximoResultado);
            Controls.Add(lbMaximo);
            Controls.Add(lbBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(tbValor);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(lbValor);
            Controls.Add(lbPromedio);
            Controls.Add(lbResultado);
            Controls.Add(tbResultado);
            Name = "FormPrincipal";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMinimo;
        private Label lbMinimoResultado;
        private Label lbMinimo;
        private Button btnMaximo;
        private Label lbMaximoResultado;
        private Label lbMaximo;
        private Label lbBuscar;
        private Button btnBuscar;
        private TextBox tbBuscar;
        private TextBox tbValor;
        private Button btnCalcularPromedio;
        private Button btnRegistrar;
        private Label lbValor;
        private Label lbPromedio;
        private Label lbResultado;
        private TextBox tbResultado;
        private Button btnMayoresAlPromedio;
        private Button btnListarOrdenado;
    }
}
