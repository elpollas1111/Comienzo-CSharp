Write-Host "compilando archivos: $($sourceFiles -join ', ') ..."
& $cscPath $args

if ($LASTEXITCODE -eq 0) {
    Write-Host "compilación terminada con exito, Ejecutable generado: $outputExe"
} else {
    Write-Host "error: $LASTEXITCODE"
}
