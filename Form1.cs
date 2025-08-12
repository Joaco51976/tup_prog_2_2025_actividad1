using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer1___Act1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDescribir_Click(object sender, EventArgs e)
        {
            Ortoedro objeto3 = new Ortoedro(7, 7, 21);

            tbDescripcion.Text = $@"[
            {objeto3.Describir()}
            ]";
        }
    }
}
