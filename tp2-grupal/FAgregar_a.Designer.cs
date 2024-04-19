
namespace tp2_grupal
{
    partial class FAgregar_a
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
            this.l_nom_art = new System.Windows.Forms.Label();
            this.tb_nombrea = new System.Windows.Forms.TextBox();
            this.l_marca_a = new System.Windows.Forms.Label();
            this.lcate_a = new System.Windows.Forms.Label();
            this.ldetalle_a = new System.Windows.Forms.Label();
            this.richdetalle_a = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // l_nom_art
            // 
            this.l_nom_art.AutoSize = true;
            this.l_nom_art.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_nom_art.ForeColor = System.Drawing.Color.White;
            this.l_nom_art.Location = new System.Drawing.Point(12, 48);
            this.l_nom_art.MaximumSize = new System.Drawing.Size(288, 33);
            this.l_nom_art.MinimumSize = new System.Drawing.Size(288, 33);
            this.l_nom_art.Name = "l_nom_art";
            this.l_nom_art.Size = new System.Drawing.Size(288, 33);
            this.l_nom_art.TabIndex = 0;
            this.l_nom_art.Text = "Nombre del Articulo:";
            this.l_nom_art.Click += new System.EventHandler(this.l_nom_art_Click);
            // 
            // tb_nombrea
            // 
            this.tb_nombrea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_nombrea.Font = new System.Drawing.Font("Arial", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombrea.Location = new System.Drawing.Point(197, 39);
            this.tb_nombrea.Name = "tb_nombrea";
            this.tb_nombrea.Size = new System.Drawing.Size(223, 34);
            this.tb_nombrea.TabIndex = 1;
            this.tb_nombrea.TextChanged += new System.EventHandler(this.tb_nombrea_TextChanged);
            // 
            // l_marca_a
            // 
            this.l_marca_a.AutoSize = true;
            this.l_marca_a.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_marca_a.ForeColor = System.Drawing.SystemColors.Control;
            this.l_marca_a.Location = new System.Drawing.Point(12, 106);
            this.l_marca_a.MaximumSize = new System.Drawing.Size(105, 33);
            this.l_marca_a.MinimumSize = new System.Drawing.Size(105, 33);
            this.l_marca_a.Name = "l_marca_a";
            this.l_marca_a.Size = new System.Drawing.Size(105, 33);
            this.l_marca_a.TabIndex = 2;
            this.l_marca_a.Text = "Marca:";
            // 
            // lcate_a
            // 
            this.lcate_a.AutoSize = true;
            this.lcate_a.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcate_a.ForeColor = System.Drawing.Color.White;
            this.lcate_a.Location = new System.Drawing.Point(12, 170);
            this.lcate_a.MaximumSize = new System.Drawing.Size(168, 33);
            this.lcate_a.MinimumSize = new System.Drawing.Size(168, 33);
            this.lcate_a.Name = "lcate_a";
            this.lcate_a.Size = new System.Drawing.Size(168, 33);
            this.lcate_a.TabIndex = 3;
            this.lcate_a.Text = "Categorias:";
            // 
            // ldetalle_a
            // 
            this.ldetalle_a.AutoSize = true;
            this.ldetalle_a.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldetalle_a.ForeColor = System.Drawing.SystemColors.Control;
            this.ldetalle_a.Location = new System.Drawing.Point(12, 234);
            this.ldetalle_a.MaximumSize = new System.Drawing.Size(132, 33);
            this.ldetalle_a.MinimumSize = new System.Drawing.Size(132, 33);
            this.ldetalle_a.Name = "ldetalle_a";
            this.ldetalle_a.Size = new System.Drawing.Size(132, 33);
            this.ldetalle_a.TabIndex = 4;
            this.ldetalle_a.Text = "Detalles:";
            // 
            // richdetalle_a
            // 
            this.richdetalle_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.richdetalle_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richdetalle_a.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richdetalle_a.Location = new System.Drawing.Point(132, 234);
            this.richdetalle_a.MaximumSize = new System.Drawing.Size(288, 156);
            this.richdetalle_a.MinimumSize = new System.Drawing.Size(288, 156);
            this.richdetalle_a.Name = "richdetalle_a";
            this.richdetalle_a.Size = new System.Drawing.Size(288, 156);
            this.richdetalle_a.TabIndex = 5;
            this.richdetalle_a.Text = "";
            // 
            // FAgregar_a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 436);
            this.Controls.Add(this.richdetalle_a);
            this.Controls.Add(this.ldetalle_a);
            this.Controls.Add(this.lcate_a);
            this.Controls.Add(this.l_marca_a);
            this.Controls.Add(this.tb_nombrea);
            this.Controls.Add(this.l_nom_art);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FAgregar_a";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nom_art;
        private System.Windows.Forms.TextBox tb_nombrea;
        private System.Windows.Forms.Label l_marca_a;
        private System.Windows.Forms.Label lcate_a;
        private System.Windows.Forms.Label ldetalle_a;
        private System.Windows.Forms.RichTextBox richdetalle_a;
    }
}