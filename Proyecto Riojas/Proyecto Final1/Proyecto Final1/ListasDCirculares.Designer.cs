namespace Proyecto_Final1
{
    partial class ListasDCirculares
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
      this.btnBorrar = new System.Windows.Forms.Button();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.btnMostrarDatos = new System.Windows.Forms.Button();
      this.btnContar = new System.Windows.Forms.Button();
      this.txtInsertar = new System.Windows.Forms.TextBox();
      this.btnInsertar = new System.Windows.Forms.Button();
      this.lblContarDes = new System.Windows.Forms.Label();
      this.lblContar = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnBorrar
      // 
      this.btnBorrar.Location = new System.Drawing.Point(372, 255);
      this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnBorrar.Name = "btnBorrar";
      this.btnBorrar.Size = new System.Drawing.Size(112, 35);
      this.btnBorrar.TabIndex = 10;
      this.btnBorrar.Text = "Borrar";
      this.btnBorrar.UseVisualStyleBackColor = true;
      this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(372, 151);
      this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(112, 35);
      this.btnBuscar.TabIndex = 11;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnMostrarDatos
      // 
      this.btnMostrarDatos.Location = new System.Drawing.Point(202, 255);
      this.btnMostrarDatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnMostrarDatos.Name = "btnMostrarDatos";
      this.btnMostrarDatos.Size = new System.Drawing.Size(112, 35);
      this.btnMostrarDatos.TabIndex = 9;
      this.btnMostrarDatos.Text = "Mostrar";
      this.btnMostrarDatos.UseVisualStyleBackColor = true;
      this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
      // 
      // btnContar
      // 
      this.btnContar.Location = new System.Drawing.Point(36, 255);
      this.btnContar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnContar.Name = "btnContar";
      this.btnContar.Size = new System.Drawing.Size(112, 35);
      this.btnContar.TabIndex = 8;
      this.btnContar.Text = "Contar";
      this.btnContar.UseVisualStyleBackColor = true;
      this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
      // 
      // txtInsertar
      // 
      this.txtInsertar.Location = new System.Drawing.Point(186, 154);
      this.txtInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtInsertar.Name = "txtInsertar";
      this.txtInsertar.Size = new System.Drawing.Size(148, 26);
      this.txtInsertar.TabIndex = 6;
      this.txtInsertar.TextChanged += new System.EventHandler(this.txtInsertar_TextChanged);
      // 
      // btnInsertar
      // 
      this.btnInsertar.Location = new System.Drawing.Point(36, 151);
      this.btnInsertar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(112, 35);
      this.btnInsertar.TabIndex = 7;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // lblContarDes
      // 
      this.lblContarDes.AutoSize = true;
      this.lblContarDes.Location = new System.Drawing.Point(182, 426);
      this.lblContarDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblContarDes.Name = "lblContarDes";
      this.lblContarDes.Size = new System.Drawing.Size(29, 20);
      this.lblContarDes.TabIndex = 17;
      this.lblContarDes.Text = ".....";
      this.lblContarDes.Click += new System.EventHandler(this.lblContarDes_Click);
      // 
      // lblContar
      // 
      this.lblContar.AutoSize = true;
      this.lblContar.Location = new System.Drawing.Point(182, 340);
      this.lblContar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblContar.Name = "lblContar";
      this.lblContar.Size = new System.Drawing.Size(29, 20);
      this.lblContar.TabIndex = 16;
      this.lblContar.Text = ".....";
      this.lblContar.Click += new System.EventHandler(this.lblContar_Click);
      // 
      // ListasDCirculares
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(513, 480);
      this.Controls.Add(this.lblContarDes);
      this.Controls.Add(this.lblContar);
      this.Controls.Add(this.btnBorrar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnMostrarDatos);
      this.Controls.Add(this.btnContar);
      this.Controls.Add(this.txtInsertar);
      this.Controls.Add(this.btnInsertar);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "ListasDCirculares";
      this.Text = "ListasDCirculares";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.TextBox txtInsertar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblContarDes;
        private System.Windows.Forms.Label lblContar;
    }
}