#Get the EquipmentRackEnclosureSlot by Name
$EquipmentRackEnclosureSlotByName = Get-IntersightEquipmentRackEnclosureSlot -Name EquipmentRackEnclosureSlotName

#Get the List of ServerProfiles
$EquipmentRackEnclosureSlotList = Get-IntersightEquipmentRackEnclosureSlot

#Get the list of EquipmentRackEnclosureSlot under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentRackEnclosureSlotByOrg = Get-IntersightEquipmentRackEnclosureSlot -Organization $org

#Get the EquipmentRackEnclosureSlot based on query Parameter
$EquipmentRackEnclosureSlotByQueryParam = Get-IntersightEquipmentRackEnclosureSlot -Filter Name eq EquipmentRackEnclosureSlotName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .