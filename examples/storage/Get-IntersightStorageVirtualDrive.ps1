#Get the StorageVirtualDrive by Name
$StorageVirtualDriveByName = Get-IntersightStorageVirtualDrive -Name StorageVirtualDriveName

#Get the List of ServerProfiles
$StorageVirtualDriveList = Get-IntersightStorageVirtualDrive

#Get the list of StorageVirtualDrive under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageVirtualDriveByOrg = Get-IntersightStorageVirtualDrive -Organization $org

#Get the StorageVirtualDrive based on query Parameter
$StorageVirtualDriveByQueryParam = Get-IntersightStorageVirtualDrive -Filter Name eq StorageVirtualDriveName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .