using System.Drawing;
using System.Windows.Forms;

public static class UIStyle
{
    public static void ConfigurarVentana(Form f)
    {
        f.Text = "NTShutdownOptions";
        f.FormBorderStyle = FormBorderStyle.FixedSingle;
        f.StartPosition = FormStartPosition.CenterScreen;
        f.Size = new Size(600, 500);
        f.BackColor = Color.Black;
        f.Font = new Font("Consolas", 12);
    }
}
