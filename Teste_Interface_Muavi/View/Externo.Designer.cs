namespace Teste_Interface_Muavi.View
{
    partial class frm_externo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_externo));
            this.pctbox_foto = new System.Windows.Forms.PictureBox();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // pctbox_foto
            // 
            this.pctbox_foto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbox_foto.Image = ((System.Drawing.Image)(resources.GetObject("pctbox_foto.Image")));
            this.pctbox_foto.Location = new System.Drawing.Point(0, 0);
            this.pctbox_foto.Name = "pctbox_foto";
            this.pctbox_foto.Size = new System.Drawing.Size(497, 340);
            this.pctbox_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_foto.TabIndex = 0;
            this.pctbox_foto.TabStop = false;
            // 
            // btn_fechar
            // 
            this.btn_fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.btn_fechar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_fechar.FlatAppearance.BorderSize = 0;
            this.btn_fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.btn_fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fechar.ForeColor = System.Drawing.Color.White;
            this.btn_fechar.Location = new System.Drawing.Point(0, 290);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(497, 50);
            this.btn_fechar.TabIndex = 1;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = false;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // frm_externo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(497, 340);
            this.Controls.Add(this.btn_fechar);
            this.Controls.Add(this.pctbox_foto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_externo";
            this.Text = "Externo";
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pctbox_foto;
        private Button btn_fechar;
    }
}