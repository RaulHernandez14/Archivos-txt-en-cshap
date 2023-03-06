namespace TBdatos
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
            this.btn_Escribir = new System.Windows.Forms.Button();
            this.btn_Leer = new System.Windows.Forms.Button();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.rtxt_Contenido = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_Escribir
            // 
            this.btn_Escribir.Location = new System.Drawing.Point(415, 294);
            this.btn_Escribir.Name = "btn_Escribir";
            this.btn_Escribir.Size = new System.Drawing.Size(123, 56);
            this.btn_Escribir.TabIndex = 0;
            this.btn_Escribir.Text = "ESCRIBIR";
            this.btn_Escribir.UseVisualStyleBackColor = true;
            this.btn_Escribir.Click += new System.EventHandler(this.btn_Escribir_Click);
            // 
            // btn_Leer
            // 
            this.btn_Leer.Location = new System.Drawing.Point(416, 368);
            this.btn_Leer.Name = "btn_Leer";
            this.btn_Leer.Size = new System.Drawing.Size(123, 54);
            this.btn_Leer.TabIndex = 1;
            this.btn_Leer.Text = "LEER";
            this.btn_Leer.UseVisualStyleBackColor = true;
            this.btn_Leer.Click += new System.EventHandler(this.btn_Leer_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.Location = new System.Drawing.Point(416, 66);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(122, 56);
            this.btn_Abrir.TabIndex = 2;
            this.btn_Abrir.Text = "ABRIR";
            this.btn_Abrir.UseVisualStyleBackColor = true;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(415, 139);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(123, 56);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Direcciòn:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(153, 22);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(385, 20);
            this.txt_Direccion.TabIndex = 5;
            // 
            // rtxt_Contenido
            // 
            this.rtxt_Contenido.Location = new System.Drawing.Point(16, 174);
            this.rtxt_Contenido.Name = "rtxt_Contenido";
            this.rtxt_Contenido.Size = new System.Drawing.Size(234, 248);
            this.rtxt_Contenido.TabIndex = 6;
            this.rtxt_Contenido.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.rtxt_Contenido);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Abrir);
            this.Controls.Add(this.btn_Leer);
            this.Controls.Add(this.btn_Escribir);
            this.Name = "Form1";
            this.Text = "TXT EN C·";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Escribir;
        private System.Windows.Forms.Button btn_Leer;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.RichTextBox rtxt_Contenido;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

