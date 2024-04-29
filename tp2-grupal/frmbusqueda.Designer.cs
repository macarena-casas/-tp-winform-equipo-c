
namespace tp2_grupal
{
    partial class frmbusqueda
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
            this.components = new System.ComponentModel.Container();
            this.btn_buscarid = new System.Windows.Forms.Button();
            this.dgv_busqueda = new System.Windows.Forms.DataGridView();
            this.txt_buscarid = new System.Windows.Forms.TextBox();
            this.btn_buscarco = new System.Windows.Forms.Button();
            this.txt_buscarco = new System.Windows.Forms.TextBox();
            this.txt_buscarno = new System.Windows.Forms.TextBox();
            this.btn_buscarno = new System.Windows.Forms.Button();
            this.pb_Busqueda = new System.Windows.Forms.PictureBox();
            this.l_listarmarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iL_busqueda = new System.Windows.Forms.ImageList(this.components);
            this.rtb_Detalles = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Busqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscarid
            // 
            this.btn_buscarid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_buscarid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_buscarid.FlatAppearance.BorderSize = 3;
            this.btn_buscarid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_buscarid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_buscarid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarid.ForeColor = System.Drawing.Color.Black;
            this.btn_buscarid.Location = new System.Drawing.Point(27, 290);
            this.btn_buscarid.Name = "btn_buscarid";
            this.btn_buscarid.Size = new System.Drawing.Size(113, 34);
            this.btn_buscarid.TabIndex = 6;
            this.btn_buscarid.Text = "Buscar";
            this.btn_buscarid.UseVisualStyleBackColor = false;
            this.btn_buscarid.Click += new System.EventHandler(this.btn_buscarid_Click);
            // 
            // dgv_busqueda
            // 
            this.dgv_busqueda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_busqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_busqueda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_busqueda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_busqueda.Location = new System.Drawing.Point(7, 8);
            this.dgv_busqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_busqueda.Name = "dgv_busqueda";
            this.dgv_busqueda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_busqueda.RowTemplate.Height = 31;
            this.dgv_busqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_busqueda.Size = new System.Drawing.Size(453, 93);
            this.dgv_busqueda.TabIndex = 7;
            this.dgv_busqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_busqueda_CellContentClick);
            // 
            // txt_buscarid
            // 
            this.txt_buscarid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_buscarid.Location = new System.Drawing.Point(25, 250);
            this.txt_buscarid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_buscarid.Name = "txt_buscarid";
            this.txt_buscarid.Size = new System.Drawing.Size(117, 20);
            this.txt_buscarid.TabIndex = 8;
            this.txt_buscarid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_buscarid.TextChanged += new System.EventHandler(this.txt_buscarid_TextChanged);
            // 
            // btn_buscarco
            // 
            this.btn_buscarco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_buscarco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarco.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_buscarco.FlatAppearance.BorderSize = 3;
            this.btn_buscarco.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_buscarco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_buscarco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarco.ForeColor = System.Drawing.Color.Black;
            this.btn_buscarco.Location = new System.Drawing.Point(196, 290);
            this.btn_buscarco.Name = "btn_buscarco";
            this.btn_buscarco.Size = new System.Drawing.Size(104, 34);
            this.btn_buscarco.TabIndex = 9;
            this.btn_buscarco.Text = "Buscar";
            this.btn_buscarco.UseVisualStyleBackColor = false;
            this.btn_buscarco.Click += new System.EventHandler(this.btn_buscarco_Click);
            // 
            // txt_buscarco
            // 
            this.txt_buscarco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_buscarco.Location = new System.Drawing.Point(196, 250);
            this.txt_buscarco.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_buscarco.Name = "txt_buscarco";
            this.txt_buscarco.Size = new System.Drawing.Size(106, 20);
            this.txt_buscarco.TabIndex = 10;
            // 
            // txt_buscarno
            // 
            this.txt_buscarno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txt_buscarno.Location = new System.Drawing.Point(343, 250);
            this.txt_buscarno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_buscarno.Name = "txt_buscarno";
            this.txt_buscarno.Size = new System.Drawing.Size(106, 20);
            this.txt_buscarno.TabIndex = 12;
            // 
            // btn_buscarno
            // 
            this.btn_buscarno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_buscarno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarno.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_buscarno.FlatAppearance.BorderSize = 3;
            this.btn_buscarno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_buscarno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_buscarno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarno.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarno.ForeColor = System.Drawing.Color.Black;
            this.btn_buscarno.Location = new System.Drawing.Point(343, 290);
            this.btn_buscarno.Name = "btn_buscarno";
            this.btn_buscarno.Size = new System.Drawing.Size(104, 34);
            this.btn_buscarno.TabIndex = 11;
            this.btn_buscarno.Text = "Buscar";
            this.btn_buscarno.UseVisualStyleBackColor = false;
            this.btn_buscarno.Click += new System.EventHandler(this.btn_buscarno_Click);
            // 
            // pb_Busqueda
            // 
            this.pb_Busqueda.Location = new System.Drawing.Point(309, 102);
            this.pb_Busqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_Busqueda.Name = "pb_Busqueda";
            this.pb_Busqueda.Size = new System.Drawing.Size(111, 111);
            this.pb_Busqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Busqueda.TabIndex = 13;
            this.pb_Busqueda.TabStop = false;
            this.pb_Busqueda.Click += new System.EventHandler(this.pb_Busqueda_Click);
            // 
            // l_listarmarca
            // 
            this.l_listarmarca.AutoSize = true;
            this.l_listarmarca.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_listarmarca.ForeColor = System.Drawing.Color.White;
            this.l_listarmarca.Location = new System.Drawing.Point(105, 102);
            this.l_listarmarca.Name = "l_listarmarca";
            this.l_listarmarca.Size = new System.Drawing.Size(66, 18);
            this.l_listarmarca.TabIndex = 15;
            this.l_listarmarca.Text = "Detalles";
            this.l_listarmarca.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(361, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // iL_busqueda
            // 
            this.iL_busqueda.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.iL_busqueda.ImageSize = new System.Drawing.Size(16, 16);
            this.iL_busqueda.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // rtb_Detalles
            // 
            this.rtb_Detalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rtb_Detalles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Detalles.Font = new System.Drawing.Font("Arial", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Detalles.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.rtb_Detalles.Location = new System.Drawing.Point(27, 138);
            this.rtb_Detalles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtb_Detalles.Name = "rtb_Detalles";
            this.rtb_Detalles.Size = new System.Drawing.Size(231, 67);
            this.rtb_Detalles.TabIndex = 19;
            this.rtb_Detalles.Text = "";
            // 
            // frmbusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(482, 406);
            this.Controls.Add(this.rtb_Detalles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_listarmarca);
            this.Controls.Add(this.pb_Busqueda);
            this.Controls.Add(this.txt_buscarno);
            this.Controls.Add(this.btn_buscarno);
            this.Controls.Add(this.txt_buscarco);
            this.Controls.Add(this.btn_buscarco);
            this.Controls.Add(this.txt_buscarid);
            this.Controls.Add(this.dgv_busqueda);
            this.Controls.Add(this.btn_buscarid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(498, 532);
            this.MinimumSize = new System.Drawing.Size(498, 411);
            this.Name = "frmbusqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda";
            this.Load += new System.EventHandler(this.frmbusqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_busqueda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Busqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscarid;
        private System.Windows.Forms.DataGridView dgv_busqueda;
        private System.Windows.Forms.TextBox txt_buscarid;
        private System.Windows.Forms.Button btn_buscarco;
        private System.Windows.Forms.TextBox txt_buscarco;
        private System.Windows.Forms.TextBox txt_buscarno;
        private System.Windows.Forms.Button btn_buscarno;
        private System.Windows.Forms.PictureBox pb_Busqueda;
        private System.Windows.Forms.Label l_listarmarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList iL_busqueda;
        private System.Windows.Forms.RichTextBox rtb_Detalles;
    }
}