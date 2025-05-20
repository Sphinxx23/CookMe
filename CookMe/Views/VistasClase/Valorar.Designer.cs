namespace CookMe.Views.VistasClase
{
    partial class Valorar
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
            this.tBValoracion = new System.Windows.Forms.TrackBar();
            this.lbVal = new System.Windows.Forms.Label();
            this.btnValorarFinal = new CustomButton();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBValoracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tBValoracion
            // 
            this.tBValoracion.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tBValoracion.LargeChange = 1;
            this.tBValoracion.Location = new System.Drawing.Point(43, 108);
            this.tBValoracion.Maximum = 5;
            this.tBValoracion.Minimum = 1;
            this.tBValoracion.Name = "tBValoracion";
            this.tBValoracion.Size = new System.Drawing.Size(354, 56);
            this.tBValoracion.TabIndex = 0;
            this.tBValoracion.Value = 2;
            this.tBValoracion.ValueChanged += new System.EventHandler(this.tBValoracion_ValueChanged);
            // 
            // lbVal
            // 
            this.lbVal.AutoSize = true;
            this.lbVal.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbVal.Location = new System.Drawing.Point(114, 39);
            this.lbVal.Name = "lbVal";
            this.lbVal.Size = new System.Drawing.Size(225, 41);
            this.lbVal.TabIndex = 14;
            this.lbVal.Text = "VALORACIÓN";
            // 
            // btnValorarFinal
            // 
            this.btnValorarFinal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnValorarFinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValorarFinal.ForeColor = System.Drawing.Color.Black;
            this.btnValorarFinal.Location = new System.Drawing.Point(127, 185);
            this.btnValorarFinal.Name = "btnValorarFinal";
            this.btnValorarFinal.Size = new System.Drawing.Size(188, 40);
            this.btnValorarFinal.TabIndex = 24;
            this.btnValorarFinal.Text = "Aceptar";
            this.btnValorarFinal.UseVisualStyleBackColor = false;
            this.btnValorarFinal.Click += new System.EventHandler(this.btnValorarFinal_Click);
            // 
            // pbStar5
            // 
            this.pbStar5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbStar5.Image = global::CookMe.Properties.Resources.star_16px;
            this.pbStar5.Location = new System.Drawing.Point(369, 135);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Size = new System.Drawing.Size(26, 23);
            this.pbStar5.TabIndex = 30;
            this.pbStar5.TabStop = false;
            // 
            // pbStar4
            // 
            this.pbStar4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbStar4.Image = global::CookMe.Properties.Resources.star_16px;
            this.pbStar4.Location = new System.Drawing.Point(289, 135);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Size = new System.Drawing.Size(26, 23);
            this.pbStar4.TabIndex = 28;
            this.pbStar4.TabStop = false;
            // 
            // pbStar2
            // 
            this.pbStar2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbStar2.Image = global::CookMe.Properties.Resources.star_16px;
            this.pbStar2.Location = new System.Drawing.Point(131, 135);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Size = new System.Drawing.Size(26, 23);
            this.pbStar2.TabIndex = 27;
            this.pbStar2.TabStop = false;
            // 
            // pbStar3
            // 
            this.pbStar3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbStar3.Image = global::CookMe.Properties.Resources.star_16px;
            this.pbStar3.Location = new System.Drawing.Point(210, 135);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Size = new System.Drawing.Size(26, 23);
            this.pbStar3.TabIndex = 26;
            this.pbStar3.TabStop = false;
            // 
            // pbStar1
            // 
            this.pbStar1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbStar1.Image = global::CookMe.Properties.Resources.star_16px;
            this.pbStar1.Location = new System.Drawing.Point(50, 135);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Size = new System.Drawing.Size(26, 23);
            this.pbStar1.TabIndex = 25;
            this.pbStar1.TabStop = false;
            // 
            // Valorar
            // 
            this.AcceptButton = this.btnValorarFinal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 254);
            this.Controls.Add(this.pbStar5);
            this.Controls.Add(this.pbStar4);
            this.Controls.Add(this.pbStar2);
            this.Controls.Add(this.pbStar3);
            this.Controls.Add(this.pbStar1);
            this.Controls.Add(this.btnValorarFinal);
            this.Controls.Add(this.lbVal);
            this.Controls.Add(this.tBValoracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(444, 254);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(444, 254);
            this.Name = "Valorar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valorar";
            ((System.ComponentModel.ISupportInitialize)(this.tBValoracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tBValoracion;
        private System.Windows.Forms.Label lbVal;
        private CustomButton btnValorarFinal;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar2;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar5;
    }
}