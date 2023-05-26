namespace WindowsFormsApp1
{
    partial class frmClientes
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
            this.lblCodigoCli = new System.Windows.Forms.Label();
            this.txtCodigoCli = new System.Windows.Forms.TextBox();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.lblSexoCli = new System.Windows.Forms.Label();
            this.rbtFem = new System.Windows.Forms.RadioButton();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.btnPesquisaCli = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCodigoCli
            // 
            this.lblCodigoCli.AutoSize = true;
            this.lblCodigoCli.Location = new System.Drawing.Point(34, 47);
            this.lblCodigoCli.Name = "lblCodigoCli";
            this.lblCodigoCli.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoCli.TabIndex = 1;
            this.lblCodigoCli.Text = "Código:";
            // 
            // txtCodigoCli
            // 
            this.txtCodigoCli.Location = new System.Drawing.Point(37, 73);
            this.txtCodigoCli.Name = "txtCodigoCli";
            this.txtCodigoCli.Size = new System.Drawing.Size(55, 20);
            this.txtCodigoCli.TabIndex = 5;
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Location = new System.Drawing.Point(34, 120);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCli.TabIndex = 6;
            this.lblNomeCli.Text = "Nome:";
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(37, 159);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.ReadOnly = true;
            this.txtNomeCli.Size = new System.Drawing.Size(248, 20);
            this.txtNomeCli.TabIndex = 7;
            // 
            // lblSexoCli
            // 
            this.lblSexoCli.AutoSize = true;
            this.lblSexoCli.Location = new System.Drawing.Point(39, 219);
            this.lblSexoCli.Name = "lblSexoCli";
            this.lblSexoCli.Size = new System.Drawing.Size(34, 13);
            this.lblSexoCli.TabIndex = 8;
            this.lblSexoCli.Text = "Sexo:";
            // 
            // rbtFem
            // 
            this.rbtFem.AutoSize = true;
            this.rbtFem.Location = new System.Drawing.Point(42, 253);
            this.rbtFem.Name = "rbtFem";
            this.rbtFem.Size = new System.Drawing.Size(67, 17);
            this.rbtFem.TabIndex = 9;
            this.rbtFem.TabStop = true;
            this.rbtFem.Text = "Feminino";
            this.rbtFem.UseVisualStyleBackColor = true;
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Location = new System.Drawing.Point(42, 296);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(73, 17);
            this.rbtMasc.TabIndex = 10;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaCli
            // 
            this.btnPesquisaCli.Image = global::WindowsFormsApp1.Properties.Resources.search;
            this.btnPesquisaCli.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisaCli.Location = new System.Drawing.Point(243, 279);
            this.btnPesquisaCli.Name = "btnPesquisaCli";
            this.btnPesquisaCli.Size = new System.Drawing.Size(70, 70);
            this.btnPesquisaCli.TabIndex = 11;
            this.btnPesquisaCli.Text = "&Buscar";
            this.btnPesquisaCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisaCli.UseVisualStyleBackColor = true;
            this.btnPesquisaCli.Click += new System.EventHandler(this.btnPesquisaCli_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::WindowsFormsApp1.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(243, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 70);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "&Sair";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPesquisaCli);
            this.Controls.Add(this.rbtMasc);
            this.Controls.Add(this.rbtFem);
            this.Controls.Add(this.lblSexoCli);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.txtCodigoCli);
            this.Controls.Add(this.lblCodigoCli);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoCli;
        private System.Windows.Forms.TextBox txtCodigoCli;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.Label lblSexoCli;
        private System.Windows.Forms.RadioButton rbtFem;
        private System.Windows.Forms.RadioButton rbtMasc;
        private System.Windows.Forms.Button btnPesquisaCli;
        private System.Windows.Forms.Button btnExit;
    }
}