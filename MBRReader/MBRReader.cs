using System;
using System.IO;

internal class MBRReader {
    public static byte[] ReadSectorZero(int physicalDriveNumber) {
        string path = @"\\.\" + "PhysicalDrive" + physicalDriveNumber; // ojito,,, para esto ya es necesario UAC admin 
        IntPtr handle = NativeMethods.CreateFile(
            path,
            Constants.GENERIC_READ,
            Constants.FILE_SHARE_READ | Constants.FILE_SHARE_WRITE,
            IntPtr.Zero,
            Constants.OPEN_EXISTING,
            0,
            IntPtr.Zero);

        if (handle == new IntPtr(-1))
            throw new IOException("No se pudo abrir el disco físico. Ejecuta como administrador.");

        byte[] buffer = new byte[512];
        uint bytesRead = 0;
        bool success = NativeMethods.ReadFile(handle, buffer, 512, out bytesRead, IntPtr.Zero);
        NativeMethods.CloseHandle(handle);

        if (!success || bytesRead != 512)
            throw new IOException("No se pudo leer el sector 0 del disco físico.");

        return buffer;
    }
}
