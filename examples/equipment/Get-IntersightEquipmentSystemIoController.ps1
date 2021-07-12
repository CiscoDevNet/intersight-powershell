#Get the EquipmentSystemIoController by Name
$EquipmentSystemIoControllerByName = Get-IntersightEquipmentSystemIoController -Name EquipmentSystemIoControllerName

#Get the List of ServerProfiles
$EquipmentSystemIoControllerList = Get-IntersightEquipmentSystemIoController

#Get the list of EquipmentSystemIoController under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$EquipmentSystemIoControllerByOrg = Get-IntersightEquipmentSystemIoController -Organization $org

#Get the EquipmentSystemIoController based on query Parameter
$EquipmentSystemIoControllerByQueryParam = Get-IntersightEquipmentSystemIoController -Filter Name eq EquipmentSystemIoControllerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .