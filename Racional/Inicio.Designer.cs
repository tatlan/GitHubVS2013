namespace Racionales
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ir_a_sumas = new System.Windows.Forms.Button();
            this.ir_a_restas = new System.Windows.Forms.Button();
            this.ir_a_multiplicar = new System.Windows.Forms.Button();
            this.ir_a_divisiones = new System.Windows.Forms.Button();
            this.ir_a_calculadora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ir_a_sumas
            // 
            this.ir_a_sumas.BackColor = System.Drawing.Color.MidnightBlue;
            this.ir_a_sumas.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ir_a_sumas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ir_a_sumas.Location = new System.Drawing.Point(234, 30);
            this.ir_a_sumas.Name = "ir_a_sumas";
            this.ir_a_sumas.Size = new System.Drawing.Size(201, 51);
            this.ir_a_sumas.TabIndex = 0;
            this.ir_a_sumas.Text = "Sumas";
            this.ir_a_sumas.UseVisualStyleBackColor = false;
            this.ir_a_sumas.Click += new System.EventHandler(this.ir_a_sumas_Click);
            // 
            // ir_a_restas
            // 
            this.ir_a_restas.BackColor = System.Drawing.Color.MidnightBlue;
            this.ir_a_restas.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ir_a_restas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ir_a_restas.Location = new System.Drawing.Point(234, 96);
            this.ir_a_restas.Name = "ir_a_restas";
            this.ir_a_restas.Size = new System.Drawing.Size(201, 51);
            this.ir_a_restas.TabIndex = 1;
            this.ir_a_restas.Text = "Restas";
            this.ir_a_restas.UseVisualStyleBackColor = false;
            // 
            // ir_a_multiplicar
            // 
            this.ir_a_multiplicar.BackColor = System.Drawing.Color.MidnightBlue;
            this.ir_a_multiplicar.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ir_a_multiplicar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ir_a_multiplicar.Location = new System.Drawing.Point(234, 153);
            this.ir_a_multiplicar.Name = "ir_a_multiplicar";
            this.ir_a_multiplicar.Size = new System.Drawing.Size(201, 51);
            this.ir_a_multiplicar.TabIndex = 2;
            this.ir_a_multiplicar.Text = "Multiplicaciones";
            this.ir_a_multiplicar.UseVisualStyleBackColor = false;
            // 
            // ir_a_divisiones
            // 
            this.ir_a_divisiones.BackColor = System.Drawing.Color.MidnightBlue;
            this.ir_a_divisiones.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ir_a_divisiones.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ir_a_divisiones.Location = new System.Drawing.Point(470, 30);
            this.ir_a_divisiones.Name = "ir_a_divisiones";
            this.ir_a_divisiones.Size = new System.Drawing.Size(201, 51);
            this.ir_a_divisiones.TabIndex = 3;
            this.ir_a_divisiones.Text = "Divisiones";
            this.ir_a_divisiones.UseVisualStyleBackColor = false;
            // 
            // ir_a_calculadora
            // 
            this.ir_a_calculadora.BackColor = System.Drawing.Color.MidnightBlue;
            this.ir_a_calculadora.Font = new System.Drawing.Font("Hobo Std", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ir_a_calculadora.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ir_a_calculadora.Location = new System.Drawing.Point(470, 106);
            this.ir_a_calculadora.Name = "ir_a_calculadora";
            this.ir_a_calculadora.Size = new System.Drawing.Size(201, 51);
            this.ir_a_calculadora.TabIndex = 4;
            this.ir_a_calculadora.Text = "Calculadora";
            this.ir_a_calculadora.UseVisualStyleBackColor = false;
            this.ir_a_calculadora.Click += new System.EventHandler(this.ir_a_calculadora_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 261);
            this.Controls.Add(this.ir_a_calculadora);
            this.Controls.Add(this.ir_a_divisiones);
            this.Controls.Add(this.ir_a_multiplicar);
            this.Controls.Add(this.ir_a_restas);
            this.Controls.Add(this.ir_a_sumas);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ir_a_sumas;
        private System.Windows.Forms.Button ir_a_restas;
        private System.Windows.Forms.Button ir_a_multiplicar;
        private System.Windows.Forms.Button ir_a_divisiones;
        private System.Windows.Forms.Button ir_a_calculadora;
    }
}