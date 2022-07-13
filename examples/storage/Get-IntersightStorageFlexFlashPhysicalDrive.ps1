#Get the StorageFlexFlashPhysicalDrive by Name
$StorageFlexFlashPhysicalDriveByName = Get-IntersightStorageFlexFlashPhysicalDrive -Name StorageFlexFlashPhysicalDriveName

#Get the List of ServerProfiles
$StorageFlexFlashPhysicalDriveList = Get-IntersightStorageFlexFlashPhysicalDrive

#Get the list of StorageFlexFlashPhysicalDrive under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageFlexFlashPhysicalDriveByOrg = Get-IntersightStorageFlexFlashPhysicalDrive -Organization $org

#Get the StorageFlexFlashPhysicalDrive based on query Parameter
$StorageFlexFlashPhysicalDriveByQueryParam = Get-IntersightStorageFlexFlashPhysicalDrive -Filter Name eq StorageFlexFlashPhysicalDriveName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .