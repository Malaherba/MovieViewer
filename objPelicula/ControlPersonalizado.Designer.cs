namespace objPelicula
{
    partial class ControlPersonalizado
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ImageMoviePreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ImageMoviePreview
            // 
            this.btn_ImageMoviePreview.BackgroundImage = global::objPelicula.Properties.Resources._default;
            this.btn_ImageMoviePreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ImageMoviePreview.Location = new System.Drawing.Point(10, 10);
            this.btn_ImageMoviePreview.Name = "btn_ImageMoviePreview";
            this.btn_ImageMoviePreview.Size = new System.Drawing.Size(150, 220);
            this.btn_ImageMoviePreview.TabIndex = 0;
            this.btn_ImageMoviePreview.UseVisualStyleBackColor = true;
            // 
            // ControlPersonalizado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.Controls.Add(this.btn_ImageMoviePreview);
            this.MinimumSize = new System.Drawing.Size(170, 240);
            this.Name = "ControlPersonalizado";
            this.Size = new System.Drawing.Size(170, 240);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ImageMoviePreview;
    }
}
