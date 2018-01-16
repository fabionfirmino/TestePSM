namespace FormsIMC
{
    partial class Form1
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.lbImc = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(91, 21);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(79, 13);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "PROJETO IMC";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(12, 60);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(45, 13);
            this.lbPeso.TabIndex = 1;
            this.lbPeso.Text = "PESO =";
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Location = new System.Drawing.Point(12, 90);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(59, 13);
            this.lbAltura.TabIndex = 2;
            this.lbAltura.Text = "ALTURA =";
            // 
            // lbImc
            // 
            this.lbImc.AutoSize = true;
            this.lbImc.Location = new System.Drawing.Point(12, 122);
            this.lbImc.Name = "lbImc";
            this.lbImc.Size = new System.Drawing.Size(38, 13);
            this.lbImc.TabIndex = 3;
            this.lbImc.Text = "IMC = ";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(94, 57);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(178, 20);
            this.txtpeso.TabIndex = 4;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(94, 87);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(178, 20);
            this.txtaltura.TabIndex = 5;
            // 
            // txtimc
            // 
            this.txtimc.Location = new System.Drawing.Point(94, 119);
            this.txtimc.Name = "txtimc";
            this.txtimc.Size = new System.Drawing.Size(178, 20);
            this.txtimc.TabIndex = 6;
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(12, 173);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(107, 173);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 23);
            this.btlimpar.TabIndex = 8;
            this.btlimpar.Text = "LIMPAR";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(197, 173);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lbImc);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbPeso);
            this.Controls.Add(this.lbTitulo);
            this.Name = "Form1";
            this.Text = "Projeto IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.Label lbImc;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

