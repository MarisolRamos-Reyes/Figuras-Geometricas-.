namespace Figuras_geometricas
{
    partial class Circulo
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
            this.lbltitulocirculo = new System.Windows.Forms.Label();
            this.lblradio = new System.Windows.Forms.Label();
            this.lblrcirculo = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.btncalcirculo = new System.Windows.Forms.Button();
            this.numradio = new System.Windows.Forms.NumericUpDown();
            this.btncerrarcirculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numradio)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulocirculo
            // 
            this.lbltitulocirculo.AutoSize = true;
            this.lbltitulocirculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbltitulocirculo.Font = new System.Drawing.Font("DFKaiSho-SB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbltitulocirculo.Location = new System.Drawing.Point(13, 13);
            this.lbltitulocirculo.Name = "lbltitulocirculo";
            this.lbltitulocirculo.Size = new System.Drawing.Size(166, 21);
            this.lbltitulocirculo.TabIndex = 0;
            this.lbltitulocirculo.Text = "Área del Circulo";
            // 
            // lblradio
            // 
            this.lblradio.AutoSize = true;
            this.lblradio.Font = new System.Drawing.Font("DFKaiSho-SB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblradio.Location = new System.Drawing.Point(157, 80);
            this.lblradio.Name = "lblradio";
            this.lblradio.Size = new System.Drawing.Size(48, 16);
            this.lblradio.TabIndex = 1;
            this.lblradio.Text = "Radio:";
            // 
            // lblrcirculo
            // 
            this.lblrcirculo.AutoSize = true;
            this.lblrcirculo.Location = new System.Drawing.Point(157, 215);
            this.lblrcirculo.Name = "lblrcirculo";
            this.lblrcirculo.Size = new System.Drawing.Size(55, 13);
            this.lblrcirculo.TabIndex = 2;
            this.lblrcirculo.Text = "Resultado";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(287, 215);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(10, 13);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = ".";
            // 
            // btncalcirculo
            // 
            this.btncalcirculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(111)))), ((int)(((byte)(255)))));
            this.btncalcirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcirculo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btncalcirculo.Location = new System.Drawing.Point(135, 137);
            this.btncalcirculo.Name = "btncalcirculo";
            this.btncalcirculo.Size = new System.Drawing.Size(307, 33);
            this.btncalcirculo.TabIndex = 4;
            this.btncalcirculo.Text = "Calcular el area del circulo";
            this.btncalcirculo.UseVisualStyleBackColor = false;
            this.btncalcirculo.Click += new System.EventHandler(this.btncalcirculo_Click);
            // 
            // numradio
            // 
            this.numradio.DecimalPlaces = 3;
            this.numradio.Location = new System.Drawing.Point(226, 76);
            this.numradio.Name = "numradio";
            this.numradio.Size = new System.Drawing.Size(120, 20);
            this.numradio.TabIndex = 5;
            // 
            // btncerrarcirculo
            // 
            this.btncerrarcirculo.BackColor = System.Drawing.Color.DarkCyan;
            this.btncerrarcirculo.Location = new System.Drawing.Point(513, 249);
            this.btncerrarcirculo.Name = "btncerrarcirculo";
            this.btncerrarcirculo.Size = new System.Drawing.Size(95, 29);
            this.btncerrarcirculo.TabIndex = 6;
            this.btncerrarcirculo.Text = "Cerrar";
            this.btncerrarcirculo.UseVisualStyleBackColor = false;
            this.btncerrarcirculo.Click += new System.EventHandler(this.btncerrarcirculo_Click);
            // 
            // Circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(620, 290);
            this.Controls.Add(this.btncerrarcirculo);
            this.Controls.Add(this.numradio);
            this.Controls.Add(this.btncalcirculo);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblrcirculo);
            this.Controls.Add(this.lblradio);
            this.Controls.Add(this.lbltitulocirculo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Circulo";
            this.Text = "Circulo";
            ((System.ComponentModel.ISupportInitialize)(this.numradio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulocirculo;
        private System.Windows.Forms.Label lblradio;
        private System.Windows.Forms.Label lblrcirculo;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Button btncalcirculo;
        private System.Windows.Forms.NumericUpDown numradio;
        private System.Windows.Forms.Button btncerrarcirculo;
    }
}