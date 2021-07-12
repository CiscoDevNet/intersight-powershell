
#Get the FirmwareDriverDistributable to delete
$FirmwareDriverDistributable = Remove-IntersightFirmwareDriverDistributable -Name FirmwareDriverDistributableName
$FirmwareDriverDistributable | Remove-IntersightFirmwareDriverDistributable

#Remove the server profile by Moid.
Remove-IntersightFirmwareDriverDistributable -Moid 123bc2222287wee
