
#Get the FirmwareUnsupportedVersionUpgrade to delete
$FirmwareUnsupportedVersionUpgrade = Get-IntersightFirmwareUnsupportedVersionUpgrade -Name FirmwareUnsupportedVersionUpgradeName
$FirmwareUnsupportedVersionUpgrade | Remove-IntersightFirmwareUnsupportedVersionUpgrade

#Remove the FirmwareUnsupportedVersionUpgrade by Moid.
Remove-IntersightFirmwareUnsupportedVersionUpgrade -Moid '<Replace with Moid>'
