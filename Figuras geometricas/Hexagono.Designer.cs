namespace Figuras_geometricas
{
    partial class Hexagono
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
            this.btncerrarhexagono = new System.Windows.Forms.Button();
            this.numaltura = new System.Windows.Forms.NumericUpDown();
            this.numbasemenor = new System.Windows.Forms.NumericUpDown();
            this.btncalarea = new System.Windows.Forms.Button();
            this.lblareapentagono = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lbllado = new System.Windows.Forms.Label();
            this.lbltitulohexagono = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbasemenor)).BeginInit();
            this.SuspendLayout();
            // 
            // btncerrarhexagono
            // 
            this.btncerrarhexagono.BackColor = System.Drawing.Color.MediumOrchid;
            this.btncerrarhexagono.Location = new System.Drawing.Point(508, 254);
            this.btncerrarhexagono.Name = "btncerrarhexagono";
            this.btncerrarhexagono.Size = new System.Drawing.Size(100, 28);
            this.btncerrarhexagono.TabIndex = 30;
            this.btncerrarhexagono.Text = "Salir";
            this.btncerrarhexagono.UseVisualStyleBackColor = false;
            this.btncerrarhexagono.Click += new System.EventHandler(this.btncerrarhexagono_Click);
            // 
            // numaltura
            // 
            this.numaltura.DecimalPlaces = 2;
            this.numaltura.Location = new System.Drawing.Point(309, 115);
            this.numaltura.Name = "numaltura";
            this.numaltura.Size = new System.Drawing.Size(120, 20);
            this.numaltura.TabIndex = 29;
            // 
            // numbasemenor
            // 
            this.numbasemenor.DecimalPlaces = 2;
            this.numbasemenor.Location = new System.Drawing.Point(309, 74);
            this.numbasemenor.Name = "numbasemenor";
            this.numbasemenor.Size = new System.Drawing.Size(120, 20);
            this.numbasemenor.TabIndex = 28;
            // 
            // btncalarea
            // 
            this.btncalarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btncalarea.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btncalarea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncalarea.Location = new System.Drawing.Point(122, 171);
            this.btncalarea.Name = "btncalarea";
            this.btncalarea.Size = new System.Drawing.Size(362, 36);
            this.btncalarea.TabIndex = 27;
            this.btncalarea.Text = "Calcular del área del Hexagono";
            this.btncalarea.UseVisualStyleBackColor = false;
            this.btncalarea.Click += new System.EventHandler(this.btncalarea_Click);
            // 
            // lblareapentagono
            // 
            this.lblareapentagono.AutoSize = true;
            this.lblareapentagono.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblareapentagono.Location = new System.Drawing.Point(306, 231);
            this.lblareapentagono.Name = "lblareapentagono";
            this.lblareapentagono.Size = new System.Drawing.Size(11, 16);
            this.lblareapentagono.TabIndex = 26;
            this.lblareapentagono.Text = ".";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblresultado.Location = new System.Drawing.Point(195, 231);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(77, 16);
            this.lblresultado.TabIndex = 25;
            this.lblresultado.Text = "Resultado:";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblaltura.Location = new System.Drawing.Point(195, 119);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(52, 16);
            this.lblaltura.TabIndex = 24;
            this.lblaltura.Text = "Altura:";
            // 
            // lbllado
            // 
            this.lbllado.AutoSize = true;
            this.lbllado.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbllado.Location = new System.Drawing.Point(195, 78);
            this.lbllado.Name = "lbllado";
            this.lbllado.Size = new System.Drawing.Size(44, 16);
            this.lbllado.TabIndex = 23;
            this.lbllado.Text = "Lado:";
            // 
            // lbltitulohexagono
            // 
            this.lbltitulohexagono.AutoSize = true;
            this.lbltitulohexagono.BackColor = System.Drawing.Color.Fuchsia;
            this.lbltitulohexagono.Font = new System.Drawing.Font("DFKaiSho-SB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltitulohexagono.Location = new System.Drawing.Point(13, 8);
            this.lbltitulohexagono.Name = "lbltitulohexagono";
            this.lbltitulohexagono.Size = new System.Drawing.Size(175, 21);
            this.lbltitulohexagono.TabIndex = 22;
            this.lbltitulohexagono.Text = "Área del Hexagono";
            // 
            // Hexagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(620, 290);
            this.Controls.Add(this.btncerrarhexagono);
            this.Controls.Add(this.numaltura);
            this.Controls.Add(this.numbasemenor);
            this.Controls.Add(this.btncalarea);
            this.Controls.Add(this.lblareapentagono);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lbllado);
            this.Controls.Add(this.lbltitulohexagono);
            this.Name = "Hexagono";
            this.Text = "Hexagono";
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbasemenor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncerrarhexagono;
        private System.Windows.Forms.NumericUpDown numaltura;
        private System.Windows.Forms.NumericUpDown numbasemenor;
        private System.Windows.Forms.Button btncalarea;
        private System.Windows.Forms.Label lblareapentagono;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lbllado;
        private System.Windows.Forms.Label lbltitulohexagono;
    }
}