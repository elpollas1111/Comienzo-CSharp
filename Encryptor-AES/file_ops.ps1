function Encrypt-File {
    $file = Get-FileDialog
    $data = [System.IO.File]::ReadAllBytes($file)
    $iv = New-Object byte[] 16; (New-Object Random).NextBytes($iv)
    $encrypted = [AESCrypto]::Encrypt($data, (Get-AESKey), $iv)
    [System.IO.File]::WriteAllBytes("$file.locked", $iv + $encrypted)
}
