namespace Proyecto_Final1
{
    partial class Grafos
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
            this.btnAgregarArista = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminarArista = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Union = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.Nodos = new System.Windows.Forms.ComboBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAgregarArista
            // 
            this.btnAgregarArista.Location = new System.Drawing.Point(224, 75);
            this.btnAgregarArista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregarArista.Name = "btnAgregarArista";
            this.btnAgregarArista.Size = new System.Drawing.Size(63, 47);
            this.btnAgregarArista.TabIndex = 13;
            this.btnAgregarArista.Text = "Agregar";
            this.btnAgregarArista.UseVisualStyleBackColor = true;
            this.btnAgregarArista.Click += new System.EventHandler(this.btnAgregarArista_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.Location = new System.Drawing.Point(33, 74);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(63, 47);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarArista
            // 
            this.btnEliminarArista.Location = new System.Drawing.Point(344, 74);
            this.btnEliminarArista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminarArista.Name = "btnEliminarArista";
            this.btnEliminarArista.Size = new System.Drawing.Size(63, 47);
            this.btnEliminarArista.TabIndex = 20;
            this.btnEliminarArista.Text = "Eliminar";
            this.btnEliminarArista.UseVisualStyleBackColor = true;
            this.btnEliminarArista.Click += new System.EventHandler(this.btnEliminarArista_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(102, 74);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(63, 47);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Union
            // 
            this.Union.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Union.FormattingEnabled = true;
            this.Union.Location = new System.Drawing.Point(344, 45);
            this.Union.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Union.Name = "Union";
            this.Union.Size = new System.Drawing.Size(60, 21);
            this.Union.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "De donde a donde";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(33, 153);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(77, 11);
            this.lblResultado.TabIndex = 18;
            this.lblResultado.Text = "RESULTADO";
            // 
            // Nodos
            // 
            this.Nodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Nodos.FormattingEnabled = true;
            this.Nodos.Location = new System.Drawing.Point(225, 45);
            this.Nodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Nodos.Name = "Nodos";
            this.Nodos.Size = new System.Drawing.Size(63, 21);
            this.Nodos.TabIndex = 15;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(68, 45);
            this.txtDato.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(73, 20);
            this.txtDato.TabIndex = 14;
            // 
            // Grafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 285);
            this.Controls.Add(this.btnAgregarArista);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminarArista);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.Union);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.Nodos);
            this.Controls.Add(this.txtDato);
            this.Name = "Grafos";
            this.Text = "Grafos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarArista;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminarArista;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox Union;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox Nodos;
        private System.Windows.Forms.TextBox txtDato;
    }
}