using Entidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Diagnostics;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private Numeracion primerOperador;
        private Numeracion segundoOperador;
        private Operacion calculadora;
        private bool cerrarFormulario = true;
        public FrmCalculadora()
        {
            InitializeComponent();

            primerOperador = new Numeracion("0", Numeracion.ESistema.Decimal);
            segundoOperador = new Numeracion("0", Numeracion.ESistema.Decimal);
            calculadora = new Operacion();
        }
        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            
        }
        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cerrarFormulario)
            {
                if (MessageBox.Show("¿Desea cerrar la calculadora?", "Confirmar cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true; // Cancela el cierre del formulario si el usuario selecciona "No".
                }
            }
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {
            setResultado();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            lblResultado.Text = "Resultado: ";
            rdbDecimal.Checked = true;
            cmbOperacion.SelectedIndex = 0;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            cerrarFormulario = true;
            this.Close(); // Cierra el formulario.
        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbOperacion.SelectedIndex > 0)
            {
                setResultado();
            } 
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbOperacion.SelectedIndex > 0)
            {
                setResultado();
            }
        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPrimerOperador.Text, out _) && !string.IsNullOrEmpty(txtPrimerOperador.Text))
            {
                MessageBox.Show("Asegurese que el Primer Operador es un numero.");
            }
        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtSegundoOperador.Text, out _) && !string.IsNullOrEmpty(txtSegundoOperador.Text))
            {
                MessageBox.Show("Asegurese que el Segundo Operador es un numero.");
            }
        }
        private void setResultado ()
        {
            if (cmbOperacion.SelectedIndex > 0 && decimal.TryParse(txtPrimerOperador.Text, out _) == true && decimal.TryParse(txtSegundoOperador.Text, out _) == true )
                {
                    Numeracion numero1 = new Numeracion(txtPrimerOperador.Text, Numeracion.ESistema.Decimal);
                    Numeracion numero2 = new Numeracion(txtSegundoOperador.Text, Numeracion.ESistema.Decimal);
                
                    Operacion operacion = new Operacion();
                    operacion.PrimerOperador = numero1;
                    operacion.SegundoOperador = numero2;

                    Numeracion resultado = operacion.Operar(cmbOperacion.SelectedItem.ToString()[0]);

                    if (rdbDecimal.Checked)
                    {
                        if(cmbOperacion.SelectedIndex == 3 && numero2.Valor == "0")
                        {
                            lblResultado.Text = "Resultado: Error.Division por 0.";
                        }
                        else
                        {
                            lblResultado.Text = "Resultado: " + resultado.ToString();
                        }
                    }
                    else if (rdbBinario.Checked)
                    {
                        Numeracion resultadoBinario = new Numeracion(resultado.ToString(), Numeracion.ESistema.Decimal);
                        lblResultado.Text = "Resultado: " + resultadoBinario.ConvertirA(Numeracion.ESistema.Binario);
                    }
                }
        }
    }
}