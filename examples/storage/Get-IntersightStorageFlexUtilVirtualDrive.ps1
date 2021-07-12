#Get the StorageFlexUtilVirtualDrive by Name
$StorageFlexUtilVirtualDriveByName = Get-IntersightStorageFlexUtilVirtualDrive -Name StorageFlexUtilVirtualDriveName

#Get the List of ServerProfiles
$StorageFlexUtilVirtualDriveList = Get-IntersightStorageFlexUtilVirtualDrive

#Get the list of StorageFlexUtilVirtualDrive under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageFlexUtilVirtualDriveByOrg = Get-IntersightStorageFlexUtilVirtualDrive -Organization $org

#Get the StorageFlexUtilVirtualDrive based on query Parameter
$StorageFlexUtilVirtualDriveByQueryParam = Get-IntersightStorageFlexUtilVirtualDrive -Filter Name eq StorageFlexUtilVirtualDriveName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .