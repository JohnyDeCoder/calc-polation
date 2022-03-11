using FontAwesome.Sharp;

namespace calc_polation_2022
{
    public partial class CALPO_Inicio : Form
    {
        // Campos.
        private IconButton currentBtn;
        private Panel btnBorderLeft;

        // Constructor.
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public CALPO_Inicio()
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            InitializeComponent();

            // Botón lateral del botón.
            btnBorderLeft = new Panel();
            btnBorderLeft.Size = new Size(8, 45);
            panel_lateral.Controls.Add(btnBorderLeft);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            // Carga inicial del formulario principal.
            Forms.CALPO_Inicio_Image showForm = new Forms.CALPO_Inicio_Image();
            openForm(showForm); //Muestra del formulario.
        }

        // INICIO de botones y componentes.

        private void picB_calpo_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btn_interpolacion_Click(object sender, EventArgs e)
        {
            buttonActivate(sender);

            if (panel_sub_interpolacion.Visible == true)
            {
                panel_sub_interpolacion.Visible = false;
                
            }
            else
            {
                if (panel_sub_help.Visible == true)
                {
                    // Oculta el submenú anterior.
                    panel_sub_help.Visible = false;
                }

                panel_sub_interpolacion.Visible = true;
            }
        }

        private void btn_inter_lineal_Click(object sender, EventArgs e)
        {
            CALPO_Lineal showForm = new CALPO_Lineal();
            openForm(showForm); //Muestra del formulario.

            hideSubMenus();
        }

        private void btn_inter_cuadratica_Click(object sender, EventArgs e)
        {
            CALPO_Cuadratica showForm = new CALPO_Cuadratica();
            openForm(showForm); //Muestra del formulario.

            hideSubMenus();
        }

        private void btn_lagrange_Click(object sender, EventArgs e)
        {
            buttonActivate(sender);

            CALPO_Lagrange showForm = new CALPO_Lagrange();
            openForm(showForm); //Muestra del formulario.

            hideSubMenus();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            buttonActivate(sender);

            if (panel_sub_help.Visible == true)
            {
                panel_sub_help.Visible = false;
            }
            else
            {
                if (panel_sub_interpolacion.Visible == true)
                {
                    // Oculta el submenú anterior.
                    panel_sub_interpolacion.Visible = false;

                }

                panel_sub_help.Visible = true;
            }
        }

        private void btn_usar_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://github.com/JohnyDeCoder/calc-polation");

            hideSubMenus();
        }

        private void btn_help_about_Click(object sender, EventArgs e)
        {
            hideSubMenus();

            Forms.CALPO_Inicio_Image showForm = new Forms.CALPO_Inicio_Image();
            openForm(showForm); //Muestra del formulario.

            Form CALPO_About = new CALPO_About();
            CALPO_About.ShowDialog();

            disableButtonActive();
            btnBorderLeft.Visible = false;
        }

        private void btn_repository_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://github.com/JohnyDeCoder/calc-polation");

            hideSubMenus();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        // FIN de controles y componentes.

        // INICIO de Métodos.
        private void openForm(Form showForm)
        {
            Text = showForm.Text;
            // Abrir un formulario dentro de un panel.
            if (panel_form.Controls.Count > 0) // Sí, existe algún elemento en el panel.
            {
                panel_form.Controls.RemoveAt(0); // Se elimina el formulario dentro del panel.
            }

            showForm.TopLevel = false;
            showForm.FormBorderStyle = FormBorderStyle.None;
            showForm.Dock = DockStyle.Fill;
            showForm.BringToFront(); // Traer al frente.

            panel_form.Controls.Add(showForm);

            showForm.Show();
        }

        private void hideSubMenus()
        {
            // Oculta submenús.
            panel_sub_interpolacion.Visible = false;
            panel_sub_help.Visible = false;
        }

        private void buttonActivate(object senderBtn)
        {
            if (senderBtn != null)
            {
                disableButtonActive();

                // Botón.
                currentBtn = (IconButton)senderBtn;
                // currentBtn.BackColor = Color.FromArgb(40, 116, 166); // Backgroud color button.
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Borde del botón latreral.
                btnBorderLeft.BackColor = Color.FromArgb(212, 172, 13); // Background color lateral button.
                if (currentBtn == btn_interpolacion)
                {
                    btnBorderLeft.Location = new Point(0, 100);
                }
                else if (currentBtn == btn_lagrange)
                {
                    btnBorderLeft.Location = new Point(0, 145);
                }
                else if (currentBtn == btn_help)
                {
                    btnBorderLeft.Location = new Point(0, 190);
                }
                else
                {
                    btnBorderLeft.Location = new Point(0, 235);
                }
                
                btnBorderLeft.Visible = true;
                btnBorderLeft.BringToFront(); // Traer al frente.
            }
        }

        private void disableButtonActive()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(36, 113, 163);
                currentBtn.ForeColor = Color.White;
                currentBtn.IconColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void reset()
        {
            hideSubMenus();
            disableButtonActive();

            btnBorderLeft.Visible = false;

            Forms.CALPO_Inicio_Image showForm = new Forms.CALPO_Inicio_Image();
            openForm(showForm); //Muestra del formulario.
        }
        // FIN de Métodos.
    }
}