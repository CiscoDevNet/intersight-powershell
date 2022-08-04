
#Get the FirmwareUpgrade to delete
$FirmwareUpgrade = Get-IntersightFirmwareUpgrade -Name FirmwareUpgradeName
$FirmwareUpgrade | Remove-IntersightFirmwareUpgrade

#Remove the FirmwareUpgrade by Moid.
Remove-IntersightFirmwareUpgrade -Moid '<Replace with Moid>'
