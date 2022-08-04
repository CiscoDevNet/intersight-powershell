
#Get the FirmwareDriverDistributable to delete
$FirmwareDriverDistributable = Get-IntersightFirmwareDriverDistributable -Name FirmwareDriverDistributableName
$FirmwareDriverDistributable | Remove-IntersightFirmwareDriverDistributable

#Remove the FirmwareDriverDistributable by Moid.
Remove-IntersightFirmwareDriverDistributable -Moid '<Replace with Moid>'
