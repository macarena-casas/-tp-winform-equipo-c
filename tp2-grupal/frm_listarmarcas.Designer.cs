﻿namespace tp2_grupal
{
    partial class F_Listar_M
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
            this.list_marcas_listarmarcas = new System.Windows.Forms.ListBox();
            this.l_listarmarca = new System.Windows.Forms.Label();
            this.btn_salir_listarmarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_marcas_listarmarcas
            // 
            this.list_marcas_listarmarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.list_marcas_listarmarcas.FormattingEnabled = true;
            this.list_marcas_listarmarcas.Location = new System.Drawing.Point(122, 91);
            this.list_marcas_listarmarcas.MaximumSize = new System.Drawing.Size(293, 160);
            this.list_marcas_listarmarcas.MinimumSize = new System.Drawing.Size(293, 160);
            this.list_marcas_listarmarcas.Name = "list_marcas_listarmarcas";
            this.list_marcas_listarmarcas.Size = new System.Drawing.Size(293, 160);
            this.list_marcas_listarmarcas.TabIndex = 0;
            // 
            // l_listarmarca
            // 
            this.l_listarmarca.AutoSize = true;
            this.l_listarmarca.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_listarmarca.ForeColor = System.Drawing.Color.White;
            this.l_listarmarca.Location = new System.Drawing.Point(235, 34);
            this.l_listarmarca.Name = "l_listarmarca";
            this.l_listarmarca.Size = new System.Drawing.Size(83, 24);
            this.l_listarmarca.TabIndex = 1;
            this.l_listarmarca.Text = "Marcas";
            this.l_listarmarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_salir_listarmarcas
            // 
            this.btn_salir_listarmarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salir_listarmarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salir_listarmarcas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salir_listarmarcas.FlatAppearance.BorderSize = 5;
            this.btn_salir_listarmarcas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_salir_listarmarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_salir_listarmarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir_listarmarcas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir_listarmarcas.Location = new System.Drawing.Point(214, 299);
            this.btn_salir_listarmarcas.Name = "btn_salir_listarmarcas";
            this.btn_salir_listarmarcas.Size = new System.Drawing.Size(104, 46);
            this.btn_salir_listarmarcas.TabIndex = 2;
            this.btn_salir_listarmarcas.Text = "Salir";
            this.btn_salir_listarmarcas.UseVisualStyleBackColor = false;
            this.btn_salir_listarmarcas.Click += new System.EventHandler(this.btn_salir_listarmarcas_Click);
            // 
            // F_Listar_M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.btn_salir_listarmarcas);
            this.Controls.Add(this.l_listarmarca);
            this.Controls.Add(this.list_marcas_listarmarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "F_Listar_M";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Marcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_marcas_listarmarcas;
        private System.Windows.Forms.Label l_listarmarca;
        private System.Windows.Forms.Button btn_salir_listarmarcas;
    }
}