#Get the EquipmentFru by Name
$EquipmentFruByName = Get-IntersightEquipmentFru -Name EquipmentFruName

#Get the List of ServerProfiles
$EquipmentFruList = Get-IntersightEquipmentFru

#Get the list of EquipmentFru under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentFruByOrg = Get-IntersightEquipmentFru -Organization $org

#Get the EquipmentFru based on query Parameter
$EquipmentFruByQueryParam = Get-IntersightEquipmentFru -Filter Name eq EquipmentFruName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .