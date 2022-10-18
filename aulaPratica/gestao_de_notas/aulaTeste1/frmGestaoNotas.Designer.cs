namespace aulaTeste1
{
    partial class frmGestaoNotas
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
            this.lblNP1 = new System.Windows.Forms.Label();
            this.lblNP2 = new System.Windows.Forms.Label();
            this.lblNP3 = new System.Windows.Forms.Label();
            this.lblNP4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNP1 = new System.Windows.Forms.TextBox();
            this.txtNP2 = new System.Windows.Forms.TextBox();
            this.txtNP3 = new System.Windows.Forms.TextBox();
            this.txtNP4 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNP1
            // 
            this.lblNP1.AutoSize = true;
            this.lblNP1.Location = new System.Drawing.Point(101, 22);
            this.lblNP1.Name = "lblNP1";
            this.lblNP1.Size = new System.Drawing.Size(31, 13);
            this.lblNP1.TabIndex = 0;
            this.lblNP1.Text = "NP1:";
            // 
            // lblNP2
            // 
            this.lblNP2.AutoSize = true;
            this.lblNP2.Location = new System.Drawing.Point(101, 61);
            this.lblNP2.Name = "lblNP2";
            this.lblNP2.Size = new System.Drawing.Size(31, 13);
            this.lblNP2.TabIndex = 1;
            this.lblNP2.Text = "NP2:";
            // 
            // lblNP3
            // 
            this.lblNP3.AutoSize = true;
            this.lblNP3.Location = new System.Drawing.Point(101, 87);
            this.lblNP3.Name = "lblNP3";
            this.lblNP3.Size = new System.Drawing.Size(31, 13);
            this.lblNP3.TabIndex = 2;
            this.lblNP3.Text = "NP3:";
            // 
            // lblNP4
            // 
            this.lblNP4.AutoSize = true;
            this.lblNP4.Location = new System.Drawing.Point(101, 116);
            this.lblNP4.Name = "lblNP4";
            this.lblNP4.Size = new System.Drawing.Size(31, 13);
            this.lblNP4.TabIndex = 3;
            this.lblNP4.Text = "NP4:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(101, 158);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtNP1
            // 
            this.txtNP1.Location = new System.Drawing.Point(203, 22);
            this.txtNP1.Name = "txtNP1";
            this.txtNP1.Size = new System.Drawing.Size(100, 20);
            this.txtNP1.TabIndex = 5;
            // 
            // txtNP2
            // 
            this.txtNP2.Location = new System.Drawing.Point(203, 58);
            this.txtNP2.Name = "txtNP2";
            this.txtNP2.Size = new System.Drawing.Size(100, 20);
            this.txtNP2.TabIndex = 6;
            // 
            // txtNP3
            // 
            this.txtNP3.Location = new System.Drawing.Point(203, 84);
            this.txtNP3.Name = "txtNP3";
            this.txtNP3.Size = new System.Drawing.Size(100, 20);
            this.txtNP3.TabIndex = 7;
            // 
            // txtNP4
            // 
            this.txtNP4.Location = new System.Drawing.Point(203, 116);
            this.txtNP4.Name = "txtNP4";
            this.txtNP4.Size = new System.Drawing.Size(100, 20);
            this.txtNP4.TabIndex = 8;
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(203, 155);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(104, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(228, 224);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(348, 224);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmGestaoNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 344);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNP4);
            this.Controls.Add(this.txtNP3);
            this.Controls.Add(this.txtNP2);
            this.Controls.Add(this.txtNP1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNP4);
            this.Controls.Add(this.lblNP3);
            this.Controls.Add(this.lblNP2);
            this.Controls.Add(this.lblNP1);
            this.Name = "frmGestaoNotas";
            this.Text = "Gestão de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNP1;
        private System.Windows.Forms.Label lblNP2;
        private System.Windows.Forms.Label lblNP3;
        private System.Windows.Forms.Label lblNP4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNP1;
        private System.Windows.Forms.TextBox txtNP2;
        private System.Windows.Forms.TextBox txtNP3;
        private System.Windows.Forms.TextBox txtNP4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}