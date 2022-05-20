
#Get the CapabilityEquipmentSlotArray to delete
$CapabilityEquipmentSlotArray = Get-IntersightCapabilityEquipmentSlotArray -Name CapabilityEquipmentSlotArrayName
$CapabilityEquipmentSlotArray | Remove-IntersightCapabilityEquipmentSlotArray

#Remove the CapabilityEquipmentSlotArray by Moid.
Remove-IntersightCapabilityEquipmentSlotArray -Moid '<Replace with Moid>'
