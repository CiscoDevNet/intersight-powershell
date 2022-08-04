
#Get the FirmwareUpgrade to Update
$FirmwareUpgrade = Get-IntersightFirmwareUpgrade -Name FirmwareUpgradeName
$FirmwareUpgrade | Set-IntersightFirmwareUpgrade -Description 'Updated description'
