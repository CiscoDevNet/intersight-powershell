$constraint1 = Initialize-IntersightHyperflexAppsettingconstraint -HxdpVersion '4.0(2a)|4.0(2b)|4.0(2c)|4.0(2d)|4.0(2e)|4.5(1a)' -HypervisorType 'ESXi' -MgmtPlatform 'EDGE' -ServerModel 'HX.*M5.*$'

$parent1 = Get-IntersightHyperflexServerfirmwareversion -Moid '<Replace with Moid>'

$hyperflex_server_firmware_version_entry1 = New-IntersightHyperflexServerFirmwareVersionEntry -Constraint $constraint1 -Parent $parent1 -ServerPlatform 'M5'