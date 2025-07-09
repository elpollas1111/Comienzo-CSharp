using System.Drawing;
using System.Windows.Forms;

public partial class NTShutdownForm : Form
{
    private Label infoLabel;
    private Button btnShutdown;
    private Button btnReboot;
    private Timer glitchTimer;
    private Random rnd = new Random();

    public NTShutdownForm()
    {
        MessageBox.Show(
            "ADVERTENCIA!\n\nApagar o reiniciar el sistema mediante NTShutdownSystem puede causar:\n\n" +
            "- Corrupcion de archivos severa\n- Daños al hardware o drivers\n- Corrupcion de la MFT (tabla de archivos)\n\n" +
            "Usalo bajo tu propia responsabilidad.",
            "Advertencia del sistema",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        );

        UIStyle.ConfigurarVentana(this);
        infoLabel = InfoLabel.Crear();
        Controls.Add(infoLabel);

        btnShutdown = ShutdownButton.Crear(infoLabel, EjecutarShutdown);
        Controls.Add(btnShutdown);

        btnReboot = RebootButton.Crear(infoLabel, EjecutarShutdown);
        Controls.Add(btnReboot);

        glitchTimer = new Timer { Interval = 100 };
        glitchTimer.Tick += (s, e) => GlitchEffect.Aplicar(btnShutdown, btnReboot, infoLabel, rnd);
        glitchTimer.Start();
    }
}
