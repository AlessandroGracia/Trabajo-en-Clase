using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_en_Clase
{
    public partial class frmSueldo : Form
    {
        public frmSueldo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //validaciones
            if(this.txtNombre.Text.Length==0)
            {
                MessageBox.Show("Por favor debes ingresar el nombre...");
                this.txtNombre.Focus();
                return;
            }
            //1.Validar el ingreso de todos los cuadros de texto
            //2.Validar que el dato ingresado sea numerico
            //no usar try..catch
            // presentar hasta miercoles 20hr
            //sumar los ingreso
            double horasTrab = double.Parse(this.txtHorasTrabajadas.Text);
            double valorHora = double.Parse(this.txtValorporHoras.Text);
            double bono = Double.Parse(this.txtBonoderesponsabilidad.Text);
            double totIng = horasTrab * valorHora + bono;
            //mostrar el total de ingreso en el cuadro de ingreso
            this.txtTotalIng.Text = totIng.ToString();
            //sumar los egresos
            double AsoTrab = double.Parse(this.txtAsoTrab.Text);
            double bar = double.Parse(this.txtBar.Text);
            double cuentaPagar = double.Parse(this.txtCuentaPagar.Text);
            double totEg = AsoTrab + bar + bono;
            this.txtEgreso.Text = totEg.ToString();
            Double LiquidoRecibir= totIng - totEg ;
            lblResultado.Text = "Estimado," + this.txtNombre.Text + ", tu sueldo es: " + LiquidoRecibir.ToString();


        
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar el programa
        }
    }
}
