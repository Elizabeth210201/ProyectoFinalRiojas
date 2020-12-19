namespace Proyecto_Final1
{
    partial class Pilas
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
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.txtDato = new System.Windows.Forms.TextBox();
      this.btnPop = new System.Windows.Forms.Button();
      this.btnPush = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(48, 180);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(153, 20);
      this.label2.TabIndex = 11;
      this.label2.Text = "Numeros Insertados";
      this.label2.Click += new System.EventHandler(this.label2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(48, 35);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(124, 20);
      this.label1.TabIndex = 10;
      this.label1.Text = "Insertar Numero";
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(34, 218);
      this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(178, 144);
      this.listBox1.TabIndex = 9;
      this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
      // 
      // txtDato
      // 
      this.txtDato.Location = new System.Drawing.Point(34, 78);
      this.txtDato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtDato.Name = "txtDato";
      this.txtDato.Size = new System.Drawing.Size(148, 26);
      this.txtDato.TabIndex = 8;
      this.txtDato.TextChanged += new System.EventHandler(this.txtDato_TextChanged);
      // 
      // btnPop
      // 
      this.btnPop.Location = new System.Drawing.Point(279, 118);
      this.btnPop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnPop.Name = "btnPop";
      this.btnPop.Size = new System.Drawing.Size(112, 35);
      this.btnPop.TabIndex = 7;
      this.btnPop.Text = "Pop";
      this.btnPop.UseVisualStyleBackColor = true;
      this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
      // 
      // btnPush
      // 
      this.btnPush.Location = new System.Drawing.Point(279, 74);
      this.btnPush.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnPush.Name = "btnPush";
      this.btnPush.Size = new System.Drawing.Size(112, 35);
      this.btnPush.TabIndex = 6;
      this.btnPush.Text = "Push";
      this.btnPush.UseVisualStyleBackColor = true;
      this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
      // 
      // Pilas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(426, 402);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.txtDato);
      this.Controls.Add(this.btnPop);
      this.Controls.Add(this.btnPush);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "Pilas";
      this.Text = "Pilas";
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPush;
    }
}