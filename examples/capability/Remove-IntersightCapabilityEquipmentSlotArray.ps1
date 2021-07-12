
#Get the CapabilityEquipmentSlotArray to delete
$CapabilityEquipmentSlotArray = Remove-IntersightCapabilityEquipmentSlotArray -Name CapabilityEquipmentSlotArrayName
$CapabilityEquipmentSlotArray | Remove-IntersightCapabilityEquipmentSlotArray

#Remove the server profile by Moid.
Remove-IntersightCapabilityEquipmentSlotArray -Moid 123bc2222287wee
