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
    public partial class TextBoxRedondeado : UserControl
    {
        // Fields
        private Color borderColor = Color.Blue;
        private Color borderFocusColor = Color.ForestGreen;
        private int borderSize = 2;
        private int borderRadius = 15;
        private bool isFocused = false;
        private bool useSystemPasswordChar;
        private string placeholderText;
        private TextBox textBox1;


        // Constructor
        public TextBoxRedondeado()
        {
            textBox1 = new System.Windows.Forms.TextBox();
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.MouseEnter += TextBox1_MouseEnter;
            textBox1.MouseLeave += TextBox1_MouseLeave;
            

            textBox1.Enter += (sender, e) =>
            {
                isFocused = true;
                borderColor = borderFocusColor;
                OnTextBoxEnter();
                this.Invalidate();
            };

            textBox1.Leave += (sender, e) =>
            {
                isFocused = false;
                borderColor = Color.Blue;
                OnTextBoxLeave();
                this.Invalidate();
            };



            textBox1.KeyPress += (sender, e) => { OnTextBoxKeyPressOnlyNumber(e); }; // Event for KeyPress validation
            textBox1.TextChanged += (sender, e) => { OnTextChanged(e); };

            Controls.Add(textBox1);
            this.Padding = new Padding(10);
            this.Size = new Size(150, 40);
            UpdateControlHeight();
            SetPlaceholder();
        }

        private void OnTextBoxLeave()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                SetPlaceholder();
            }
        }

        private void OnTextBoxEnter()
        {
            if (textBox1.Text == placeholderText)
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.FromArgb(0, 0, 0); // Color normal cuando el usuario escribe

                UpdatePasswordChar(); // Activa el enmascarado si corresponde
            }
        }

        // Properties
        [Category("Custom Properties")]
        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public int MaxLength
        {
            get => textBox1.MaxLength;
            set => textBox1.MaxLength = value; // Establece el MaxLength del TextBox interno
        }

        [Category("Custom Properties")]
        public bool OnlyAllowNumbers { get; set; } = false;

        [Category("Custom Properties")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        public override string Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public bool UseSystemPasswordChar
        {
            get => useSystemPasswordChar;
            set
            {
                useSystemPasswordChar = value;
                UpdatePasswordChar(); // Actualiza el enmascarado del texto según la propiedad
            }
        }

        private void UpdatePasswordChar()
        {
            // Solo enmascara el texto si no está mostrando el placeholder
            textBox1.UseSystemPasswordChar = useSystemPasswordChar && textBox1.Text != placeholderText;
        }

        // Private Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Asegurar que el radio no sea mayor que la mitad del ancho o la altura
            int adjustedRadius = Math.Min(radius, Math.Min(rect.Width, rect.Height) / 2);
            float curveSize = adjustedRadius * 2F;

            if (curveSize > 0)
            {
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
                path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
                path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
                path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
                path.CloseFigure();
            }
            else
            {
                // Si el rectángulo es muy pequeño, usar un camino rectangular
                path.AddRectangle(rect);
            }

            return path;
        }
        private void UpdateControlHeight()
        {
            if (!textBox1.Multiline)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;
                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustTextBoxPosition();
        }

        private void AdjustTextBoxPosition()
        {
            textBox1.Location = new Point(this.Padding.Left, this.Padding.Top);
            textBox1.Width = this.Width - this.Padding.Left - this.Padding.Right;
            textBox1.Height = this.Height - this.Padding.Top - this.Padding.Bottom;
        }

        // Overridden Paint Method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            Rectangle rectBorderSmooth = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
            int smoothSize = borderSize > 0 ? borderSize : 1;

            using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
            using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
            using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
            {
                this.Region = new Region(pathBorderSmooth);

                graph.SmoothingMode = SmoothingMode.AntiAlias;
                penBorder.Alignment = PenAlignment.Center;
                graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                graph.DrawPath(penBorder, pathBorder);
            }
        }

        // Event Handlers
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
        }

        private void TextBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void TextBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        public void Clear()
        {
            textBox1.Text = "";
            SetPlaceholder();
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = placeholderText;
                textBox1.ForeColor = Color.Blue; // Color del texto para el placeholder
                textBox1.UseSystemPasswordChar = false; // Asegura que el placeholder no esté enmascarado
            }
        }

        private void OnTextBoxKeyPressOnlyNumber(KeyPressEventArgs e)
        {
            if (OnlyAllowNumbers && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si no es un número ni una tecla de control
            }
        }
    }
}
