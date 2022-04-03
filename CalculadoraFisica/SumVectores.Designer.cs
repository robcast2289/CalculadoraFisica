namespace CalculadoraFisica
{
    partial class SumVectores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiaControles = new System.Windows.Forms.Button();
            this.btnCalculaDatos = new System.Windows.Forms.Button();
            this.btnCreaControles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCantControl = new System.Windows.Forms.NumericUpDown();
            this.panelData = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantControl)).BeginInit();
            this.panelData.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLimpiaControles);
            this.panel1.Controls.Add(this.btnCalculaDatos);
            this.panel1.Controls.Add(this.btnCreaControles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudCantControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 78);
            this.panel1.TabIndex = 0;
            // 
            // btnLimpiaControles
            // 
            this.btnLimpiaControles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiaControles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiaControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiaControles.Location = new System.Drawing.Point(855, 23);
            this.btnLimpiaControles.Name = "btnLimpiaControles";
            this.btnLimpiaControles.Size = new System.Drawing.Size(116, 31);
            this.btnLimpiaControles.TabIndex = 4;
            this.btnLimpiaControles.Text = "Limpiar";
            this.btnLimpiaControles.UseVisualStyleBackColor = true;
            this.btnLimpiaControles.Click += new System.EventHandler(this.btnLimpiaControles_Click);
            // 
            // btnCalculaDatos
            // 
            this.btnCalculaDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculaDatos.Location = new System.Drawing.Point(586, 23);
            this.btnCalculaDatos.Name = "btnCalculaDatos";
            this.btnCalculaDatos.Size = new System.Drawing.Size(116, 31);
            this.btnCalculaDatos.TabIndex = 3;
            this.btnCalculaDatos.Text = "Calcular";
            this.btnCalculaDatos.UseVisualStyleBackColor = true;
            this.btnCalculaDatos.Click += new System.EventHandler(this.btnCalculaDatos_Click);
            // 
            // btnCreaControles
            // 
            this.btnCreaControles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreaControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreaControles.Location = new System.Drawing.Point(453, 23);
            this.btnCreaControles.Name = "btnCreaControles";
            this.btnCreaControles.Size = new System.Drawing.Size(116, 31);
            this.btnCreaControles.TabIndex = 2;
            this.btnCreaControles.Text = "Generar";
            this.btnCreaControles.UseVisualStyleBackColor = true;
            this.btnCreaControles.Click += new System.EventHandler(this.btnCreaControles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Vectores a sumar";
            // 
            // nudCantControl
            // 
            this.nudCantControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantControl.Location = new System.Drawing.Point(307, 24);
            this.nudCantControl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudCantControl.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantControl.Name = "nudCantControl";
            this.nudCantControl.Size = new System.Drawing.Size(120, 30);
            this.nudCantControl.TabIndex = 0;
            this.nudCantControl.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // panelData
            // 
            this.panelData.AutoScroll = true;
            this.panelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelData.Controls.Add(this.label7);
            this.panelData.Controls.Add(this.label6);
            this.panelData.Controls.Add(this.label5);
            this.panelData.Controls.Add(this.label2);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelData.Location = new System.Drawing.Point(0, 78);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(397, 372);
            this.panelData.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 26);
            this.label7.TabIndex = 6;
            this.label7.Text = "(En grados, con \r\nrespecto al origen)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(170, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Longitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "DATOS";
            // 
            // panelResult
            // 
            this.panelResult.AutoScroll = true;
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelResult.Controls.Add(this.label3);
            this.panelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResult.Location = new System.Drawing.Point(397, 78);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(586, 372);
            this.panelResult.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "RESULTADOS";
            // 
            // SumVectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panel1);
            this.Name = "SumVectores";
            this.Text = "SumVectores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantControl)).EndInit();
            this.panelData.ResumeLayout(false);
            this.panelData.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalculaDatos;
        private System.Windows.Forms.Button btnCreaControles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudCantControl;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimpiaControles;
    }
}