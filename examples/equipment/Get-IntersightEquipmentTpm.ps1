#Get the EquipmentTpm by Name
$EquipmentTpmByName = Get-IntersightEquipmentTpm -Name EquipmentTpmName

#Get the List of ServerProfiles
$EquipmentTpmList = Get-IntersightEquipmentTpm

#Get the list of EquipmentTpm under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentTpmByOrg = Get-IntersightEquipmentTpm -Organization $org

#Get the EquipmentTpm based on query Parameter
$EquipmentTpmByQueryParam = Get-IntersightEquipmentTpm -Filter Name eq EquipmentTpmName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .