namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtIngresos = new System.Windows.Forms.TextBox();
            this.txtInssL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInssP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTipD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inss Laboral";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(233, 302);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(96, 35);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(74, 302);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 35);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtIngresos
            // 
            this.txtIngresos.Location = new System.Drawing.Point(243, 84);
            this.txtIngresos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIngresos.Name = "txtIngresos";
            this.txtIngresos.Size = new System.Drawing.Size(127, 28);
            this.txtIngresos.TabIndex = 5;
            this.txtIngresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIngresos_KeyPress);
            // 
            // txtInssL
            // 
            this.txtInssL.Location = new System.Drawing.Point(243, 184);
            this.txtInssL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInssL.Name = "txtInssL";
            this.txtInssL.Size = new System.Drawing.Size(127, 28);
            this.txtInssL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aplicaion para calcular el INSS laboral";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inss Patronal";
            // 
            // txtInssP
            // 
            this.txtInssP.Location = new System.Drawing.Point(243, 246);
            this.txtInssP.Name = "txtInssP";
            this.txtInssP.Size = new System.Drawing.Size(123, 28);
            this.txtInssP.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Deduccion";
            // 
            // cboTipD
            // 
            this.cboTipD.FormattingEnabled = true;
            this.cboTipD.Items.AddRange(new object[] {
            "Inss Laboral",
            "Inss Patronal"});
            this.cboTipD.Location = new System.Drawing.Point(243, 134);
            this.cboTipD.Name = "cboTipD";
            this.cboTipD.Size = new System.Drawing.Size(231, 31);
            this.cboTipD.TabIndex = 12;
            this.cboTipD.SelectedIndexChanged += new System.EventHandler(this.cboTipD_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(554, 478);
            this.Controls.Add(this.cboTipD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInssP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInssL);
            this.Controls.Add(this.txtIngresos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Subheading", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnlimpiar;
        private Button btnSalir;
        private TextBox txtIngresos;
        private TextBox txtInssL;
        private Label label3;
        private Label label4;
        private TextBox txtInssP;
        private Label label5;
        private ComboBox cboTipD;
    }
}