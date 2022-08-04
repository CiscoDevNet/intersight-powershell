
#Get the HyperflexServerFirmwareVersion to delete
$HyperflexServerFirmwareVersion = Get-IntersightHyperflexServerFirmwareVersion -Name HyperflexServerFirmwareVersionName
$HyperflexServerFirmwareVersion | Remove-IntersightHyperflexServerFirmwareVersion

#Remove the HyperflexServerFirmwareVersion by Moid.
Remove-IntersightHyperflexServerFirmwareVersion -Moid '<Replace with Moid>'
