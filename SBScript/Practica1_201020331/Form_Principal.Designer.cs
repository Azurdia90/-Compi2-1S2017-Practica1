namespace Practica1_201020331
{
    partial class Form_Principal
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
            this.b_nuevo = new System.Windows.Forms.Button();
            this.b_abrir = new System.Windows.Forms.Button();
            this.b_guardar = new System.Windows.Forms.Button();
            this.b_Guardar_Como = new System.Windows.Forms.Button();
            this.b_cerrar = new System.Windows.Forms.Button();
            this.b_ejecutar = new System.Windows.Forms.Button();
            this.b_reporte = new System.Windows.Forms.Button();
            this.tC_entradas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rTB_entrada1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tB_consola = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_album = new System.Windows.Forms.Button();
            this.tC_entradas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_nuevo
            // 
            this.b_nuevo.Location = new System.Drawing.Point(12, 12);
            this.b_nuevo.Name = "b_nuevo";
            this.b_nuevo.Size = new System.Drawing.Size(75, 23);
            this.b_nuevo.TabIndex = 0;
            this.b_nuevo.Text = "Nuevo";
            this.b_nuevo.UseVisualStyleBackColor = true;
            this.b_nuevo.Click += new System.EventHandler(this.b_nuevo_Click);
            // 
            // b_abrir
            // 
            this.b_abrir.Location = new System.Drawing.Point(93, 12);
            this.b_abrir.Name = "b_abrir";
            this.b_abrir.Size = new System.Drawing.Size(75, 23);
            this.b_abrir.TabIndex = 1;
            this.b_abrir.Text = "Abrir";
            this.b_abrir.UseVisualStyleBackColor = true;
            this.b_abrir.Click += new System.EventHandler(this.b_abrir_Click);
            // 
            // b_guardar
            // 
            this.b_guardar.Location = new System.Drawing.Point(174, 12);
            this.b_guardar.Name = "b_guardar";
            this.b_guardar.Size = new System.Drawing.Size(75, 23);
            this.b_guardar.TabIndex = 2;
            this.b_guardar.Text = "Guardar";
            this.b_guardar.UseVisualStyleBackColor = true;
            // 
            // b_Guardar_Como
            // 
            this.b_Guardar_Como.Location = new System.Drawing.Point(255, 12);
            this.b_Guardar_Como.Name = "b_Guardar_Como";
            this.b_Guardar_Como.Size = new System.Drawing.Size(75, 23);
            this.b_Guardar_Como.TabIndex = 3;
            this.b_Guardar_Como.Text = "Guardar Como";
            this.b_Guardar_Como.UseVisualStyleBackColor = true;
            this.b_Guardar_Como.Click += new System.EventHandler(this.b_Guardar_Como_Click);
            // 
            // b_cerrar
            // 
            this.b_cerrar.Location = new System.Drawing.Point(336, 12);
            this.b_cerrar.Name = "b_cerrar";
            this.b_cerrar.Size = new System.Drawing.Size(75, 23);
            this.b_cerrar.TabIndex = 4;
            this.b_cerrar.Text = "Cerrar Pestaña";
            this.b_cerrar.UseVisualStyleBackColor = true;
            this.b_cerrar.Click += new System.EventHandler(this.b_cerrar_Click);
            // 
            // b_ejecutar
            // 
            this.b_ejecutar.Location = new System.Drawing.Point(417, 12);
            this.b_ejecutar.Name = "b_ejecutar";
            this.b_ejecutar.Size = new System.Drawing.Size(75, 23);
            this.b_ejecutar.TabIndex = 5;
            this.b_ejecutar.Text = "Ejecutar Archivo";
            this.b_ejecutar.UseVisualStyleBackColor = true;
            this.b_ejecutar.Click += new System.EventHandler(this.b_ejecutar_Click);
            // 
            // b_reporte
            // 
            this.b_reporte.Location = new System.Drawing.Point(498, 12);
            this.b_reporte.Name = "b_reporte";
            this.b_reporte.Size = new System.Drawing.Size(75, 23);
            this.b_reporte.TabIndex = 6;
            this.b_reporte.Text = "Reporte Errores";
            this.b_reporte.UseVisualStyleBackColor = true;
            // 
            // tC_entradas
            // 
            this.tC_entradas.Controls.Add(this.tabPage1);
            this.tC_entradas.Location = new System.Drawing.Point(13, 56);
            this.tC_entradas.Name = "tC_entradas";
            this.tC_entradas.SelectedIndex = 0;
            this.tC_entradas.Size = new System.Drawing.Size(642, 250);
            this.tC_entradas.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rTB_entrada1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(634, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Archivo 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rTB_entrada1
            // 
            this.rTB_entrada1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTB_entrada1.Location = new System.Drawing.Point(3, 3);
            this.rTB_entrada1.Name = "rTB_entrada1";
            this.rTB_entrada1.Size = new System.Drawing.Size(628, 218);
            this.rTB_entrada1.TabIndex = 0;
            this.rTB_entrada1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tB_consola);
            this.groupBox1.Location = new System.Drawing.Point(13, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consola";
            // 
            // tB_consola
            // 
            this.tB_consola.BackColor = System.Drawing.SystemColors.InfoText;
            this.tB_consola.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_consola.ForeColor = System.Drawing.Color.Lime;
            this.tB_consola.Location = new System.Drawing.Point(7, 20);
            this.tB_consola.Multiline = true;
            this.tB_consola.Name = "tB_consola";
            this.tB_consola.Size = new System.Drawing.Size(625, 74);
            this.tB_consola.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(676, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 396);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Imagen";
            // 
            // b_album
            // 
            this.b_album.Location = new System.Drawing.Point(580, 11);
            this.b_album.Name = "b_album";
            this.b_album.Size = new System.Drawing.Size(75, 23);
            this.b_album.TabIndex = 10;
            this.b_album.Text = "Álbum";
            this.b_album.UseVisualStyleBackColor = true;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 420);
            this.Controls.Add(this.b_album);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tC_entradas);
            this.Controls.Add(this.b_reporte);
            this.Controls.Add(this.b_ejecutar);
            this.Controls.Add(this.b_cerrar);
            this.Controls.Add(this.b_Guardar_Como);
            this.Controls.Add(this.b_guardar);
            this.Controls.Add(this.b_abrir);
            this.Controls.Add(this.b_nuevo);
            this.Name = "Form_Principal";
            this.Text = "SBScript";
            this.tC_entradas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_nuevo;
        private System.Windows.Forms.Button b_abrir;
        private System.Windows.Forms.Button b_guardar;
        private System.Windows.Forms.Button b_Guardar_Como;
        private System.Windows.Forms.Button b_cerrar;
        private System.Windows.Forms.Button b_ejecutar;
        private System.Windows.Forms.Button b_reporte;
        private System.Windows.Forms.TabControl tC_entradas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox rTB_entrada1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tB_consola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_album;
    }
}

