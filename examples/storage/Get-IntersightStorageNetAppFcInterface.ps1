#Get the StorageNetAppFcInterface by Name
$StorageNetAppFcInterfaceByName = Get-IntersightStorageNetAppFcInterface -Name StorageNetAppFcInterfaceName

#Get the List of ServerProfiles
$StorageNetAppFcInterfaceList = Get-IntersightStorageNetAppFcInterface

#Get the list of StorageNetAppFcInterface under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageNetAppFcInterfaceByOrg = Get-IntersightStorageNetAppFcInterface -Organization $org

#Get the StorageNetAppFcInterface based on query Parameter
$StorageNetAppFcInterfaceByQueryParam = Get-IntersightStorageNetAppFcInterface -Filter Name eq StorageNetAppFcInterfaceName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .