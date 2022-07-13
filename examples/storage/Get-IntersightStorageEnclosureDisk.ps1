#Get the StorageEnclosureDisk by Name
$StorageEnclosureDiskByName = Get-IntersightStorageEnclosureDisk -Name StorageEnclosureDiskName

#Get the List of ServerProfiles
$StorageEnclosureDiskList = Get-IntersightStorageEnclosureDisk

#Get the list of StorageEnclosureDisk under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageEnclosureDiskByOrg = Get-IntersightStorageEnclosureDisk -Organization $org

#Get the StorageEnclosureDisk based on query Parameter
$StorageEnclosureDiskByQueryParam = Get-IntersightStorageEnclosureDisk -Filter Name eq StorageEnclosureDiskName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .