using System;
using System.Drawing;
using System.Windows.Forms;

public static class GlitchEffect
{
    public static void Aplicar(Button btn1, Button btn2, Label label, Random rnd)
    {
        int dx1 = rnd.Next(-5, 6);
        int dy1 = rnd.Next(-5, 6);
        int dx2 = rnd.Next(-5, 6);
        int dy2 = rnd.Next(-5, 6);

        btn1.Location = new Point(50 + dx1, 100 + dy1);
        btn2.Location = new Point(300 + dx2, 100 + dy2);

        label.ForeColor = Color.FromArgb(rnd.Next(100, 255), rnd.Next(100, 255), rnd.Next(100, 255));
    }
}
