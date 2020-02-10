namespace cajeroautomaticomodificado
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtentrega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnretirar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblrspuesta = new System.Windows.Forms.Label();
            this.btnsucesion = new System.Windows.Forms.Button();
            this.btnprimo = new System.Windows.Forms.Button();
            this.lblprimo = new System.Windows.Forms.Label();
            this.lblsucesion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(133, 24);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(140, 34);
            this.txttotal.TabIndex = 1;
            // 
            // txtentrega
            // 
            this.txtentrega.Location = new System.Drawing.Point(439, 24);
            this.txtentrega.Multiline = true;
            this.txtentrega.Name = "txtentrega";
            this.txtentrega.Size = new System.Drawing.Size(140, 34);
            this.txtentrega.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entrego:";
            // 
            // btnretirar
            // 
            this.btnretirar.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirar.Location = new System.Drawing.Point(12, 79);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(185, 58);
            this.btnretirar.TabIndex = 4;
            this.btnretirar.Text = "Retirar";
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Click += new System.EventHandler(this.Btnretirar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vuelto:";
            // 
            // lblrspuesta
            // 
            this.lblrspuesta.AutoSize = true;
            this.lblrspuesta.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrspuesta.Location = new System.Drawing.Point(65, 182);
            this.lblrspuesta.Name = "lblrspuesta";
            this.lblrspuesta.Size = new System.Drawing.Size(94, 23);
            this.lblrspuesta.TabIndex = 6;
            this.lblrspuesta.Text = "Procesando...";
            // 
            // btnsucesion
            // 
            this.btnsucesion.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsucesion.Location = new System.Drawing.Point(491, 79);
            this.btnsucesion.Name = "btnsucesion";
            this.btnsucesion.Size = new System.Drawing.Size(185, 58);
            this.btnsucesion.TabIndex = 7;
            this.btnsucesion.Text = "Sucesion de Fibonacci";
            this.btnsucesion.UseVisualStyleBackColor = true;
            this.btnsucesion.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnprimo
            // 
            this.btnprimo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprimo.Location = new System.Drawing.Point(259, 79);
            this.btnprimo.Name = "btnprimo";
            this.btnprimo.Size = new System.Drawing.Size(185, 58);
            this.btnprimo.TabIndex = 8;
            this.btnprimo.Text = "Numero primo";
            this.btnprimo.UseVisualStyleBackColor = true;
            this.btnprimo.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblprimo
            // 
            this.lblprimo.AutoSize = true;
            this.lblprimo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimo.Location = new System.Drawing.Point(310, 191);
            this.lblprimo.Name = "lblprimo";
            this.lblprimo.Size = new System.Drawing.Size(94, 23);
            this.lblprimo.TabIndex = 9;
            this.lblprimo.Text = "Procesando...";
            // 
            // lblsucesion
            // 
            this.lblsucesion.AutoSize = true;
            this.lblsucesion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsucesion.Location = new System.Drawing.Point(537, 201);
            this.lblsucesion.Name = "lblsucesion";
            this.lblsucesion.Size = new System.Drawing.Size(94, 23);
            this.lblsucesion.TabIndex = 10;
            this.lblsucesion.Text = "Procesando...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 42);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numero\r\n primo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 42);
            this.label7.TabIndex = 12;
            this.label7.Text = "La sucesion de\r\n fibonacci es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 362);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblsucesion);
            this.Controls.Add(this.lblprimo);
            this.Controls.Add(this.btnprimo);
            this.Controls.Add(this.btnsucesion);
            this.Controls.Add(this.lblrspuesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnretirar);
            this.Controls.Add(this.txtentrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.TextBox txtentrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblrspuesta;
        private System.Windows.Forms.Button btnsucesion;
        private System.Windows.Forms.Button btnprimo;
        private System.Windows.Forms.Label lblprimo;
        private System.Windows.Forms.Label lblsucesion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

