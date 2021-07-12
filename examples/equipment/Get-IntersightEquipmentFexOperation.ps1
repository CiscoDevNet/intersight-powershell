#Get the EquipmentFexOperation by Name
$EquipmentFexOperationByName = Get-IntersightEquipmentFexOperation -Name EquipmentFexOperationName

#Get the List of ServerProfiles
$EquipmentFexOperationList = Get-IntersightEquipmentFexOperation

#Get the list of EquipmentFexOperation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentFexOperationByOrg = Get-IntersightEquipmentFexOperation -Organization $org

#Get the EquipmentFexOperation based on query Parameter
$EquipmentFexOperationByQueryParam = Get-IntersightEquipmentFexOperation -Filter Name eq EquipmentFexOperationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .