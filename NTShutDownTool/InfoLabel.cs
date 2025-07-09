using System.Drawing;
using System.Windows.Forms;

public static class InfoLabel
{
    public static Label Crear()
    {
        return new Label
        {
            ForeColor = Color.LimeGreen,
            BackColor = Color.Black,
            AutoSize = true,
            Location = new Point(50, 400),
            Font = new Font("Consolas", 10, FontStyle.Italic),
        };
    }
}
