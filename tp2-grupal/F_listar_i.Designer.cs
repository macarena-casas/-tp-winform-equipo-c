
namespace tp2_grupal
{
    partial class F_listar_i
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
            this.dgv_listar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listar
            // 
            this.dgv_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listar.Location = new System.Drawing.Point(39, 21);
            this.dgv_listar.Name = "dgv_listar";
            this.dgv_listar.Size = new System.Drawing.Size(469, 195);
            this.dgv_listar.TabIndex = 0;
            this.dgv_listar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listar_CellContentClick);
            // 
            // F_listar_i
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(543, 250);
            this.Controls.Add(this.dgv_listar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "F_listar_i";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Imagenes";
            this.Load += new System.EventHandler(this.F_listar_i_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listar;
    }
}