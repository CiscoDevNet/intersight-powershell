
#Get the CapabilityIoCardManufacturingDef to delete
$CapabilityIoCardManufacturingDef = Remove-IntersightCapabilityIoCardManufacturingDef -Name CapabilityIoCardManufacturingDefName
$CapabilityIoCardManufacturingDef | Remove-IntersightCapabilityIoCardManufacturingDef

#Remove the server profile by Moid.
Remove-IntersightCapabilityIoCardManufacturingDef -Moid 123bc2222287wee
