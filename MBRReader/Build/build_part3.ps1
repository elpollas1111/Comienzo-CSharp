$outputExe = "PhysicalDriveReader.exe"

$args = @(
    "/target:winexe",
    "/out:$outputExe"
)

$args += $sourceFiles
$args += "/win32manifest:$manifestFile"
$args += "/reference:$references"
