using System;
using System.Drawing;
using System.Windows.Forms;

public static class RebootButton
{
    public static Button Crear(Label infoLabel, Action<int> accion)
    {
        var btn = new Button
        {
            Text = "REINICIAR SIN MENSAJE",
            BackColor = Color.Black,
            ForeColor = Color.Cyan,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Consolas", 14, FontStyle.Bold),
            Size = new Size(250, 80),
            Location = new Point(300, 100)
        };
        btn.FlatAppearance.BorderColor = Color.Cyan;
        btn.MouseEnter += (s, e) => infoLabel.Text = "NTShutdownSystem: ShutdownReboot 1";
        btn.MouseLeave += (s, e) => infoLabel.Text = "";
        btn.Click += (s, e) => accion(1);
        return btn;
    }
}
