#Get the EquipmentPsuControl by Name
$EquipmentPsuControlByName = Get-IntersightEquipmentPsuControl -Name EquipmentPsuControlName

#Get the List of ServerProfiles
$EquipmentPsuControlList = Get-IntersightEquipmentPsuControl

#Get the list of EquipmentPsuControl under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentPsuControlByOrg = Get-IntersightEquipmentPsuControl -Organization $org

#Get the EquipmentPsuControl based on query Parameter
$EquipmentPsuControlByQueryParam = Get-IntersightEquipmentPsuControl -Filter Name eq EquipmentPsuControlName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .