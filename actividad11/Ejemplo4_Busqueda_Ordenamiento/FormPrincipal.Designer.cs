namespace Ejemplo4_Busqueda_Ordenamiento
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
            tbValor = new TextBox();
            btnCalcularPromedio = new Button();
            btnRegistrar = new Button();
            lbValor = new Label();
            lbPromedio = new Label();
            lbResultado = new Label();
            tbResultado = new TextBox();
            btnListarOrdenado = new Button();
            tbBuscar = new TextBox();
            btnBuscar = new Button();
            lbBuscar = new Label();
            SuspendLayout();
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 10F);
            tbValor.Location = new Point(121, 40);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(136, 25);
            tbValor.TabIndex = 15;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Font = new Font("Segoe UI", 10F);
            btnCalcularPromedio.Location = new Point(275, 101);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(89, 54);
            btnCalcularPromedio.TabIndex = 17;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.Location = new Point(275, 25);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 52);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbValor.Location = new Point(24, 43);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(49, 19);
            lbValor.TabIndex = 12;
            lbValor.Text = "Valor:";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbPromedio.Location = new Point(24, 120);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(80, 19);
            lbPromedio.TabIndex = 13;
            lbPromedio.Text = "Promedio:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 10F);
            lbResultado.Location = new Point(121, 120);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 19);
            lbResultado.TabIndex = 14;
            lbResultado.Text = "Resultado";
            // 
            // tbResultado
            // 
            tbResultado.Font = new Font("Segoe UI", 10F);
            tbResultado.Location = new Point(24, 258);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(262, 97);
            tbResultado.TabIndex = 18;
            // 
            // btnListarOrdenado
            // 
            btnListarOrdenado.Font = new Font("Segoe UI", 10F);
            btnListarOrdenado.Location = new Point(303, 281);
            btnListarOrdenado.Name = "btnListarOrdenado";
            btnListarOrdenado.Size = new Size(89, 54);
            btnListarOrdenado.TabIndex = 19;
            btnListarOrdenado.Text = "Listar Ordenado";
            btnListarOrdenado.UseVisualStyleBackColor = true;
            btnListarOrdenado.Click += btnListarOrdenado_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Font = new Font("Segoe UI", 10F);
            tbBuscar.Location = new Point(24, 218);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(136, 25);
            tbBuscar.TabIndex = 20;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.Location = new Point(168, 218);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(89, 25);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lbBuscar
            // 
            lbBuscar.AutoSize = true;
            lbBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbBuscar.Location = new Point(24, 186);
            lbBuscar.Name = "lbBuscar";
            lbBuscar.Size = new Size(116, 19);
            lbBuscar.TabIndex = 22;
            lbBuscar.Text = "Buscar Número:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 379);
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
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbValor;
        private Button btnCalcularPromedio;
        private Button btnRegistrar;
        private Label lbValor;
        private Label lbPromedio;
        private Label lbResultado;
        private TextBox tbResultado;
        private Button btnListarOrdenado;
        private TextBox tbBuscar;
        private Button btnBuscar;
        private Label lbBuscar;
    }
}
