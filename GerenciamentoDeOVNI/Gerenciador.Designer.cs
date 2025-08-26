namespace GerenciamentoDeOVNI
{
    partial class Gerenciador
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
            this.grbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblPlaneta = new System.Windows.Forms.Label();
            this.btnDesligar = new System.Windows.Forms.Button();
            this.btnLigar = new System.Windows.Forms.Button();
            this.lblAbduzidos = new System.Windows.Forms.Label();
            this.lblTripulantes = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.grbTripulantes = new System.Windows.Forms.GroupBox();
            this.btnRemoverTripulantes = new System.Windows.Forms.Button();
            this.btnAddTripulantes = new System.Windows.Forms.Button();
            this.grbAbduzidos = new System.Windows.Forms.GroupBox();
            this.btnRemoverAbduzidos = new System.Windows.Forms.Button();
            this.btnAddAbduzidos = new System.Windows.Forms.Button();
            this.grbPlaneta = new System.Windows.Forms.GroupBox();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnMudarPlaneta = new System.Windows.Forms.Button();
            this.cmbPlanetas = new System.Windows.Forms.ComboBox();
            this.pibTerra = new System.Windows.Forms.PictureBox();
            this.pibOvni = new System.Windows.Forms.PictureBox();
            this.grbInformacoes.SuspendLayout();
            this.grbTripulantes.SuspendLayout();
            this.grbAbduzidos.SuspendLayout();
            this.grbPlaneta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibOvni)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInformacoes
            // 
            this.grbInformacoes.Controls.Add(this.lblPlaneta);
            this.grbInformacoes.Controls.Add(this.btnDesligar);
            this.grbInformacoes.Controls.Add(this.btnLigar);
            this.grbInformacoes.Controls.Add(this.lblAbduzidos);
            this.grbInformacoes.Controls.Add(this.lblTripulantes);
            this.grbInformacoes.Controls.Add(this.lblSituacao);
            this.grbInformacoes.Location = new System.Drawing.Point(12, 12);
            this.grbInformacoes.Name = "grbInformacoes";
            this.grbInformacoes.Size = new System.Drawing.Size(222, 223);
            this.grbInformacoes.TabIndex = 0;
            this.grbInformacoes.TabStop = false;
            this.grbInformacoes.Text = "Informações";
            // 
            // lblPlaneta
            // 
            this.lblPlaneta.AutoSize = true;
            this.lblPlaneta.Location = new System.Drawing.Point(21, 117);
            this.lblPlaneta.Name = "lblPlaneta";
            this.lblPlaneta.Size = new System.Drawing.Size(72, 13);
            this.lblPlaneta.TabIndex = 5;
            this.lblPlaneta.Text = "Planeta atual:";
            // 
            // btnDesligar
            // 
            this.btnDesligar.Location = new System.Drawing.Point(18, 185);
            this.btnDesligar.Name = "btnDesligar";
            this.btnDesligar.Size = new System.Drawing.Size(189, 32);
            this.btnDesligar.TabIndex = 4;
            this.btnDesligar.Text = "Deligar";
            this.btnDesligar.UseVisualStyleBackColor = true;
            this.btnDesligar.Click += new System.EventHandler(this.btnDesligar_Click);
            // 
            // btnLigar
            // 
            this.btnLigar.Enabled = false;
            this.btnLigar.Location = new System.Drawing.Point(18, 147);
            this.btnLigar.Name = "btnLigar";
            this.btnLigar.Size = new System.Drawing.Size(189, 32);
            this.btnLigar.TabIndex = 3;
            this.btnLigar.Text = "Ligar";
            this.btnLigar.UseVisualStyleBackColor = true;
            this.btnLigar.Click += new System.EventHandler(this.btnLigar_Click);
            // 
            // lblAbduzidos
            // 
            this.lblAbduzidos.AutoSize = true;
            this.lblAbduzidos.Location = new System.Drawing.Point(15, 91);
            this.lblAbduzidos.Name = "lblAbduzidos";
            this.lblAbduzidos.Size = new System.Drawing.Size(59, 13);
            this.lblAbduzidos.TabIndex = 2;
            this.lblAbduzidos.Text = "Abduzidos:";
            // 
            // lblTripulantes
            // 
            this.lblTripulantes.AutoSize = true;
            this.lblTripulantes.Location = new System.Drawing.Point(15, 61);
            this.lblTripulantes.Name = "lblTripulantes";
            this.lblTripulantes.Size = new System.Drawing.Size(62, 13);
            this.lblTripulantes.TabIndex = 1;
            this.lblTripulantes.Text = "Tripulantes:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(15, 36);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(52, 13);
            this.lblSituacao.TabIndex = 0;
            this.lblSituacao.Text = "Situação:";
            // 
            // grbTripulantes
            // 
            this.grbTripulantes.Controls.Add(this.btnRemoverTripulantes);
            this.grbTripulantes.Controls.Add(this.btnAddTripulantes);
            this.grbTripulantes.Location = new System.Drawing.Point(19, 256);
            this.grbTripulantes.Name = "grbTripulantes";
            this.grbTripulantes.Size = new System.Drawing.Size(215, 167);
            this.grbTripulantes.TabIndex = 1;
            this.grbTripulantes.TabStop = false;
            this.grbTripulantes.Text = "Tripulantes";
            // 
            // btnRemoverTripulantes
            // 
            this.btnRemoverTripulantes.Location = new System.Drawing.Point(11, 101);
            this.btnRemoverTripulantes.Name = "btnRemoverTripulantes";
            this.btnRemoverTripulantes.Size = new System.Drawing.Size(189, 45);
            this.btnRemoverTripulantes.TabIndex = 1;
            this.btnRemoverTripulantes.Text = "Remover";
            this.btnRemoverTripulantes.UseVisualStyleBackColor = true;
            this.btnRemoverTripulantes.Click += new System.EventHandler(this.btnRemoverTripulantes_Click);
            // 
            // btnAddTripulantes
            // 
            this.btnAddTripulantes.Location = new System.Drawing.Point(11, 32);
            this.btnAddTripulantes.Name = "btnAddTripulantes";
            this.btnAddTripulantes.Size = new System.Drawing.Size(189, 46);
            this.btnAddTripulantes.TabIndex = 0;
            this.btnAddTripulantes.Text = "Adicionar";
            this.btnAddTripulantes.UseVisualStyleBackColor = true;
            this.btnAddTripulantes.Click += new System.EventHandler(this.btnAddTripulantes_Click);
            // 
            // grbAbduzidos
            // 
            this.grbAbduzidos.Controls.Add(this.btnRemoverAbduzidos);
            this.grbAbduzidos.Controls.Add(this.btnAddAbduzidos);
            this.grbAbduzidos.Location = new System.Drawing.Point(264, 12);
            this.grbAbduzidos.Name = "grbAbduzidos";
            this.grbAbduzidos.Size = new System.Drawing.Size(215, 162);
            this.grbAbduzidos.TabIndex = 2;
            this.grbAbduzidos.TabStop = false;
            this.grbAbduzidos.Text = "Abduzidos";
            // 
            // btnRemoverAbduzidos
            // 
            this.btnRemoverAbduzidos.Location = new System.Drawing.Point(11, 101);
            this.btnRemoverAbduzidos.Name = "btnRemoverAbduzidos";
            this.btnRemoverAbduzidos.Size = new System.Drawing.Size(189, 45);
            this.btnRemoverAbduzidos.TabIndex = 1;
            this.btnRemoverAbduzidos.Text = "Remover";
            this.btnRemoverAbduzidos.UseVisualStyleBackColor = true;
            this.btnRemoverAbduzidos.Click += new System.EventHandler(this.btnRemoverAbduzidos_Click);
            // 
            // btnAddAbduzidos
            // 
            this.btnAddAbduzidos.Location = new System.Drawing.Point(11, 32);
            this.btnAddAbduzidos.Name = "btnAddAbduzidos";
            this.btnAddAbduzidos.Size = new System.Drawing.Size(189, 46);
            this.btnAddAbduzidos.TabIndex = 0;
            this.btnAddAbduzidos.Text = "Adicionar";
            this.btnAddAbduzidos.UseVisualStyleBackColor = true;
            this.btnAddAbduzidos.Click += new System.EventHandler(this.btnAddAbduzidos_Click);
            // 
            // grbPlaneta
            // 
            this.grbPlaneta.Controls.Add(this.btnRetornar);
            this.grbPlaneta.Controls.Add(this.btnMudarPlaneta);
            this.grbPlaneta.Controls.Add(this.cmbPlanetas);
            this.grbPlaneta.Location = new System.Drawing.Point(264, 180);
            this.grbPlaneta.Name = "grbPlaneta";
            this.grbPlaneta.Size = new System.Drawing.Size(215, 243);
            this.grbPlaneta.TabIndex = 3;
            this.grbPlaneta.TabStop = false;
            this.grbPlaneta.Text = "Planeta";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Location = new System.Drawing.Point(11, 146);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(198, 76);
            this.btnRetornar.TabIndex = 2;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnMudarPlaneta
            // 
            this.btnMudarPlaneta.Location = new System.Drawing.Point(11, 56);
            this.btnMudarPlaneta.Name = "btnMudarPlaneta";
            this.btnMudarPlaneta.Size = new System.Drawing.Size(198, 79);
            this.btnMudarPlaneta.TabIndex = 1;
            this.btnMudarPlaneta.Text = "Mudar Planeta";
            this.btnMudarPlaneta.UseVisualStyleBackColor = true;
            this.btnMudarPlaneta.Click += new System.EventHandler(this.btnMudarPlaneta_Click);
            // 
            // cmbPlanetas
            // 
            this.cmbPlanetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlanetas.FormattingEnabled = true;
            this.cmbPlanetas.Location = new System.Drawing.Point(11, 19);
            this.cmbPlanetas.Name = "cmbPlanetas";
            this.cmbPlanetas.Size = new System.Drawing.Size(198, 21);
            this.cmbPlanetas.TabIndex = 0;
            // 
            // pibTerra
            // 
            this.pibTerra.Location = new System.Drawing.Point(542, 288);
            this.pibTerra.Name = "pibTerra";
            this.pibTerra.Size = new System.Drawing.Size(86, 54);
            this.pibTerra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibTerra.TabIndex = 4;
            this.pibTerra.TabStop = false;
            // 
            // pibOvni
            // 
            this.pibOvni.Image = global::GerenciamentoDeOVNI.Properties.Resources.human;
            this.pibOvni.Location = new System.Drawing.Point(485, 12);
            this.pibOvni.Name = "pibOvni";
            this.pibOvni.Size = new System.Drawing.Size(217, 254);
            this.pibOvni.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibOvni.TabIndex = 5;
            this.pibOvni.TabStop = false;
            // 
            // Gerenciador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 435);
            this.Controls.Add(this.pibOvni);
            this.Controls.Add(this.pibTerra);
            this.Controls.Add(this.grbPlaneta);
            this.Controls.Add(this.grbAbduzidos);
            this.Controls.Add(this.grbTripulantes);
            this.Controls.Add(this.grbInformacoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Gerenciador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciador";
            this.grbInformacoes.ResumeLayout(false);
            this.grbInformacoes.PerformLayout();
            this.grbTripulantes.ResumeLayout(false);
            this.grbAbduzidos.ResumeLayout(false);
            this.grbPlaneta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibTerra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibOvni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInformacoes;
        private System.Windows.Forms.Label lblAbduzidos;
        private System.Windows.Forms.Label lblTripulantes;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button btnDesligar;
        private System.Windows.Forms.Button btnLigar;
        private System.Windows.Forms.GroupBox grbTripulantes;
        private System.Windows.Forms.Button btnRemoverTripulantes;
        private System.Windows.Forms.Button btnAddTripulantes;
        private System.Windows.Forms.GroupBox grbAbduzidos;
        private System.Windows.Forms.Button btnRemoverAbduzidos;
        private System.Windows.Forms.Button btnAddAbduzidos;
        private System.Windows.Forms.GroupBox grbPlaneta;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnMudarPlaneta;
        private System.Windows.Forms.ComboBox cmbPlanetas;
        private System.Windows.Forms.Label lblPlaneta;
        private System.Windows.Forms.PictureBox pibTerra;
        private System.Windows.Forms.PictureBox pibOvni;
    }
}