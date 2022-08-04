
#Get the FirmwareSwitchUpgrade to delete
$FirmwareSwitchUpgrade = Get-IntersightFirmwareSwitchUpgrade -Name FirmwareSwitchUpgradeName
$FirmwareSwitchUpgrade | Remove-IntersightFirmwareSwitchUpgrade

#Remove the FirmwareSwitchUpgrade by Moid.
Remove-IntersightFirmwareSwitchUpgrade -Moid '<Replace with Moid>'
