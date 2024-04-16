
namespace tp2_grupal
{
    partial class Frm_principal
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
            this.b_articulos = new System.Windows.Forms.Button();
            this.btn_marcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_articulos
            // 
            this.b_articulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_articulos.Location = new System.Drawing.Point(91, 114);
            this.b_articulos.Name = "b_articulos";
            this.b_articulos.Size = new System.Drawing.Size(144, 60);
            this.b_articulos.TabIndex = 0;
            this.b_articulos.Text = "Articulos";
            this.b_articulos.UseVisualStyleBackColor = true;
            this.b_articulos.Click += new System.EventHandler(this.b_articulos_Click);
            // 
            // btn_marcas
            // 
            this.btn_marcas.AccessibleName = "btn_marcas";
            this.btn_marcas.Location = new System.Drawing.Point(91, 180);
            this.btn_marcas.Name = "btn_marcas";
            this.btn_marcas.Size = new System.Drawing.Size(144, 60);
            this.btn_marcas.TabIndex = 1;
            this.btn_marcas.Text = "marcas";
            this.btn_marcas.UseVisualStyleBackColor = true;
            this.btn_marcas.Click += new System.EventHandler(this.btn_marcas_Click);
            // 
            // Frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_marcas);
            this.Controls.Add(this.b_articulos);
            this.Name = "Frm_principal";
            this.Text = "Frm_principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_articulos;
        private System.Windows.Forms.Button btn_marcas;
    }
}