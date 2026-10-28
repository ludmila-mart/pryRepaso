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
            // frmGrupo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 266);
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
    }
}