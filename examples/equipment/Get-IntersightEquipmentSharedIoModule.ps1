#Get the EquipmentSharedIoModule by Name
$EquipmentSharedIoModuleByName = Get-IntersightEquipmentSharedIoModule -Name EquipmentSharedIoModuleName

#Get the List of ServerProfiles
$EquipmentSharedIoModuleList = Get-IntersightEquipmentSharedIoModule

#Get the list of EquipmentSharedIoModule under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$EquipmentSharedIoModuleByOrg = Get-IntersightEquipmentSharedIoModule -Organization $org

#Get the EquipmentSharedIoModule based on query Parameter
$EquipmentSharedIoModuleByQueryParam = Get-IntersightEquipmentSharedIoModule -Filter Name eq EquipmentSharedIoModuleName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .