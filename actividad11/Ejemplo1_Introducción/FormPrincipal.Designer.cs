namespace Ejemplo1_Introducción
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
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 15F);
            btnMostrar.Location = new Point(52, 32);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(181, 60);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 127);
            Controls.Add(btnMostrar);
            Name = "FormPrincipal";
            Text = "Ejemplo1 - Introducción";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrar;
    }
}
