#Get the EquipmentRackEnclosure by Name
$EquipmentRackEnclosureByName = Get-IntersightEquipmentRackEnclosure -Name EquipmentRackEnclosureName

#Get the List of ServerProfiles
$EquipmentRackEnclosureList = Get-IntersightEquipmentRackEnclosure

#Get the list of EquipmentRackEnclosure under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentRackEnclosureByOrg = Get-IntersightEquipmentRackEnclosure -Organization $org

#Get the EquipmentRackEnclosure based on query Parameter
$EquipmentRackEnclosureByQueryParam = Get-IntersightEquipmentRackEnclosure -Filter Name eq EquipmentRackEnclosureName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .