
namespace tp2_grupal
{
    partial class FModificar_a
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
            this.tex_modif_a = new System.Windows.Forms.TextBox();
            this.b_acep_ma = new System.Windows.Forms.Button();
            this.b_cancel_ma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el codigo del articulo que desea modificar:";
            // 
            // tex_modif_a
            // 
            this.tex_modif_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tex_modif_a.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_modif_a.Location = new System.Drawing.Point(386, 48);
            this.tex_modif_a.MaximumSize = new System.Drawing.Size(170, 34);
            this.tex_modif_a.MinimumSize = new System.Drawing.Size(170, 34);
            this.tex_modif_a.Name = "tex_modif_a";
            this.tex_modif_a.Size = new System.Drawing.Size(170, 23);
            this.tex_modif_a.TabIndex = 1;
            // 
            // b_acep_ma
            // 
            this.b_acep_ma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_acep_ma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_acep_ma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_acep_ma.FlatAppearance.BorderSize = 3;
            this.b_acep_ma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_acep_ma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_acep_ma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_acep_ma.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_acep_ma.Location = new System.Drawing.Point(90, 288);
            this.b_acep_ma.Name = "b_acep_ma";
            this.b_acep_ma.Size = new System.Drawing.Size(150, 44);
            this.b_acep_ma.TabIndex = 2;
            this.b_acep_ma.Text = "&Aceptar";
            this.b_acep_ma.UseVisualStyleBackColor = false;
            // 
            // b_cancel_ma
            // 
            this.b_cancel_ma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_cancel_ma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_cancel_ma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_cancel_ma.FlatAppearance.BorderSize = 3;
            this.b_cancel_ma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_cancel_ma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_cancel_ma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel_ma.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cancel_ma.Location = new System.Drawing.Point(302, 288);
            this.b_cancel_ma.Name = "b_cancel_ma";
            this.b_cancel_ma.Size = new System.Drawing.Size(150, 44);
            this.b_cancel_ma.TabIndex = 3;
            this.b_cancel_ma.Text = "&Cancelar";
            this.b_cancel_ma.UseVisualStyleBackColor = false;
            this.b_cancel_ma.Click += new System.EventHandler(this.b_cancel_ma_Click);
            // 
            // FModificar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.b_cancel_ma);
            this.Controls.Add(this.b_acep_ma);
            this.Controls.Add(this.tex_modif_a);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FModificar_a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Articulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_modif_a;
        private System.Windows.Forms.Button b_acep_ma;
        private System.Windows.Forms.Button b_cancel_ma;
    }
}