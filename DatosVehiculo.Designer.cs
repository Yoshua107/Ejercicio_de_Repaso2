
namespace Ejercicio_de_Repaso2
{
    partial class DatosVehiculo
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
            this.texPlaca = new System.Windows.Forms.TextBox();
            this.texMarca = new System.Windows.Forms.TextBox();
            this.texModelo = new System.Windows.Forms.TextBox();
            this.texColor = new System.Windows.Forms.TextBox();
            this.texPrecKilo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio por Kilometro";
            // 
            // texPlaca
            // 
            this.texPlaca.Location = new System.Drawing.Point(152, 54);
            this.texPlaca.Name = "texPlaca";
            this.texPlaca.Size = new System.Drawing.Size(258, 20);
            this.texPlaca.TabIndex = 5;
            // 
            // texMarca
            // 
            this.texMarca.Location = new System.Drawing.Point(152, 100);
            this.texMarca.Name = "texMarca";
            this.texMarca.Size = new System.Drawing.Size(258, 20);
            this.texMarca.TabIndex = 6;
            // 
            // texModelo
            // 
            this.texModelo.Location = new System.Drawing.Point(152, 142);
            this.texModelo.Name = "texModelo";
            this.texModelo.Size = new System.Drawing.Size(258, 20);
            this.texModelo.TabIndex = 7;
            // 
            // texColor
            // 
            this.texColor.Location = new System.Drawing.Point(152, 186);
            this.texColor.Name = "texColor";
            this.texColor.Size = new System.Drawing.Size(258, 20);
            this.texColor.TabIndex = 8;
            // 
            // texPrecKilo
            // 
            this.texPrecKilo.Location = new System.Drawing.Point(152, 227);
            this.texPrecKilo.Name = "texPrecKilo";
            this.texPrecKilo.Size = new System.Drawing.Size(258, 20);
            this.texPrecKilo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DatosVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texPrecKilo);
            this.Controls.Add(this.texColor);
            this.Controls.Add(this.texModelo);
            this.Controls.Add(this.texMarca);
            this.Controls.Add(this.texPlaca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DatosVehiculo";
            this.Text = "DatosVehiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texPlaca;
        private System.Windows.Forms.TextBox texMarca;
        private System.Windows.Forms.TextBox texModelo;
        private System.Windows.Forms.TextBox texColor;
        private System.Windows.Forms.TextBox texPrecKilo;
        private System.Windows.Forms.Button button1;
    }
}