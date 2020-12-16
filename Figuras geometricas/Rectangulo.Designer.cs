namespace Figuras_geometricas
{
    partial class Rectangulo
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
            this.btncalarearectangulo = new System.Windows.Forms.Button();
            this.numbaserec = new System.Windows.Forms.NumericUpDown();
            this.lblarearectangulo = new System.Windows.Forms.Label();
            this.numalturarec = new System.Windows.Forms.NumericUpDown();
            this.lblbase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lbltitulorectangulo = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.lbalResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numbaserec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numalturarec)).BeginInit();
            this.SuspendLayout();
            // 
            // btncalarearectangulo
            // 
            this.btncalarearectangulo.BackColor = System.Drawing.Color.LimeGreen;
            this.btncalarearectangulo.Location = new System.Drawing.Point(157, 163);
            this.btncalarearectangulo.Name = "btncalarearectangulo";
            this.btncalarearectangulo.Size = new System.Drawing.Size(321, 39);
            this.btncalarearectangulo.TabIndex = 0;
            this.btncalarearectangulo.Text = "Calcular área del rectangulo";
            this.btncalarearectangulo.UseVisualStyleBackColor = false;
            this.btncalarearectangulo.Click += new System.EventHandler(this.btncalarearetangulo_Click);
            // 
            // numbaserec
            // 
            this.numbaserec.DecimalPlaces = 3;
            this.numbaserec.Location = new System.Drawing.Point(297, 68);
            this.numbaserec.Name = "numbaserec";
            this.numbaserec.Size = new System.Drawing.Size(120, 20);
            this.numbaserec.TabIndex = 1;
            // 
            // lblarearectangulo
            // 
            this.lblarearectangulo.AutoSize = true;
            this.lblarearectangulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarearectangulo.Location = new System.Drawing.Point(343, 226);
            this.lblarearectangulo.Name = "lblarearectangulo";
            this.lblarearectangulo.Size = new System.Drawing.Size(12, 18);
            this.lblarearectangulo.TabIndex = 2;
            this.lblarearectangulo.Text = ".";
            
            // 
            // numalturarec
            // 
            this.numalturarec.DecimalPlaces = 3;
            this.numalturarec.Location = new System.Drawing.Point(297, 126);
            this.numalturarec.Name = "numalturarec";
            this.numalturarec.Size = new System.Drawing.Size(120, 20);
            this.numalturarec.TabIndex = 3;
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblbase.Location = new System.Drawing.Point(223, 68);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(44, 16);
            this.lblbase.TabIndex = 4;
            this.lblbase.Text = "Base:";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblaltura.Location = new System.Drawing.Point(223, 124);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(52, 16);
            this.lblaltura.TabIndex = 5;
            this.lblaltura.Text = "Altura:";
            // 
            // lbltitulorectangulo
            // 
            this.lbltitulorectangulo.AutoSize = true;
            this.lbltitulorectangulo.BackColor = System.Drawing.Color.LawnGreen;
            this.lbltitulorectangulo.Font = new System.Drawing.Font("DFKaiSho-SB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltitulorectangulo.Location = new System.Drawing.Point(13, 4);
            this.lbltitulorectangulo.Name = "lbltitulorectangulo";
            this.lbltitulorectangulo.Size = new System.Drawing.Size(187, 21);
            this.lbltitulorectangulo.TabIndex = 6;
            this.lbltitulorectangulo.Text = "Área del Rectangulo";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btncerrar.Location = new System.Drawing.Point(524, 242);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(94, 36);
            this.btncerrar.TabIndex = 7;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // lbalResultado
            // 
            this.lbalResultado.AutoSize = true;
            this.lbalResultado.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbalResultado.Location = new System.Drawing.Point(223, 226);
            this.lbalResultado.Name = "lbalResultado";
            this.lbalResultado.Size = new System.Drawing.Size(77, 16);
            this.lbalResultado.TabIndex = 8;
            this.lbalResultado.Text = "Resultado:";
            // 
            // Rectangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(630, 290);
            this.Controls.Add(this.lbalResultado);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.lbltitulorectangulo);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.numalturarec);
            this.Controls.Add(this.lblarearectangulo);
            this.Controls.Add(this.numbaserec);
            this.Controls.Add(this.btncalarearectangulo);
            this.Name = "Rectangulo";
            this.Text = "Rectangulo";
            ((System.ComponentModel.ISupportInitialize)(this.numbaserec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numalturarec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalarearectangulo;
        private System.Windows.Forms.NumericUpDown numbaserec;
        private System.Windows.Forms.Label lblarearectangulo;
        private System.Windows.Forms.NumericUpDown numalturarec;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lbltitulorectangulo;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label lbalResultado;
    }
}