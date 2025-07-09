Add-Type -Path "./aes_engine.cs"
Add-Type -Path "./useless_config.cs"

. "$PSScriptRoot\file_ops.ps1"
. "$PSScriptRoot\key_core.ps1"
. "$PSScriptRoot\hook_launcher.ps1"

Start-AESApp
