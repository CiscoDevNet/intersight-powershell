#Get the EquipmentIoExpander by Name
$EquipmentIoExpanderByName = Get-IntersightEquipmentIoExpander -Name EquipmentIoExpanderName

#Get the List of ServerProfiles
$EquipmentIoExpanderList = Get-IntersightEquipmentIoExpander

#Get the list of EquipmentIoExpander under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentIoExpanderByOrg = Get-IntersightEquipmentIoExpander -Organization $org

#Get the EquipmentIoExpander based on query Parameter
$EquipmentIoExpanderByQueryParam = Get-IntersightEquipmentIoExpander -Filter Name eq EquipmentIoExpanderName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .