using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace CookMe.ControlesPersonalizados
{
    //Clase sacada de otros proyectos realizados durante el curso
    public partial class TextBoxRedondeado : UserControl
    {
        private Color borderColor = Color.Blue;
        private int borderRadius = 15;
        private TextBox textBox = new TextBox();

        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; Invalidate(); }
        }

        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public char PasswordChar
        {
            get => textBox.PasswordChar;
            set => textBox.PasswordChar = value;
        }

        public bool Multiline
        {
            get => textBox.Multiline;
            set => textBox.Multiline = true;
        }

        public TextBoxRedondeado()
        {
            textBox.BorderStyle = BorderStyle.None;
            textBox.Location = new Point(10, 10);
            textBox.Width = this.Width - 20;
            textBox.Height = this.Height - 20;

            Controls.Add(textBox);
            this.Padding = new Padding(10);
            this.Size = new Size(150, 40);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            textBox.Width = this.Width - 20;
            textBox.Height = this.Height - 20;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(borderColor, 2))
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(Width - borderRadius - 1, Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }
}
