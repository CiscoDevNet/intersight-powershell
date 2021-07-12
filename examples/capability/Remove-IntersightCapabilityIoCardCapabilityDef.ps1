
#Get the CapabilityIoCardCapabilityDef to delete
$CapabilityIoCardCapabilityDef = Remove-IntersightCapabilityIoCardCapabilityDef -Name CapabilityIoCardCapabilityDefName
$CapabilityIoCardCapabilityDef | Remove-IntersightCapabilityIoCardCapabilityDef

#Remove the server profile by Moid.
Remove-IntersightCapabilityIoCardCapabilityDef -Moid 123bc2222287wee
