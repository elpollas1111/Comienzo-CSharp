using System;
using System.Security.Cryptography;
using System.IO;
public class AESCrypto {
    public static byte[] Encrypt(byte[] data, byte[] key, byte[] iv) {
        using (var aes = Aes.Create()) {
            aes.Key = key;
            aes.IV = iv;
            using (var encryptor = aes.CreateEncryptor()) {
                return encryptor.TransformFinalBlock(data, 0, data.Length);
            }
        }
    }

    public static byte[] Decrypt(byte[] data, byte[] key, byte[] iv) {
        using (var aes = Aes.Create()) {
            aes.Key = key;
            aes.IV = iv;
            using (var decryptor = aes.CreateDecryptor()) {
                return decryptor.TransformFinalBlock(data, 0, data.Length);
            }
        }
    }
}
