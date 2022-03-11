using FontAwesome.Sharp;

namespace calc_polation_2022
{
    partial class CALPO_Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CALPO_Inicio));
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.btn_repository = new FontAwesome.Sharp.IconButton();
            this.btn_exit = new FontAwesome.Sharp.IconButton();
            this.panel_sub_help = new System.Windows.Forms.Panel();
            this.btn_help_about = new FontAwesome.Sharp.IconButton();
            this.btn_usar = new FontAwesome.Sharp.IconButton();
            this.btn_help = new FontAwesome.Sharp.IconButton();
            this.btn_lagrange = new FontAwesome.Sharp.IconButton();
            this.panel_sub_interpolacion = new System.Windows.Forms.Panel();
            this.btn_inter_cuadratica = new FontAwesome.Sharp.IconButton();
            this.btn_inter_lineal = new FontAwesome.Sharp.IconButton();
            this.btn_interpolacion = new FontAwesome.Sharp.IconButton();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.picB_calpo = new System.Windows.Forms.PictureBox();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel_lateral.SuspendLayout();
            this.panel_sub_help.SuspendLayout();
            this.panel_sub_interpolacion.SuspendLayout();
            this.panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_calpo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            resources.ApplyResources(this.panel_lateral, "panel_lateral");
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(113)))), ((int)(((byte)(163)))));
            this.panel_lateral.Controls.Add(this.btn_repository);
            this.panel_lateral.Controls.Add(this.btn_exit);
            this.panel_lateral.Controls.Add(this.panel_sub_help);
            this.panel_lateral.Controls.Add(this.btn_help);
            this.panel_lateral.Controls.Add(this.btn_lagrange);
            this.panel_lateral.Controls.Add(this.panel_sub_interpolacion);
            this.panel_lateral.Controls.Add(this.btn_interpolacion);
            this.panel_lateral.Controls.Add(this.panel_logo);
            this.panel_lateral.Name = "panel_lateral";
            // 
            // btn_repository
            // 
            resources.ApplyResources(this.btn_repository, "btn_repository");
            this.btn_repository.FlatAppearance.BorderSize = 0;
            this.btn_repository.ForeColor = System.Drawing.Color.White;
            this.btn_repository.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btn_repository.IconColor = System.Drawing.Color.White;
            this.btn_repository.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_repository.IconSize = 25;
            this.btn_repository.Name = "btn_repository";
            this.btn_repository.UseVisualStyleBackColor = true;
            this.btn_repository.Click += new System.EventHandler(this.btn_repository_Click);
            // 
            // btn_exit
            // 
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btn_exit.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_exit.IconSize = 25;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel_sub_help
            // 
            resources.ApplyResources(this.panel_sub_help, "panel_sub_help");
            this.panel_sub_help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.panel_sub_help.Controls.Add(this.btn_help_about);
            this.panel_sub_help.Controls.Add(this.btn_usar);
            this.panel_sub_help.Name = "panel_sub_help";
            // 
            // btn_help_about
            // 
            resources.ApplyResources(this.btn_help_about, "btn_help_about");
            this.btn_help_about.FlatAppearance.BorderSize = 0;
            this.btn_help_about.ForeColor = System.Drawing.Color.White;
            this.btn_help_about.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_help_about.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_help_about.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_help_about.IconSize = 25;
            this.btn_help_about.Name = "btn_help_about";
            this.btn_help_about.UseVisualStyleBackColor = true;
            this.btn_help_about.Click += new System.EventHandler(this.btn_help_about_Click);
            // 
            // btn_usar
            // 
            resources.ApplyResources(this.btn_usar, "btn_usar");
            this.btn_usar.FlatAppearance.BorderSize = 0;
            this.btn_usar.ForeColor = System.Drawing.Color.White;
            this.btn_usar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_usar.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_usar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_usar.IconSize = 25;
            this.btn_usar.Name = "btn_usar";
            this.btn_usar.UseVisualStyleBackColor = true;
            this.btn_usar.Click += new System.EventHandler(this.btn_usar_Click);
            // 
            // btn_help
            // 
            resources.ApplyResources(this.btn_help, "btn_help");
            this.btn_help.FlatAppearance.BorderSize = 0;
            this.btn_help.ForeColor = System.Drawing.Color.White;
            this.btn_help.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btn_help.IconColor = System.Drawing.Color.White;
            this.btn_help.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_help.IconSize = 25;
            this.btn_help.Name = "btn_help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_lagrange
            // 
            resources.ApplyResources(this.btn_lagrange, "btn_lagrange");
            this.btn_lagrange.FlatAppearance.BorderSize = 0;
            this.btn_lagrange.ForeColor = System.Drawing.Color.White;
            this.btn_lagrange.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.btn_lagrange.IconColor = System.Drawing.Color.White;
            this.btn_lagrange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_lagrange.IconSize = 25;
            this.btn_lagrange.Name = "btn_lagrange";
            this.btn_lagrange.UseVisualStyleBackColor = true;
            this.btn_lagrange.Click += new System.EventHandler(this.btn_lagrange_Click);
            // 
            // panel_sub_interpolacion
            // 
            resources.ApplyResources(this.panel_sub_interpolacion, "panel_sub_interpolacion");
            this.panel_sub_interpolacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.panel_sub_interpolacion.Controls.Add(this.btn_inter_cuadratica);
            this.panel_sub_interpolacion.Controls.Add(this.btn_inter_lineal);
            this.panel_sub_interpolacion.Name = "panel_sub_interpolacion";
            // 
            // btn_inter_cuadratica
            // 
            resources.ApplyResources(this.btn_inter_cuadratica, "btn_inter_cuadratica");
            this.btn_inter_cuadratica.FlatAppearance.BorderSize = 0;
            this.btn_inter_cuadratica.ForeColor = System.Drawing.Color.White;
            this.btn_inter_cuadratica.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_inter_cuadratica.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inter_cuadratica.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_inter_cuadratica.IconSize = 25;
            this.btn_inter_cuadratica.Name = "btn_inter_cuadratica";
            this.btn_inter_cuadratica.UseVisualStyleBackColor = true;
            this.btn_inter_cuadratica.Click += new System.EventHandler(this.btn_inter_cuadratica_Click);
            // 
            // btn_inter_lineal
            // 
            resources.ApplyResources(this.btn_inter_lineal, "btn_inter_lineal");
            this.btn_inter_lineal.FlatAppearance.BorderSize = 0;
            this.btn_inter_lineal.ForeColor = System.Drawing.Color.White;
            this.btn_inter_lineal.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_inter_lineal.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_inter_lineal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_inter_lineal.IconSize = 25;
            this.btn_inter_lineal.Name = "btn_inter_lineal";
            this.btn_inter_lineal.UseVisualStyleBackColor = true;
            this.btn_inter_lineal.Click += new System.EventHandler(this.btn_inter_lineal_Click);
            // 
            // btn_interpolacion
            // 
            resources.ApplyResources(this.btn_interpolacion, "btn_interpolacion");
            this.btn_interpolacion.FlatAppearance.BorderSize = 0;
            this.btn_interpolacion.ForeColor = System.Drawing.Color.White;
            this.btn_interpolacion.IconChar = FontAwesome.Sharp.IconChar.Subscript;
            this.btn_interpolacion.IconColor = System.Drawing.Color.White;
            this.btn_interpolacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_interpolacion.IconSize = 25;
            this.btn_interpolacion.Name = "btn_interpolacion";
            this.btn_interpolacion.UseVisualStyleBackColor = true;
            this.btn_interpolacion.Click += new System.EventHandler(this.btn_interpolacion_Click);
            // 
            // panel_logo
            // 
            resources.ApplyResources(this.panel_logo, "panel_logo");
            this.panel_logo.Controls.Add(this.picB_calpo);
            this.panel_logo.Name = "panel_logo";
            // 
            // picB_calpo
            // 
            resources.ApplyResources(this.picB_calpo, "picB_calpo");
            this.picB_calpo.Image = global::calc_polation_2022.Properties.Resources.Logotipo_Left_Panel;
            this.picB_calpo.Name = "picB_calpo";
            this.picB_calpo.TabStop = false;
            this.picB_calpo.Click += new System.EventHandler(this.picB_calpo_Click);
            // 
            // panel_form
            // 
            resources.ApplyResources(this.panel_form, "panel_form");
            this.panel_form.Name = "panel_form";
            // 
            // CALPO_Inicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel_lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CALPO_Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel_lateral.ResumeLayout(false);
            this.panel_sub_help.ResumeLayout(false);
            this.panel_sub_interpolacion.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_calpo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_lateral;
        private Panel panel_logo;
        private Panel panel_form;
        private FontAwesome.Sharp.IconButton btn_interpolacion;
        private Panel panel_sub_interpolacion;
        private FontAwesome.Sharp.IconButton btn_inter_cuadratica;
        private FontAwesome.Sharp.IconButton btn_inter_lineal;
        private FontAwesome.Sharp.IconButton btn_lagrange;
        private FontAwesome.Sharp.IconButton btn_help;
        private Panel panel_sub_help;
        private FontAwesome.Sharp.IconButton btn_help_about;
        private FontAwesome.Sharp.IconButton btn_usar;
        private FontAwesome.Sharp.IconButton btn_exit;
        private IconButton btn_repository;
        private PictureBox picB_calpo;
    }
}