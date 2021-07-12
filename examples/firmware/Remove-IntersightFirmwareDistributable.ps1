
#Get the FirmwareDistributable to delete
$FirmwareDistributable = Remove-IntersightFirmwareDistributable -Name FirmwareDistributableName
$FirmwareDistributable | Remove-IntersightFirmwareDistributable

#Remove the server profile by Moid.
Remove-IntersightFirmwareDistributable -Moid 123bc2222287wee
