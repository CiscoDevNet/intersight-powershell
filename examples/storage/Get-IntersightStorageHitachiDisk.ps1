#Get the StorageHitachiDisk by Name
$StorageHitachiDiskByName = Get-IntersightStorageHitachiDisk -Name StorageHitachiDiskName

#Get the List of ServerProfiles
$StorageHitachiDiskList = Get-IntersightStorageHitachiDisk

#Get the list of StorageHitachiDisk under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StorageHitachiDiskByOrg = Get-IntersightStorageHitachiDisk -Organization $org

#Get the StorageHitachiDisk based on query Parameter
$StorageHitachiDiskByQueryParam = Get-IntersightStorageHitachiDisk -Filter Name eq StorageHitachiDiskName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .