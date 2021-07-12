
#Get the FirmwareSwitchUpgrade to delete
$FirmwareSwitchUpgrade = Remove-IntersightFirmwareSwitchUpgrade -Name FirmwareSwitchUpgradeName
$FirmwareSwitchUpgrade | Remove-IntersightFirmwareSwitchUpgrade

#Remove the server profile by Moid.
Remove-IntersightFirmwareSwitchUpgrade -Moid 123bc2222287wee
