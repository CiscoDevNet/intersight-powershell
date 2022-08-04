
#Get the FirmwareDriverDistributable to Update
$FirmwareDriverDistributable = Get-IntersightFirmwareDriverDistributable -Name FirmwareDriverDistributableName
$FirmwareDriverDistributable | Set-IntersightFirmwareDriverDistributable -Description 'Updated description'
