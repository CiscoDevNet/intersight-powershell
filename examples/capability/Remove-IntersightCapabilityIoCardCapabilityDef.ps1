
#Get the CapabilityIoCardCapabilityDef to delete
$CapabilityIoCardCapabilityDef = Get-IntersightCapabilityIoCardCapabilityDef -Name CapabilityIoCardCapabilityDefName
$CapabilityIoCardCapabilityDef | Remove-IntersightCapabilityIoCardCapabilityDef

#Remove the CapabilityIoCardCapabilityDef by Moid.
Remove-IntersightCapabilityIoCardCapabilityDef -Moid '<Replace with Moid>'
