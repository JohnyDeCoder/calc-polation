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
    public partial class CALPO_Cuadratica : Form
    {
        private TextBox currentTxtBox;
        public bool txtEmpty; // Variable utilizada para saber si hay algún TextBox vacio.
        public bool txtContains; // Variable utilizada para saber si hay algún TextBox únicamente con - o .
        public string mas = " + ";
        public string menos = " - ";
        public string entre = " ÷ ";
        public string igual = " = ";

#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public CALPO_Cuadratica()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            InitializeComponent();
        }

        private void CALPO_Cuadratica_Load(object sender, EventArgs e)
        {

        }

        // INICIO de controles y componentes.

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            ifTxtBoxEmpty(gb_values); // Determina si hay TextBox vacíos.
            ifTxtBoxContains(gb_values); // Determina si algunos de los TextBox tengan solamente - o punto.

            double part1, part2, part3, result, b0, b1, b2, percent1, percent2, result_percent; // Variables.

            if (cb_calculate_percent.Checked == true) // ---- CheckBox.Checked = True ----
            {
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

                        if (result_percent.ToString() == "NaN" || result_percent.ToString().Contains('∞')) // Si hay algún error matemático.
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
                            templateETP(); // Plantilla error relativo porcentual.
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
                                "• Paso final: Se obtiene el error relativo porcentual dividiendo el ERROR verdadero " +
                                "entre el VALOR verdadero y se multiplica por el 100%."
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + " * 100%" + igual + result_percent);
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

                        if (result_percent.ToString() == "NaN" || result_percent.ToString().Contains('∞')) // Si hay algún error matemático.
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
                            templateETP(); // Plantilla error relativo porcentual.
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
                                "• Paso final: Se obtiene el error relativo porcentual dividiendo el ERROR verdadero " +
                                "entre el VALOR verdadero y se multiplica por el 100%."
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + " * 100%" + igual + result_percent);
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

                        if (result_percent.ToString() == "NaN" || result_percent.ToString().Contains('∞')) // Si hay algún error matemático.
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
                            templateETP(); // Plantilla error relativo porcentual.
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
                                "• Paso final: Se obtiene el error relativo porcentual dividiendo el ERROR verdadero " +
                                "entre el VALOR verdadero y se multiplica por el 100%."
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("Et" + igual + percent1 + entre + txt_x.Text + " * 100%" + igual + result_percent);
                        }
                    }
                }
            }
            else
            {
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
                else // ---- CheckBox.Checked = False ----
                {
                    if (rb_noRedondeo.Checked == true)
                    {
                        try
                        {
                            // Operaciones.
                            b0 = double.Parse(txt_y0.Text);
                            b1 = (double.Parse(txt_y1.Text) - b0) / (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text));
                            b2 = (((double.Parse(txt_y2.Text) - double.Parse(txt_y1.Text)) / (double.Parse(txt_x2.Text) -
                                double.Parse(txt_x1.Text))) - (double.Parse(txt_y1.Text) - b0) / (double.Parse(txt_x1.Text) -
                                double.Parse(txt_x0.Text))) / (double.Parse(txt_x2.Text) - double.Parse(txt_x0.Text));


                            part1 = b2 * (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text));
                            part2 = b1 * (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text));
                            part3 = part2 + part1;
                            result = b0 + part3;
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

                        if (result.ToString() == "NaN" || result.ToString().Contains('∞')) // Si hay algún error matemático.
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
                            txt_fx.Text = result.ToString();

                            lbox_results.Items.Clear(); // Reseteo del listBox.

                            // Impresión de valores.
                            lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN CUADRÁTICA");
                            lbox_results.Items.Add("f(x) = " + result);
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("─────────────────────────────────");
                            lbox_results.Items.Add("");
                            templateCuadratica(); // Plantilla fórmula de interpolación lineal.
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("─────────────────────────────────");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Primer paso: Se remplazan los valores en b₀, b₁ y b₂");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "b₀" + igual + b0
                                );
                            lbox_results.Items.Add(
                                "b₁" + igual + "(" + txt_y1.Text + menos + b0 + ")" + entre + "(" + txt_x1.Text + menos + txt_x0.Text + ")"
                                );
                            lbox_results.Items.Add(
                                "b₂" + igual + "(" + txt_y2.Text + menos + txt_y1.Text + ")" + entre + "(" + txt_x2.Text + menos +
                                txt_x1.Text + ")" + menos + "(" + txt_y1.Text + menos + b0 + ")" + entre + "(" + txt_x1.Text + menos +
                                txt_x0.Text + ")" + entre + "(" + txt_x2.Text + menos + txt_x0.Text + ")"
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Segundo paso: Se resuelven los valores b₀, b₁ y b₂.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "b₀" + igual + b0
                                );
                            lbox_results.Items.Add(
                                "b₁" + igual + b1
                                );
                            lbox_results.Items.Add(
                                "b₂" + igual + b2
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Tercer paso: Una vez obtenidos, se remplazan en la fórmula de interpolación.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b0 + " " + mas + b1 + " " + "(" + txt_x.Text + menos + txt_x0.Text + ")" + mas +
                                b2 + " " + "(" + txt_x.Text + menos + txt_x0.Text + ") " + "(" + txt_x.Text + menos + txt_x1.Text + ")"
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Cuarto paso: Se obtiene la primera parte.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b2 + " (" + txt_x.Text + menos + txt_x0.Text + ") " + "(" + txt_x.Text + menos + txt_x1.Text + ")"
                                + igual + part1
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Quinto paso: Se obtiene la segunda parte y se suma con la primera parte.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b1 + " (" + txt_x.Text + menos + txt_x0.Text + ") " + mas + part1 + igual + part3
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando la segunda parte más b₀.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b0 + mas + part3 + igual + result
                                );
                        }
                    }
                    else if (rb_redondeo.Checked == true)
                    {
                        try
                        {
                            // Operaciones.
                            b0 = double.Parse(txt_y0.Text);
                            b1 = (double.Parse(txt_y1.Text) - b0) / (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text));
                            b2 = (((double.Parse(txt_y2.Text) - double.Parse(txt_y1.Text)) / (double.Parse(txt_x2.Text) -
                                double.Parse(txt_x1.Text))) - (double.Parse(txt_y1.Text) - b0) / (double.Parse(txt_x1.Text) -
                                double.Parse(txt_x0.Text))) / (double.Parse(txt_x2.Text) - double.Parse(txt_x0.Text));


                            part1 = b2 * (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text));
                            part2 = b1 * (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text));
                            part3 = part2 + part1;
                            result = b0 + part3;
                            result = Math.Round(result);
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

                        if (result.ToString() == "NaN" || result.ToString().Contains('∞')) // Si hay algún error matemático.
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
                            txt_fx.Text = result.ToString();

                            lbox_results.Items.Clear(); // Reseteo del listBox.

                            // Impresión de valores.
                            lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN CUADRÁTICA");
                            lbox_results.Items.Add("f(x) = " + result);
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("─────────────────────────────────");
                            lbox_results.Items.Add("");
                            templateCuadratica(); // Plantilla fórmula de interpolación lineal.
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("─────────────────────────────────");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Primer paso: Se remplazan los valores en b₀, b₁ y b₂");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "b₀" + igual + b0
                                );
                            lbox_results.Items.Add(
                                "b₁" + igual + "(" + txt_y1.Text + menos + b0 + ")" + entre + "(" + txt_x1.Text + menos + txt_x0.Text + ")"
                                );
                            lbox_results.Items.Add(
                                "b₂" + igual + "(" + txt_y2.Text + menos + txt_y1.Text + ")" + entre + "(" + txt_x2.Text + menos +
                                txt_x1.Text + ")" + menos + "(" + txt_y1.Text + menos + b0 + ")" + entre + "(" + txt_x1.Text + menos +
                                txt_x0.Text + ")" + entre + "(" + txt_x2.Text + menos + txt_x0.Text + ")"
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Segundo paso: Se resuelven los valores b₀, b₁ y b₂.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "b₀" + igual + b0
                                );
                            lbox_results.Items.Add(
                                "b₁" + igual + b1
                                );
                            lbox_results.Items.Add(
                                "b₂" + igual + b2
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Tercer paso: Una vez obtenidos, se remplazan en la fórmula de interpolación.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b0 + " " + mas + b1 + " " + "(" + txt_x.Text + menos + txt_x0.Text + ")" + mas +
                                b2 + " " + "(" + txt_x.Text + menos + txt_x0.Text + ") " + "(" + txt_x.Text + menos + txt_x1.Text + ")"
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Cuarto paso: Se obtiene la primera parte.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b2 + " (" + txt_x.Text + menos + txt_x0.Text + ") " + "(" + txt_x.Text + menos + txt_x1.Text + ")"
                                + igual + part1
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Quinto paso: Se obtiene la segunda parte y se suma con la primera parte.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b1 + " (" + txt_x.Text + menos + txt_x0.Text + ") " + mas + part1 + igual + part3
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando la segunda parte más b₀.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b0 + mas + part3 + igual + result
                                );
                        }
                    }
                    else // Últimos 4 decimales.
                    {
                        try
                        {
                            // Operaciones.
                            b0 = double.Parse(txt_y0.Text);
                            b1 = (double.Parse(txt_y1.Text) - b0) / (double.Parse(txt_x1.Text) - double.Parse(txt_x0.Text));
                            b2 = (((double.Parse(txt_y2.Text) - double.Parse(txt_y1.Text)) / (double.Parse(txt_x2.Text) -
                                double.Parse(txt_x1.Text))) - (double.Parse(txt_y1.Text) - b0) / (double.Parse(txt_x1.Text) -
                                double.Parse(txt_x0.Text))) / (double.Parse(txt_x2.Text) - double.Parse(txt_x0.Text));


                            part1 = b2 * (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text)) * (double.Parse(txt_x.Text) - double.Parse(txt_x1.Text));
                            part2 = b1 * (double.Parse(txt_x.Text) - double.Parse(txt_x0.Text));
                            part3 = part2 + part1;
                            result = b0 + part3;
                            result = Math.Round(result, 4);
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

                        if (result.ToString() == "NaN" || result.ToString().Contains('∞')) // Si hay algún error matemático.
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
                            txt_fx.Text = result.ToString();

                            lbox_results.Items.Clear(); // Reseteo del listBox.

                            // Impresión de valores.
                            lbox_results.Items.Add("RESULTADO DE LA INTERPOLACIÓN CUADRÁTICA");
                            lbox_results.Items.Add("f(x) = " + result);
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("─────────────────────────────────");
                            lbox_results.Items.Add("");
                            templateCuadratica(); // Plantilla fórmula de interpolación lineal.
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("─────────────────────────────────");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("PROCEDIMIENTO POR PASOS");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Primer paso: Se remplazan los valores en b₀, b₁ y b₂");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "b₀" + igual + b0
                                );
                            lbox_results.Items.Add(
                                "b₁" + igual + "(" + txt_y1.Text + menos + b0 + ")" + entre + "(" + txt_x1.Text + menos + txt_x0.Text + ")"
                                );
                            lbox_results.Items.Add(
                                "b₂" + igual + "(" + txt_y2.Text + menos + txt_y1.Text + ")" + entre + "(" + txt_x2.Text + menos +
                                txt_x1.Text + ")" + menos + "(" + txt_y1.Text + menos + b0 + ")" + entre + "(" + txt_x1.Text + menos +
                                txt_x0.Text + ")" + entre + "(" + txt_x2.Text + menos + txt_x0.Text + ")"
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Segundo paso: Se resuelven los valores b₀, b₁ y b₂.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "b₀" + igual + b0
                                );
                            lbox_results.Items.Add(
                                "b₁" + igual + b1
                                );
                            lbox_results.Items.Add(
                                "b₂" + igual + b2
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Tercer paso: Una vez obtenidos, se remplazan en la fórmula de interpolación.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b0 + " " + mas + b1 + " " + "(" + txt_x.Text + menos + txt_x0.Text + ")" + mas +
                                b2 + " " + "(" + txt_x.Text + menos + txt_x0.Text + ") " + "(" + txt_x.Text + menos + txt_x1.Text + ")"
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Cuarto paso: Se obtiene la primera parte.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b2 + " (" + txt_x.Text + menos + txt_x0.Text + ") " + "(" + txt_x.Text + menos + txt_x1.Text + ")"
                                + igual + part1
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Quinto paso: Se obtiene la segunda parte y se suma con la primera parte.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b1 + " (" + txt_x.Text + menos + txt_x0.Text + ") " + mas + part1 + igual + part3
                                );
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add("• Paso final: Se obtiene el resultado sumando la segunda parte más b₀.");
                            lbox_results.Items.Add("");
                            lbox_results.Items.Add(
                                "f(x)" + igual + b0 + mas + part3 + igual + result
                                );
                        }
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset(gb_values);

            if (cb_calculate_percent.Checked == true)
            {
                lbox_results.Items.Add("");
                lbox_results.Items.Add("• Ingrese el valor verdadero en Vv y el valor aproximado en Vapx.");
            }
        }

        private void cb_calculate_percent_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_calculate_percent.Checked == true)
            {
                lbox_results.Items.Clear(); // Reseteo del listBox.

                templateETP();

                lbox_results.Items.Add("");
                lbox_results.Items.Add("• Ingrese el valor verdadero en Vv y el valor aproximado en Vapx.");

                lbl_x.Text = "Vv =";
                lbl_vv.Visible = true;

                lbl_fx.Text = "Vapx =";
                lbl_va.Visible = true;

                txt_x.Text = "0";

                txt_x0.Enabled = false;
                txt_x0.Visible = false;
                lbl_x0.Visible = false; // Label.

                txt_x1.Enabled = false;
                txt_x1.Visible = false;
                lbl_x1.Visible = false; // Label.

                txt_x2.Enabled = false;
                txt_x2.Visible = false;
                lbl_x2.Visible = false; // Label.

                txt_y0.Enabled = false;
                txt_y0.Visible = false;
                lbl_y0.Visible = false; // Label.

                txt_y1.Enabled = false;
                txt_y1.Visible = false;
                lbl_y1.Visible = false; // Label.

                txt_y2.Enabled = false;
                txt_y2.Visible = false;
                lbl_y2.Visible = false; // Label.

                txt_fx.Enabled = true;

                gb_values.Size = new Size(730, 75);

            }
            else
            {
                lbox_results.Items.Clear(); // Reseteo del listBox.

                templateCuadratica();

                lbl_x.Text = "X =";
                lbl_vv.Visible = false;

                lbl_fx.Text = "F(X) =";
                lbl_va.Visible = false;

                txt_x.Text = "0";

                txt_x0.Enabled = true;
                txt_x0.Visible = true;
                lbl_x0.Visible = true; // Label.

                txt_x1.Enabled = true;
                txt_x1.Visible = true;
                lbl_x1.Visible = true; // Label.

                txt_x2.Enabled = true;
                txt_x2.Visible = true;
                lbl_x2.Visible = true; // Label.

                txt_y0.Enabled = true;
                txt_y0.Visible = true;
                lbl_y0.Visible = true; // Label.

                txt_y1.Enabled = true;
                txt_y1.Visible = true;
                lbl_y1.Visible = true; // Label.

                txt_y2.Enabled = true;
                txt_y2.Visible = true;
                lbl_y2.Visible = true; // Label.

                txt_fx.Enabled = false;
                gb_values.Size = new Size(730, 194);
                if (txt_fx.Text == string.Empty)
                {
                    txt_fx.Text = "0";
                }
            }
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
                if (oControls is TextBox & oControls.Enabled == true & oControls.Text == string.Empty)
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
                if (oControls is TextBox & oControls.Enabled == true & oControls.Text == "-" || oControls.Text == "." ||
                    oControls.Text.Contains("-.") || oControls.Text.Contains(".-") ||
                    oControls.Text.EndsWith("-"))
                {
                    txtContains = true;
                }
            }
        }

        private void reset(Control CALPO_Lineal)
        {
            lbox_results.Items.Clear(); // Reseteo del listBox.

            if (cb_calculate_percent.Checked == true)
            {
                templateETP();
            }
            else
            {
                templateCuadratica();
            }

            // Restablece por default cada campo.
            foreach (Control oControls in CALPO_Lineal.Controls)
            {
                if (oControls is TextBox)
                {
                    oControls.Text = "0";
                }
            }
        }

        private void templateCuadratica()
        {
            lbox_results.Items.Add("FÓRMULA DE LA INTERPOLACIÓN CUADRÁTICA");
            lbox_results.Items.Add("");
            lbox_results.Items.Add("• f(x) = b₀ + b₁ (x - x₀) + b₂ (x - x₀) (x - x₁)");
            lbox_results.Items.Add("");
            lbox_results.Items.Add("donde...");
            lbox_results.Items.Add("");
            lbox_results.Items.Add("• b₀ = f(x₀)");
            lbox_results.Items.Add("• b₁ = f(x₁) - f(x₀) ÷ x₁ - x₀");
            lbox_results.Items.Add("• b₂ = ((f(x₂) - f(x₁)) ÷ (x₂ - x₁)) - ((f(x₁) - f(x₀)) ÷ (x₁ - x₀)) ÷ x₂ - x₀");
        }

        private void templateETP()
        {
            lbox_results.Items.Add("FÓRMULA PARA CALCULAR EL ERROR RELATIVO PORCENTUAL");
            lbox_results.Items.Add("");
            lbox_results.Items.Add("• Ev = valor verdadero(Vv) - valor aproximado(Vapx)");
            lbox_results.Items.Add("• Ev = error verdadero");
            lbox_results.Items.Add("• Et = Ev ÷ valor verdadero * 100%");
        }
    }
}
