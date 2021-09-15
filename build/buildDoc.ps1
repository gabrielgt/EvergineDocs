# Install docfx
mkdir -Force Tools
$toolsDir = Get-Location
(New-Object Net.WebClient).DownloadFile('https://github.com/dotnet/docfx/releases/download/v2.58.4/docfx.zip', "$toolsDir\Tools\docfx.zip");(new-object -com shell.application).namespace("$toolsDir\Tools").CopyHere((new-object -com shell.application).namespace("$toolsDir\Tools\docfx.zip").Items(),16)
Tools\docfx ..\docfx.json
