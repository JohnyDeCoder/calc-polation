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
    public partial class CALPO_Lagrange : Form
    {
        private TextBox currentTxtBox;
        public bool txtEmpty; // Variable utilizada para saber si hay algún TextBox vacio.
        public bool txtContains; // Variable utilizada para saber si hay algún TextBox únicamente con - o .
        public string mas = " + ";
        public string menos = " - ";
        public string entre = " ÷ ";
        public string igual = " = ";

        public CALPO_Lagrange()
        {
            InitializeComponent();
        }

        private void CALPO_Lagrange_Load(object sender, EventArgs e)
        {
            // Carga inicial del formulario.
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            ifTxtBoxEmpty(gb_values); // Determina si hay TextBox vacíos.
            ifTxtBoxContains(gb_values); // Determina si algunos de los TextBox tengan solamente - o punto.

            double part1_orden_1, part2_orden_1, result_orden_1, 
                part1_orden_2, part1_orden_2_div_1, part1_orden_2_div_2, 
                part2_orden_2, part2_orden_2_div_1, part2_orden_2_div_2,
                part3_orden_2, part3_orden_2_div_1, part3_orden_2_div_2,
                result_orden_2, 
                percent1, percent2, result_percent; // Variables.

            if (txtEmpty == true || txtContains == true) // Si hay algún TextBox vacío o únicamenmte con - o punto.
            {
                MessageBox.Show(
                    "No se admiten campos vacíos o sin dígitos, por favor rellene los campos faltantes con valores válidos para calcular.",
                    "Advertencia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );

                txtEmpty = false; // Se reinicia la variable si ya se había encontrado un TextBox vacío.
                txtContains = false; // Se reinicia la variable si ya se había encontrado un TextBox con - o punto.
            }
            else
            {
                if (rb_orden_1.Checked == true)
                {
                    txt_x2.Enabled = false;
                    txt_x2.Text = "0";
                    txt_y2.Enabled  = false;
                    txt_y2.Text = "0";

                    if (cb_calculate_percent.Checked == true) // ---- CheckBox.Checked = True ----
                    {
                        if (rb_noRedondeo.Checked == true)
                        {
                            try
                            {
                                // Operaciones.
                                percent1 = double.Parse(txt_x.Text) - double.Parse(txt_fx.Text);
                                percent2 = percent1 / double.Parse(txt_x.Text);
                                result_percent = percent2 * 100;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_percent.ToString() == "NaN") // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DEL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("Et = " + result_percent);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("FÓRMULA PARA CALCULAR EL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Ev = valor verdadero - valor aproximado");
                                lbox_results.Items.Add("• Et = Ev / valor verdadero * 100%");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se obtiene el valor del error verdadero (Ev).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text + igual + percent1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "• Paso final: Se obtiene el error relativo porcentual dividiendo el error verdadero entre el valor verdadero y multiplicandolo por 100."
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + "* 100%" + igual + result_percent);
                            }
                        }
                        else if (rb_redondeo.Checked == true)
                        {
                            try
                            {
                                // Operaciones.
                                percent1 = double.Parse(txt_x.Text) - double.Parse(txt_fx.Text);
                                percent2 = percent1 / double.Parse(txt_x.Text);
                                result_percent = percent2 * 100;
                                result_percent = Math.Round(result_percent);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_percent.ToString() == "NaN") // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DEL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("Et = " + result_percent);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("FÓRMULA PARA CALCULAR EL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Ev = valor verdadero - valor aproximado");
                                lbox_results.Items.Add("• Et = Ev / valor verdadero * 100%");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se obtiene el valor del error verdadero (Ev).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text + igual + percent1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "• Paso final: Se obtiene el error relativo porcentual dividiendo el error verdadero entre el valor verdadero y multiplicandolo por 100."
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + "* 100%" + igual + result_percent);
                            }
                        }
                        else // Últimos 4 decimales.
                        {
                            try
                            {
                                // Operaciones.
                                percent1 = double.Parse(txt_x.Text) - double.Parse(txt_fx.Text);
                                percent2 = percent1 / double.Parse(txt_x.Text);
                                result_percent = percent2 * 100;
                                result_percent = Math.Round(result_percent, 4);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_percent.ToString() == "NaN") // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else // Últimos 4 decimales.
                            {
                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DEL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("Et = " + result_percent);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("FÓRMULA PARA CALCULAR EL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Ev = valor verdadero - valor aproximado");
                                lbox_results.Items.Add("• Et = Ev / valor verdadero * 100%");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se obtiene el valor del error verdadero (Ev).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text + igual + percent1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "• Paso final: Se obtiene el error relativo porcentual dividiendo el error verdadero entre el valor verdadero y multiplicandolo por 100."
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + "* 100%" + igual + result_percent);
                            }
                        }
                    }
                    else // ---- CheckBox.Checked = False ----
                    {
                        if (rb_noRedondeo.Checked == true)
                        {
                            try
                            {
                                // Operaciones.
                                part1_orden_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text)) / (double.Parse(txt_x0.Text) - double.Parse(txt_x1.Text));
                                part1_orden_1 = part1_orden_1 * double.Parse(txt_y0.Text);

                                part2_orden_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) / (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text));
                                part2_orden_1 = part2_orden_1 * double.Parse(txt_y1.Text);

                                result_orden_1 = part1_orden_1 + part2_orden_1;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_orden_1.ToString() == "NaN" || result_orden_1.ToString().Contains('∞')) // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                txt_fx.Text = result_orden_1.ToString();

                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN DE LAGRANGE 1ER ORDEN");
                                lbox_results.Items.Add("f₁(x) = " + result_orden_1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                templateLagrange1();
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + ") " +
                                    txt_y0.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + ")" +
                                    txt_y1.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se resuelve la primera parte y se multiplica por f(x₀).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + ") " +
                                    txt_y0.Text + igual + part1_orden_1
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Tercer paso: Se resuelve la segunda parte y se multiplica por f(x₁).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" +txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + ") " +
                                    txt_y1.Text + igual + part2_orden_1
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando la primera parte más la segunda.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + part1_orden_1 + mas + part2_orden_1 + igual + result_orden_1
                                    );
                            }
                        }
                        else if (rb_redondeo.Checked == true)
                        {
                            try
                            {
                                // Operaciones.
                                part1_orden_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text)) / (double.Parse(txt_x0.Text) - double.Parse(txt_x1.Text));
                                part1_orden_1 = part1_orden_1 * double.Parse(txt_y0.Text);

                                part2_orden_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) / (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text));
                                part2_orden_1 = part2_orden_1 * double.Parse(txt_y1.Text);

                                result_orden_1 = part1_orden_1 + part2_orden_1;
                                result_orden_1 = Math.Round(result_orden_1);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_orden_1.ToString() == "NaN" || result_orden_1.ToString().Contains('∞')) // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                txt_fx.Text = result_orden_1.ToString();

                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN DE LAGRANGE 1ER ORDEN");
                                lbox_results.Items.Add("f₁(x) = " + result_orden_1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                templateLagrange1();
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + ") " +
                                    txt_y0.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + ")" +
                                    txt_y1.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se resuelve la primera parte y se multiplica por f(x₀).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + ") " +
                                    txt_y0.Text + igual + part1_orden_1
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Tercer paso: Se resuelve la segunda parte y se multiplica por f(x₁).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + ") " +
                                    txt_y1.Text + igual + part2_orden_1
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando la primera parte más la segunda.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + part1_orden_1 + mas + part2_orden_1 + igual + result_orden_1
                                    );
                            }
                        }
                        else // Últimos 4 decimales.
                        {
                            try
                            {
                                // Operaciones.
                                part1_orden_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text)) / (double.Parse(txt_x0.Text) - double.Parse(txt_x1.Text));
                                part1_orden_1 = part1_orden_1 * double.Parse(txt_y0.Text);

                                part2_orden_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) / (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text));
                                part2_orden_1 = part2_orden_1 * double.Parse(txt_y1.Text);

                                result_orden_1 = part1_orden_1 + part2_orden_1;
                                result_orden_1 = Math.Round(result_orden_1, 4);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_orden_1.ToString() == "NaN" || result_orden_1.ToString().Contains('∞')) // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                txt_fx.Text = result_orden_1.ToString();

                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN DE LAGRANGE 1ER ORDEN");
                                lbox_results.Items.Add("f₁(x) = " + result_orden_1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                templateLagrange1();
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + ") " +
                                    txt_y0.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + ")" +
                                    txt_y1.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se resuelve la primera parte y se multiplica por f(x₀).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + ") " +
                                    txt_y0.Text + igual + part1_orden_1
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Tercer paso: Se resuelve la segunda parte y se multiplica por f(x₁).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + ") " +
                                    txt_y1.Text + igual + part2_orden_1
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando la primera parte más la segunda.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₁(x)" + igual + part1_orden_1 + mas + part2_orden_1 + igual + result_orden_1
                                    );
                            }
                        }
                    }
                }
                else // If rb_orden_2.Checked == true
                {
                    txt_x2.Enabled = true;
                    txt_y2.Enabled = true;

                    if (cb_calculate_percent.Checked == true) // ---- CheckBox.Checked = True ----
                    {
                        if (rb_noRedondeo.Checked == true)
                        {
                            try
                            {
                                // Operaciones.
                                percent1 = double.Parse(txt_x.Text) - double.Parse(txt_fx.Text);
                                percent2 = percent1 / double.Parse(txt_x.Text);
                                result_percent = percent2 * 100;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_percent.ToString() == "NaN") // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DEL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("Et = " + result_percent);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("FÓRMULA PARA CALCULAR EL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Ev = valor verdadero - valor aproximado");
                                lbox_results.Items.Add("• Et = Ev / valor verdadero * 100%");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se obtiene el valor del error verdadero (Ev).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text + igual + percent1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "• Paso final: Se obtiene el error relativo porcentual dividiendo el error verdadero entre el valor verdadero y multiplicandolo por 100."
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + "* 100%" + igual + result_percent);
                            }
                        }
                        else if (rb_redondeo.Checked == true)
                        {
                            try
                            {
                                // Operaciones.
                                percent1 = double.Parse(txt_x.Text) - double.Parse(txt_fx.Text);
                                percent2 = percent1 / double.Parse(txt_x.Text);
                                result_percent = percent2 * 100;
                                result_percent = Math.Round(result_percent);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_percent.ToString() == "NaN") // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DEL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("Et = " + result_percent);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("FÓRMULA PARA CALCULAR EL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Ev = valor verdadero - valor aproximado");
                                lbox_results.Items.Add("• Et = Ev / valor verdadero * 100%");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se obtiene el valor del error verdadero (Ev).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text + igual + percent1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "• Paso final: Se obtiene el error relativo porcentual dividiendo el error verdadero entre el valor verdadero y multiplicandolo por 100."
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + "* 100%" + igual + result_percent);
                            }
                        }
                        else // Últimos 4 decimales.
                        {
                            try
                            {
                                // Operaciones.
                                percent1 = double.Parse(txt_x.Text) - double.Parse(txt_fx.Text);
                                percent2 = percent1 / double.Parse(txt_x.Text);
                                result_percent = percent2 * 100;
                                result_percent = Math.Round(result_percent, 4);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_percent.ToString() == "NaN") // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else // Últimos 4 decimales.
                            {
                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DEL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("Et = " + result_percent);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("FÓRMULA PARA CALCULAR EL ERROR RELATIVO PORCENTUAL");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Ev = valor verdadero - valor aproximado");
                                lbox_results.Items.Add("• Et = Ev / valor verdadero * 100%");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se obtiene el valor del error verdadero (Ev).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Ev" + igual + txt_x.Text + menos + txt_fx.Text + igual + percent1);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "• Paso final: Se obtiene el error relativo porcentual dividiendo el error verdadero entre el valor verdadero y multiplicandolo por 100."
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + "* 100%" + igual + result_percent);
                            }
                        }
                    }
                    else // ---- CheckBox.Checked = False ----
                    {
                        if (rb_noRedondeo.Checked == true)
                        {
                            try
                            {
                                // Operaciones.
                                part1_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x2.Text));
                                part1_orden_2_div_2 = (double.Parse(txt_x0.Text) - double.Parse(txt_x1.Text)) * (double.Parse(txt_x0.Text) - double.Parse(txt_x2.Text));
                                part1_orden_2 = part1_orden_2_div_1 / part1_orden_2_div_2;
                                part1_orden_2 *= double.Parse(txt_y0.Text);

                                part2_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x2.Text));
                                part2_orden_2_div_2 = (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x1.Text) - double.Parse(txt_x2.Text));
                                part2_orden_2 = part2_orden_2_div_1 / part2_orden_2_div_2;
                                part2_orden_2 *= double.Parse(txt_y1.Text);

                                part3_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text));
                                part3_orden_2_div_2 = (double.Parse(txt_x2.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x2.Text) - double.Parse(txt_x1.Text));
                                part3_orden_2 = part3_orden_2_div_1 / part3_orden_2_div_2;
                                part3_orden_2 *= double.Parse(txt_y2.Text);

                                result_orden_2 = part1_orden_2 + part2_orden_2 + part3_orden_2;
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_orden_2.ToString() == "NaN" || result_orden_2.ToString().Contains('∞')) // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                txt_fx.Text = result_orden_2.ToString();

                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN DE LAGRANGE 2DA ORDEN");
                                lbox_results.Items.Add("f₂(x) = " + result_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                templateLagrange2();
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x2.Text + entre + txt_x0.Text + menos + txt_x2.Text + ")");
                                lbox_results.Items.Add(
                                    txt_y0.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x2.Text + entre + txt_x1.Text + menos + txt_x2.Text + ")");
                                lbox_results.Items.Add(
                                    txt_y1.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x2.Text + menos + txt_x0.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x1.Text + entre + txt_x2.Text + menos + txt_x1.Text + ") ");
                                lbox_results.Items.Add(txt_y2.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se resuelve la primera parte y se multiplica por f(x₀).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x2.Text + entre + txt_x0.Text + menos + txt_x2.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y0.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part1_orden_2_div_1 + entre + part1_orden_2_div_2 + ") " + txt_y0.Text + igual + part1_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Tercer paso: Se resuelve la segunda parte y se multiplica por f(x₁).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x2.Text + entre + txt_x1.Text + menos + txt_x2.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y1.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part2_orden_2_div_1 + entre + part2_orden_2_div_2 + ") " + txt_y1.Text + igual + part2_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Cuarto paso: Se resuelve la tercera parte y se multiplica por f(x₂).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x2.Text + menos + txt_x0.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x1.Text + entre + txt_x2.Text + menos + txt_x1.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y2.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part3_orden_2_div_1 + entre + part3_orden_2_div_2 + ") " + txt_y2.Text + igual + part3_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando las 3 partes.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + part1_orden_2 + mas + part2_orden_2 + mas + part3_orden_2 + igual + result_orden_2);
                            }
                        }
                        else if (rb_redondeo.Checked == true)
                        {
                            try
                            {
                                // Operaciones.
                                part1_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x2.Text));
                                part1_orden_2_div_2 = (double.Parse(txt_x0.Text) - double.Parse(txt_x1.Text)) * (double.Parse(txt_x0.Text) - double.Parse(txt_x2.Text));
                                part1_orden_2 = part1_orden_2_div_1 / part1_orden_2_div_2;
                                part1_orden_2 *= double.Parse(txt_y0.Text);

                                part2_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x2.Text));
                                part2_orden_2_div_2 = (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x1.Text) - double.Parse(txt_x2.Text));
                                part2_orden_2 = part2_orden_2_div_1 / part2_orden_2_div_2;
                                part2_orden_2 *= double.Parse(txt_y1.Text);

                                part3_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text));
                                part3_orden_2_div_2 = (double.Parse(txt_x2.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x2.Text) - double.Parse(txt_x1.Text));
                                part3_orden_2 = part3_orden_2_div_1 / part3_orden_2_div_2;
                                part3_orden_2 *= double.Parse(txt_y2.Text);

                                result_orden_2 = part1_orden_2 + part2_orden_2 + part3_orden_2;
                                result_orden_2 = Math.Round(result_orden_2);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_orden_2.ToString() == "NaN" || result_orden_2.ToString().Contains('∞')) // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                txt_fx.Text = result_orden_2.ToString();

                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN DE LAGRANGE 2DA ORDEN");
                                lbox_results.Items.Add("f₂(x) = " + result_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                templateLagrange2();
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x2.Text + entre + txt_x0.Text + menos + txt_x2.Text + ")");
                                lbox_results.Items.Add(
                                    txt_y0.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x2.Text + entre + txt_x1.Text + menos + txt_x2.Text + ")");
                                lbox_results.Items.Add(
                                    txt_y1.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x2.Text + menos + txt_x0.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x1.Text + entre + txt_x2.Text + menos + txt_x1.Text + ") ");
                                lbox_results.Items.Add(txt_y2.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se resuelve la primera parte y se multiplica por f(x₀).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x2.Text + entre + txt_x0.Text + menos + txt_x2.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y0.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part1_orden_2_div_1 + entre + part1_orden_2_div_2 + ") " + txt_y0.Text + igual + part1_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Tercer paso: Se resuelve la segunda parte y se multiplica por f(x₁).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x2.Text + entre + txt_x1.Text + menos + txt_x2.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y1.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part2_orden_2_div_1 + entre + part2_orden_2_div_2 + ") " + txt_y1.Text + igual + part2_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Cuarto paso: Se resuelve la tercera parte y se multiplica por f(x₂).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x2.Text + menos + txt_x0.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x1.Text + entre + txt_x2.Text + menos + txt_x1.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y2.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part3_orden_2_div_1 + entre + part3_orden_2_div_2 + ") " + txt_y2.Text + igual + part3_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando las 3 partes.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + part1_orden_2 + mas + part2_orden_2 + mas + part3_orden_2 + igual + result_orden_2);
                            }
                        }
                        else // Últimos 4 decimales.
                        {
                            try
                            {
                                // Operaciones.
                                part1_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x2.Text));
                                part1_orden_2_div_2 = (double.Parse(txt_x0.Text) - double.Parse(txt_x1.Text)) * (double.Parse(txt_x0.Text) - double.Parse(txt_x2.Text));
                                part1_orden_2 = part1_orden_2_div_1 / part1_orden_2_div_2;
                                part1_orden_2 *= double.Parse(txt_y0.Text);

                                part2_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x2.Text));
                                part2_orden_2_div_2 = (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x1.Text) - double.Parse(txt_x2.Text));
                                part2_orden_2 = part2_orden_2_div_1 / part2_orden_2_div_2;
                                part2_orden_2 *= double.Parse(txt_y1.Text);

                                part3_orden_2_div_1 = (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text));
                                part3_orden_2_div_2 = (double.Parse(txt_x2.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x2.Text) - double.Parse(txt_x1.Text));
                                part3_orden_2 = part3_orden_2_div_1 / part3_orden_2_div_2;
                                part3_orden_2 *= double.Parse(txt_y2.Text);

                                result_orden_2 = part1_orden_2 + part2_orden_2 + part3_orden_2;
                                result_orden_2 = Math.Round(result_orden_2, 4);
                            }
                            catch (Exception)
                            {
                                MessageBox.Show(
                                "Se ha detectado un error mientras se realizaba su operación, por favor asegúrese de introducir datos correctos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );

                                Application.Restart(); // Reiniciar la aplicación automáticamente.
                                throw;
                            }

                            if (result_orden_2.ToString() == "NaN" || result_orden_2.ToString().Contains('∞')) // Si hay algún error matemático.
                            {
                                MessageBox.Show(
                                "No se puede dividir un número entre 0.",
                                "Math ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            }
                            else
                            {
                                txt_fx.Text = result_orden_2.ToString();

                                lbox_results.Items.Clear(); // Reseteo del listBox.

                                // Impresión de valores.
                                lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN DE LAGRANGE 2DA ORDEN");
                                lbox_results.Items.Add("f₂(x) = " + result_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                templateLagrange2();
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("─────────────────────────────────");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Primer paso: Se remplazan los valores de acuerdo a la fórmula.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x2.Text + entre + txt_x0.Text + menos + txt_x2.Text + ")");
                                lbox_results.Items.Add(
                                    txt_y0.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x2.Text + entre + txt_x1.Text + menos + txt_x2.Text + ")");
                                lbox_results.Items.Add(
                                    txt_y1.Text + mas + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x2.Text + menos + txt_x0.Text + " * "
                                    );
                                lbox_results.Items.Add(txt_x.Text + menos + txt_x1.Text + entre + txt_x2.Text + menos + txt_x1.Text + ") ");
                                lbox_results.Items.Add(txt_y2.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Segundo paso: Se resuelve la primera parte y se multiplica por f(x₀).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x1.Text + entre + txt_x0.Text + menos + txt_x1.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x2.Text + entre + txt_x0.Text + menos + txt_x2.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y0.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part1_orden_2_div_1 + entre + part1_orden_2_div_2 + ") " + txt_y0.Text + igual + part1_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Tercer paso: Se resuelve la segunda parte y se multiplica por f(x₁).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x1.Text + menos + txt_x0.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x2.Text + entre + txt_x1.Text + menos + txt_x2.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y1.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part2_orden_2_div_1 + entre + part2_orden_2_div_2 + ") " + txt_y1.Text + igual + part2_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Cuarto paso: Se resuelve la tercera parte y se multiplica por f(x₂).");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add(
                                    "f₂(x)" + igual + "(" + txt_x.Text + menos + txt_x0.Text + entre + txt_x2.Text + menos + txt_x0.Text
                                    );
                                lbox_results.Items.Add(" * " + txt_x.Text + menos + txt_x1.Text + entre + txt_x2.Text + menos + txt_x1.Text + ") ");
                                lbox_results.Items.Add(
                                    txt_y2.Text
                                    );
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + "(" + part3_orden_2_div_1 + entre + part3_orden_2_div_2 + ") " + txt_y2.Text + igual + part3_orden_2);
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando las 3 partes.");
                                lbox_results.Items.Add("");
                                lbox_results.Items.Add("f₂(x)" + igual + part1_orden_2 + mas + part2_orden_2 + mas + part3_orden_2 + igual + result_orden_2);
                            }
                        }
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void cb_calculate_percent_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_orden_1.Enabled == false && rb_orden_2.Enabled == false)
            {
                rb_orden_1.Enabled = true;
                rb_orden_2.Enabled = true;
            }
            else
            {
                rb_orden_1.Enabled = false;
                rb_orden_2.Enabled = false;
            }

            if (cb_calculate_percent.Checked == true)
            {
                ifTxtBoxEmpty(gb_values); // Determina si hay TextBox vacíos.
                lbox_results.Items.Clear(); // Reseteo del listBox.

                templateETP();

                txt_x0.Enabled = false;
                txt_x1.Enabled = false;
                txt_x2.Enabled = false;
                txt_y0.Enabled = false;
                txt_y1.Enabled = false;
                txt_y2.Enabled = false;

                txt_x0.Text = "0";
                txt_x1.Text = "0";
                txt_x2.Text = "0";
                txt_y0.Text = "0";
                txt_y1.Text = "0";
                txt_y2.Text = "0";

                txt_fx.Enabled = true;
            }
            else if (rb_orden_1.Checked == true)
            {
                lbox_results.Items.Clear(); // Reseteo del listBox.

                templateLagrange1();

                txt_x0.Enabled = true;
                txt_x1.Enabled = true;
                txt_x2.Enabled = false;
                txt_y0.Enabled = true;
                txt_y1.Enabled = true;
                txt_y2.Enabled = false;

                txt_fx.Enabled = false;
                if (txt_fx.Text == string.Empty)
                {
                    txt_fx.Text = "0";
                }

                if (txt_x2.Text == string.Empty)
                {
                    txt_x2.Text = "0";
                }
                else // Sí, y2 o f(x2) vacío
                {
                    txt_y2.Text = "0";
                }
            }
            else
            {
                lbox_results.Items.Clear(); // Reseteo del listBox.

                templateLagrange2();

                txt_x0.Enabled = true;
                txt_x1.Enabled = true;
                txt_x2.Enabled = true;
                txt_y0.Enabled = true;
                txt_y1.Enabled = true;
                txt_y2.Enabled = true;

                txt_fx.Enabled = false;
                if (txt_fx.Text == string.Empty)
                {
                    txt_fx.Text = "0";
                }
            }
        }

        private void rb_orden_1_CheckedChanged(object sender, EventArgs e)
        {
            lbox_results.Items.Clear(); // Reseteo del listBox.
            templateLagrange1();

            txt_x2.Enabled = false;
            txt_y2.Enabled = false;
            if (txt_x2.Text == string.Empty && txt_y2.Text == string.Empty)
            {
                txt_x2.Text = "0";
                txt_y2.Text = "0";
            }
            else 
            {
                if (txt_x2.Text == string.Empty)
                {
                    txt_x2.Text = "0";
                }

                if (txt_y2.Text == string.Empty)
                {
                    txt_y2.Text = "0";
                }
            }
        }

        private void rb_orden_2_CheckedChanged(object sender, EventArgs e)
        {
            lbox_results.Items.Clear(); // Reseteo del listBox.
            templateLagrange2();

            txt_x2.Enabled = true;
            txt_y2.Enabled = true;
        }

        private void txt_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            // X
            onlyNumbers(sender, e);
        }

        private void txt_fx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // F(X) o Y
            onlyNumbers(sender, e);
        }

        private void txt_x0_KeyPress(object sender, KeyPressEventArgs e)
        {
            // X0
            onlyNumbers(sender, e);
        }

        private void txt_y0_KeyPress(object sender, KeyPressEventArgs e)
        {
            // f(X0) o y0
            onlyNumbers(sender, e);
        }

        private void txt_x1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // X1
            onlyNumbers(sender, e);
        }

        private void txt_y1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // f(X1) o y1
            onlyNumbers(sender, e);
        }

        private void txt_x2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // X2
            onlyNumbers(sender, e);
        }

        private void txt_y2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // f(X2) o y2
            onlyNumbers(sender, e);
        }

        // FIN de controles y componentes.

        // INICIO de métodos.

        private void onlyNumbers(object senderTxtBox, KeyPressEventArgs e)
        {
            currentTxtBox = (TextBox)senderTxtBox;

            // Solo aceptar dígitos, punto decimal y guión de resta.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

            // Para que acepte un solo punto decimal.
            if ((e.KeyChar == '.') && (currentTxtBox.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            // Para que acepte un solo punto guión de resta.
            if ((e.KeyChar == '-') && (currentTxtBox.Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }


        private void ifTxtBoxEmpty(Control CALPO_Lineal)
        {
            // Busca cada TextBox dentro del formulario - (Control.groupBox o Form Formulario (parámetro)).
            foreach (Control oControls in CALPO_Lineal.Controls)
            {
                // Si encuentra un TextBox vacío.
                if (oControls is TextBox & oControls.Text == string.Empty)
                {
                    txtEmpty = true;
                }
            }
        }

        private void ifTxtBoxContains(Control CALPO_Lineal)
        {
            // Busca cada TextBox dentro del formulario.
            foreach (Control oControls in CALPO_Lineal.Controls)
            {
                // Si encuentra un TextBox con únicamente un - o punto o ambos juntos.
                if (oControls is TextBox & oControls.Text == "-" || oControls.Text == "." ||
                    oControls.Text.Contains("-.") || oControls.Text.Contains(".-"))
                {
                    txtContains = true;
                }
            }
        }

        private void reset()
        {
            lbox_results.Items.Clear(); // Reseteo del listBox.

            if (cb_calculate_percent.Checked == true)
            {
                templateETP();
            }
            else if (rb_orden_1.Checked == true)
            {
                templateLagrange1();
            }
            else
            {
                templateLagrange2();
            }

            // Restablece por default cada campo.
            txt_x.Text = "0";
            txt_x0.Text = "0";
            txt_x1.Text = "0";
            txt_x2.Text = "0";
            txt_y0.Text = "0";
            txt_y1.Text = "0";
            txt_y2.Text = "0";
            txt_fx.Text = "0";
        }

        private void templateLagrange1()
        {
            lbox_results.Items.Add("FÓRMULA DE LA INTERPOLACIÓN DE LAGRANGE 1ER ORDEN");
            lbox_results.Items.Add("");
            lbox_results.Items.Add("• f₁(x) = (x - x₁ ÷ x₀ - x₁) f(x₀) + (x - x₀ ÷ x₁ - x₀) f(x₁)");
        }

        private void templateLagrange2()
        {
            lbox_results.Items.Add("FÓRMULA DE LA INTERPOLACIÓN DE LAGRANGE 2DA ORDEN");
            lbox_results.Items.Add("");
            lbox_results.Items.Add("• f₂(x) = (x - x₁ ÷ x₀ - x₁ * x - x₂ ÷ x₀ - x₂) f(x₀) +");
            lbox_results.Items.Add("  (x - x₀ ÷ x₁ - x₀ * x - x₂ ÷ x₁ - x₂) f(x₁) +");
            lbox_results.Items.Add("  (x - x₀ ÷ x₂ - x₀ * x - x₁ ÷ x₂ - x₁) f(x₂)");
        }

        private void templateETP()
        {
            lbox_results.Items.Add("FÓRMULA PARA CALCULAR EL ERROR RELATIVO PORCENTUAL");
            lbox_results.Items.Add("");
            lbox_results.Items.Add("• Ev = valor verdadero - valor aproximado");
            lbox_results.Items.Add("• Et = Ev / valor verdadero * 100%");
        }
    }
}
