using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc_polation_2022
{
    public partial class CALPO_Lineal : Form
    {
        private TextBox currentTxtBox;

        public CALPO_Lineal()
        {
            InitializeComponent();
        }

        private void CALPO_Lineal_Load(object sender, EventArgs e)
        {

        }

        // INICIO de controles y componentes.

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //float part1, part2, result;

            //part1 = (int.Parse(txt_y1.Text) - int.Parse(txt_y0.Text)) / (int.Parse(txt_x1.Text) - int.Parse(txt_x0.Text));
            //part2 = part1 * (int.Parse(txt_x.Text) - int.Parse(txt_x0.Text));

            //result = int.Parse(txt_x0.Text) + part2;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void txt_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        // FIN de controles y componentes.

        // INICIO de métodos.

        private void onlyNumbers(object senderTxtBox, KeyPressEventArgs e)
        {
            currentTxtBox = (TextBox)senderTxtBox;

            // Solo aceptar dígitos.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Para que acepte un solo punto decimal.
            if ((e.KeyChar == '.') && (currentTxtBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //private void ifNull(object senderTxtBox)
        //{
        //    currentTxtBox = (TextBox)senderTxtBox;

        //    if (currentTxtBox == null)
        //    {
                
        //    }
        //}

        private void reset()
        {
            txt_x.Text = "0";
            txt_x0.Text = "0";
            txt_x1.Text = "0";
            txt_y0.Text = "0";
            txt_y1.Text = "0";
        }
    }
}
