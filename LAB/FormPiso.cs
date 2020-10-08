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
    public partial class FormPiso : Form
    {
        public FormPiso()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //Nos da todo los datos en caso de comprar un mueble para piso.
        #region
        private void CargaDatosPiso_Click(object sender, EventArgs e)
        {
            string dirreccion = txtDirrecion.Text;
            string edificio = txtEdifcio.Text;
            string piso = txtPiso.Text; //realiza el cambio de string a int por la variable piso;
            int pisoconvert = Int16.Parse(piso);
            string valor = txtValor.Text;
            int valorconvert = Int32.Parse(valor); //realiza el cambio del valor monetario de string a int;
            string edadM = txtEdadMueble.Text;
            int edadconvert = Int16.Parse(edadM); //realiza el cambio de valor de los años del mueble de string a int;
            int aux;

            if(edadconvert < 15)
            {
                aux = 1 * valorconvert /100;
                valorconvert = valorconvert - aux;
            }

            if(edadconvert > 15)
            {
                aux = 2 * valorconvert / 100;
                valorconvert = valorconvert - aux;
            }

            if(pisoconvert > 3)
            {
                aux = 3 * valorconvert / 100;
                valorconvert +=  aux;
            }


            MessageBox.Show("Dirrecion: "+ dirreccion + "\nEdificio: "+ edificio + "\nPiso: "+ piso + "\nEl valor total del mueble  es: $" + valorconvert   , "DATOS DEL CLIENTE");
        }

        #endregion

    }
}
