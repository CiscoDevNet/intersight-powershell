
#Get the FirmwareChassisUpgrade to delete
$FirmwareChassisUpgrade = Get-IntersightFirmwareChassisUpgrade -Name FirmwareChassisUpgradeName
$FirmwareChassisUpgrade | Remove-IntersightFirmwareChassisUpgrade

#Remove the FirmwareChassisUpgrade by Moid.
Remove-IntersightFirmwareChassisUpgrade -Moid '<Replace with Moid>'
