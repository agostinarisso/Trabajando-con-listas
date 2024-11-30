namespace TP5EJ3
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
            this.txtNroExpediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ApilarExpediente = new System.Windows.Forms.Button();
            this.btnDesapilar = new System.Windows.Forms.Button();
            this.listMiPila = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de expediente:";
            // 
            // txtNroExpediente
            // 
            this.txtNroExpediente.Location = new System.Drawing.Point(194, 71);
            this.txtNroExpediente.Name = "txtNroExpediente";
            this.txtNroExpediente.Size = new System.Drawing.Size(200, 26);
            this.txtNroExpediente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(194, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 26);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 167);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // ApilarExpediente
            // 
            this.ApilarExpediente.Location = new System.Drawing.Point(49, 224);
            this.ApilarExpediente.Name = "ApilarExpediente";
            this.ApilarExpediente.Size = new System.Drawing.Size(201, 35);
            this.ApilarExpediente.TabIndex = 6;
            this.ApilarExpediente.Text = "Apilar expediente";
            this.ApilarExpediente.UseVisualStyleBackColor = true;
            this.ApilarExpediente.Click += new System.EventHandler(this.ApilarExpediente_Click);
            // 
            // btnDesapilar
            // 
            this.btnDesapilar.Location = new System.Drawing.Point(49, 288);
            this.btnDesapilar.Name = "btnDesapilar";
            this.btnDesapilar.Size = new System.Drawing.Size(201, 35);
            this.btnDesapilar.TabIndex = 7;
            this.btnDesapilar.Text = "Desapilar";
            this.btnDesapilar.UseVisualStyleBackColor = true;
            this.btnDesapilar.Click += new System.EventHandler(this.btnDesapilar_Click);
            // 
            // listMiPila
            // 
            this.listMiPila.FormattingEnabled = true;
            this.listMiPila.ItemHeight = 20;
            this.listMiPila.Location = new System.Drawing.Point(468, 71);
            this.listMiPila.Name = "listMiPila";
            this.listMiPila.Size = new System.Drawing.Size(357, 364);
            this.listMiPila.TabIndex = 8;
            this.listMiPila.SelectedIndexChanged += new System.EventHandler(this.listMiPila_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 477);
            this.Controls.Add(this.listMiPila);
            this.Controls.Add(this.btnDesapilar);
            this.Controls.Add(this.ApilarExpediente);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNroExpediente);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroExpediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ApilarExpediente;
        private System.Windows.Forms.Button btnDesapilar;
        private System.Windows.Forms.ListBox listMiPila;
    }
}

