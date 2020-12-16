namespace Figuras_geometricas
{
    partial class Romboide
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
            this.lbltituloromboide = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblrresultado = new System.Windows.Forms.Label();
            this.lblarear = new System.Windows.Forms.Label();
            this.numbaserom = new System.Windows.Forms.NumericUpDown();
            this.numalturarom = new System.Windows.Forms.NumericUpDown();
            this.btncalcularromboide = new System.Windows.Forms.Button();
            this.btncerrarrom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numbaserom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numalturarom)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltituloromboide
            // 
            this.lbltituloromboide.AutoSize = true;
            this.lbltituloromboide.BackColor = System.Drawing.Color.HotPink;
            this.lbltituloromboide.Font = new System.Drawing.Font("DFKaiSho-SB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltituloromboide.Location = new System.Drawing.Point(13, 13);
            this.lbltituloromboide.Name = "lbltituloromboide";
            this.lbltituloromboide.Size = new System.Drawing.Size(173, 21);
            this.lbltituloromboide.TabIndex = 0;
            this.lbltituloromboide.Text = "Área del Romboide";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBase.Location = new System.Drawing.Point(216, 55);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(44, 16);
            this.lblBase.TabIndex = 1;
            this.lblBase.Text = "Base:";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblaltura.Location = new System.Drawing.Point(216, 94);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(52, 16);
            this.lblaltura.TabIndex = 2;
            this.lblaltura.Text = "Altura:";
            // 
            // lblrresultado
            // 
            this.lblrresultado.AutoSize = true;
            this.lblrresultado.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblrresultado.Location = new System.Drawing.Point(225, 213);
            this.lblrresultado.Name = "lblrresultado";
            this.lblrresultado.Size = new System.Drawing.Size(77, 16);
            this.lblrresultado.TabIndex = 4;
            this.lblrresultado.Text = "Resultado:";
            // 
            // lblarear
            // 
            this.lblarear.AutoSize = true;
            this.lblarear.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblarear.Location = new System.Drawing.Point(363, 217);
            this.lblarear.Name = "lblarear";
            this.lblarear.Size = new System.Drawing.Size(11, 16);
            this.lblarear.TabIndex = 5;
            this.lblarear.Text = ".";
            // 
            // numbaserom
            // 
            this.numbaserom.DecimalPlaces = 3;
            this.numbaserom.Location = new System.Drawing.Point(312, 55);
            this.numbaserom.Name = "numbaserom";
            this.numbaserom.Size = new System.Drawing.Size(120, 20);
            this.numbaserom.TabIndex = 6;
            // 
            // numalturarom
            // 
            this.numalturarom.DecimalPlaces = 3;
            this.numalturarom.Location = new System.Drawing.Point(312, 90);
            this.numalturarom.Name = "numalturarom";
            this.numalturarom.Size = new System.Drawing.Size(120, 20);
            this.numalturarom.TabIndex = 7;
            // 
            // btncalcularromboide
            // 
            this.btncalcularromboide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(61)))), ((int)(((byte)(123)))));
            this.btncalcularromboide.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btncalcularromboide.Location = new System.Drawing.Point(171, 151);
            this.btncalcularromboide.Name = "btncalcularromboide";
            this.btncalcularromboide.Size = new System.Drawing.Size(293, 33);
            this.btncalcularromboide.TabIndex = 8;
            this.btncalcularromboide.Text = "Calcular área del Romboide";
            this.btncalcularromboide.UseVisualStyleBackColor = false;
            this.btncalcularromboide.Click += new System.EventHandler(this.btncalcularromboide_Click);
            // 
            // btncerrarrom
            // 
            this.btncerrarrom.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btncerrarrom.Location = new System.Drawing.Point(515, 252);
            this.btncerrarrom.Name = "btncerrarrom";
            this.btncerrarrom.Size = new System.Drawing.Size(103, 26);
            this.btncerrarrom.TabIndex = 9;
            this.btncerrarrom.Text = "Cerrar";
            this.btncerrarrom.UseVisualStyleBackColor = false;
            this.btncerrarrom.Click += new System.EventHandler(this.btncerrarrom_Click_1);
            // 
            // Romboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(630, 290);
            this.Controls.Add(this.btncerrarrom);
            this.Controls.Add(this.btncalcularromboide);
            this.Controls.Add(this.numalturarom);
            this.Controls.Add(this.numbaserom);
            this.Controls.Add(this.lblarear);
            this.Controls.Add(this.lblrresultado);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lbltituloromboide);
            this.Name = "Romboide";
            this.Text = "Romboide";
            ((System.ComponentModel.ISupportInitialize)(this.numbaserom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numalturarom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltituloromboide;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblrresultado;
        private System.Windows.Forms.Label lblarear;
        private System.Windows.Forms.NumericUpDown numbaserom;
        private System.Windows.Forms.NumericUpDown numalturarom;
        private System.Windows.Forms.Button btncalcularromboide;
        private System.Windows.Forms.Button btncerrarrom;
    }
}