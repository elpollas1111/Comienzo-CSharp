using System;
using System.Text;

internal class MBRFormatter {
    public static string FormatMBR(byte[] mbr) {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("=== Sector 0 (MBR) PHYSICALDRIVE0 ===\n");

        for (int i = 0; i < 512; i += 16) {
            sb.Append(i.ToString("X4") + ": ");
            for (int j = 0; j < 16; j++) {
                sb.Append(mbr[i + j].ToString("X2") + " ");
            }
            sb.AppendLine();
        }
        sb.AppendLine();

        sb.AppendLine((mbr[510] == 0x55 && mbr[511] == 0xAA)
            ? "Firma MBR válida (0x55AA)."
            : "Firma MBR inválida.");

        sb.AppendLine("\nTabla de particiones:");

        for (int i = 0; i < 4; i++) {
            int offset = 446 + i * 16;
            var entry = PartitionEntry.Parse(mbr, offset);
            sb.AppendLine(entry.ToString());
        }

        return sb.ToString();
    }
}
