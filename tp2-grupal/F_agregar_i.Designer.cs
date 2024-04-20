
namespace tp2_grupal
{
    partial class F_agregar_i
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
            this.b_cancel_ai = new System.Windows.Forms.Button();
            this.b_acep_ai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_cancel_ai
            // 
            this.b_cancel_ai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_cancel_ai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_cancel_ai.FlatAppearance.BorderSize = 3;
            this.b_cancel_ai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_cancel_ai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_cancel_ai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cancel_ai.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cancel_ai.Location = new System.Drawing.Point(321, 298);
            this.b_cancel_ai.MaximumSize = new System.Drawing.Size(150, 44);
            this.b_cancel_ai.MinimumSize = new System.Drawing.Size(150, 44);
            this.b_cancel_ai.Name = "b_cancel_ai";
            this.b_cancel_ai.Size = new System.Drawing.Size(150, 44);
            this.b_cancel_ai.TabIndex = 0;
            this.b_cancel_ai.Text = "&Cancelar";
            this.b_cancel_ai.UseVisualStyleBackColor = false;
            this.b_cancel_ai.Click += new System.EventHandler(this.b_cancel_ai_Click);
            // 
            // b_acep_ai
            // 
            this.b_acep_ai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_acep_ai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_acep_ai.FlatAppearance.BorderSize = 3;
            this.b_acep_ai.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.b_acep_ai.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(175)))), ((int)(((byte)(58)))));
            this.b_acep_ai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_acep_ai.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_acep_ai.Location = new System.Drawing.Point(71, 298);
            this.b_acep_ai.MaximumSize = new System.Drawing.Size(150, 44);
            this.b_acep_ai.MinimumSize = new System.Drawing.Size(150, 44);
            this.b_acep_ai.Name = "b_acep_ai";
            this.b_acep_ai.Size = new System.Drawing.Size(150, 44);
            this.b_acep_ai.TabIndex = 1;
            this.b_acep_ai.Text = "&Aceptar";
            this.b_acep_ai.UseVisualStyleBackColor = false;
            // 
            // F_agregar_i
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(576, 436);
            this.Controls.Add(this.b_acep_ai);
            this.Controls.Add(this.b_cancel_ai);
            this.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 500);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "F_agregar_i";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Imagen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_cancel_ai;
        private System.Windows.Forms.Button b_acep_ai;
    }
}