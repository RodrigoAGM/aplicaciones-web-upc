namespace CapaPresentacion
{
    partial class Listado
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
            this.dgProblemas = new System.Windows.Forms.DataGridView();
            this.dgSoluciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProblemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoluciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProblemas
            // 
            this.dgProblemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProblemas.Location = new System.Drawing.Point(30, 41);
            this.dgProblemas.Name = "dgProblemas";
            this.dgProblemas.Size = new System.Drawing.Size(324, 356);
            this.dgProblemas.TabIndex = 0;
            this.dgProblemas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgProblemas_MouseClick);
            // 
            // dgSoluciones
            // 
            this.dgSoluciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSoluciones.Location = new System.Drawing.Point(418, 41);
            this.dgSoluciones.Name = "dgSoluciones";
            this.dgSoluciones.Size = new System.Drawing.Size(303, 356);
            this.dgSoluciones.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista Problemas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Soluciones";
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSoluciones);
            this.Controls.Add(this.dgProblemas);
            this.Name = "Listado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.Listado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProblemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSoluciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProblemas;
        private System.Windows.Forms.DataGridView dgSoluciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}