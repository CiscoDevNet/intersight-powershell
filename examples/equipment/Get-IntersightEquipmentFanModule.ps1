#Get the EquipmentFanModule by Name
$EquipmentFanModuleByName = Get-IntersightEquipmentFanModule -Name EquipmentFanModuleName

#Get the List of ServerProfiles
$EquipmentFanModuleList = Get-IntersightEquipmentFanModule

#Get the list of EquipmentFanModule under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentFanModuleByOrg = Get-IntersightEquipmentFanModule -Organization $org

#Get the EquipmentFanModule based on query Parameter
$EquipmentFanModuleByQueryParam = Get-IntersightEquipmentFanModule -Filter Name eq EquipmentFanModuleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .