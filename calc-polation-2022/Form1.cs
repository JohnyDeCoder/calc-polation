namespace calc_polation_2022
{
    public partial class CALPO_Form : Form
    {
        public CALPO_Form()
        {
            InitializeComponent();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            // Carga inicial del formulario principal.
        }

        // INICIO de botones y componentes.

        private void btn_interpolacion_Click(object sender, EventArgs e)
        {
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
            CALPO_Lagrange showForm = new CALPO_Lagrange();
            openForm(showForm); //Muestra del formulario.

            hideSubMenus();
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
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
            hideSubMenus();
        }

        private void btn_help_about_Click(object sender, EventArgs e)
        {
            CALPO_About showForm = new CALPO_About();
            openForm(showForm); //Muestra del formulario

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
            // Abrir un formulario dentro de otro.
            showForm.TopLevel = false;
            showForm.FormBorderStyle = FormBorderStyle.None;
            showForm.Dock = DockStyle.Fill;
            showForm.BringToFront();

            panel_form.Controls.Add(showForm);

            showForm.Show();
        }

        private void hideSubMenus()
        {
            // Oculta submenús.
            panel_sub_interpolacion.Visible = false;
            panel_sub_help.Visible = false;
        }
        // FIN de Métodos.
    }
}