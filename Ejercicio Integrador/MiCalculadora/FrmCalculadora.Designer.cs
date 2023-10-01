namespace MiCalculadora
{
    partial class FrmCalculadora
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
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblPrimerOperador = new System.Windows.Forms.Label();
            this.lblSegundoOperador = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.rdbDecimal = new System.Windows.Forms.RadioButton();
            this.rdbBinario = new System.Windows.Forms.RadioButton();
            this.txtPrimerOperador = new System.Windows.Forms.TextBox();
            this.txtSegundoOperador = new System.Windows.Forms.TextBox();
            this.grpSistema = new System.Windows.Forms.GroupBox();
            this.grpSistema.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOperar
            // 
            this.btnOperar.Location = new System.Drawing.Point(46, 381);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(168, 47);
            this.btnOperar.TabIndex = 4;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(220, 381);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(168, 47);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(394, 381);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(168, 47);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "/",
            "*"});
            this.cmbOperacion.Location = new System.Drawing.Point(241, 297);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(131, 23);
            this.cmbOperacion.TabIndex = 2;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(45, 71);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(167, 45);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblPrimerOperador
            // 
            this.lblPrimerOperador.AutoSize = true;
            this.lblPrimerOperador.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrimerOperador.Location = new System.Drawing.Point(46, 253);
            this.lblPrimerOperador.Name = "lblPrimerOperador";
            this.lblPrimerOperador.Size = new System.Drawing.Size(160, 28);
            this.lblPrimerOperador.TabIndex = 11;
            this.lblPrimerOperador.Text = "Primer operador:";
            // 
            // lblSegundoOperador
            // 
            this.lblSegundoOperador.AutoSize = true;
            this.lblSegundoOperador.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSegundoOperador.Location = new System.Drawing.Point(380, 253);
            this.lblSegundoOperador.Name = "lblSegundoOperador";
            this.lblSegundoOperador.Size = new System.Drawing.Size(182, 28);
            this.lblSegundoOperador.TabIndex = 13;
            this.lblSegundoOperador.Text = "Segundo operador:";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOperacion.Location = new System.Drawing.Point(252, 253);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(107, 28);
            this.lblOperacion.TabIndex = 12;
            this.lblOperacion.Text = "Operacion:";
            // 
            // rdbDecimal
            // 
            this.rdbDecimal.AutoSize = true;
            this.rdbDecimal.Checked = true;
            this.rdbDecimal.Location = new System.Drawing.Point(14, 22);
            this.rdbDecimal.Name = "rdbDecimal";
            this.rdbDecimal.Size = new System.Drawing.Size(68, 19);
            this.rdbDecimal.TabIndex = 7;
            this.rdbDecimal.TabStop = true;
            this.rdbDecimal.Text = "Decimal";
            this.rdbDecimal.UseVisualStyleBackColor = true;
            this.rdbDecimal.CheckedChanged += new System.EventHandler(this.rdbDecimal_CheckedChanged);
            // 
            // rdbBinario
            // 
            this.rdbBinario.AutoSize = true;
            this.rdbBinario.Location = new System.Drawing.Point(104, 22);
            this.rdbBinario.Name = "rdbBinario";
            this.rdbBinario.Size = new System.Drawing.Size(62, 19);
            this.rdbBinario.TabIndex = 8;
            this.rdbBinario.Text = "Binario";
            this.rdbBinario.UseVisualStyleBackColor = true;
            this.rdbBinario.CheckedChanged += new System.EventHandler(this.rdbBinario_CheckedChanged);
            // 
            // txtPrimerOperador
            // 
            this.txtPrimerOperador.Location = new System.Drawing.Point(55, 297);
            this.txtPrimerOperador.Name = "txtPrimerOperador";
            this.txtPrimerOperador.Size = new System.Drawing.Size(157, 23);
            this.txtPrimerOperador.TabIndex = 1;
            this.txtPrimerOperador.TextChanged += new System.EventHandler(this.txtPrimerOperador_TextChanged);
            // 
            // txtSegundoOperador
            // 
            this.txtSegundoOperador.Location = new System.Drawing.Point(394, 297);
            this.txtSegundoOperador.Name = "txtSegundoOperador";
            this.txtSegundoOperador.Size = new System.Drawing.Size(159, 23);
            this.txtSegundoOperador.TabIndex = 3;
            this.txtSegundoOperador.TextChanged += new System.EventHandler(this.txtSegundoOperador_TextChanged);
            // 
            // grpSistema
            // 
            this.grpSistema.Controls.Add(this.rdbBinario);
            this.grpSistema.Controls.Add(this.rdbDecimal);
            this.grpSistema.Location = new System.Drawing.Point(206, 152);
            this.grpSistema.Name = "grpSistema";
            this.grpSistema.Size = new System.Drawing.Size(182, 56);
            this.grpSistema.TabIndex = 10;
            this.grpSistema.TabStop = false;
            this.grpSistema.Text = "Representar resultado en:";
            // 
            // FrmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.grpSistema);
            this.Controls.Add(this.txtSegundoOperador);
            this.Controls.Add(this.txtPrimerOperador);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.lblSegundoOperador);
            this.Controls.Add(this.lblPrimerOperador);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbOperacion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Vallario Cores, Agustin ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCalculadora_FormClosing);
            this.Load += new System.EventHandler(this.FrmCalculadora_Load);
            this.grpSistema.ResumeLayout(false);
            this.grpSistema.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private ComboBox cmbOperacion;
        private Label lblResultado;
        private Label lblPrimerOperador;
        private Label lblSegundoOperador;
        private Label lblOperacion;
        private RadioButton rdbDecimal;
        private RadioButton rdbBinario;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private GroupBox grpSistema;
    }
}