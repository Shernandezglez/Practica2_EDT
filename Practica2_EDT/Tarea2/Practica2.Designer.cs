namespace Tarea2
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
            this.btnAbrirBmp = new System.Windows.Forms.Button();
            this.bmp = new System.Windows.Forms.OpenFileDialog();
            this.xml = new System.Windows.Forms.SaveFileDialog();
            this.txtInfoBmp = new System.Windows.Forms.TextBox();
            this.btnGenerarXml = new System.Windows.Forms.Button();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtD3 = new System.Windows.Forms.TextBox();
            this.txtD4 = new System.Windows.Forms.TextBox();
            this.txtD5 = new System.Windows.Forms.TextBox();
            this.lblD1 = new System.Windows.Forms.Label();
            this.lblD2 = new System.Windows.Forms.Label();
            this.lblD3 = new System.Windows.Forms.Label();
            this.lblD4 = new System.Windows.Forms.Label();
            this.lblD5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAbrirBmp
            // 
            this.btnAbrirBmp.Location = new System.Drawing.Point(80, 53);
            this.btnAbrirBmp.Name = "btnAbrirBmp";
            this.btnAbrirBmp.Size = new System.Drawing.Size(85, 34);
            this.btnAbrirBmp.TabIndex = 0;
            this.btnAbrirBmp.Text = "Cargar Imagen";
            this.btnAbrirBmp.UseVisualStyleBackColor = true;
            this.btnAbrirBmp.Click += new System.EventHandler(this.btnAbrirBmp_Click);
            // 
            // bmp
            // 
            this.bmp.FileName = "openFileDialog1";
            // 
            // txtInfoBmp
            // 
            this.txtInfoBmp.Location = new System.Drawing.Point(12, 93);
            this.txtInfoBmp.Multiline = true;
            this.txtInfoBmp.Name = "txtInfoBmp";
            this.txtInfoBmp.Size = new System.Drawing.Size(231, 191);
            this.txtInfoBmp.TabIndex = 1;
            // 
            // btnGenerarXml
            // 
            this.btnGenerarXml.Location = new System.Drawing.Point(326, 53);
            this.btnGenerarXml.Name = "btnGenerarXml";
            this.btnGenerarXml.Size = new System.Drawing.Size(93, 34);
            this.btnGenerarXml.TabIndex = 2;
            this.btnGenerarXml.Text = "Generar Xml";
            this.btnGenerarXml.UseVisualStyleBackColor = true;
            this.btnGenerarXml.Click += new System.EventHandler(this.btnGenerarXml_Click);
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(326, 103);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(100, 20);
            this.txtD1.TabIndex = 3;
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(326, 141);
            this.txtD2.Name = "txtD2";
            this.txtD2.Size = new System.Drawing.Size(100, 20);
            this.txtD2.TabIndex = 4;
            // 
            // txtD3
            // 
            this.txtD3.Location = new System.Drawing.Point(326, 176);
            this.txtD3.Name = "txtD3";
            this.txtD3.Size = new System.Drawing.Size(100, 20);
            this.txtD3.TabIndex = 5;
            // 
            // txtD4
            // 
            this.txtD4.Location = new System.Drawing.Point(326, 214);
            this.txtD4.Name = "txtD4";
            this.txtD4.Size = new System.Drawing.Size(100, 20);
            this.txtD4.TabIndex = 6;
            // 
            // txtD5
            // 
            this.txtD5.Location = new System.Drawing.Point(326, 253);
            this.txtD5.Name = "txtD5";
            this.txtD5.Size = new System.Drawing.Size(100, 20);
            this.txtD5.TabIndex = 7;
            // 
            // lblD1
            // 
            this.lblD1.AutoSize = true;
            this.lblD1.Location = new System.Drawing.Point(276, 106);
            this.lblD1.Name = "lblD1";
            this.lblD1.Size = new System.Drawing.Size(50, 13);
            this.lblD1.TabIndex = 8;
            this.lblD1.Text = "Nombre: ";
            // 
            // lblD2
            // 
            this.lblD2.AutoSize = true;
            this.lblD2.Location = new System.Drawing.Point(276, 144);
            this.lblD2.Name = "lblD2";
            this.lblD2.Size = new System.Drawing.Size(50, 13);
            this.lblD2.TabIndex = 9;
            this.lblD2.Text = "Apellido: ";
            // 
            // lblD3
            // 
            this.lblD3.AutoSize = true;
            this.lblD3.Location = new System.Drawing.Point(276, 183);
            this.lblD3.Name = "lblD3";
            this.lblD3.Size = new System.Drawing.Size(44, 13);
            this.lblD3.TabIndex = 10;
            this.lblD3.Text = "Correo: ";
            // 
            // lblD4
            // 
            this.lblD4.AutoSize = true;
            this.lblD4.Location = new System.Drawing.Point(265, 217);
            this.lblD4.Name = "lblD4";
            this.lblD4.Size = new System.Drawing.Size(55, 13);
            this.lblD4.TabIndex = 11;
            this.lblD4.Text = "Domicilio: ";
            // 
            // lblD5
            // 
            this.lblD5.AutoSize = true;
            this.lblD5.Location = new System.Drawing.Point(265, 256);
            this.lblD5.Name = "lblD5";
            this.lblD5.Size = new System.Drawing.Size(55, 13);
            this.lblD5.TabIndex = 12;
            this.lblD5.Text = "Telefono: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 378);
            this.Controls.Add(this.lblD5);
            this.Controls.Add(this.lblD4);
            this.Controls.Add(this.lblD3);
            this.Controls.Add(this.lblD2);
            this.Controls.Add(this.lblD1);
            this.Controls.Add(this.txtD5);
            this.Controls.Add(this.txtD4);
            this.Controls.Add(this.txtD3);
            this.Controls.Add(this.txtD2);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.btnGenerarXml);
            this.Controls.Add(this.txtInfoBmp);
            this.Controls.Add(this.btnAbrirBmp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirBmp;
        private System.Windows.Forms.OpenFileDialog bmp;
        private System.Windows.Forms.SaveFileDialog xml;
        private System.Windows.Forms.TextBox txtInfoBmp;
        private System.Windows.Forms.Button btnGenerarXml;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtD3;
        private System.Windows.Forms.TextBox txtD4;
        private System.Windows.Forms.TextBox txtD5;
        private System.Windows.Forms.Label lblD1;
        private System.Windows.Forms.Label lblD2;
        private System.Windows.Forms.Label lblD3;
        private System.Windows.Forms.Label lblD4;
        private System.Windows.Forms.Label lblD5;
    }
}

