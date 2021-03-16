
namespace Practica2
{
    partial class ininre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ininre));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.Button();
            this.creacion = new System.Windows.Forms.Button();
            this.olvicontra = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Azure;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Name = "label4";
            // 
            // Usuario
            // 
            this.Usuario.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.Usuario, "Usuario");
            this.Usuario.Name = "Usuario";
            this.Usuario.TextChanged += new System.EventHandler(this.Usuario_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.contraseña, "contraseña");
            this.contraseña.Name = "contraseña";
            this.contraseña.TextChanged += new System.EventHandler(this.contraseña_TextChanged);
            // 
            // salir
            // 
            resources.ApplyResources(this.salir, "salir");
            this.salir.Name = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click_1);
            // 
            // creacion
            // 
            this.creacion.BackColor = System.Drawing.Color.SeaGreen;
            resources.ApplyResources(this.creacion, "creacion");
            this.creacion.ForeColor = System.Drawing.Color.Beige;
            this.creacion.Name = "creacion";
            this.creacion.UseVisualStyleBackColor = false;
            this.creacion.Click += new System.EventHandler(this.creacion_Click);
            // 
            // olvicontra
            // 
            resources.ApplyResources(this.olvicontra, "olvicontra");
            this.olvicontra.Name = "olvicontra";
            this.olvicontra.UseVisualStyleBackColor = true;
            this.olvicontra.Click += new System.EventHandler(this.olvicontra_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Practica2.Properties.Resources._1ea2e318_c195_4af3_8e65_f0ca03afe80e;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Practica2.Properties.Resources._1934740b_232f_4478_8072_8adb3f48c6d3;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica2.Properties.Resources.phone_call;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // inicio
            // 
            this.inicio.BackColor = System.Drawing.Color.DeepSkyBlue;
            resources.ApplyResources(this.inicio, "inicio");
            this.inicio.ForeColor = System.Drawing.Color.Beige;
            this.inicio.Name = "inicio";
            this.inicio.UseVisualStyleBackColor = false;
            this.inicio.Click += new System.EventHandler(this.inicio_Click);
            // 
            // ininre
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.olvicontra);
            this.Controls.Add(this.creacion);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ininre";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.ininre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button creacion;
        private System.Windows.Forms.Button olvido;
        private System.Windows.Forms.Button olvicontra;
        private System.Windows.Forms.Button inicio;
    }
}

