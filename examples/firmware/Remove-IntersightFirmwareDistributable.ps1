
#Get the FirmwareDistributable to delete
$FirmwareDistributable = Get-IntersightFirmwareDistributable -Name FirmwareDistributableName
$FirmwareDistributable | Remove-IntersightFirmwareDistributable

#Remove the FirmwareDistributable by Moid.
Remove-IntersightFirmwareDistributable -Moid '<Replace with Moid>'
