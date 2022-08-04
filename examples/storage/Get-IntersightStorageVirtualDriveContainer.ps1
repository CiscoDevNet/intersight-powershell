#Get the StorageVirtualDriveContainer by Name
$StorageVirtualDriveContainerByName = Get-IntersightStorageVirtualDriveContainer -Name StorageVirtualDriveContainerName

#Get the List of ServerProfiles
$StorageVirtualDriveContainerList = Get-IntersightStorageVirtualDriveContainer

#Get the list of StorageVirtualDriveContainer under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageVirtualDriveContainerByOrg = Get-IntersightStorageVirtualDriveContainer -Organization $org

#Get the StorageVirtualDriveContainer based on query Parameter
$StorageVirtualDriveContainerByQueryParam = Get-IntersightStorageVirtualDriveContainer -Filter Name eq StorageVirtualDriveContainerName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .