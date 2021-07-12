#Get the StorageFlexFlashVirtualDrive by Name
$StorageFlexFlashVirtualDriveByName = Get-IntersightStorageFlexFlashVirtualDrive -Name StorageFlexFlashVirtualDriveName

#Get the List of ServerProfiles
$StorageFlexFlashVirtualDriveList = Get-IntersightStorageFlexFlashVirtualDrive

#Get the list of StorageFlexFlashVirtualDrive under particular organization.
$org = Get-IntersightOrganizationOrganization -Name myOrg

$StorageFlexFlashVirtualDriveByOrg = Get-IntersightStorageFlexFlashVirtualDrive -Organization $org

#Get the StorageFlexFlashVirtualDrive based on query Parameter
$StorageFlexFlashVirtualDriveByQueryParam = Get-IntersightStorageFlexFlashVirtualDrive -Filter Name eq StorageFlexFlashVirtualDriveName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .