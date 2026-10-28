namespace pryRepaso
{
    partial class frmGrupo
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
            lblGrupo = new Label();
            cboGrupo = new ComboBox();
            lstResultado = new ListBox();
            btnSobre = new Button();
            lblGrup = new Label();
            lblDato = new Label();
            cboGrup = new ComboBox();
            txtDato = new TextBox();
            btnGrabar = new Button();
            SuspendLayout();
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(29, 20);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 0;
            lblGrupo.Text = "Grupo";
            lblGrupo.Click += label1_Click;
            // 
            // cboGrupo
            // 
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Items.AddRange(new object[] { "Plan A", "Plan B", "Plan C" });
            cboGrupo.Location = new Point(73, 17);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(86, 23);
            cboGrupo.TabIndex = 1;
            cboGrupo.SelectedIndexChanged += cboGrupo_SelectedIndexChanged;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(29, 61);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(130, 49);
            lstResultado.TabIndex = 2;
            // 
            // btnSobre
            // 
            btnSobre.Location = new Point(29, 116);
            btnSobre.Name = "btnSobre";
            btnSobre.Size = new Size(130, 23);
            btnSobre.TabIndex = 3;
            btnSobre.Text = "Sobreescribir";
            btnSobre.UseVisualStyleBackColor = true;
            // 
            // lblGrup
            // 
            lblGrup.AutoSize = true;
            lblGrup.Location = new Point(12, 156);
            lblGrup.Name = "lblGrup";
            lblGrup.Size = new Size(43, 15);
            lblGrup.TabIndex = 4;
            lblGrup.Text = "Grupo:";
            lblGrup.Click += label1_Click_1;
            // 
            // lblDato
            // 
            lblDato.AutoSize = true;
            lblDato.Location = new Point(20, 190);
            lblDato.Name = "lblDato";
            lblDato.Size = new Size(35, 15);
            lblDato.TabIndex = 5;
            lblDato.Text = "Dato:";
            // 
            // cboGrup
            // 
            cboGrup.FormattingEnabled = true;
            cboGrup.Location = new Point(61, 158);
            cboGrup.Name = "cboGrup";
            cboGrup.Size = new Size(121, 23);
            cboGrup.TabIndex = 6;
            cboGrup.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtDato
            // 
            txtDato.Location = new Point(61, 187);
            txtDato.Name = "txtDato";
            txtDato.Size = new Size(121, 23);
            txtDato.TabIndex = 7;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(51, 216);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // frmGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 266);
            Controls.Add(btnGrabar);
            Controls.Add(txtDato);
            Controls.Add(cboGrup);
            Controls.Add(lblDato);
            Controls.Add(lblGrup);
            Controls.Add(btnSobre);
            Controls.Add(lstResultado);
            Controls.Add(cboGrupo);
            Controls.Add(lblGrupo);
            Name = "frmGrupo";
            Text = "Grupo";
            Load += frmGrupo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrupo;
        private ComboBox cboGrupo;
        private ListBox lstResultado;
        private Button btnSobre;
        private Label lblGrup;
        private Label lblDato;
        private ComboBox cboGrup;
        private TextBox txtDato;
        private Button btnGrabar;
    }
}