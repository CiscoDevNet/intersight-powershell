#Get the EquipmentChassisOperation by Name
$EquipmentChassisOperationByName = Get-IntersightEquipmentChassisOperation -Name EquipmentChassisOperationName

#Get the List of ServerProfiles
$EquipmentChassisOperationList = Get-IntersightEquipmentChassisOperation

#Get the list of EquipmentChassisOperation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentChassisOperationByOrg = Get-IntersightEquipmentChassisOperation -Organization $org

#Get the EquipmentChassisOperation based on query Parameter
$EquipmentChassisOperationByQueryParam = Get-IntersightEquipmentChassisOperation -Filter Name eq EquipmentChassisOperationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .