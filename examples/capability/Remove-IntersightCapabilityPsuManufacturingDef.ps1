
#Get the CapabilityPsuManufacturingDef to delete
$CapabilityPsuManufacturingDef = Remove-IntersightCapabilityPsuManufacturingDef -Name CapabilityPsuManufacturingDefName
$CapabilityPsuManufacturingDef | Remove-IntersightCapabilityPsuManufacturingDef

#Remove the server profile by Moid.
Remove-IntersightCapabilityPsuManufacturingDef -Moid 123bc2222287wee
