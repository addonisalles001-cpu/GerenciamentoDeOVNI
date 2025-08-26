namespace GerenciamentoDeOVNI
{
    partial class TelaInicial
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
            this.lblMaximoDeTripulantes = new System.Windows.Forms.Label();
            this.lblMaximoDeAbdusidos = new System.Windows.Forms.Label();
            this.lblPlanetaDeOrigem = new System.Windows.Forms.Label();
            this.txbTripulantes = new System.Windows.Forms.TextBox();
            this.txbAbduzidos = new System.Windows.Forms.TextBox();
            this.cmbPlaneta = new System.Windows.Forms.ComboBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaximoDeTripulantes
            // 
            this.lblMaximoDeTripulantes.AutoSize = true;
            this.lblMaximoDeTripulantes.Location = new System.Drawing.Point(66, 144);
            this.lblMaximoDeTripulantes.Name = "lblMaximoDeTripulantes";
            this.lblMaximoDeTripulantes.Size = new System.Drawing.Size(113, 13);
            this.lblMaximoDeTripulantes.TabIndex = 0;
            this.lblMaximoDeTripulantes.Text = "Máximo de Tripulantes";
            // 
            // lblMaximoDeAbdusidos
            // 
            this.lblMaximoDeAbdusidos.AutoSize = true;
            this.lblMaximoDeAbdusidos.Location = new System.Drawing.Point(66, 175);
            this.lblMaximoDeAbdusidos.Name = "lblMaximoDeAbdusidos";
            this.lblMaximoDeAbdusidos.Size = new System.Drawing.Size(110, 13);
            this.lblMaximoDeAbdusidos.TabIndex = 1;
            this.lblMaximoDeAbdusidos.Text = "Máximo de Abduzidos";
            // 
            // lblPlanetaDeOrigem
            // 
            this.lblPlanetaDeOrigem.AutoSize = true;
            this.lblPlanetaDeOrigem.Location = new System.Drawing.Point(66, 216);
            this.lblPlanetaDeOrigem.Name = "lblPlanetaDeOrigem";
            this.lblPlanetaDeOrigem.Size = new System.Drawing.Size(94, 13);
            this.lblPlanetaDeOrigem.TabIndex = 2;
            this.lblPlanetaDeOrigem.Text = "Planeta de Origem";
            // 
            // txbTripulantes
            // 
            this.txbTripulantes.Location = new System.Drawing.Point(225, 137);
            this.txbTripulantes.Name = "txbTripulantes";
            this.txbTripulantes.Size = new System.Drawing.Size(121, 20);
            this.txbTripulantes.TabIndex = 3;
            // 
            // txbAbduzidos
            // 
            this.txbAbduzidos.Location = new System.Drawing.Point(225, 168);
            this.txbAbduzidos.Name = "txbAbduzidos";
            this.txbAbduzidos.Size = new System.Drawing.Size(121, 20);
            this.txbAbduzidos.TabIndex = 4;
            // 
            // cmbPlaneta
            // 
            this.cmbPlaneta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPlaneta.FormattingEnabled = true;
            this.cmbPlaneta.Location = new System.Drawing.Point(225, 208);
            this.cmbPlaneta.Name = "cmbPlaneta";
            this.cmbPlaneta.Size = new System.Drawing.Size(121, 21);
            this.cmbPlaneta.TabIndex = 5;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(225, 260);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(139, 44);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(218, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(352, 37);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "UFO MANEGER 5000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GerenciamentoDeOVNI.Properties.Resources.human;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.cmbPlaneta);
            this.Controls.Add(this.txbAbduzidos);
            this.Controls.Add(this.txbTripulantes);
            this.Controls.Add(this.lblPlanetaDeOrigem);
            this.Controls.Add(this.lblMaximoDeAbdusidos);
            this.Controls.Add(this.lblMaximoDeTripulantes);
            this.Name = "TelaInicial";
            this.Text = "TelaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaximoDeTripulantes;
        private System.Windows.Forms.Label lblMaximoDeAbdusidos;
        private System.Windows.Forms.Label lblPlanetaDeOrigem;
        private System.Windows.Forms.TextBox txbTripulantes;
        private System.Windows.Forms.TextBox txbAbduzidos;
        private System.Windows.Forms.ComboBox cmbPlaneta;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}