
#Get the FirmwareSwitchUpgrade to Update
$FirmwareSwitchUpgrade = Get-IntersightFirmwareSwitchUpgrade -Name FirmwareSwitchUpgradeName
$FirmwareSwitchUpgrade | Set-IntersightFirmwareSwitchUpgrade -Description 'Updated description'
