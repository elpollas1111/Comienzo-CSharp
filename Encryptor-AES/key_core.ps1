function Get-AESKey {
    $clave = "Clav3SeguraAES16"
    return [System.Text.Encoding]::UTF8.GetBytes($clave)
}
