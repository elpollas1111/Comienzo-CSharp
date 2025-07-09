using System;
using System.Drawing;
using System.Windows.Forms;

public static class ShutdownButton
{
    public static Button Crear(Label infoLabel, Action<int> accion)
    {
        var btn = new Button
        {
            Text = "APAGAR SIN MENSAJE",
            BackColor = Color.Black,
            ForeColor = Color.LimeGreen,
            FlatStyle = FlatStyle.Flat,
            Font = new Font("Consolas", 14, FontStyle.Bold),
            Size = new Size(250, 80),
            Location = new Point(50, 100)
        };
        btn.FlatAppearance.BorderColor = Color.Lime;
        btn.MouseEnter += (s, e) => infoLabel.Text = "NTShutdownSystem: ShutdownPowerOff 2";
        btn.MouseLeave += (s, e) => infoLabel.Text = "";
        btn.Click += (s, e) => accion(2);
        return btn;
    }
}
