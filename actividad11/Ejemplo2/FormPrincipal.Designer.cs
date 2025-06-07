namespace Ejemplo2
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
            btnRegistrar = new Button();
            tbRegistrar = new TextBox();
            btnPromedio = new Button();
            tbResultado = new TextBox();
            lbResultado = new Label();
            btnLimpiar = new Button();
            lbRegistrarAviso = new Label();
            lbResultadoAviso = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 10F);
            btnRegistrar.Location = new Point(266, 23);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(110, 50);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbRegistrar
            // 
            tbRegistrar.Font = new Font("Microsoft Sans Serif", 15F);
            tbRegistrar.Location = new Point(24, 30);
            tbRegistrar.Name = "tbRegistrar";
            tbRegistrar.Size = new Size(217, 30);
            tbRegistrar.TabIndex = 9;
            tbRegistrar.TextChanged += tbRegistrar_TextChanged;
            // 
            // btnPromedio
            // 
            btnPromedio.Font = new Font("Microsoft Sans Serif", 10F);
            btnPromedio.Location = new Point(266, 93);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(110, 50);
            btnPromedio.TabIndex = 8;
            btnPromedio.Text = "Mostrar Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // tbResultado
            // 
            tbResultado.Font = new Font("Microsoft Sans Serif", 15F);
            tbResultado.Location = new Point(24, 169);
            tbResultado.Name = "tbResultado";
            tbResultado.Size = new Size(352, 30);
            tbResultado.TabIndex = 7;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Font = new Font("Microsoft Sans Serif", 15F);
            lbResultado.ForeColor = SystemColors.ControlDarkDark;
            lbResultado.Location = new Point(24, 141);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(99, 25);
            lbResultado.TabIndex = 6;
            lbResultado.Text = "Resultado";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Microsoft Sans Serif", 10F);
            btnLimpiar.Location = new Point(81, 248);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 33);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lbRegistrarAviso
            // 
            lbRegistrarAviso.AutoSize = true;
            lbRegistrarAviso.Font = new Font("Microsoft Sans Serif", 9F);
            lbRegistrarAviso.Location = new Point(24, 73);
            lbRegistrarAviso.Name = "lbRegistrarAviso";
            lbRegistrarAviso.Size = new Size(174, 15);
            lbRegistrarAviso.TabIndex = 12;
            lbRegistrarAviso.Text = "No hay números para agregar.";
            // 
            // lbResultadoAviso
            // 
            lbResultadoAviso.AutoSize = true;
            lbResultadoAviso.Font = new Font("Microsoft Sans Serif", 9F);
            lbResultadoAviso.Location = new Point(212, 257);
            lbResultadoAviso.Name = "lbResultadoAviso";
            lbResultadoAviso.Size = new Size(104, 15);
            lbResultadoAviso.TabIndex = 13;
            lbResultadoAviso.Text = "Registro limpiado";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 310);
            Controls.Add(lbResultadoAviso);
            Controls.Add(lbRegistrarAviso);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(tbRegistrar);
            Controls.Add(btnPromedio);
            Controls.Add(tbResultado);
            Controls.Add(lbResultado);
            MaximizeBox = false;
            Name = "FormPrincipal";
            Text = "Ejemplo2 - Vector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private TextBox tbRegistrar;
        private Button btnPromedio;
        private TextBox tbResultado;
        private Label lbResultado;
        private Button btnLimpiar;
        private Label lbRegistrarAviso;
        private Label lbResultadoAviso;
    }
}
