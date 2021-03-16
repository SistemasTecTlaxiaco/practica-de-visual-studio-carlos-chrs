
namespace Practica2
{
    partial class recargar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(recargar));
            this.label2 = new System.Windows.Forms.Label();
            this.atras = new System.Windows.Forms.Button();
            this.aceotar = new System.Windows.Forms.Button();
            this.datos = new System.Windows.Forms.Label();
            this.datosRecargaa = new System.Windows.Forms.Panel();
            this.mon = new System.Windows.Forms.TextBox();
            this.monto = new System.Windows.Forms.Label();
            this.numero_tel = new System.Windows.Forms.TextBox();
            this.compa = new System.Windows.Forms.ComboBox();
            this.Compañia = new System.Windows.Forms.Label();
            this.numeroTel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.datosRecargaa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(270, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "RECARGAS PHONE";
            // 
            // atras
            // 
            this.atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atras.Location = new System.Drawing.Point(672, 375);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(100, 39);
            this.atras.TabIndex = 4;
            this.atras.Text = "Regresar";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // aceotar
            // 
            this.aceotar.BackColor = System.Drawing.Color.DodgerBlue;
            this.aceotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceotar.Location = new System.Drawing.Point(309, 313);
            this.aceotar.Name = "aceotar";
            this.aceotar.Size = new System.Drawing.Size(129, 37);
            this.aceotar.TabIndex = 5;
            this.aceotar.Text = "Recargar";
            this.aceotar.UseVisualStyleBackColor = false;
            // 
            // datos
            // 
            this.datos.AutoSize = true;
            this.datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datos.ForeColor = System.Drawing.Color.LavenderBlush;
            this.datos.Location = new System.Drawing.Point(250, 110);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(220, 18);
            this.datos.TabIndex = 6;
            this.datos.Text = "Ingrese los datos a recargar";
            this.datos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datosRecargaa
            // 
            this.datosRecargaa.BackColor = System.Drawing.Color.Navy;
            this.datosRecargaa.Controls.Add(this.mon);
            this.datosRecargaa.Controls.Add(this.monto);
            this.datosRecargaa.Controls.Add(this.numero_tel);
            this.datosRecargaa.Controls.Add(this.compa);
            this.datosRecargaa.Controls.Add(this.Compañia);
            this.datosRecargaa.Controls.Add(this.numeroTel);
            this.datosRecargaa.Location = new System.Drawing.Point(237, 141);
            this.datosRecargaa.Name = "datosRecargaa";
            this.datosRecargaa.Size = new System.Drawing.Size(272, 166);
            this.datosRecargaa.TabIndex = 8;
            // 
            // mon
            // 
            this.mon.Location = new System.Drawing.Point(112, 91);
            this.mon.Name = "mon";
            this.mon.Size = new System.Drawing.Size(149, 20);
            this.mon.TabIndex = 10;
            // 
            // monto
            // 
            this.monto.AutoSize = true;
            this.monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(3, 98);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(103, 13);
            this.monto.TabIndex = 9;
            this.monto.Text = "Total a Recargar";
            this.monto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numero_tel
            // 
            this.numero_tel.Location = new System.Drawing.Point(112, 16);
            this.numero_tel.Name = "numero_tel";
            this.numero_tel.Size = new System.Drawing.Size(149, 20);
            this.numero_tel.TabIndex = 3;
            this.numero_tel.TextChanged += new System.EventHandler(this.numero_tel_TextChanged);
            // 
            // compa
            // 
            this.compa.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.compa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.compa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.compa.FormattingEnabled = true;
            this.compa.Location = new System.Drawing.Point(112, 53);
            this.compa.Name = "compa";
            this.compa.Size = new System.Drawing.Size(149, 21);
            this.compa.TabIndex = 2;
            this.compa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Compañia
            // 
            this.Compañia.AutoSize = true;
            this.Compañia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Compañia.Location = new System.Drawing.Point(44, 61);
            this.Compañia.Name = "Compañia";
            this.Compañia.Size = new System.Drawing.Size(62, 13);
            this.Compañia.TabIndex = 1;
            this.Compañia.Text = "Compañia";
            // 
            // numeroTel
            // 
            this.numeroTel.AutoSize = true;
            this.numeroTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroTel.Location = new System.Drawing.Point(3, 23);
            this.numeroTel.Name = "numeroTel";
            this.numeroTel.Size = new System.Drawing.Size(104, 13);
            this.numeroTel.TabIndex = 0;
            this.numeroTel.Text = "Número Teléfono";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Perfil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica2.Properties.Resources.phone_call;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(309, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // recargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datosRecargaa);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.aceotar);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "recargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recargas Aquí...";
            this.Load += new System.EventHandler(this.recargar_Load);
            this.datosRecargaa.ResumeLayout(false);
            this.datosRecargaa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button aceotar;
        private System.Windows.Forms.Label datos;
        private System.Windows.Forms.Panel datosRecargaa;
        private System.Windows.Forms.TextBox numero_tel;
        private System.Windows.Forms.ComboBox compa;
        private System.Windows.Forms.Label Compañia;
        private System.Windows.Forms.Label numeroTel;
        private System.Windows.Forms.TextBox mon;
        private System.Windows.Forms.Label monto;
        private System.Windows.Forms.Button button1;
    }
}