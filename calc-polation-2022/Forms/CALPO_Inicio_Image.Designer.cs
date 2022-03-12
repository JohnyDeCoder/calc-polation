namespace calc_polation_2022.Forms
{
    partial class CALPO_Inicio_Image
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
            this.picB_inicio_image = new System.Windows.Forms.PictureBox();
            this.lbl_version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picB_inicio_image)).BeginInit();
            this.SuspendLayout();
            // 
            // picB_inicio_image
            // 
            this.picB_inicio_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picB_inicio_image.Image = global::calc_polation_2022.Properties.Resources.Logotipo_Center_Panel;
            this.picB_inicio_image.Location = new System.Drawing.Point(0, 0);
            this.picB_inicio_image.Name = "picB_inicio_image";
            this.picB_inicio_image.Size = new System.Drawing.Size(754, 561);
            this.picB_inicio_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_inicio_image.TabIndex = 0;
            this.picB_inicio_image.TabStop = false;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_version.Location = new System.Drawing.Point(676, 544);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(78, 17);
            this.lbl_version.TabIndex = 1;
            this.lbl_version.Text = "v1.0.0-beta";
            // 
            // CALPO_Inicio_Image
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 561);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.picB_inicio_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CALPO_Inicio_Image";
            this.Text = "CALPO: Inicio";
            this.Load += new System.EventHandler(this.CALPO_Inicio_Image_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_inicio_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picB_inicio_image;
        private Label lbl_version;
    }
}