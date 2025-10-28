namespace pyrLunaSP2BoletosFerrocarril
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblDistancia = new Label();
            txtDistancia = new TextBox();
            txtDias = new Label();
            nudDias = new NumericUpDown();
            btnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            SuspendLayout();
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Font = new Font("Segoe UI", 14.25F);
            lblDistancia.Location = new Point(22, 17);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(230, 25);
            lblDistancia.TabIndex = 0;
            lblDistancia.Text = "Distancia hasta su destino";
            // 
            // txtDistancia
            // 
            txtDistancia.Font = new Font("Segoe UI", 14.25F);
            txtDistancia.Location = new Point(258, 14);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(100, 33);
            txtDistancia.TabIndex = 1;
            txtDistancia.KeyPress += txtDistancia_KeyPress;
            // 
            // txtDias
            // 
            txtDias.AutoSize = true;
            txtDias.Font = new Font("Segoe UI", 14.25F);
            txtDias.Location = new Point(22, 55);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(148, 25);
            txtDias.TabIndex = 2;
            txtDias.Text = "Dias de estancia";
            // 
            // nudDias
            // 
            nudDias.Font = new Font("Segoe UI", 14.25F);
            nudDias.Location = new Point(258, 53);
            nudDias.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nudDias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(100, 33);
            nudDias.TabIndex = 3;
            nudDias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 14.25F);
            btnCalcular.Location = new Point(258, 92);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 33);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular precio";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 139);
            Controls.Add(btnCalcular);
            Controls.Add(nudDias);
            Controls.Add(txtDias);
            Controls.Add(txtDistancia);
            Controls.Add(lblDistancia);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Precios de los boletos de ferrocarril";
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDistancia;
        private TextBox txtDistancia;
        private Label txtDias;
        private NumericUpDown nudDias;
        private Button btnCalcular;
    }
}
