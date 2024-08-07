namespace Loja_Virtual
{
    partial class frm_Carregamento
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Carregamento));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPDT = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLoading = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.labelMensagem = new System.Windows.Forms.Label();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.pictureBoxCelular = new System.Windows.Forms.PictureBox();
            this.pictureBoxRelogio = new System.Windows.Forms.PictureBox();
            this.pictureBoxTablets = new System.Windows.Forms.PictureBox();
            this.pictureBoxTelevisao = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogo.SuspendLayout();
            this.panelButtom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelogio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTablets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelevisao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.labelPDT);
            this.panelLogo.Controls.Add(this.pictureBoxIcon);
            this.panelLogo.Location = new System.Drawing.Point(-11, -2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(273, 50);
            this.panelLogo.TabIndex = 6;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(213, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "1.0";
            // 
            // labelPDT
            // 
            this.labelPDT.AutoSize = true;
            this.labelPDT.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPDT.ForeColor = System.Drawing.Color.White;
            this.labelPDT.Location = new System.Drawing.Point(59, 11);
            this.labelPDT.Name = "labelPDT";
            this.labelPDT.Size = new System.Drawing.Size(148, 31);
            this.labelPDT.TabIndex = 1;
            this.labelPDT.Text = "PDT-STORE";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panelLoading.Location = new System.Drawing.Point(-10, 66);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(63, 19);
            this.panelLoading.TabIndex = 0;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagem.ForeColor = System.Drawing.Color.White;
            this.labelMensagem.Location = new System.Drawing.Point(60, 33);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(519, 27);
            this.labelMensagem.TabIndex = 0;
            this.labelMensagem.Text = "LEVANDO  A TECNOLOGIA MAIS PRÓXIMA PRA SI";
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelButtom.Controls.Add(this.panelLoading);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(0, 221);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(600, 83);
            this.panelButtom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDT-STORE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(66)))), ((int)(((byte)(194)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelMensagem);
            this.panel1.Location = new System.Drawing.Point(-11, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 70);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Loja_Virtual.Properties.Resources.shopping_cart_80px;
            this.pictureBox2.Location = new System.Drawing.Point(210, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::Loja_Virtual.Properties.Resources.shopping_cart_80px;
            this.pictureBoxIcon.Location = new System.Drawing.Point(1, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(74, 47);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // pictureBoxCelular
            // 
            this.pictureBoxCelular.Image = global::Loja_Virtual.Properties.Resources.celular;
            this.pictureBoxCelular.Location = new System.Drawing.Point(-38, -2);
            this.pictureBoxCelular.Name = "pictureBoxCelular";
            this.pictureBoxCelular.Size = new System.Drawing.Size(676, 224);
            this.pictureBoxCelular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxCelular.TabIndex = 5;
            this.pictureBoxCelular.TabStop = false;
            // 
            // pictureBoxRelogio
            // 
            this.pictureBoxRelogio.Image = global::Loja_Virtual.Properties.Resources.relogio;
            this.pictureBoxRelogio.Location = new System.Drawing.Point(-38, -2);
            this.pictureBoxRelogio.Name = "pictureBoxRelogio";
            this.pictureBoxRelogio.Size = new System.Drawing.Size(676, 224);
            this.pictureBoxRelogio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxRelogio.TabIndex = 4;
            this.pictureBoxRelogio.TabStop = false;
            // 
            // pictureBoxTablets
            // 
            this.pictureBoxTablets.Image = global::Loja_Virtual.Properties.Resources.tablet;
            this.pictureBoxTablets.Location = new System.Drawing.Point(-38, -2);
            this.pictureBoxTablets.Name = "pictureBoxTablets";
            this.pictureBoxTablets.Size = new System.Drawing.Size(676, 224);
            this.pictureBoxTablets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTablets.TabIndex = 3;
            this.pictureBoxTablets.TabStop = false;
            // 
            // pictureBoxTelevisao
            // 
            this.pictureBoxTelevisao.Image = global::Loja_Virtual.Properties.Resources.televisao;
            this.pictureBoxTelevisao.Location = new System.Drawing.Point(-38, -2);
            this.pictureBoxTelevisao.Name = "pictureBoxTelevisao";
            this.pictureBoxTelevisao.Size = new System.Drawing.Size(676, 224);
            this.pictureBoxTelevisao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxTelevisao.TabIndex = 2;
            this.pictureBoxTelevisao.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Loja_Virtual.Properties.Resources.televisao;
            this.pictureBox1.Location = new System.Drawing.Point(-38, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Carregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.pictureBoxCelular);
            this.Controls.Add(this.pictureBoxRelogio);
            this.Controls.Add(this.pictureBoxTablets);
            this.Controls.Add(this.pictureBoxTelevisao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelButtom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Carregamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDT-Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelButtom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRelogio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTablets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTelevisao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxTelevisao;
        private System.Windows.Forms.PictureBox pictureBoxTablets;
        private System.Windows.Forms.PictureBox pictureBoxRelogio;
        private System.Windows.Forms.PictureBox pictureBoxCelular;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelPDT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

