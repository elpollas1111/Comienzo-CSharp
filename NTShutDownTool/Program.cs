using System;
using System.Windows.Forms;

public static class Program
{
    [STAThread]
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new NTShutdownForm());
    }
}
