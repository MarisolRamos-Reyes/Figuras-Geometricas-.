namespace Figuras_geometricas
{
    partial class Trapecio
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
            this.lbltitulotrapecio = new System.Windows.Forms.Label();
            this.lblbasemayor = new System.Windows.Forms.Label();
            this.lblbasemenor = new System.Windows.Forms.Label();
            this.lblalturatra = new System.Windows.Forms.Label();
            this.lblresultadotra = new System.Windows.Forms.Label();
            this.lblareatrapecio = new System.Windows.Forms.Label();
            this.btncalarea = new System.Windows.Forms.Button();
            this.numbasemayor = new System.Windows.Forms.NumericUpDown();
            this.numbasemenor = new System.Windows.Forms.NumericUpDown();
            this.numaltura = new System.Windows.Forms.NumericUpDown();
            this.btnsalirtra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numbasemayor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbasemenor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulotrapecio
            // 
            this.lbltitulotrapecio.AutoSize = true;
            this.lbltitulotrapecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.lbltitulotrapecio.Font = new System.Drawing.Font("DFKaiSho-SB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltitulotrapecio.Location = new System.Drawing.Point(13, 4);
            this.lbltitulotrapecio.Name = "lbltitulotrapecio";
            this.lbltitulotrapecio.Size = new System.Drawing.Size(164, 21);
            this.lbltitulotrapecio.TabIndex = 0;
            this.lbltitulotrapecio.Text = "Área del Trapecio";
            // 
            // lblbasemayor
            // 
            this.lblbasemayor.AutoSize = true;
            this.lblbasemayor.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblbasemayor.Location = new System.Drawing.Point(195, 52);
            this.lblbasemayor.Name = "lblbasemayor";
            this.lblbasemayor.Size = new System.Drawing.Size(91, 16);
            this.lblbasemayor.TabIndex = 1;
            this.lblbasemayor.Text = "Base Mayor:";
            // 
            // lblbasemenor
            // 
            this.lblbasemenor.AutoSize = true;
            this.lblbasemenor.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblbasemenor.Location = new System.Drawing.Point(195, 86);
            this.lblbasemenor.Name = "lblbasemenor";
            this.lblbasemenor.Size = new System.Drawing.Size(91, 16);
            this.lblbasemenor.TabIndex = 2;
            this.lblbasemenor.Text = "Base Menor:";
            // 
            // lblalturatra
            // 
            this.lblalturatra.AutoSize = true;
            this.lblalturatra.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblalturatra.Location = new System.Drawing.Point(195, 125);
            this.lblalturatra.Name = "lblalturatra";
            this.lblalturatra.Size = new System.Drawing.Size(52, 16);
            this.lblalturatra.TabIndex = 3;
            this.lblalturatra.Text = "Altura:";
            // 
            // lblresultadotra
            // 
            this.lblresultadotra.AutoSize = true;
            this.lblresultadotra.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblresultadotra.Location = new System.Drawing.Point(195, 227);
            this.lblresultadotra.Name = "lblresultadotra";
            this.lblresultadotra.Size = new System.Drawing.Size(77, 16);
            this.lblresultadotra.TabIndex = 4;
            this.lblresultadotra.Text = "Resultado:";
            // 
            // lblareatrapecio
            // 
            this.lblareatrapecio.AutoSize = true;
            this.lblareatrapecio.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblareatrapecio.Location = new System.Drawing.Point(306, 227);
            this.lblareatrapecio.Name = "lblareatrapecio";
            this.lblareatrapecio.Size = new System.Drawing.Size(11, 16);
            this.lblareatrapecio.TabIndex = 5;
            this.lblareatrapecio.Text = ".";
            // 
            // btncalarea
            // 
            this.btncalarea.BackColor = System.Drawing.Color.Maroon;
            this.btncalarea.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btncalarea.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btncalarea.Location = new System.Drawing.Point(122, 167);
            this.btncalarea.Name = "btncalarea";
            this.btncalarea.Size = new System.Drawing.Size(362, 36);
            this.btncalarea.TabIndex = 6;
            this.btncalarea.Text = "Calcular del área del Trapecio";
            this.btncalarea.UseVisualStyleBackColor = false;
            this.btncalarea.Click += new System.EventHandler(this.btncalarea_Click);
            // 
            // numbasemayor
            // 
            this.numbasemayor.DecimalPlaces = 2;
            this.numbasemayor.Location = new System.Drawing.Point(309, 48);
            this.numbasemayor.Name = "numbasemayor";
            this.numbasemayor.Size = new System.Drawing.Size(120, 20);
            this.numbasemayor.TabIndex = 7;
            // 
            // numbasemenor
            // 
            this.numbasemenor.DecimalPlaces = 2;
            this.numbasemenor.Location = new System.Drawing.Point(309, 86);
            this.numbasemenor.Name = "numbasemenor";
            this.numbasemenor.Size = new System.Drawing.Size(120, 20);
            this.numbasemenor.TabIndex = 8;
            // 
            // numaltura
            // 
            this.numaltura.DecimalPlaces = 2;
            this.numaltura.Location = new System.Drawing.Point(309, 127);
            this.numaltura.Name = "numaltura";
            this.numaltura.Size = new System.Drawing.Size(120, 20);
            this.numaltura.TabIndex = 9;
            // 
            // btnsalirtra
            // 
            this.btnsalirtra.BackColor = System.Drawing.Color.Coral;
            this.btnsalirtra.Location = new System.Drawing.Point(508, 250);
            this.btnsalirtra.Name = "btnsalirtra";
            this.btnsalirtra.Size = new System.Drawing.Size(100, 28);
            this.btnsalirtra.TabIndex = 10;
            this.btnsalirtra.Text = "Salir";
            this.btnsalirtra.UseVisualStyleBackColor = false;
            this.btnsalirtra.Click += new System.EventHandler(this.button1_Click);
            // 
            // Trapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(620, 290);
            this.Controls.Add(this.btnsalirtra);
            this.Controls.Add(this.numaltura);
            this.Controls.Add(this.numbasemenor);
            this.Controls.Add(this.numbasemayor);
            this.Controls.Add(this.btncalarea);
            this.Controls.Add(this.lblareatrapecio);
            this.Controls.Add(this.lblresultadotra);
            this.Controls.Add(this.lblalturatra);
            this.Controls.Add(this.lblbasemenor);
            this.Controls.Add(this.lblbasemayor);
            this.Controls.Add(this.lbltitulotrapecio);
            this.Name = "Trapecio";
            this.Text = "Trapecio";
            ((System.ComponentModel.ISupportInitialize)(this.numbasemayor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbasemenor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numaltura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulotrapecio;
        private System.Windows.Forms.Label lblbasemayor;
        private System.Windows.Forms.Label lblbasemenor;
        private System.Windows.Forms.Label lblalturatra;
        private System.Windows.Forms.Label lblresultadotra;
        private System.Windows.Forms.Label lblareatrapecio;
        private System.Windows.Forms.Button btncalarea;
        private System.Windows.Forms.NumericUpDown numbasemayor;
        private System.Windows.Forms.NumericUpDown numbasemenor;
        private System.Windows.Forms.NumericUpDown numaltura;
        private System.Windows.Forms.Button btnsalirtra;
    }
}