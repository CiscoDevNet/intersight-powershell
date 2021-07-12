
#Get the FirmwareUpgrade to delete
$FirmwareUpgrade = Remove-IntersightFirmwareUpgrade -Name FirmwareUpgradeName
$FirmwareUpgrade | Remove-IntersightFirmwareUpgrade

#Remove the server profile by Moid.
Remove-IntersightFirmwareUpgrade -Moid 123bc2222287wee
