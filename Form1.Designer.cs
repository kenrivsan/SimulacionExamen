
namespace SimulacionExamen
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoidentificacion = new System.Windows.Forms.TextBox();
            this.txtNomDep = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.btnIngresarDep = new System.Windows.Forms.Button();
            this.btnIngresarTemp = new System.Windows.Forms.Button();
            this.dtvDepartamentos = new System.Windows.Forms.DataGridView();
            this.dtvTemperaturas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtvNomTemp = new System.Windows.Forms.DataGridView();
            this.btnOrdenar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtvDepartamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTemperaturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNomTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el numero de identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperatura";
            // 
            // txtNoidentificacion
            // 
            this.txtNoidentificacion.Location = new System.Drawing.Point(15, 59);
            this.txtNoidentificacion.Name = "txtNoidentificacion";
            this.txtNoidentificacion.Size = new System.Drawing.Size(225, 22);
            this.txtNoidentificacion.TabIndex = 4;
            // 
            // txtNomDep
            // 
            this.txtNomDep.Location = new System.Drawing.Point(20, 105);
            this.txtNomDep.Name = "txtNomDep";
            this.txtNomDep.Size = new System.Drawing.Size(220, 22);
            this.txtNomDep.TabIndex = 5;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(15, 315);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(212, 22);
            this.txtTemp.TabIndex = 7;
            // 
            // btnIngresarDep
            // 
            this.btnIngresarDep.Location = new System.Drawing.Point(21, 133);
            this.btnIngresarDep.Name = "btnIngresarDep";
            this.btnIngresarDep.Size = new System.Drawing.Size(86, 30);
            this.btnIngresarDep.TabIndex = 8;
            this.btnIngresarDep.Text = "Ingresar";
            this.btnIngresarDep.UseVisualStyleBackColor = true;
            this.btnIngresarDep.Click += new System.EventHandler(this.btnIngresarDep_Click);
            // 
            // btnIngresarTemp
            // 
            this.btnIngresarTemp.Location = new System.Drawing.Point(27, 343);
            this.btnIngresarTemp.Name = "btnIngresarTemp";
            this.btnIngresarTemp.Size = new System.Drawing.Size(80, 26);
            this.btnIngresarTemp.TabIndex = 9;
            this.btnIngresarTemp.Text = "Ingresar";
            this.btnIngresarTemp.UseVisualStyleBackColor = true;
            this.btnIngresarTemp.Click += new System.EventHandler(this.btnIngresarTemp_Click);
            // 
            // dtvDepartamentos
            // 
            this.dtvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvDepartamentos.Location = new System.Drawing.Point(279, 28);
            this.dtvDepartamentos.Name = "dtvDepartamentos";
            this.dtvDepartamentos.RowHeadersWidth = 51;
            this.dtvDepartamentos.RowTemplate.Height = 24;
            this.dtvDepartamentos.Size = new System.Drawing.Size(541, 207);
            this.dtvDepartamentos.TabIndex = 10;
            // 
            // dtvTemperaturas
            // 
            this.dtvTemperaturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvTemperaturas.Location = new System.Drawing.Point(279, 252);
            this.dtvTemperaturas.Name = "dtvTemperaturas";
            this.dtvTemperaturas.RowHeadersWidth = 51;
            this.dtvTemperaturas.RowTemplate.Height = 24;
            this.dtvTemperaturas.Size = new System.Drawing.Size(541, 207);
            this.dtvTemperaturas.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtvNomTemp
            // 
            this.dtvNomTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvNomTemp.Location = new System.Drawing.Point(279, 475);
            this.dtvNomTemp.Name = "dtvNomTemp";
            this.dtvNomTemp.RowHeadersWidth = 51;
            this.dtvNomTemp.RowTemplate.Height = 24;
            this.dtvNomTemp.Size = new System.Drawing.Size(541, 207);
            this.dtvNomTemp.TabIndex = 13;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(12, 547);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(173, 30);
            this.btnOrdenar.TabIndex = 14;
            this.btnOrdenar.Text = "Ordenar ascendentes";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 704);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.dtvNomTemp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtvTemperaturas);
            this.Controls.Add(this.dtvDepartamentos);
            this.Controls.Add(this.btnIngresarTemp);
            this.Controls.Add(this.btnIngresarDep);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.txtNomDep);
            this.Controls.Add(this.txtNoidentificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtvDepartamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvTemperaturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtvNomTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoidentificacion;
        private System.Windows.Forms.TextBox txtNomDep;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Button btnIngresarDep;
        private System.Windows.Forms.Button btnIngresarTemp;
        private System.Windows.Forms.DataGridView dtvDepartamentos;
        private System.Windows.Forms.DataGridView dtvTemperaturas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtvNomTemp;
        private System.Windows.Forms.Button btnOrdenar;
    }
}

