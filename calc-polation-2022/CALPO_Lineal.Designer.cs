namespace calc_polation_2022
{
    partial class CALPO_Lineal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_options = new System.Windows.Forms.GroupBox();
            this.gb_results_type = new System.Windows.Forms.GroupBox();
            this.rb_last4dec = new System.Windows.Forms.RadioButton();
            this.rb_primerNum = new System.Windows.Forms.RadioButton();
            this.rb_redondeo = new System.Windows.Forms.RadioButton();
            this.rB_noRedondeo = new System.Windows.Forms.RadioButton();
            this.btn_reset = new FontAwesome.Sharp.IconButton();
            this.btn_calculate = new FontAwesome.Sharp.IconButton();
            this.gb_values = new System.Windows.Forms.GroupBox();
            this.txt_y1 = new System.Windows.Forms.TextBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.txt_y0 = new System.Windows.Forms.TextBox();
            this.txt_x0 = new System.Windows.Forms.TextBox();
            this.lbl_y1 = new System.Windows.Forms.Label();
            this.lbl_y0 = new System.Windows.Forms.Label();
            this.lbl_x1 = new System.Windows.Forms.Label();
            this.lbl_x0 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.lbl_x = new System.Windows.Forms.Label();
            this.gb_results = new System.Windows.Forms.GroupBox();
            this.rtb_results = new System.Windows.Forms.RichTextBox();
            this.gb_options.SuspendLayout();
            this.gb_results_type.SuspendLayout();
            this.gb_values.SuspendLayout();
            this.gb_results.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_options
            // 
            this.gb_options.Controls.Add(this.gb_results_type);
            this.gb_options.Controls.Add(this.btn_reset);
            this.gb_options.Controls.Add(this.btn_calculate);
            this.gb_options.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_options.Location = new System.Drawing.Point(12, 12);
            this.gb_options.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_options.Name = "gb_options";
            this.gb_options.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_options.Size = new System.Drawing.Size(150, 343);
            this.gb_options.TabIndex = 0;
            this.gb_options.TabStop = false;
            this.gb_options.Text = "Opciones";
            // 
            // gb_results_type
            // 
            this.gb_results_type.Controls.Add(this.rb_last4dec);
            this.gb_results_type.Controls.Add(this.rb_primerNum);
            this.gb_results_type.Controls.Add(this.rb_redondeo);
            this.gb_results_type.Controls.Add(this.rB_noRedondeo);
            this.gb_results_type.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_results_type.Location = new System.Drawing.Point(6, 185);
            this.gb_results_type.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_results_type.Name = "gb_results_type";
            this.gb_results_type.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_results_type.Size = new System.Drawing.Size(139, 152);
            this.gb_results_type.TabIndex = 2;
            this.gb_results_type.TabStop = false;
            this.gb_results_type.Text = "Tipo de Resultado";
            // 
            // rb_last4dec
            // 
            this.rb_last4dec.AutoSize = true;
            this.rb_last4dec.Location = new System.Drawing.Point(6, 97);
            this.rb_last4dec.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_last4dec.Name = "rb_last4dec";
            this.rb_last4dec.Size = new System.Drawing.Size(78, 34);
            this.rb_last4dec.TabIndex = 3;
            this.rb_last4dec.Text = "Últimos 4\r\ndecimales";
            this.rb_last4dec.UseVisualStyleBackColor = true;
            // 
            // rb_primerNum
            // 
            this.rb_primerNum.AutoSize = true;
            this.rb_primerNum.Location = new System.Drawing.Point(6, 72);
            this.rb_primerNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_primerNum.Name = "rb_primerNum";
            this.rb_primerNum.Size = new System.Drawing.Size(95, 19);
            this.rb_primerNum.TabIndex = 2;
            this.rb_primerNum.Text = "Primer dígito";
            this.rb_primerNum.UseVisualStyleBackColor = true;
            // 
            // rb_redondeo
            // 
            this.rb_redondeo.AutoSize = true;
            this.rb_redondeo.Location = new System.Drawing.Point(6, 47);
            this.rb_redondeo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rb_redondeo.Name = "rb_redondeo";
            this.rb_redondeo.Size = new System.Drawing.Size(102, 19);
            this.rb_redondeo.TabIndex = 1;
            this.rb_redondeo.Text = "Con redondeo";
            this.rb_redondeo.UseVisualStyleBackColor = true;
            // 
            // rB_noRedondeo
            // 
            this.rB_noRedondeo.AutoSize = true;
            this.rB_noRedondeo.Checked = true;
            this.rB_noRedondeo.Location = new System.Drawing.Point(6, 22);
            this.rB_noRedondeo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rB_noRedondeo.Name = "rB_noRedondeo";
            this.rB_noRedondeo.Size = new System.Drawing.Size(97, 19);
            this.rB_noRedondeo.TabIndex = 0;
            this.rB_noRedondeo.TabStop = true;
            this.rB_noRedondeo.Text = "Sin redondeo";
            this.rB_noRedondeo.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_reset.IconColor = System.Drawing.Color.Black;
            this.btn_reset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_reset.Location = new System.Drawing.Point(6, 125);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(139, 54);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Vaciar";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calculate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_calculate.IconColor = System.Drawing.Color.Black;
            this.btn_calculate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_calculate.Location = new System.Drawing.Point(6, 22);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(139, 97);
            this.btn_calculate.TabIndex = 0;
            this.btn_calculate.Text = "Calcular\r\ninterpolación";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // gb_values
            // 
            this.gb_values.Controls.Add(this.txt_y1);
            this.gb_values.Controls.Add(this.txt_x1);
            this.gb_values.Controls.Add(this.txt_y0);
            this.gb_values.Controls.Add(this.txt_x0);
            this.gb_values.Controls.Add(this.lbl_y1);
            this.gb_values.Controls.Add(this.lbl_y0);
            this.gb_values.Controls.Add(this.lbl_x1);
            this.gb_values.Controls.Add(this.lbl_x0);
            this.gb_values.Controls.Add(this.txt_x);
            this.gb_values.Controls.Add(this.lbl_x);
            this.gb_values.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_values.Location = new System.Drawing.Point(12, 355);
            this.gb_values.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_values.Name = "gb_values";
            this.gb_values.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gb_values.Size = new System.Drawing.Size(730, 194);
            this.gb_values.TabIndex = 2;
            this.gb_values.TabStop = false;
            this.gb_values.Text = "Valores";
            // 
            // txt_y1
            // 
            this.txt_y1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_y1.Location = new System.Drawing.Point(430, 141);
            this.txt_y1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_y1.Name = "txt_y1";
            this.txt_y1.PlaceholderText = "número";
            this.txt_y1.ShortcutsEnabled = false;
            this.txt_y1.Size = new System.Drawing.Size(289, 36);
            this.txt_y1.TabIndex = 11;
            this.txt_y1.Text = "0";
            // 
            // txt_x1
            // 
            this.txt_x1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_x1.Location = new System.Drawing.Point(64, 141);
            this.txt_x1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.PlaceholderText = "número";
            this.txt_x1.ShortcutsEnabled = false;
            this.txt_x1.Size = new System.Drawing.Size(265, 36);
            this.txt_x1.TabIndex = 10;
            this.txt_x1.Text = "0";
            // 
            // txt_y0
            // 
            this.txt_y0.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_y0.Location = new System.Drawing.Point(430, 86);
            this.txt_y0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_y0.Name = "txt_y0";
            this.txt_y0.PlaceholderText = "número";
            this.txt_y0.ShortcutsEnabled = false;
            this.txt_y0.Size = new System.Drawing.Size(289, 36);
            this.txt_y0.TabIndex = 9;
            this.txt_y0.Text = "0";
            // 
            // txt_x0
            // 
            this.txt_x0.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_x0.Location = new System.Drawing.Point(64, 84);
            this.txt_x0.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_x0.Name = "txt_x0";
            this.txt_x0.PlaceholderText = "número";
            this.txt_x0.ShortcutsEnabled = false;
            this.txt_x0.Size = new System.Drawing.Size(265, 36);
            this.txt_x0.TabIndex = 8;
            this.txt_x0.Text = "0";
            // 
            // lbl_y1
            // 
            this.lbl_y1.AutoSize = true;
            this.lbl_y1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_y1.Location = new System.Drawing.Point(337, 143);
            this.lbl_y1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_y1.Name = "lbl_y1";
            this.lbl_y1.Size = new System.Drawing.Size(85, 28);
            this.lbl_y1.TabIndex = 5;
            this.lbl_y1.Text = "F(X₁) =";
            // 
            // lbl_y0
            // 
            this.lbl_y0.AutoSize = true;
            this.lbl_y0.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_y0.Location = new System.Drawing.Point(337, 86);
            this.lbl_y0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_y0.Name = "lbl_y0";
            this.lbl_y0.Size = new System.Drawing.Size(85, 28);
            this.lbl_y0.TabIndex = 4;
            this.lbl_y0.Text = "F(X₀) =";
            // 
            // lbl_x1
            // 
            this.lbl_x1.AutoSize = true;
            this.lbl_x1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x1.Location = new System.Drawing.Point(8, 143);
            this.lbl_x1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x1.Name = "lbl_x1";
            this.lbl_x1.Size = new System.Drawing.Size(54, 28);
            this.lbl_x1.TabIndex = 3;
            this.lbl_x1.Text = "X₁ =";
            // 
            // lbl_x0
            // 
            this.lbl_x0.AutoSize = true;
            this.lbl_x0.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x0.Location = new System.Drawing.Point(8, 86);
            this.lbl_x0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x0.Name = "lbl_x0";
            this.lbl_x0.Size = new System.Drawing.Size(54, 28);
            this.lbl_x0.TabIndex = 2;
            this.lbl_x0.Text = "X₀ =";
            // 
            // txt_x
            // 
            this.txt_x.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_x.Location = new System.Drawing.Point(64, 28);
            this.txt_x.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_x.Name = "txt_x";
            this.txt_x.PlaceholderText = "número";
            this.txt_x.ShortcutsEnabled = false;
            this.txt_x.Size = new System.Drawing.Size(655, 36);
            this.txt_x.TabIndex = 1;
            this.txt_x.Text = "0";
            this.txt_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x_KeyPress);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x.Location = new System.Drawing.Point(12, 30);
            this.lbl_x.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(44, 28);
            this.lbl_x.TabIndex = 0;
            this.lbl_x.Text = "X =";
            // 
            // gb_results
            // 
            this.gb_results.Controls.Add(this.rtb_results);
            this.gb_results.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_results.Location = new System.Drawing.Point(169, 12);
            this.gb_results.Name = "gb_results";
            this.gb_results.Size = new System.Drawing.Size(573, 343);
            this.gb_results.TabIndex = 3;
            this.gb_results.TabStop = false;
            this.gb_results.Text = "Resultados";
            // 
            // rtb_results
            // 
            this.rtb_results.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_results.BulletIndent = 5;
            this.rtb_results.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_results.Font = new System.Drawing.Font("Cambria Math", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_results.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.rtb_results.Location = new System.Drawing.Point(7, 22);
            this.rtb_results.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rtb_results.Name = "rtb_results";
            this.rtb_results.ReadOnly = true;
            this.rtb_results.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtb_results.ShortcutsEnabled = false;
            this.rtb_results.Size = new System.Drawing.Size(559, 315);
            this.rtb_results.TabIndex = 4;
            this.rtb_results.TabStop = false;
            this.rtb_results.Text = "FÓRMULA DE LA INTERPOLACIÓN LINEAL\n\nf(x) = f(x₀) + f(x₁) - f(x₀)/x₁ - x₀ (x - x₀)" +
    "";
            // 
            // CALPO_Lineal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 558);
            this.Controls.Add(this.gb_results);
            this.Controls.Add(this.gb_values);
            this.Controls.Add(this.gb_options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CALPO_Lineal";
            this.Text = "CALPO: Interpolación Lineal";
            this.Load += new System.EventHandler(this.CALPO_Lineal_Load);
            this.gb_options.ResumeLayout(false);
            this.gb_results_type.ResumeLayout(false);
            this.gb_results_type.PerformLayout();
            this.gb_values.ResumeLayout(false);
            this.gb_values.PerformLayout();
            this.gb_results.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_options;
        private FontAwesome.Sharp.IconButton btn_reset;
        private FontAwesome.Sharp.IconButton btn_calculate;
        private GroupBox gb_values;
        private TextBox txt_x;
        private Label lbl_x;
        private GroupBox gb_results_type;
        private RadioButton rb_redondeo;
        private RadioButton rB_noRedondeo;
        private Label lbl_y0;
        private Label lbl_x1;
        private Label lbl_x0;
        private TextBox txt_x0;
        private Label lbl_y1;
        private TextBox txt_y1;
        private TextBox txt_x1;
        private TextBox txt_y0;
        private RadioButton rb_last4dec;
        private RadioButton rb_primerNum;
        private GroupBox gb_results;
        private RichTextBox rtb_results;
    }
}