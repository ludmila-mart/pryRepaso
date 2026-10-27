namespace pryRepaso
{
    partial class frmCargadedatos
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
            txtCodigo = new TextBox();
            btnRegistrar = new Button();
            lblCodigo = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(96, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextChanged += textBox1_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(197, 162);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 27);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(12, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            lblNombre.Click += lblNombre_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(96, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += textBox1_TextChanged_1;
            // 
            // frmCargadedatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblCodigo);
            Controls.Add(btnRegistrar);
            Controls.Add(txtCodigo);
            Name = "frmCargadedatos";
            Text = "Carga de datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private Button btnRegistrar;
        private Label lblCodigo;
        private Label lblNombre;
        private TextBox txtNombre;
    }
}
