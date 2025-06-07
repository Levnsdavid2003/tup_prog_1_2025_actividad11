namespace Ejemplo3_Con_Vectores
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
            SuspendLayout();
            // 
            // tbValor
            // 
            tbValor.Font = new Font("Segoe UI", 10F);
            tbValor.Location = new Point(119, 44);
            tbValor.Name = "tbValor";
            tbValor.Size = new Size(136, 25);
            tbValor.TabIndex = 8;
            // 
            // btnCalcularPromedio
            // 
            btnCalcularPromedio.Font = new Font("Segoe UI", 10F);
            btnCalcularPromedio.Location = new Point(273, 105);
            btnCalcularPromedio.Name = "btnCalcularPromedio";
            btnCalcularPromedio.Size = new Size(89, 54);
            btnCalcularPromedio.TabIndex = 10;
            btnCalcularPromedio.Text = "Calcular Promedio";
            btnCalcularPromedio.UseVisualStyleBackColor = true;
            btnCalcularPromedio.Click += btnCalcularPromedio_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.Location = new Point(273, 29);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(89, 52);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbValor
            // 
            lbValor.AutoSize = true;
            lbValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbValor.Location = new Point(22, 47);
            lbValor.Name = "lbValor";
            lbValor.Size = new Size(49, 19);
            lbValor.TabIndex = 5;
            lbValor.Text = "Valor:";
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbPromedio.Location = new Point(22, 124);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(80, 19);
            lbPromedio.TabIndex = 6;
            lbPromedio.Text = "Promedio:";
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Segoe UI", 10F);
            lbResultado.Location = new Point(119, 124);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(69, 19);
            lbResultado.TabIndex = 7;
            lbResultado.Text = "Resultado";
            // 
            // tbResultado
            // 
            tbResultado.Font = new Font("Segoe UI", 10F);
            tbResultado.Location = new Point(54, 184);
            tbResultado.Multiline = true;
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(262, 97);
            tbResultado.TabIndex = 11;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 301);
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
    }
}
