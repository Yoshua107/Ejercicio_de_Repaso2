
namespace Ejercicio_de_Repaso2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarDatosDeAlquiler = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarDatosDelVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.texDirección = new System.Windows.Forms.TextBox();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.texNIT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataClientes = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataAlquiler = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dataVehiculos = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKLM = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1022, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarDatosDeAlquiler,
            this.ingresarDatosDelVehiculoToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ingresarDatosDeAlquiler
            // 
            this.ingresarDatosDeAlquiler.Name = "ingresarDatosDeAlquiler";
            this.ingresarDatosDeAlquiler.Size = new System.Drawing.Size(216, 22);
            this.ingresarDatosDeAlquiler.Text = "Ingresar Datos del Alquiler";
            this.ingresarDatosDeAlquiler.Click += new System.EventHandler(this.ingresarDatosDelClienteToolStripMenuItem_Click);
            // 
            // ingresarDatosDelVehiculoToolStripMenuItem
            // 
            this.ingresarDatosDelVehiculoToolStripMenuItem.Name = "ingresarDatosDelVehiculoToolStripMenuItem";
            this.ingresarDatosDelVehiculoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ingresarDatosDelVehiculoToolStripMenuItem.Text = "Ingresar Datos del Vehiculo";
            this.ingresarDatosDelVehiculoToolStripMenuItem.Click += new System.EventHandler(this.ingresarDatosDelVehiculoToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.texDirección);
            this.groupBox1.Controls.Add(this.texNombre);
            this.groupBox1.Controls.Add(this.texNIT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 166);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(132, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texDirección
            // 
            this.texDirección.Location = new System.Drawing.Point(65, 84);
            this.texDirección.Name = "texDirección";
            this.texDirección.Size = new System.Drawing.Size(258, 20);
            this.texDirección.TabIndex = 5;
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(65, 56);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(258, 20);
            this.texNombre.TabIndex = 4;
            // 
            // texNIT
            // 
            this.texNIT.Location = new System.Drawing.Point(65, 30);
            this.texNIT.Name = "texNIT";
            this.texNIT.Size = new System.Drawing.Size(258, 20);
            this.texNIT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // dataClientes
            // 
            this.dataClientes.AllowUserToOrderColumns = true;
            this.dataClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClientes.Location = new System.Drawing.Point(12, 255);
            this.dataClientes.Name = "dataClientes";
            this.dataClientes.Size = new System.Drawing.Size(345, 253);
            this.dataClientes.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datos de los clientes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Actualizar Datos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataAlquiler
            // 
            this.dataAlquiler.AllowUserToOrderColumns = true;
            this.dataAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAlquiler.Location = new System.Drawing.Point(398, 57);
            this.dataAlquiler.Name = "dataAlquiler";
            this.dataAlquiler.Size = new System.Drawing.Size(612, 150);
            this.dataAlquiler.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Datos del Alquiler";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Actualizar Datos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataVehiculos
            // 
            this.dataVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculos.Location = new System.Drawing.Point(398, 287);
            this.dataVehiculos.Name = "dataVehiculos";
            this.dataVehiculos.Size = new System.Drawing.Size(612, 221);
            this.dataVehiculos.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(648, 514);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Actualizar Datos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datos de Los Vehiculos";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelPlaca);
            this.groupBox2.Controls.Add(this.labelMarca);
            this.groupBox2.Controls.Add(this.labelCliente);
            this.groupBox2.Controls.Add(this.labelKLM);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(309, 561);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 176);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alquiler Con Mas Kilometros";
            // 
            // labelKLM
            // 
            this.labelKLM.AutoSize = true;
            this.labelKLM.Location = new System.Drawing.Point(115, 67);
            this.labelKLM.Name = "labelKLM";
            this.labelKLM.Size = new System.Drawing.Size(118, 13);
            this.labelKLM.TabIndex = 12;
            this.labelKLM.Text = "Kilometros Recorridos...";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(115, 29);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(88, 13);
            this.labelCliente.TabIndex = 13;
            this.labelCliente.Text = "Nombre Cliente...";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(115, 105);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(107, 13);
            this.labelMarca.TabIndex = 14;
            this.labelMarca.Text = "Marca del Vehiculo...";
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Location = new System.Drawing.Point(115, 141);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(101, 13);
            this.labelPlaca.TabIndex = 15;
            this.labelPlaca.Text = "Placa de vehiculo...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 749);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataVehiculos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataAlquiler);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Escritorio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarDatosDeAlquiler;
        private System.Windows.Forms.ToolStripMenuItem ingresarDatosDelVehiculoToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox texDirección;
        private System.Windows.Forms.TextBox texNombre;
        private System.Windows.Forms.TextBox texNIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataAlquiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataVehiculos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelKLM;
    }
}

