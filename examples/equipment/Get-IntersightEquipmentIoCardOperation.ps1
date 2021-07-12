#Get the EquipmentIoCardOperation by Name
$EquipmentIoCardOperationByName = Get-IntersightEquipmentIoCardOperation -Name EquipmentIoCardOperationName

#Get the List of ServerProfiles
$EquipmentIoCardOperationList = Get-IntersightEquipmentIoCardOperation

#Get the list of EquipmentIoCardOperation under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentIoCardOperationByOrg = Get-IntersightEquipmentIoCardOperation -Organization $org

#Get the EquipmentIoCardOperation based on query Parameter
$EquipmentIoCardOperationByQueryParam = Get-IntersightEquipmentIoCardOperation -Filter Name eq EquipmentIoCardOperationName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .