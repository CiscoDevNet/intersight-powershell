#Get the CapabilityEquipmentSlotArray by Name
$CapabilityEquipmentSlotArrayByName = Get-IntersightCapabilityEquipmentSlotArray -Name CapabilityEquipmentSlotArrayName

#Get the List of ServerProfiles
$CapabilityEquipmentSlotArrayList = Get-IntersightCapabilityEquipmentSlotArray

#Get the list of CapabilityEquipmentSlotArray under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$CapabilityEquipmentSlotArrayByOrg = Get-IntersightCapabilityEquipmentSlotArray -Organization $org

#Get the CapabilityEquipmentSlotArray based on query Parameter
$CapabilityEquipmentSlotArrayByQueryParam = Get-IntersightCapabilityEquipmentSlotArray -Filter Name eq CapabilityEquipmentSlotArrayName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .