namespace CapaPresentacion
{
    partial class Inicio
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
            this.btnProblema = new System.Windows.Forms.Button();
            this.btnSolucion = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProblema
            // 
            this.btnProblema.Location = new System.Drawing.Point(81, 64);
            this.btnProblema.Name = "btnProblema";
            this.btnProblema.Size = new System.Drawing.Size(139, 23);
            this.btnProblema.TabIndex = 0;
            this.btnProblema.Text = "Nuevo Problema";
            this.btnProblema.UseVisualStyleBackColor = true;
            this.btnProblema.Click += new System.EventHandler(this.btnProblema_Click);
            // 
            // btnSolucion
            // 
            this.btnSolucion.Location = new System.Drawing.Point(81, 113);
            this.btnSolucion.Name = "btnSolucion";
            this.btnSolucion.Size = new System.Drawing.Size(139, 23);
            this.btnSolucion.TabIndex = 1;
            this.btnSolucion.Text = "Nueva Solucion";
            this.btnSolucion.UseVisualStyleBackColor = true;
            this.btnSolucion.Click += new System.EventHandler(this.btnSolucion_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(81, 161);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(139, 23);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar Problemas";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 292);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnSolucion);
            this.Controls.Add(this.btnProblema);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProblema;
        private System.Windows.Forms.Button btnSolucion;
        private System.Windows.Forms.Button btnListar;
    }
}

