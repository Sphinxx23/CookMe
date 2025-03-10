using System;
using System.Drawing;
using System.Windows.Forms;

public class CustomButton : Button
{
    // Definir los colores para el estado normal y el estado presionado
    private Color normalBackColor = Color.LightSkyBlue;
    private Color normalBorderColor = Color.Blue;
    private Color clickedBackColor = Color.LightGreen;
    private Color clickedBorderColor = Color.Green;

    // Indicador de si el botón está siendo presionado
    private bool isClicked = false;

    // Constructor
    public CustomButton()
    {
        // No usar FlatStyle.Flat para tener control total del borde
        this.FlatStyle = FlatStyle.Standard;
        this.BackColor = normalBackColor;
        this.ForeColor = Color.Black; // Color de texto blanco
        this.Cursor = Cursors.Hand; // Cambiar el cursor al hacer hover sobre el botón
        this.Width = 120;  // Tamaño inicial del botón
        this.Height = 40;
    }

    // Sobrescribir el método OnPaint para personalizar la apariencia del botón
    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        // Dibuja el fondo del botón
        using (SolidBrush brush = new SolidBrush(isClicked ? clickedBackColor : normalBackColor))
        {
            pevent.Graphics.FillRectangle(brush, 0, 0, this.Width, this.Height);
        }

        // Dibuja el borde del botón
        using (Pen borderPen = new Pen(isClicked ? clickedBorderColor : normalBorderColor, 2))
        {
            pevent.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
        }

        // Dibuja el texto del botón (centrado)
        TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    // Cambiar el fondo al hacer clic
    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        isClicked = true;
        this.Invalidate(); // Forzar el redibujado del botón

        // Volver al color original después de un corto tiempo
        Timer timer = new Timer();
        timer.Interval = 200; // Tiempo en milisegundos
        timer.Tick += (sender, args) =>
        {
            isClicked = false;
            this.Invalidate();
            timer.Stop(); // Detener el temporizador
        };
        timer.Start();
    }

    // Cambiar el borde cuando el mouse pasa sobre el botón
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        this.Invalidate(); // Forzar redibujado para mostrar el borde
    }

    // Restaurar el borde cuando el mouse sale del botón
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        this.Invalidate(); // Forzar redibujado para mostrar el borde
    }
}
