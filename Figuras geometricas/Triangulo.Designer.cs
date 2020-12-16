namespace Figuras_geometricas
{
    partial class Triangulo
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
            this.lbltitulotringulo = new System.Windows.Forms.Label();
            this.lblbase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lresultado = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.numbase = new System.Windows.Forms.NumericUpDown();
            this.numaltura = new System.Windows.Forms.NumericUpDown();
            this.btncalcular = new System.Windows.Forms.Button();
            this.Regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numbase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulotringulo
            // 
            this.lbltitulotringulo.AutoSize = true;
            this.lbltitulotringulo.BackColor = System.Drawing.Color.Indigo;
            this.lbltitulotringulo.Font = new System.Drawing.Font("DFKaiSho-SB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltitulotringulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltitulotringulo.Location = new System.Drawing.Point(13, 13);
            this.lbltitulotringulo.Name = "lbltitulotringulo";
            this.lbltitulotringulo.Size = new System.Drawing.Size(168, 21);
            this.lbltitulotringulo.TabIndex = 0;
            this.lbltitulotringulo.Text = "Área del Triangulo";
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblbase.Location = new System.Drawing.Point(180, 62);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(44, 16);
            this.lblbase.TabIndex = 1;
            this.lblbase.Text = "Base:";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblaltura.Location = new System.Drawing.Point(180, 101);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(49, 16);
            this.lblaltura.TabIndex = 2;
            this.lblaltura.Text = "Altura";
            // 
            // lresultado
            // 
            this.lresultado.AutoSize = true;
            this.lresultado.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lresultado.Location = new System.Drawing.Point(180, 192);
            this.lresultado.Name = "lresultado";
            this.lresultado.Size = new System.Drawing.Size(77, 16);
            this.lresultado.TabIndex = 3;
            this.lresultado.Text = "Resultado:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(308, 196);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(10, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = ".";
            // 
            // numbase
            // 
            this.numbase.DecimalPlaces = 3;
            this.numbase.Location = new System.Drawing.Point(283, 62);
            this.numbase.Name = "numbase";
            this.numbase.Size = new System.Drawing.Size(120, 20);
            this.numbase.TabIndex = 5;
            // 
            // numaltura
            // 
            this.numaltura.DecimalPlaces = 3;
            this.numaltura.Location = new System.Drawing.Point(283, 101);
            this.numaltura.Name = "numaltura";
            this.numaltura.Size = new System.Drawing.Size(120, 20);
            this.numaltura.TabIndex = 6;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Thistle;
            this.btncalcular.Font = new System.Drawing.Font("DFKaiSho-SB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btncalcular.Location = new System.Drawing.Point(183, 142);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(274, 32);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular área de un triangulo";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // Regresar
            // 
            this.Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresar.Location = new System.Drawing.Point(519, 243);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(99, 35);
            this.Regresar.TabIndex = 8;
            this.Regresar.Text = "Regresar";
            this.Regresar.UseVisualStyleBackColor = true;
            this.Regresar.Click += new System.EventHandler(this.Regresar_Click);
            // 
            // Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(630, 290);
            this.Controls.Add(this.Regresar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.numaltura);
            this.Controls.Add(this.numbase);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lresultado);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.lbltitulotringulo);
            this.Name = "Triangulo";
            this.Text = "Triangulo";
            ((System.ComponentModel.ISupportInitialize)(this.numbase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulotringulo;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lresultado;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.NumericUpDown numbase;
        private System.Windows.Forms.NumericUpDown numaltura;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button Regresar;
    }
}