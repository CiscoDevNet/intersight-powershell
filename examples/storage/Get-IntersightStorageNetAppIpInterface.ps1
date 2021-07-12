#Get the StorageNetAppIpInterface by Name
$StorageNetAppIpInterfaceByName = Get-IntersightStorageNetAppIpInterface -Name StorageNetAppIpInterfaceName

#Get the List of ServerProfiles
$StorageNetAppIpInterfaceList = Get-IntersightStorageNetAppIpInterface

#Get the list of StorageNetAppIpInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppIpInterfaceByOrg = Get-IntersightStorageNetAppIpInterface -Organization $org

#Get the StorageNetAppIpInterface based on query Parameter
$StorageNetAppIpInterfaceByQueryParam = Get-IntersightStorageNetAppIpInterface -Filter Name eq StorageNetAppIpInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .