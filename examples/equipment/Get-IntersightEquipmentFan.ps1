#Get the EquipmentFan by Name
$EquipmentFanByName = Get-IntersightEquipmentFan -Name EquipmentFanName

#Get the List of ServerProfiles
$EquipmentFanList = Get-IntersightEquipmentFan

#Get the list of EquipmentFan under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentFanByOrg = Get-IntersightEquipmentFan -Organization $org

#Get the EquipmentFan based on query Parameter
$EquipmentFanByQueryParam = Get-IntersightEquipmentFan -Filter Name eq EquipmentFanName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .