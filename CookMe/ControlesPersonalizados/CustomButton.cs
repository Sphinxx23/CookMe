using System;
using System.Drawing;
using System.Windows.Forms;


//Clase sacada de otros proyectos realizados durante el curso
public class CustomButton : Button
{
    
    private Color normalBackColor = Color.LightSkyBlue;
    private Color normalBorderColor = Color.Blue;
    private Color clickedBackColor = Color.LightGreen;
    private Color clickedBorderColor = Color.Green;

    
    private bool isClicked = false;

    
    public CustomButton()
    {
        
        this.FlatStyle = FlatStyle.Standard;
        this.BackColor = normalBackColor;
        this.ForeColor = Color.Black; 
        this.Cursor = Cursors.Hand; 
        this.Width = 120;  
        this.Height = 40;
    }

    
    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        
        using (SolidBrush brush = new SolidBrush(isClicked ? clickedBackColor : normalBackColor))
        {
            pevent.Graphics.FillRectangle(brush, 0, 0, this.Width, this.Height);
        }

        
        using (Pen borderPen = new Pen(isClicked ? clickedBorderColor : normalBorderColor, 2))
        {
            pevent.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
        }

        
        TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }

    
    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        isClicked = true;
        this.Invalidate(); 

        
        Timer timer = new Timer();
        timer.Interval = 200; 
        timer.Tick += (sender, args) =>
        {
            isClicked = false;
            this.Invalidate();
            timer.Stop();
        };
        timer.Start();
    }

    
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        this.Invalidate(); 
    }

    
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        this.Invalidate(); 
    }
}
