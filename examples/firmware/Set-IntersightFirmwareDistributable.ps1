
#Get the FirmwareDistributable to Update
$FirmwareDistributable = Get-IntersightFirmwareDistributable -Name FirmwareDistributableName
$FirmwareDistributable | Set-IntersightFirmwareDistributable -Description 'Updated description'
