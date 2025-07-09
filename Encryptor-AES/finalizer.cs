using System;
using System.IO;

public class FileFinalizer {
    public static void FinalWrite(string path, byte[] data) {
        File.WriteAllBytes(path, data);
    }

    public static void FinalRemove(string path) {
        if (File.Exists(path)) {
            File.Delete(path);
        }
    }
}
