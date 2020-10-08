using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB
{
    public partial class FormLOCAL : Form
    {
        public FormLOCAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dirrecionLocal = txtDirrecionL.Text;
            string metrosCuadradosLocal = txtMetrosL.Text;
            string estadoMuebleL = txtEstadoML.Text;
            int auxl;

            //Las siguientes varriables fueron convertidas a entero para poder usar los bucles if;
            int metros_Local = Int16.Parse(metrosCuadradosLocal);
            string ventanasL = txtVentnasL.Text;
            int ventanas_Local = Int16.Parse(ventanasL);
            string valorMuebleL = txtValorL.Text;
            int valorMueble_Local = Int32.Parse(valorMuebleL);   
            string edadmuebleL = txtMuebleL.Text;
            int edadMueble_Local = Int16.Parse(edadmuebleL);

            #region
            //If para la edad del mueble;
            if (edadMueble_Local < 15)
            {
                auxl = 1 * valorMueble_Local / 100;
                valorMueble_Local = valorMueble_Local - auxl;
            }

            if (edadMueble_Local > 15)
            {
                auxl = 2 * valorMueble_Local / 100;
                valorMueble_Local = valorMueble_Local - auxl;
            }
           
            //if para calcular el valor que se agrega o decrementa por metros cuadrados del local.
            if(metros_Local > 50)
            {
                auxl = 1 * valorMueble_Local / 100;
                valorMueble_Local += auxl;
            }

            //Condicion ventana;
            if (ventanas_Local < 1)  //Si son menos de 2 ventanas se le descuenta un 2% 
            {
                auxl = 2 * valorMueble_Local / 100;
                valorMueble_Local -= auxl;
            }else if(ventanas_Local > 4){           //Si son mas de 4 ventanas se le incrementa un 2%

                auxl = 2 * valorMueble_Local / 100;
                valorMueble_Local += auxl;
            }

            MessageBox.Show("La dirrecion del local es: " + dirrecionLocal + "\nLos metros cuadrados del local: " + metros_Local + "\nVentanas del local: " + ventanas_Local + "\nEstado del mueble: " + estadoMuebleL + "\nEdad del mueble: " + edadmuebleL + "\nValor total del mueble: $" + valorMueble_Local);

            #endregion //Esta region contiene todas las operaciones segun las caracteristicas del mueble;

            

        }

        
    }
}
