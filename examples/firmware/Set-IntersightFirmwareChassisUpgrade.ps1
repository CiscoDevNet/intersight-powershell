
#Get the FirmwareChassisUpgrade to Update
$FirmwareChassisUpgrade = Get-IntersightFirmwareChassisUpgrade -Name FirmwareChassisUpgradeName
$FirmwareChassisUpgrade | Set-IntersightFirmwareChassisUpgrade -Description 'Updated description'
