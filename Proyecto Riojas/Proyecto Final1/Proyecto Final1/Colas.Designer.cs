namespace Proyecto_Final1
{
    partial class Colas
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
      this.Numero = new System.Windows.Forms.Label();
      this.txtNumero = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaximo = new System.Windows.Forms.TextBox();
      this.btnDesencolar = new System.Windows.Forms.Button();
      this.btnEncolar = new System.Windows.Forms.Button();
      this.btnCrear = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Numero
      // 
      this.Numero.AutoSize = true;
      this.Numero.Location = new System.Drawing.Point(32, 192);
      this.Numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.Numero.Name = "Numero";
      this.Numero.Size = new System.Drawing.Size(65, 20);
      this.Numero.TabIndex = 22;
      this.Numero.Text = "Numero";
      this.Numero.Click += new System.EventHandler(this.Numero_Click);
      // 
      // txtNumero
      // 
      this.txtNumero.Location = new System.Drawing.Point(106, 188);
      this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtNumero.Name = "txtNumero";
      this.txtNumero.Size = new System.Drawing.Size(148, 26);
      this.txtNumero.TabIndex = 21;
      this.txtNumero.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(33, 148);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 20);
      this.label1.TabIndex = 20;
      this.label1.Text = "Maximo";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // txtMaximo
      // 
      this.txtMaximo.Location = new System.Drawing.Point(106, 143);
      this.txtMaximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtMaximo.Name = "txtMaximo";
      this.txtMaximo.Size = new System.Drawing.Size(148, 26);
      this.txtMaximo.TabIndex = 19;
      this.txtMaximo.TextChanged += new System.EventHandler(this.txtMaximo_TextChanged);
      // 
      // btnDesencolar
      // 
      this.btnDesencolar.Location = new System.Drawing.Point(284, 228);
      this.btnDesencolar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnDesencolar.Name = "btnDesencolar";
      this.btnDesencolar.Size = new System.Drawing.Size(112, 35);
      this.btnDesencolar.TabIndex = 18;
      this.btnDesencolar.Text = "Desencolar";
      this.btnDesencolar.UseVisualStyleBackColor = true;
      this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
      // 
      // btnEncolar
      // 
      this.btnEncolar.Location = new System.Drawing.Point(284, 183);
      this.btnEncolar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnEncolar.Name = "btnEncolar";
      this.btnEncolar.Size = new System.Drawing.Size(112, 35);
      this.btnEncolar.TabIndex = 17;
      this.btnEncolar.Text = "Encolar";
      this.btnEncolar.UseVisualStyleBackColor = true;
      this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
      // 
      // btnCrear
      // 
      this.btnCrear.Location = new System.Drawing.Point(284, 138);
      this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnCrear.Name = "btnCrear";
      this.btnCrear.Size = new System.Drawing.Size(112, 35);
      this.btnCrear.TabIndex = 16;
      this.btnCrear.Text = "Crear";
      this.btnCrear.UseVisualStyleBackColor = true;
      this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
      // 
      // Colas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(426, 402);
      this.Controls.Add(this.Numero);
      this.Controls.Add(this.txtNumero);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMaximo);
      this.Controls.Add(this.btnDesencolar);
      this.Controls.Add(this.btnEncolar);
      this.Controls.Add(this.btnCrear);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Colas";
      this.Text = "Colas";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnCrear;

    }
}