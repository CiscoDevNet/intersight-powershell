
#Get the CapabilityEquipmentPhysicalDef to delete
$CapabilityEquipmentPhysicalDef = Get-IntersightCapabilityEquipmentPhysicalDef -Name CapabilityEquipmentPhysicalDefName
$CapabilityEquipmentPhysicalDef | Remove-IntersightCapabilityEquipmentPhysicalDef

#Remove the CapabilityEquipmentPhysicalDef by Moid.
Remove-IntersightCapabilityEquipmentPhysicalDef -Moid '<Replace with Moid>'
