#Get the StoragePhysicalDisk by Name
$StoragePhysicalDiskByName = Get-IntersightStoragePhysicalDisk -Name StoragePhysicalDiskName

#Get the List of ServerProfiles
$StoragePhysicalDiskList = Get-IntersightStoragePhysicalDisk

#Get the list of StoragePhysicalDisk under particular organization.
$org = Get-IntersightOrganizationOrganization -Name 'default'

$StoragePhysicalDiskByOrg = Get-IntersightStoragePhysicalDisk -Organization $org

#Get the StoragePhysicalDisk based on query Parameter
$StoragePhysicalDiskByQueryParam = Get-IntersightStoragePhysicalDisk -Filter Name eq StoragePhysicalDiskName

#Note :- The output returns by the ParameterSet "QueryParam" cannot be piped to the New or Set cmdlet due to different property structure .