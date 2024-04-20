namespace tp2_grupal
{
    partial class frm_eliminarmarca
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.l_eliminar_marca = new System.Windows.Forms.Label();
            this.l_confirmar_eliminar_marca = new System.Windows.Forms.Label();
            this.btn_marca_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar_eliminarmarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox1.Location = new System.Drawing.Point(211, 55);
            this.textBox1.MaximumSize = new System.Drawing.Size(223, 23);
            this.textBox1.MinimumSize = new System.Drawing.Size(223, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l_eliminar_marca
            // 
            this.l_eliminar_marca.AutoSize = true;
            this.l_eliminar_marca.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.l_eliminar_marca.ForeColor = System.Drawing.Color.White;
            this.l_eliminar_marca.Location = new System.Drawing.Point(52, 55);
            this.l_eliminar_marca.MaximumSize = new System.Drawing.Size(143, 18);
            this.l_eliminar_marca.MinimumSize = new System.Drawing.Size(143, 18);
            this.l_eliminar_marca.Name = "l_eliminar_marca";
            this.l_eliminar_marca.Size = new System.Drawing.Size(143, 18);
            this.l_eliminar_marca.TabIndex = 1;
            this.l_eliminar_marca.Text = "Codigo de la marca";
            this.l_eliminar_marca.Click += new System.EventHandler(this.l_eliminar_marca_Click);
            // 
            // l_confirmar_eliminar_marca
            // 
            this.l_confirmar_eliminar_marca.AutoSize = true;
            this.l_confirmar_eliminar_marca.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.l_confirmar_eliminar_marca.ForeColor = System.Drawing.Color.White;
            this.l_confirmar_eliminar_marca.Location = new System.Drawing.Point(52, 129);
            this.l_confirmar_eliminar_marca.Name = "l_confirmar_eliminar_marca";
            this.l_confirmar_eliminar_marca.Size = new System.Drawing.Size(111, 18);
            this.l_confirmar_eliminar_marca.TabIndex = 2;
            this.l_confirmar_eliminar_marca.Text = "Eliminar marca";
            // 
            // btn_marca_eliminar
            // 
            this.btn_marca_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_marca_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_marca_eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_marca_eliminar.FlatAppearance.BorderSize = 5;
            this.btn_marca_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_marca_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_marca_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_marca_eliminar.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btn_marca_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_marca_eliminar.Location = new System.Drawing.Point(211, 117);
            this.btn_marca_eliminar.Name = "btn_marca_eliminar";
            this.btn_marca_eliminar.Size = new System.Drawing.Size(109, 39);
            this.btn_marca_eliminar.TabIndex = 3;
            this.btn_marca_eliminar.Text = "Aceptar";
            this.btn_marca_eliminar.UseVisualStyleBackColor = false;
            this.btn_marca_eliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar_eliminarmarca
            // 
            this.btn_cancelar_eliminarmarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_cancelar_eliminarmarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar_eliminarmarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar_eliminarmarca.FlatAppearance.BorderSize = 5;
            this.btn_cancelar_eliminarmarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_cancelar_eliminarmarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar_eliminarmarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_eliminarmarca.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar_eliminarmarca.Location = new System.Drawing.Point(325, 117);
            this.btn_cancelar_eliminarmarca.Name = "btn_cancelar_eliminarmarca";
            this.btn_cancelar_eliminarmarca.Size = new System.Drawing.Size(109, 39);
            this.btn_cancelar_eliminarmarca.TabIndex = 4;
            this.btn_cancelar_eliminarmarca.Text = "Cancelar";
            this.btn_cancelar_eliminarmarca.UseVisualStyleBackColor = false;
            this.btn_cancelar_eliminarmarca.Click += new System.EventHandler(this.btn_cancelar_eliminarmarca_Click);
            // 
            // frm_eliminarmarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(531, 228);
            this.Controls.Add(this.btn_cancelar_eliminarmarca);
            this.Controls.Add(this.btn_marca_eliminar);
            this.Controls.Add(this.l_confirmar_eliminar_marca);
            this.Controls.Add(this.l_eliminar_marca);
            this.Controls.Add(this.textBox1);
            this.MaximumSize = new System.Drawing.Size(547, 267);
            this.MinimumSize = new System.Drawing.Size(547, 267);
            this.Name = "frm_eliminarmarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_eliminarmarca";
            this.Load += new System.EventHandler(this.frm_eliminarmarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label l_eliminar_marca;
        private System.Windows.Forms.Label l_confirmar_eliminar_marca;
        private System.Windows.Forms.Button btn_marca_eliminar;
        private System.Windows.Forms.Button btn_cancelar_eliminarmarca;
    }
}