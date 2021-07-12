#Get the StorageFlexUtilPhysicalDrive by Name
$StorageFlexUtilPhysicalDriveByName = Get-IntersightStorageFlexUtilPhysicalDrive -Name StorageFlexUtilPhysicalDriveName

#Get the List of ServerProfiles
$StorageFlexUtilPhysicalDriveList = Get-IntersightStorageFlexUtilPhysicalDrive

#Get the list of StorageFlexUtilPhysicalDrive under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageFlexUtilPhysicalDriveByOrg = Get-IntersightStorageFlexUtilPhysicalDrive -Organization $org

#Get the StorageFlexUtilPhysicalDrive based on query Parameter
$StorageFlexUtilPhysicalDriveByQueryParam = Get-IntersightStorageFlexUtilPhysicalDrive -Filter Name eq StorageFlexUtilPhysicalDriveName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .