namespace pryRepaso
{
    partial class Calculo
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
            lblMonto = new Label();
            lblIva = new Label();
            btnCalculo = new Button();
            txtMonto = new TextBox();
            cboIva = new ComboBox();
            SuspendLayout();
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(12, 12);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(43, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.Location = new Point(12, 53);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(24, 15);
            lblIva.TabIndex = 1;
            lblIva.Text = "IVA";
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(136, 109);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(75, 23);
            btnCalculo.TabIndex = 2;
            btnCalculo.Text = "Calculo";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(75, 9);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(100, 23);
            txtMonto.TabIndex = 3;
            txtMonto.TextChanged += txtMonto_TextChanged;
            // 
            // cboIva
            // 
            cboIva.FormattingEnabled = true;
            cboIva.Items.AddRange(new object[] { "10%", "21%" });
            cboIva.Location = new Point(75, 50);
            cboIva.Name = "cboIva";
            cboIva.Size = new Size(100, 23);
            cboIva.TabIndex = 4;
            // 
            // Calculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 253);
            Controls.Add(cboIva);
            Controls.Add(txtMonto);
            Controls.Add(btnCalculo);
            Controls.Add(lblIva);
            Controls.Add(lblMonto);
            Name = "Calculo";
            Text = "Calculo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMonto;
        private Label lblIva;
        private Button btnCalculo;
        private TextBox txtMonto;
        private ComboBox cboIva;
    }
}