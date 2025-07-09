using System;
using System.Drawing;
using System.Windows.Forms;

public class PhysicalDriveReader : Form
{
    private TextBox txtOutput;
    private Button btnReadMBR;

    public PhysicalDriveReader()
    {
        this.Text = "Leer Sector 0 - PHYSICALDRIVE0";
        this.Size = new Size(900, 700);
        this.StartPosition = FormStartPosition.CenterScreen;

        btnReadMBR = new Button();
        btnReadMBR.Text = "Leer Sector 0 (MBR) de PHYSICALDRIVE0";
        btnReadMBR.Dock = DockStyle.Top;
        btnReadMBR.Height = 40;
        btnReadMBR.Click += BtnReadMBR_Click;

        txtOutput = new TextBox();
        txtOutput.Multiline = true;
        txtOutput.Font = new Font("Consolas", 10);
        txtOutput.ScrollBars = ScrollBars.Both;
        txtOutput.WordWrap = false;
        txtOutput.Dock = DockStyle.Fill;

        this.Controls.Add(txtOutput);
        this.Controls.Add(btnReadMBR);
    }

    private void BtnReadMBR_Click(object sender, EventArgs e)
    {
        try
        {
            byte[] mbrSector = MBRReader.ReadSectorZero(0);

            txtOutput.Text = MBRFormatter.FormatMBR(mbrSector);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message);
        }
    }
}
