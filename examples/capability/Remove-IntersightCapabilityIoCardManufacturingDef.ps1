
#Get the CapabilityIoCardManufacturingDef to delete
$CapabilityIoCardManufacturingDef = Get-IntersightCapabilityIoCardManufacturingDef -Name CapabilityIoCardManufacturingDefName
$CapabilityIoCardManufacturingDef | Remove-IntersightCapabilityIoCardManufacturingDef

#Remove the CapabilityIoCardManufacturingDef by Moid.
Remove-IntersightCapabilityIoCardManufacturingDef -Moid '<Replace with Moid>'
