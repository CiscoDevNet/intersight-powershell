#Get the EquipmentIoCard by Name
$EquipmentIoCardByName = Get-IntersightEquipmentIoCard -Name EquipmentIoCardName

#Get the List of ServerProfiles
$EquipmentIoCardList = Get-IntersightEquipmentIoCard

#Get the list of EquipmentIoCard under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentIoCardByOrg = Get-IntersightEquipmentIoCard -Organization $org

#Get the EquipmentIoCard based on query Parameter
$EquipmentIoCardByQueryParam = Get-IntersightEquipmentIoCard -Filter Name eq EquipmentIoCardName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .