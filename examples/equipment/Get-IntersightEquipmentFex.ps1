#Get the EquipmentFex by Name
$EquipmentFexByName = Get-IntersightEquipmentFex -Name EquipmentFexName

#Get the List of ServerProfiles
$EquipmentFexList = Get-IntersightEquipmentFex

#Get the list of EquipmentFex under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentFexByOrg = Get-IntersightEquipmentFex -Organization $org

#Get the EquipmentFex based on query Parameter
$EquipmentFexByQueryParam = Get-IntersightEquipmentFex -Filter Name eq EquipmentFexName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .