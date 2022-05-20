
#Get the CapabilitySwitchManufacturingDef to delete
$CapabilitySwitchManufacturingDef = Get-IntersightCapabilitySwitchManufacturingDef -Name CapabilitySwitchManufacturingDefName
$CapabilitySwitchManufacturingDef | Remove-IntersightCapabilitySwitchManufacturingDef

#Remove the CapabilitySwitchManufacturingDef by Moid.
Remove-IntersightCapabilitySwitchManufacturingDef -Moid '<Replace with Moid>'
