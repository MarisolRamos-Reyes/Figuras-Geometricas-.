namespace Figuras_geometricas
{
    partial class Pentagono
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
            this.btncerrarpentagono = new System.Windows.Forms.Button();
            this.numaltura = new System.Windows.Forms.NumericUpDown();
            this.numbasemenor = new System.Windows.Forms.NumericUpDown();
            this.btncalarea = new System.Windows.Forms.Button();
            this.lblareapentagono = new System.Windows.Forms.Label();
            this.lblresultadopentagono = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lbllado = new System.Windows.Forms.Label();
            this.lbltitulopentagono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbasemenor)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrarpentagono
            // 
            this.btncerrarpentagono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(253)))), ((int)(((byte)(9)))));
            this.btncerrarpentagono.Location = new System.Drawing.Point(513, 254);
            this.btncerrarpentagono.Name = "btncerrarpentagono";
            this.btncerrarpentagono.Size = new System.Drawing.Size(100, 28);
            this.btncerrarpentagono.TabIndex = 21;
            this.btncerrarpentagono.Text = "Salir";
            this.btncerrarpentagono.UseVisualStyleBackColor = false;
            this.btncerrarpentagono.Click += new System.EventHandler(this.btncerrarpentagono_Click);
            // 
            // numaltura
            // 
            this.numaltura.DecimalPlaces = 2;
            this.numaltura.Location = new System.Drawing.Point(314, 115);
            this.numaltura.Name = "numaltura";
            this.numaltura.Size = new System.Drawing.Size(120, 20);
            this.numaltura.TabIndex = 20;
            // 
            // numbasemenor
            // 
            this.numbasemenor.DecimalPlaces = 2;
            this.numbasemenor.Location = new System.Drawing.Point(314, 74);
            this.numbasemenor.Name = "numbasemenor";
            this.numbasemenor.Size = new System.Drawing.Size(120, 20);
            this.numbasemenor.TabIndex = 19;
            // 
            // btncalarea
            // 
            this.btncalarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(151)))), ((int)(((byte)(0)))));
            this.btncalarea.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btncalarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalarea.Location = new System.Drawing.Point(127, 171);
            this.btncalarea.Name = "btncalarea";
            this.btncalarea.Size = new System.Drawing.Size(362, 36);
            this.btncalarea.TabIndex = 17;
            this.btncalarea.Text = "Calcular del área del Pentagono";
            this.btncalarea.UseVisualStyleBackColor = false;
            this.btncalarea.Click += new System.EventHandler(this.btncalarea_Click);
            // 
            // lblareapentagono
            // 
            this.lblareapentagono.AutoSize = true;
            this.lblareapentagono.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblareapentagono.Location = new System.Drawing.Point(311, 231);
            this.lblareapentagono.Name = "lblareapentagono";
            this.lblareapentagono.Size = new System.Drawing.Size(11, 16);
            this.lblareapentagono.TabIndex = 16;
            this.lblareapentagono.Text = ".";
            // 
            // lblresultadopentagono
            // 
            this.lblresultadopentagono.AutoSize = true;
            this.lblresultadopentagono.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblresultadopentagono.Location = new System.Drawing.Point(200, 231);
            this.lblresultadopentagono.Name = "lblresultadopentagono";
            this.lblresultadopentagono.Size = new System.Drawing.Size(77, 16);
            this.lblresultadopentagono.TabIndex = 15;
            this.lblresultadopentagono.Text = "Resultado:";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblaltura.Location = new System.Drawing.Point(200, 119);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(52, 16);
            this.lblaltura.TabIndex = 14;
            this.lblaltura.Text = "Altura:";
            // 
            // lbllado
            // 
            this.lbllado.AutoSize = true;
            this.lbllado.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbllado.Location = new System.Drawing.Point(200, 78);
            this.lbllado.Name = "lbllado";
            this.lbllado.Size = new System.Drawing.Size(44, 16);
            this.lbllado.TabIndex = 13;
            this.lbllado.Text = "Lado:";
            // 
            // lbltitulopentagono
            // 
            this.lbltitulopentagono.AutoSize = true;
            this.lbltitulopentagono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(222)))), ((int)(((byte)(16)))));
            this.lbltitulopentagono.Font = new System.Drawing.Font("DFKaiSho-SB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltitulopentagono.Location = new System.Drawing.Point(18, 8);
            this.lbltitulopentagono.Name = "lbltitulopentagono";
            this.lbltitulopentagono.Size = new System.Drawing.Size(183, 21);
            this.lbltitulopentagono.TabIndex = 11;
            this.lbltitulopentagono.Text = "Área del Pentagono";
            // 
            // Pentagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(630, 290);
            this.Controls.Add(this.btncerrarpentagono);
            this.Controls.Add(this.numaltura);
            this.Controls.Add(this.numbasemenor);
            this.Controls.Add(this.btncalarea);
            this.Controls.Add(this.lblareapentagono);
            this.Controls.Add(this.lblresultadopentagono);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lbllado);
            this.Controls.Add(this.lbltitulopentagono);
            this.Name = "Pentagono";
            this.Text = "Pentagono";
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbasemenor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncerrarpentagono;
        private System.Windows.Forms.NumericUpDown numaltura;
        private System.Windows.Forms.NumericUpDown numbasemenor;
        private System.Windows.Forms.Button btncalarea;
        private System.Windows.Forms.Label lblareapentagono;
        private System.Windows.Forms.Label lblresultadopentagono;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lbllado;
        private System.Windows.Forms.Label lbltitulopentagono;
    }
}