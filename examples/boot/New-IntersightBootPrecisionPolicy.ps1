$organization1 = Get-IntersightOrganizationOrganization -Name 'default'

$boot_devices1 = Initialize-IntersightBootLocaldisk -Enabled 1 -Name 'scu-device-hdd' 
$boot_devices2 = Initialize-IntersightBootVirtualmedia -Enabled 1 -Name 'NIIODCIMCDVD' 
$boot_devices3 = Initialize-IntersightBootLocaldisk -Enabled 1 -Name 'hdd' 
$boot_devices4 = Initialize-IntersightBootIscsi -Enabled 1 -Name 'iscsi'

$boot_precision1 = New-IntersightBootPrecisionPolicy -Organization $organization1 -BootDevices @($boot_devices1,$boot_devices2,$boot_devices3,$boot_devices4) -Name 'boot_precision1' -Description 'test policy' -ConfiguredBootMode 'Legacy' -EnforceUefiSecureBoot $true