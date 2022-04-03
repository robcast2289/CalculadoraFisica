namespace CalculadoraFisica
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogoutMenu = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelConfigSubmenu = new System.Windows.Forms.Panel();
            this.btnProyectiles = new System.Windows.Forms.Button();
            this.btnVectores = new System.Windows.Forms.Button();
            this.btnSolucionProblemas = new System.Windows.Forms.Button();
            this.btnConversor = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelChildFormContent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelConfigSubmenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelSideMenu.Controls.Add(this.label1);
            this.panelSideMenu.Controls.Add(this.btnLogoutMenu);
            this.panelSideMenu.Controls.Add(this.btnInfo);
            this.panelSideMenu.Controls.Add(this.panelConfigSubmenu);
            this.panelSideMenu.Controls.Add(this.btnSolucionProblemas);
            this.panelSideMenu.Controls.Add(this.btnConversor);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 664);
            this.panelSideMenu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(3, 647);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Version: 1.0.0";
            // 
            // btnLogoutMenu
            // 
            this.btnLogoutMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogoutMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogoutMenu.FlatAppearance.BorderSize = 0;
            this.btnLogoutMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutMenu.ForeColor = System.Drawing.Color.White;
            this.btnLogoutMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutMenu.Location = new System.Drawing.Point(0, 315);
            this.btnLogoutMenu.Name = "btnLogoutMenu";
            this.btnLogoutMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogoutMenu.Size = new System.Drawing.Size(250, 45);
            this.btnLogoutMenu.TabIndex = 2;
            this.btnLogoutMenu.Text = "Salir";
            this.btnLogoutMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogoutMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogoutMenu.UseVisualStyleBackColor = false;
            this.btnLogoutMenu.Click += new System.EventHandler(this.btnLogoutMenu_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 270);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(250, 45);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "Información del Sistema";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // panelConfigSubmenu
            // 
            this.panelConfigSubmenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelConfigSubmenu.Controls.Add(this.btnProyectiles);
            this.panelConfigSubmenu.Controls.Add(this.btnVectores);
            this.panelConfigSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfigSubmenu.Location = new System.Drawing.Point(0, 190);
            this.panelConfigSubmenu.Name = "panelConfigSubmenu";
            this.panelConfigSubmenu.Size = new System.Drawing.Size(250, 80);
            this.panelConfigSubmenu.TabIndex = 1;
            // 
            // btnProyectiles
            // 
            this.btnProyectiles.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnProyectiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProyectiles.FlatAppearance.BorderSize = 0;
            this.btnProyectiles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(110)))));
            this.btnProyectiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectiles.Location = new System.Drawing.Point(0, 40);
            this.btnProyectiles.Name = "btnProyectiles";
            this.btnProyectiles.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnProyectiles.Size = new System.Drawing.Size(250, 40);
            this.btnProyectiles.TabIndex = 1;
            this.btnProyectiles.Text = "Movimiento de Proyectiles";
            this.btnProyectiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectiles.UseVisualStyleBackColor = false;
            this.btnProyectiles.Click += new System.EventHandler(this.btnProyectiles_Click);
            // 
            // btnVectores
            // 
            this.btnVectores.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVectores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVectores.FlatAppearance.BorderSize = 0;
            this.btnVectores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(110)))));
            this.btnVectores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVectores.Location = new System.Drawing.Point(0, 0);
            this.btnVectores.Name = "btnVectores";
            this.btnVectores.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnVectores.Size = new System.Drawing.Size(250, 40);
            this.btnVectores.TabIndex = 0;
            this.btnVectores.Text = "Suma de Vectores";
            this.btnVectores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVectores.UseVisualStyleBackColor = false;
            this.btnVectores.Click += new System.EventHandler(this.btnVectores_Click);
            // 
            // btnSolucionProblemas
            // 
            this.btnSolucionProblemas.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSolucionProblemas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSolucionProblemas.FlatAppearance.BorderSize = 0;
            this.btnSolucionProblemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolucionProblemas.ForeColor = System.Drawing.Color.White;
            this.btnSolucionProblemas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolucionProblemas.Location = new System.Drawing.Point(0, 145);
            this.btnSolucionProblemas.Name = "btnSolucionProblemas";
            this.btnSolucionProblemas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSolucionProblemas.Size = new System.Drawing.Size(250, 45);
            this.btnSolucionProblemas.TabIndex = 0;
            this.btnSolucionProblemas.Text = "Solución de Problemas Físicos";
            this.btnSolucionProblemas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolucionProblemas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSolucionProblemas.UseVisualStyleBackColor = false;
            this.btnSolucionProblemas.Click += new System.EventHandler(this.btnSolucionProblemas_Click);
            // 
            // btnConversor
            // 
            this.btnConversor.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnConversor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConversor.FlatAppearance.BorderSize = 0;
            this.btnConversor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConversor.ForeColor = System.Drawing.Color.White;
            this.btnConversor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConversor.Location = new System.Drawing.Point(0, 100);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConversor.Size = new System.Drawing.Size(250, 45);
            this.btnConversor.TabIndex = 3;
            this.btnConversor.Text = "Calculadora de Conversión";
            this.btnConversor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConversor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConversor.UseVisualStyleBackColor = false;
            this.btnConversor.Click += new System.EventHandler(this.btnConversor_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(101)))), ((int)(((byte)(158)))));
            this.panelFilter.Controls.Add(this.lblUserName);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(250, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(905, 54);
            this.panelFilter.TabIndex = 2;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(298, 9);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(289, 31);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Proyecto Final Fisica 1";
            // 
            // panelChildFormContent
            // 
            this.panelChildFormContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelChildFormContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildFormContent.Location = new System.Drawing.Point(250, 54);
            this.panelChildFormContent.Name = "panelChildFormContent";
            this.panelChildFormContent.Size = new System.Drawing.Size(905, 610);
            this.panelChildFormContent.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CalculadoraFisica.Properties.Resources.FISICA_LOGO;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 664);
            this.Controls.Add(this.panelChildFormContent);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1171, 703);
            this.MinimumSize = new System.Drawing.Size(1171, 703);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Física";
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.panelConfigSubmenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogoutMenu;
        private System.Windows.Forms.Panel panelConfigSubmenu;
        private System.Windows.Forms.Button btnProyectiles;
        private System.Windows.Forms.Button btnVectores;
        private System.Windows.Forms.Button btnSolucionProblemas;
        private System.Windows.Forms.Button btnConversor;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel panelChildFormContent;
    }
}

