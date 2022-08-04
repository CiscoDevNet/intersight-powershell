$app_catalog1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$parent1 = Get-IntersightHyperflexAppcatalog -Moid '<Replace with Moid>'

$server_firmware_version_entries1 = Get-IntersightHyperflexServerfirmwareversionentry -Moid '<Replace with Moid>'

$hyperflex_server_firmware_version1 = New-IntersightHyperflexServerFirmwareVersion -AppCatalog $app_catalog1 -Parent $parent1 -ServerFirmwareVersionEntries $server_firmware_version_entries1