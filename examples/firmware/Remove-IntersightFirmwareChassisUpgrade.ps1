
#Get the FirmwareChassisUpgrade to delete
$FirmwareChassisUpgrade = Remove-IntersightFirmwareChassisUpgrade -Name FirmwareChassisUpgradeName
$FirmwareChassisUpgrade | Remove-IntersightFirmwareChassisUpgrade

#Remove the server profile by Moid.
Remove-IntersightFirmwareChassisUpgrade -Moid 123bc2222287wee
