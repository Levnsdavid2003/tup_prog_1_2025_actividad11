namespace Ejemplo2_Sin_Vectores
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
            tbResultado = new TextBox();
            lbResultado = new Label();
            lbPromedio = new Label();
            lbValor = new Label();
            btnRegistrar = new Button();
            btnCalcularPromedio = new Button();
            tbValor = new TextBox();
            SuspendLayout();
            // 
            // tbResultado
            // 
            tbResultado.Location = new Point(54, 184);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(262, 97);
            tbResultado.TabIndex = 4;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(119, 124);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 19);
            lbResultado.TabIndex = 0;
            lbResultado.Text = "Resultado";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbPromedio.Location = new Point(22, 124);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(80, 19);
            lbPromedio.TabIndex = 0;
            lbPromedio.Text = "Promedio:";
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbValor.Location = new Point(22, 47);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(49, 19);
            lbValor.TabIndex = 0;
            lbValor.Text = "Valor:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(273, 29);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 52);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Location = new Point(273, 105);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(89, 54);
            btnCalcularPromedio.TabIndex = 3;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // tbValor
            // 
            tbValor.Location = new Point(119, 44);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(136, 25);
            tbValor.TabIndex = 1;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 305);
            Controls.Add(tbValor);
            Controls.Add(btnCalcularPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(lbValor);
            Controls.Add(lbPromedio);
            Controls.Add(lbResultado);
            Controls.Add(tbResultado);
            Font = new Font("Segoe UI", 10F);
            Name = "FormPrincipal";
            Text = "Ejemplo2 - Sin vectores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbResultado;
        private Label lbResultado;
        private Label lbPromedio;
        private Label lbValor;
        private Button btnRegistrar;
        private Button btnCalcularPromedio;
        private TextBox tbValor;
    }
}
