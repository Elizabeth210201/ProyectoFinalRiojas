namespace Proyecto_Final1
{
    partial class Arboles
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
      this.lblResultado = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnPostOrden = new System.Windows.Forms.Button();
      this.btnEnOrden = new System.Windows.Forms.Button();
      this.btnPreOrden = new System.Windows.Forms.Button();
      this.txtDato = new System.Windows.Forms.TextBox();
      this.btnBorrar = new System.Windows.Forms.Button();
      this.btnBuscar = new System.Windows.Forms.Button();
      this.btnInsertar = new System.Windows.Forms.Button();
      this.lblArbol = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblResultado
      // 
      this.lblResultado.AutoSize = true;
      this.lblResultado.Location = new System.Drawing.Point(214, 165);
      this.lblResultado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblResultado.Name = "lblResultado";
      this.lblResultado.Size = new System.Drawing.Size(0, 25);
      this.lblResultado.TabIndex = 31;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(122, 99);
      this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 25);
      this.label1.TabIndex = 30;
      this.label1.Text = "Dato:";
      // 
      // btnPostOrden
      // 
      this.btnPostOrden.Location = new System.Drawing.Point(329, 297);
      this.btnPostOrden.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnPostOrden.Name = "btnPostOrden";
      this.btnPostOrden.Size = new System.Drawing.Size(133, 82);
      this.btnPostOrden.TabIndex = 27;
      this.btnPostOrden.Text = "PostOrden";
      this.btnPostOrden.UseVisualStyleBackColor = true;
      this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
      // 
      // btnEnOrden
      // 
      this.btnEnOrden.Location = new System.Drawing.Point(194, 297);
      this.btnEnOrden.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnEnOrden.Name = "btnEnOrden";
      this.btnEnOrden.Size = new System.Drawing.Size(133, 82);
      this.btnEnOrden.TabIndex = 26;
      this.btnEnOrden.Text = "EnOrden";
      this.btnEnOrden.UseVisualStyleBackColor = true;
      this.btnEnOrden.Click += new System.EventHandler(this.btnEnOrden_Click);
      // 
      // btnPreOrden
      // 
      this.btnPreOrden.Location = new System.Drawing.Point(60, 297);
      this.btnPreOrden.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnPreOrden.Name = "btnPreOrden";
      this.btnPreOrden.Size = new System.Drawing.Size(133, 82);
      this.btnPreOrden.TabIndex = 25;
      this.btnPreOrden.Text = "PreOrden";
      this.btnPreOrden.UseVisualStyleBackColor = true;
      this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
      // 
      // txtDato
      // 
      this.txtDato.Location = new System.Drawing.Point(194, 99);
      this.txtDato.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.txtDato.Name = "txtDato";
      this.txtDato.Size = new System.Drawing.Size(130, 29);
      this.txtDato.TabIndex = 29;
      // 
      // btnBorrar
      // 
      this.btnBorrar.Location = new System.Drawing.Point(329, 202);
      this.btnBorrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnBorrar.Name = "btnBorrar";
      this.btnBorrar.Size = new System.Drawing.Size(133, 82);
      this.btnBorrar.TabIndex = 28;
      this.btnBorrar.Text = "Borrar";
      this.btnBorrar.UseVisualStyleBackColor = true;
      this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
      // 
      // btnBuscar
      // 
      this.btnBuscar.Location = new System.Drawing.Point(194, 202);
      this.btnBuscar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnBuscar.Name = "btnBuscar";
      this.btnBuscar.Size = new System.Drawing.Size(133, 82);
      this.btnBuscar.TabIndex = 24;
      this.btnBuscar.Text = "Buscar";
      this.btnBuscar.UseVisualStyleBackColor = true;
      this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
      // 
      // btnInsertar
      // 
      this.btnInsertar.Location = new System.Drawing.Point(60, 202);
      this.btnInsertar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.btnInsertar.Name = "btnInsertar";
      this.btnInsertar.Size = new System.Drawing.Size(133, 82);
      this.btnInsertar.TabIndex = 23;
      this.btnInsertar.Text = "Insertar";
      this.btnInsertar.UseVisualStyleBackColor = true;
      this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
      // 
      // lblArbol
      // 
      this.lblArbol.AutoSize = true;
      this.lblArbol.Location = new System.Drawing.Point(188, 441);
      this.lblArbol.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
      this.lblArbol.Name = "lblArbol";
      this.lblArbol.Size = new System.Drawing.Size(17, 25);
      this.lblArbol.TabIndex = 32;
      this.lblArbol.Text = ".";
      // 
      // Arboles
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(521, 482);
      this.Controls.Add(this.lblArbol);
      this.Controls.Add(this.lblResultado);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnPostOrden);
      this.Controls.Add(this.btnEnOrden);
      this.Controls.Add(this.btnPreOrden);
      this.Controls.Add(this.txtDato);
      this.Controls.Add(this.btnBorrar);
      this.Controls.Add(this.btnBuscar);
      this.Controls.Add(this.btnInsertar);
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "Arboles";
      this.Text = "Arboles";
      this.Load += new System.EventHandler(this.Arboles_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.Button btnEnOrden;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblArbol;
    }
}