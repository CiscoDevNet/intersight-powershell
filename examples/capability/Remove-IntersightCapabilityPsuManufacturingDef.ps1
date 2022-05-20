
#Get the CapabilityPsuManufacturingDef to delete
$CapabilityPsuManufacturingDef = Get-IntersightCapabilityPsuManufacturingDef -Name CapabilityPsuManufacturingDefName
$CapabilityPsuManufacturingDef | Remove-IntersightCapabilityPsuManufacturingDef

#Remove the CapabilityPsuManufacturingDef by Moid.
Remove-IntersightCapabilityPsuManufacturingDef -Moid '<Replace with Moid>'
