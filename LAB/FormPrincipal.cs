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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void bnPiso_Click(object sender, EventArgs e)
        {
            FormPiso formpiso = new FormPiso();
            formpiso.Show();
        }

        private void bnLocal_Click(object sender, EventArgs e)
        {
            FormLOCAL formlocal = new FormLOCAL();
            formlocal.Show();
        }
    }
}
