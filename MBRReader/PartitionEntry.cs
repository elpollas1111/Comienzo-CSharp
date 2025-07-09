using System;

internal class PartitionEntry {
    public byte Status { get; private set; }
    public byte Type { get; private set; }
    public uint FirstSector { get; private set; }
    public uint SectorCount { get; private set; }

    public static PartitionEntry Parse(byte[] mbr, int offset) {
        return new PartitionEntry {
            Status = mbr[offset],
            Type = mbr[offset + 4],
            FirstSector = BitConverter.ToUInt32(mbr, offset + 8),
            SectorCount = BitConverter.ToUInt32(mbr, offset + 12)
        };
    }

    public override string ToString() {
        return
            $"Partición:\n" +
            $"  Estado: {(Status == 0x80 ? "Activo" : "Inactivo")}\n" +
            $"  Tipo: 0x{Type:X2}\n" +
            $"  Primer sector (LBA): {FirstSector}\n" +
            $"  Sectores totales: {SectorCount}\n";
    }
}
