
#Get the CapabilityChassisManufacturingDef to delete
$CapabilityChassisManufacturingDef = Get-IntersightCapabilityChassisManufacturingDef -Name CapabilityChassisManufacturingDefName
$CapabilityChassisManufacturingDef | Remove-IntersightCapabilityChassisManufacturingDef

#Remove the CapabilityChassisManufacturingDef by Moid.
Remove-IntersightCapabilityChassisManufacturingDef -Moid '<Replace with Moid>'
