namespace Figuras_geometricas
{
    partial class Cuadrado
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
            this.numlado = new System.Windows.Forms.NumericUpDown();
            this.btncalcuadrado = new System.Windows.Forms.Button();
            this.lblareacuadrado = new System.Windows.Forms.Label();
            this.btncerrarcuadrado = new System.Windows.Forms.Button();
            this.lbltitulocuadrado = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lbllado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numlado)).BeginInit();
            this.SuspendLayout();
            // 
            // numlado
            // 
            this.numlado.DecimalPlaces = 2;
            this.numlado.Location = new System.Drawing.Point(242, 61);
            this.numlado.Name = "numlado";
            this.numlado.Size = new System.Drawing.Size(144, 20);
            this.numlado.TabIndex = 0;
            // 
            // btncalcuadrado
            // 
            this.btncalcuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btncalcuadrado.Font = new System.Drawing.Font("DFKaiSho-SB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btncalcuadrado.Location = new System.Drawing.Point(189, 102);
            this.btncalcuadrado.Name = "btncalcuadrado";
            this.btncalcuadrado.Size = new System.Drawing.Size(197, 37);
            this.btncalcuadrado.TabIndex = 1;
            this.btncalcuadrado.Text = "Calcular área del Cuadrado";
            this.btncalcuadrado.UseVisualStyleBackColor = false;
            this.btncalcuadrado.Click += new System.EventHandler(this.btncalcuadrado_Click);
            // 
            // lblareacuadrado
            // 
            this.lblareacuadrado.AutoSize = true;
            this.lblareacuadrado.Location = new System.Drawing.Point(271, 169);
            this.lblareacuadrado.Name = "lblareacuadrado";
            this.lblareacuadrado.Size = new System.Drawing.Size(10, 13);
            this.lblareacuadrado.TabIndex = 2;
            this.lblareacuadrado.Text = ".";
            // 
            // btncerrarcuadrado
            // 
            this.btncerrarcuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(142)))), ((int)(((byte)(14)))));
            this.btncerrarcuadrado.Location = new System.Drawing.Point(446, 193);
            this.btncerrarcuadrado.Name = "btncerrarcuadrado";
            this.btncerrarcuadrado.Size = new System.Drawing.Size(91, 33);
            this.btncerrarcuadrado.TabIndex = 3;
            this.btncerrarcuadrado.Text = "Regresar";
            this.btncerrarcuadrado.UseVisualStyleBackColor = false;
            this.btncerrarcuadrado.Click += new System.EventHandler(this.btncerrarcuadrado_Click);
            // 
            // lbltitulocuadrado
            // 
            this.lbltitulocuadrado.AutoSize = true;
            this.lbltitulocuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(91)))), ((int)(((byte)(37)))));
            this.lbltitulocuadrado.Font = new System.Drawing.Font("DFKaiSho-SB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltitulocuadrado.Location = new System.Drawing.Point(3, 9);
            this.lbltitulocuadrado.Name = "lbltitulocuadrado";
            this.lbltitulocuadrado.Size = new System.Drawing.Size(214, 21);
            this.lbltitulocuadrado.TabIndex = 4;
            this.lbltitulocuadrado.Text = "  Área del cuadrado...\r\n";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblresultado.Location = new System.Drawing.Point(174, 169);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(77, 16);
            this.lblresultado.TabIndex = 5;
            this.lblresultado.Text = "Resultado:";
            // 
            // lbllado
            // 
            this.lbllado.AutoSize = true;
            this.lbllado.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbllado.Location = new System.Drawing.Point(174, 65);
            this.lbllado.Name = "lbllado";
            this.lbllado.Size = new System.Drawing.Size(44, 16);
            this.lbllado.TabIndex = 6;
            this.lbllado.Text = "Lado:";
            // 
            // Cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(187)))), ((int)(((byte)(114)))));
            this.ClientSize = new System.Drawing.Size(549, 238);
            this.Controls.Add(this.lbllado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lbltitulocuadrado);
            this.Controls.Add(this.btncerrarcuadrado);
            this.Controls.Add(this.lblareacuadrado);
            this.Controls.Add(this.btncalcuadrado);
            this.Controls.Add(this.numlado);
            this.Name = "Cuadrado";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numlado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numlado;
        private System.Windows.Forms.Button btncalcuadrado;
        private System.Windows.Forms.Label lblareacuadrado;
        private System.Windows.Forms.Button btncerrarcuadrado;
        private System.Windows.Forms.Label lbltitulocuadrado;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lbllado;
    }
}