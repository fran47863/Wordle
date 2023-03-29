namespace Wordle
{
    partial class Form1
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
            this.Titulo = new System.Windows.Forms.Label();
            this.TextoPalabraElegida = new System.Windows.Forms.Label();
            this.BotonGenerar = new System.Windows.Forms.Button();
            this.BotonComparar = new System.Windows.Forms.Button();
            this.TextoPalabraIngresada = new System.Windows.Forms.TextBox();
            this.ResultadoFinal = new System.Windows.Forms.Label();
            this.Letra0 = new System.Windows.Forms.Label();
            this.Letra1 = new System.Windows.Forms.Label();
            this.Letra2 = new System.Windows.Forms.Label();
            this.Letra3 = new System.Windows.Forms.Label();
            this.Letra4 = new System.Windows.Forms.Label();
            this.Instrucciones = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TituloIntentos = new System.Windows.Forms.Label();
            this.CantidadIntentos = new System.Windows.Forms.Label();
            this.Instrucciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Titulo.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titulo.Location = new System.Drawing.Point(29, 29);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(158, 44);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "WORDLE";
            // 
            // TextoPalabraElegida
            // 
            this.TextoPalabraElegida.AutoSize = true;
            this.TextoPalabraElegida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextoPalabraElegida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextoPalabraElegida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextoPalabraElegida.Location = new System.Drawing.Point(29, 73);
            this.TextoPalabraElegida.Name = "TextoPalabraElegida";
            this.TextoPalabraElegida.Size = new System.Drawing.Size(89, 21);
            this.TextoPalabraElegida.TabIndex = 1;
            this.TextoPalabraElegida.Text = "textoPrueba";
            // 
            // BotonGenerar
            // 
            this.BotonGenerar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonGenerar.Location = new System.Drawing.Point(29, 310);
            this.BotonGenerar.Name = "BotonGenerar";
            this.BotonGenerar.Size = new System.Drawing.Size(98, 36);
            this.BotonGenerar.TabIndex = 2;
            this.BotonGenerar.Text = "Generar";
            this.BotonGenerar.UseVisualStyleBackColor = true;
            this.BotonGenerar.Click += new System.EventHandler(this.BotonGenerar_Click);
            // 
            // BotonComparar
            // 
            this.BotonComparar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BotonComparar.Location = new System.Drawing.Point(133, 310);
            this.BotonComparar.Name = "BotonComparar";
            this.BotonComparar.Size = new System.Drawing.Size(98, 36);
            this.BotonComparar.TabIndex = 3;
            this.BotonComparar.Text = "Comparar";
            this.BotonComparar.UseVisualStyleBackColor = true;
            this.BotonComparar.Click += new System.EventHandler(this.BotonComparar_Click);
            // 
            // TextoPalabraIngresada
            // 
            this.TextoPalabraIngresada.Location = new System.Drawing.Point(29, 281);
            this.TextoPalabraIngresada.Name = "TextoPalabraIngresada";
            this.TextoPalabraIngresada.Size = new System.Drawing.Size(89, 23);
            this.TextoPalabraIngresada.TabIndex = 4;
            // 
            // ResultadoFinal
            // 
            this.ResultadoFinal.AutoSize = true;
            this.ResultadoFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultadoFinal.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ResultadoFinal.Location = new System.Drawing.Point(193, 44);
            this.ResultadoFinal.Name = "ResultadoFinal";
            this.ResultadoFinal.Size = new System.Drawing.Size(123, 24);
            this.ResultadoFinal.TabIndex = 5;
            this.ResultadoFinal.Text = "en proceso";
            // 
            // Letra0
            // 
            this.Letra0.AutoSize = true;
            this.Letra0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Letra0.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Letra0.Location = new System.Drawing.Point(29, 236);
            this.Letra0.Name = "Letra0";
            this.Letra0.Size = new System.Drawing.Size(23, 21);
            this.Letra0.TabIndex = 6;
            this.Letra0.Text = "...";
            // 
            // Letra1
            // 
            this.Letra1.AutoSize = true;
            this.Letra1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Letra1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Letra1.Location = new System.Drawing.Point(58, 236);
            this.Letra1.Name = "Letra1";
            this.Letra1.Size = new System.Drawing.Size(23, 21);
            this.Letra1.TabIndex = 6;
            this.Letra1.Text = "...";
            // 
            // Letra2
            // 
            this.Letra2.AutoSize = true;
            this.Letra2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Letra2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Letra2.Location = new System.Drawing.Point(87, 236);
            this.Letra2.Name = "Letra2";
            this.Letra2.Size = new System.Drawing.Size(23, 21);
            this.Letra2.TabIndex = 6;
            this.Letra2.Text = "...";
            // 
            // Letra3
            // 
            this.Letra3.AutoSize = true;
            this.Letra3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Letra3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Letra3.Location = new System.Drawing.Point(116, 236);
            this.Letra3.Name = "Letra3";
            this.Letra3.Size = new System.Drawing.Size(23, 21);
            this.Letra3.TabIndex = 6;
            this.Letra3.Text = "...";
            // 
            // Letra4
            // 
            this.Letra4.AutoSize = true;
            this.Letra4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Letra4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Letra4.Location = new System.Drawing.Point(145, 236);
            this.Letra4.Name = "Letra4";
            this.Letra4.Size = new System.Drawing.Size(23, 21);
            this.Letra4.TabIndex = 6;
            this.Letra4.Text = "...";
            // 
            // Instrucciones
            // 
            this.Instrucciones.Controls.Add(this.label1);
            this.Instrucciones.Location = new System.Drawing.Point(334, 139);
            this.Instrucciones.Name = "Instrucciones";
            this.Instrucciones.Size = new System.Drawing.Size(151, 118);
            this.Instrucciones.TabIndex = 7;
            this.Instrucciones.TabStop = false;
            this.Instrucciones.Text = "Instrucciones";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"o\" = Letra en posicion \r\ncorrecta.\r\n\"v\" = Letra en palabra, \r\nno en posicion cor" +
    "recta.\r\n\"x\" = Letra ausente en\r\n palabra.\r\n";
            // 
            // TituloIntentos
            // 
            this.TituloIntentos.AutoSize = true;
            this.TituloIntentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TituloIntentos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TituloIntentos.Location = new System.Drawing.Point(334, 104);
            this.TituloIntentos.Name = "TituloIntentos";
            this.TituloIntentos.Size = new System.Drawing.Size(122, 21);
            this.TituloIntentos.TabIndex = 8;
            this.TituloIntentos.Text = "Cant. de intentos";
            // 
            // CantidadIntentos
            // 
            this.CantidadIntentos.AutoSize = true;
            this.CantidadIntentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CantidadIntentos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CantidadIntentos.Location = new System.Drawing.Point(462, 104);
            this.CantidadIntentos.Name = "CantidadIntentos";
            this.CantidadIntentos.Size = new System.Drawing.Size(19, 21);
            this.CantidadIntentos.TabIndex = 9;
            this.CantidadIntentos.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 375);
            this.Controls.Add(this.CantidadIntentos);
            this.Controls.Add(this.TituloIntentos);
            this.Controls.Add(this.Instrucciones);
            this.Controls.Add(this.Letra4);
            this.Controls.Add(this.Letra3);
            this.Controls.Add(this.Letra2);
            this.Controls.Add(this.Letra1);
            this.Controls.Add(this.Letra0);
            this.Controls.Add(this.ResultadoFinal);
            this.Controls.Add(this.TextoPalabraIngresada);
            this.Controls.Add(this.BotonComparar);
            this.Controls.Add(this.BotonGenerar);
            this.Controls.Add(this.TextoPalabraElegida);
            this.Controls.Add(this.Titulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Instrucciones.ResumeLayout(false);
            this.Instrucciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Titulo;
        private Label TextoPalabraElegida;
        private Button BotonGenerar;
        private Button BotonComparar;
        private TextBox TextoPalabraIngresada;
        private Label ResultadoFinal;
        private Label Letra0;
        private Label Letra1;
        private Label Letra2;
        private Label Letra3;
        private Label Letra4;
        private GroupBox Instrucciones;
        private Label label1;
        private Label TituloIntentos;
        private Label CantidadIntentos;
    }
}