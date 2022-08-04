#Get the EquipmentPsu by Name
$EquipmentPsuByName = Get-IntersightEquipmentPsu -Name EquipmentPsuName

#Get the List of ServerProfiles
$EquipmentPsuList = Get-IntersightEquipmentPsu

#Get the list of EquipmentPsu under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentPsuByOrg = Get-IntersightEquipmentPsu -Organization $org

#Get the EquipmentPsu based on query Parameter
$EquipmentPsuByQueryParam = Get-IntersightEquipmentPsu -Filter Name eq EquipmentPsuName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .