
namespace Ejercicio_de_Repaso2
{
    partial class DatosAlquiler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.texNITAlquiler = new System.Windows.Forms.TextBox();
            this.texPlacaAlquiler = new System.Windows.Forms.TextBox();
            this.texKlmRecorridos = new System.Windows.Forms.TextBox();
            this.dateTimeAlquiler = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDevolucion = new System.Windows.Forms.DateTimePicker();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de Devolución";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kilometros Recorridos";
            // 
            // texNITAlquiler
            // 
            this.texNITAlquiler.Location = new System.Drawing.Point(159, 37);
            this.texNITAlquiler.Name = "texNITAlquiler";
            this.texNITAlquiler.Size = new System.Drawing.Size(278, 20);
            this.texNITAlquiler.TabIndex = 5;
            // 
            // texPlacaAlquiler
            // 
            this.texPlacaAlquiler.Location = new System.Drawing.Point(159, 72);
            this.texPlacaAlquiler.Name = "texPlacaAlquiler";
            this.texPlacaAlquiler.Size = new System.Drawing.Size(278, 20);
            this.texPlacaAlquiler.TabIndex = 6;
            // 
            // texKlmRecorridos
            // 
            this.texKlmRecorridos.Location = new System.Drawing.Point(159, 206);
            this.texKlmRecorridos.Name = "texKlmRecorridos";
            this.texKlmRecorridos.Size = new System.Drawing.Size(278, 20);
            this.texKlmRecorridos.TabIndex = 7;
            // 
            // dateTimeAlquiler
            // 
            this.dateTimeAlquiler.Location = new System.Drawing.Point(159, 114);
            this.dateTimeAlquiler.Name = "dateTimeAlquiler";
            this.dateTimeAlquiler.Size = new System.Drawing.Size(278, 20);
            this.dateTimeAlquiler.TabIndex = 8;
            // 
            // dateTimeDevolucion
            // 
            this.dateTimeDevolucion.Location = new System.Drawing.Point(159, 158);
            this.dateTimeDevolucion.Name = "dateTimeDevolucion";
            this.dateTimeDevolucion.Size = new System.Drawing.Size(278, 20);
            this.dateTimeDevolucion.TabIndex = 9;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(262, 256);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(94, 33);
            this.buttonAgregar.TabIndex = 10;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // DatosAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 404);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dateTimeDevolucion);
            this.Controls.Add(this.dateTimeAlquiler);
            this.Controls.Add(this.texKlmRecorridos);
            this.Controls.Add(this.texPlacaAlquiler);
            this.Controls.Add(this.texNITAlquiler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosAlquiler";
            this.Text = "DatosAlquiler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texNITAlquiler;
        private System.Windows.Forms.TextBox texPlacaAlquiler;
        private System.Windows.Forms.TextBox texKlmRecorridos;
        private System.Windows.Forms.DateTimePicker dateTimeAlquiler;
        private System.Windows.Forms.DateTimePicker dateTimeDevolucion;
        private System.Windows.Forms.Button buttonAgregar;
    }
}